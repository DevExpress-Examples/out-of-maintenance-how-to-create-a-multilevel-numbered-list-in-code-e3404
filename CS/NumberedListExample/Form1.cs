using System;
using System.Windows.Forms;
using DevExpress.Utils;
using DevExpress.XtraRichEdit.API.Native;

namespace NumberingListExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            richEditControl1.CreateNewDocument();
        }

        private void btnSimpleNumberedList_Click(object sender, EventArgs e)
        {
            Document doc = richEditControl1.Document;
            doc.BeginUpdate();
            //Describe the pattern used for numbered list.
            //Specify parameters used to represent each list level, up to the eighth level.
            #region #abstractnumberlist
            AbstractNumberingList list = richEditControl1.Document.AbstractNumberingLists.Add();
            list.NumberingType = NumberingType.MultiLevel;

            ListLevel level = list.Levels[0];
            level.ParagraphProperties.LeftIndent = 150;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.Decimal;
            level.DisplayFormatString = "{0}.";

            level = list.Levels[1];
            level.ParagraphProperties.LeftIndent = 300;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerLetter;
            level.DisplayFormatString = "{1}.";
            #endregion #abstractnumberlist

            level = list.Levels[2];
            level.ParagraphProperties.LeftIndent = 450;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 100;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerRoman;
            level.DisplayFormatString = "{2}.";

            level = list.Levels[3];
            level.ParagraphProperties.LeftIndent = 600;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.Decimal;
            level.DisplayFormatString = "{3}.";

            level = list.Levels[4];
            level.ParagraphProperties.LeftIndent = 750;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerLetter;
            level.DisplayFormatString = "{4}.";

            level = list.Levels[5];
            level.ParagraphProperties.LeftIndent = 900;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 100;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerRoman;
            level.DisplayFormatString = "{5}.";

            level = list.Levels[6];
            level.ParagraphProperties.LeftIndent = 1050;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.Decimal;
            level.DisplayFormatString = "{6}.";

            level = list.Levels[7];
            level.ParagraphProperties.LeftIndent = 1200;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 75;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerLetter;
            level.DisplayFormatString = "{7}.";

            level = list.Levels[8];
            level.ParagraphProperties.LeftIndent = 1350;
            level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging;
            level.ParagraphProperties.FirstLineIndent = 100;
            level.Start = 1;
            level.NumberingFormat = NumberingFormat.LowerRoman;
            level.DisplayFormatString = "{8}.";

            // Create a numbering list. It is based on a previously defined abstract list with ID = 0.
            doc.NumberingLists.Add(0);

            //The main purpose of the Guard class is to validate parameters passed into a method. 
            //Methods exposed by the Guard class are designed to throw exceptions if a parameter being checked does not pass validation.
            Guard.Equals(doc.NumberingLists[doc.NumberingLists.Count - 1].Index, doc.NumberingLists.Count - 1);
            
            // Append list items
            AppendListParagraph(doc, "One", 0, 0, 0);
            AppendListParagraph(doc, "Two", 1, 0, 0);
            AppendListParagraph(doc, "Three", 2, 0, 0);
            AppendListParagraph(doc, "ThreeOne", 3, 1, 0);
            AppendListParagraph(doc, "ThreeTwo", 4, 1, 0);
            AppendListParagraph(doc, "ThreeTwoOne", 5, 2, 0);
            AppendListParagraph(doc, "ThreeTwoTwo", 6, 2, 0);
            AppendListParagraph(doc, "Four", 7, 0, 0);
            AppendListParagraph(doc, "FourOne", 8, 1, 0);
            AppendListParagraph(doc, "FourTwo", 9, 1, 0);
            AppendListParagraph(doc, "Five", 10, 0, 0);
            doc.AppendParagraph();

            doc.EndUpdate();
        }        
        
        void AppendListParagraph(Document doc, string text, int paragraphIndex, int numberingLevel, int numberingIndex){
            doc.AppendText(text);
            doc.AppendParagraph();
            Paragraph paragraph = doc.Paragraphs[paragraphIndex];
            paragraph.ListIndex = numberingIndex;
            paragraph.ListLevel = numberingLevel;
        }

    }
    }
