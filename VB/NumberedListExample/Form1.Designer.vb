Imports Microsoft.VisualBasic
Imports System
Namespace NumberingListExample
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.richEditControl1 = New DevExpress.XtraRichEdit.RichEditControl()
			Me.btnSimpleNumberedList = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' richEditControl1
			' 
			Me.richEditControl1.Dock = System.Windows.Forms.DockStyle.Left
			Me.richEditControl1.Location = New System.Drawing.Point(0, 0)
			Me.richEditControl1.Name = "richEditControl1"
			Me.richEditControl1.Size = New System.Drawing.Size(532, 562)
			Me.richEditControl1.TabIndex = 0
			Me.richEditControl1.Text = "richEditControl1"
			' 
			' btnSimpleNumberedList
			' 
			Me.btnSimpleNumberedList.Location = New System.Drawing.Point(541, 12)
			Me.btnSimpleNumberedList.Name = "btnSimpleNumberedList"
			Me.btnSimpleNumberedList.Size = New System.Drawing.Size(114, 23)
			Me.btnSimpleNumberedList.TabIndex = 1
			Me.btnSimpleNumberedList.Text = "Create numbered list"
			Me.btnSimpleNumberedList.UseVisualStyleBackColor = True
'			Me.btnSimpleNumberedList.Click += New System.EventHandler(Me.btnSimpleNumberedList_Click);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(664, 562)
			Me.Controls.Add(Me.btnSimpleNumberedList)
			Me.Controls.Add(Me.richEditControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private richEditControl1 As DevExpress.XtraRichEdit.RichEditControl
		Private WithEvents btnSimpleNumberedList As System.Windows.Forms.Button
	End Class
End Namespace

