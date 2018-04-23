using System;
using System.Windows.Forms;
#region #usings
using DevExpress.XtraRichEdit.API.Native;
#endregion #usings

namespace BulletedListExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.CreateNewDocument();
            AddBulletedListToDocument();
        }
        #region #definelist
        private void AddBulletedListToDocument()
        {
            Document doc = richEditControl1.Document;
            // Define an abstract numbered list and add it to the document.
            DefineAbstractList(doc);
            // Create a numbered list. It is based on a previously defined abstract list with ID = 0.
            doc.NumberingLists.Add(0);
        }
        void DefineAbstractList(Document doc)
        {
            doc.BeginUpdate();
            //Describe the pattern used for the numbered list.
            //Specify parameters used to represent each list level.

            AbstractNumberingList list = richEditControl1.Document.AbstractNumberingLists.Add();
            list.NumberingType = NumberingType.MultiLevel;
            
            ListLevel level = list.Levels[0];
            level.ParagraphProperties.LeftIndent = 150;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.Decimal;
            level.DisplayFormatString = "{0}";

            level = list.Levels[1];
            level.ParagraphProperties.LeftIndent = 300;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 150;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.DecimalEnclosedParenthses;
            level.DisplayFormatString = "{0}►{1}";

            level = list.Levels[2];
            level.ParagraphProperties.LeftIndent = 450;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 220;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerRoman;
            level.DisplayFormatString = "{0}→{1}→{2}";
           
            doc.EndUpdate();
        }
        #endregion #definelist

        private void comboBoxEdit1_Left(object sender, EventArgs e)
        {
            #region #setlistlevel
            // Create a list item from the selected paragraph. A list pattern with index 0 is used.
            // The list level is specified by selecting an item in a combo box.
            Document doc = richEditControl1.Document;

            if (doc.Selection != null)
            {
                int listLevel = comboBoxEdit1.SelectedIndex - 1;
                doc.BeginUpdate();
                ParagraphCollection paragraphs = doc.GetParagraphs(doc.Selection);
                foreach (Paragraph pgf in paragraphs)
                {
                    // If 'None" is selected in the list level combo, remove the paragraph from the list.
                    if (listLevel == -1)
                    {
                        pgf.ListIndex = -1;
                    }
                    // Otherwise specify the list pattern and the list level.
                    else
                    {
                        pgf.ListIndex = 0;
                        pgf.ListLevel = listLevel;
                    }
                }
                doc.EndUpdate();
            }
            #endregion #setlistlevel
        }

        private void btnbtnNumberedList_Click(object sender, EventArgs e)
        {
            Document doc = richEditControl1.Document;
            doc.BeginUpdate();
            NumberingList numberingList = doc.NumberingLists.Add(0);
            int listIndex = numberingList.Index; 
            // Append list items
            AppendListParagraph(doc, "Level0 Par0", 0, 0, listIndex);
            AppendListParagraph(doc, "Level0 Par1", 1, 0, listIndex);
            AppendListParagraph(doc, "Level0 Par2", 2, 0, listIndex);
            AppendListParagraph(doc, "Level1 Par3", 3, 1, listIndex);
            AppendListParagraph(doc, "Level1 Par4", 4, 1, listIndex);
            AppendListParagraph(doc, "Level2 Par5", 5, 2, listIndex);
            AppendListParagraph(doc, "Level2 Par6", 6, 2, listIndex);
            AppendListParagraph(doc, "Level0 Par7", 7, 0, listIndex);
            AppendListParagraph(doc, "Level1 Par8", 8, 1, listIndex);
            AppendListParagraph(doc, "Level1 Par9", 9, 1, listIndex);
            AppendListParagraph(doc, "Level0 Par10", 10, 0, listIndex);
            doc.AppendParagraph();
            doc.EndUpdate();
        }

        void AppendListParagraph(Document doc, string text, int paragraphIndex, int numberingLevel, int numberingIndex)
        {
            doc.AppendText(text);
            doc.AppendParagraph();
            Paragraph paragraph = doc.Paragraphs[paragraphIndex];
            paragraph.ListIndex = numberingIndex;
            paragraph.ListLevel = numberingLevel;
        }
    }
    }
