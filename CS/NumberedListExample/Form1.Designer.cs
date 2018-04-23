namespace NumberingListExample
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richEditControl1 = new DevExpress.XtraRichEdit.RichEditControl();
            this.btnSimpleNumberedList = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richEditControl1
            // 
            this.richEditControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.richEditControl1.Location = new System.Drawing.Point(0, 0);
            this.richEditControl1.Name = "richEditControl1";
            this.richEditControl1.Size = new System.Drawing.Size(532, 562);
            this.richEditControl1.TabIndex = 0;
            this.richEditControl1.Text = "richEditControl1";
            // 
            // btnSimpleNumberedList
            // 
            this.btnSimpleNumberedList.Location = new System.Drawing.Point(541, 12);
            this.btnSimpleNumberedList.Name = "btnSimpleNumberedList";
            this.btnSimpleNumberedList.Size = new System.Drawing.Size(114, 23);
            this.btnSimpleNumberedList.TabIndex = 1;
            this.btnSimpleNumberedList.Text = "Create numbered list";
            this.btnSimpleNumberedList.UseVisualStyleBackColor = true;
            this.btnSimpleNumberedList.Click += new System.EventHandler(this.btnSimpleNumberedList_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 562);
            this.Controls.Add(this.btnSimpleNumberedList);
            this.Controls.Add(this.richEditControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraRichEdit.RichEditControl richEditControl1;
        private System.Windows.Forms.Button btnSimpleNumberedList;
    }
}

