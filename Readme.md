<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128609683/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3404)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/NumberedListExample/Form1.cs) (VB: [Form1.vb](./VB/NumberedListExample/Form1.vb))
* [Program.cs](./CS/NumberedListExample/Program.cs) (VB: [Program.vb](./VB/NumberedListExample/Program.vb))
<!-- default file list end -->
# How to create a multilevel numbered list in code


<p>This example illustrates how to create a numbered list in code.</p><p>Add a new <a href="http://documentation.devexpress.com/CoreLibraries/clsDevExpressXtraRichEditAPINativeAbstractNumberingListtopic.aspx"><u>AbstractNumberingList</u></a>  instance to the <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraRichEditAPINativeDocument_AbstractNumberingListstopic.aspx"><u>Document.AbstractNumberingLists</u></a> collection.</p><p>Specify a <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraRichEditAPINativeNumberingListBase_NumberingTypetopic.aspx"><u>NumberingListBase.NumberingType</u></a> property, so that it is equal to the <strong>NumberingType.Multilevel</strong> value. </p><p>For each list level, specify the paragraph characteristics using the <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraRichEditAPINativeListLevel_ParagraphPropertiestopic.aspx"><u>ListLevel.ParagraphProperties</u></a>ListLevel.ParagraphProperties property. Set the left indentation so that each level has a different offset from the left. Specify a hanging first line and set the first line indent value to provide enough space for a number that precedes the text. Set the starting number value. Specify a format used to display a number via the <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraRichEditAPINativeListLevelProperties_NumberingFormattopic.aspx"><u>NumberingFormat</u></a> property.<br />
Use the Add method of the collection of lists in the document (accessible via the <a href="http://documentation.devexpress.com/CoreLibraries/DevExpressXtraRichEditAPINativeDocument_NumberingListstopic.aspx"><u>Document.NumberingLists</u></a> property) to add a list definition to the document. The parameter is the index of an abstract numbering list created previously. The Add method creates a pattern that can be applied to a paragraph so that the paragraph looks like a list item. </p><p>To include a paragraph in a list, set the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeParagraph_ListIndextopic"><u>ListIndex</u></a> property of a paragraph to the index of a list in the document and specify the <a href="http://documentation.devexpress.com/#CoreLibraries/DevExpressXtraRichEditAPINativeParagraph_ListLeveltopic"><u>ListLevel</u></a> property. </p>

<br/>


