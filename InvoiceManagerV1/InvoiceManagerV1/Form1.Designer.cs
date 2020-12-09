namespace InvoiceManagerV1
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
            this.readButton = new System.Windows.Forms.Button();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.totalByNamesButton = new System.Windows.Forms.Button();
            this.totalByYear = new System.Windows.Forms.Button();
            this.totalByDate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(12, 12);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(155, 69);
            this.readButton.TabIndex = 1;
            this.readButton.Text = "Select file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(12, 87);
            this.resultTextBox.Multiline = true;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(839, 435);
            this.resultTextBox.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // totalByNamesButton
            // 
            this.totalByNamesButton.Location = new System.Drawing.Point(173, 12);
            this.totalByNamesButton.Name = "totalByNamesButton";
            this.totalByNamesButton.Size = new System.Drawing.Size(155, 69);
            this.totalByNamesButton.TabIndex = 5;
            this.totalByNamesButton.Text = "Total by names";
            this.totalByNamesButton.UseVisualStyleBackColor = true;
            this.totalByNamesButton.Click += new System.EventHandler(this.totalByNamesButton_Click);
            // 
            // totalByYear
            // 
            this.totalByYear.Location = new System.Drawing.Point(334, 12);
            this.totalByYear.Name = "totalByYear";
            this.totalByYear.Size = new System.Drawing.Size(155, 69);
            this.totalByYear.TabIndex = 6;
            this.totalByYear.Text = "Total by year";
            this.totalByYear.UseVisualStyleBackColor = true;
            this.totalByYear.Click += new System.EventHandler(this.totalByYear_Click);
            // 
            // totalByDate
            // 
            this.totalByDate.Location = new System.Drawing.Point(495, 12);
            this.totalByDate.Name = "totalByDate";
            this.totalByDate.Size = new System.Drawing.Size(155, 69);
            this.totalByDate.TabIndex = 7;
            this.totalByDate.Text = "Total by date";
            this.totalByDate.UseVisualStyleBackColor = true;
            this.totalByDate.Click += new System.EventHandler(this.totalByDate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 534);
            this.Controls.Add(this.totalByDate);
            this.Controls.Add(this.totalByYear);
            this.Controls.Add(this.totalByNamesButton);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.readButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button totalByNamesButton;
        private System.Windows.Forms.Button totalByYear;
        private System.Windows.Forms.Button totalByDate;
    }
}

