Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
#Region "#usings"
Imports DevExpress.XtraRichEdit.API.Native
#End Region ' #usings

Namespace BulletedListExample
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			richEditControl1.CreateNewDocument()
			AddBulletedListToDocument()
		End Sub
		#Region "#definelist"
		Private Sub AddBulletedListToDocument()
			Dim doc As Document = richEditControl1.Document
			' Define an abstract numbered list and add it to the document.
			DefineAbstractList(doc)
			' Create a numbered list. It is based on a previously defined abstract list with ID = 0.
			doc.NumberingLists.Add(0)
		End Sub
		Private Sub DefineAbstractList(ByVal doc As Document)
			doc.BeginUpdate()
			'Describe the pattern used for the numbered list.
			'Specify parameters used to represent each list level.

			Dim list As AbstractNumberingList = richEditControl1.Document.AbstractNumberingLists.Add()
			list.NumberingType = NumberingType.MultiLevel

			Dim level As ListLevel = list.Levels(0)
			level.ParagraphProperties.LeftIndent = 150
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 75
			level.Start = 1
			level.NumberingFormat = NumberingFormat.Decimal
			level.DisplayFormatString = "{0}"

			level = list.Levels(1)
			level.ParagraphProperties.LeftIndent = 300
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 150
			level.Start = 1
			level.NumberingFormat = NumberingFormat.DecimalEnclosedParenthses
			level.DisplayFormatString = "{0}►{1}"

			level = list.Levels(2)
			level.ParagraphProperties.LeftIndent = 450
			level.ParagraphProperties.FirstLineIndentType = ParagraphFirstLineIndent.Hanging
			level.ParagraphProperties.FirstLineIndent = 220
			level.Start = 1
			level.NumberingFormat = NumberingFormat.LowerRoman
			level.DisplayFormatString = "{0}→{1}→{2}"

			doc.EndUpdate()
		End Sub
		#End Region ' #definelist

		Private Sub comboBoxEdit1_Left(ByVal sender As Object, ByVal e As EventArgs) Handles comboBoxEdit1.SelectedIndexChanged
'			#Region "#setlistlevel"
			' Create a list item from the selected paragraph. A list pattern with index 0 is used.
			' The list level is specified by selecting an item in a combo box.
			Dim doc As Document = richEditControl1.Document

			If doc.Selection IsNot Nothing Then
				Dim listLevel As Integer = comboBoxEdit1.SelectedIndex - 1
				doc.BeginUpdate()
				Dim paragraphs As ParagraphCollection = doc.GetParagraphs(doc.Selection)
				For Each pgf As Paragraph In paragraphs
					' If 'None" is selected in the list level combo, remove the paragraph from the list.
					If listLevel = -1 Then
						pgf.ListIndex = -1
					' Otherwise specify the list pattern and the list level.
					Else
						pgf.ListIndex = 0
						pgf.ListLevel = listLevel
					End If
				Next pgf
				doc.EndUpdate()
			End If
'			#End Region ' #setlistlevel
		End Sub

		Private Sub btnbtnNumberedList_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNumberedList.Click
			Dim doc As Document = richEditControl1.Document
			doc.BeginUpdate()
			Dim numberingList As NumberingList = doc.NumberingLists.Add(0)
			Dim listIndex As Integer = numberingList.Index
			' Append list items
			AppendListParagraph(doc, "Level0 Par0", 0, 0, listIndex)
			AppendListParagraph(doc, "Level0 Par1", 1, 0, listIndex)
			AppendListParagraph(doc, "Level0 Par2", 2, 0, listIndex)
			AppendListParagraph(doc, "Level1 Par3", 3, 1, listIndex)
			AppendListParagraph(doc, "Level1 Par4", 4, 1, listIndex)
			AppendListParagraph(doc, "Level2 Par5", 5, 2, listIndex)
			AppendListParagraph(doc, "Level2 Par6", 6, 2, listIndex)
			AppendListParagraph(doc, "Level0 Par7", 7, 0, listIndex)
			AppendListParagraph(doc, "Level1 Par8", 8, 1, listIndex)
			AppendListParagraph(doc, "Level1 Par9", 9, 1, listIndex)
			AppendListParagraph(doc, "Level0 Par10", 10, 0, listIndex)
			doc.AppendParagraph()
			doc.EndUpdate()
		End Sub

		Private Sub AppendListParagraph(ByVal doc As Document, ByVal text As String, ByVal paragraphIndex As Integer, ByVal numberingLevel As Integer, ByVal numberingIndex As Integer)
			doc.AppendText(text)
			doc.AppendParagraph()
			Dim paragraph As Paragraph = doc.Paragraphs(paragraphIndex)
			paragraph.ListIndex = numberingIndex
			paragraph.ListLevel = numberingLevel
		End Sub
	End Class
End Namespace
