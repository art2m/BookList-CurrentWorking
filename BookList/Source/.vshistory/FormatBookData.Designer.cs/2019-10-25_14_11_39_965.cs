namespace BookList.Source
{
    partial class RawDataInput
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
            this.lstRawData = new System.Windows.Forms.ListBox();
            this.btnSplit = new System.Windows.Forms.Button();
            this.btnReplace = new System.Windows.Forms.Button();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.txtRawData = new System.Windows.Forms.TextBox();
            this.lblAuthors = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstRawData
            // 
            this.lstRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstRawData.FormattingEnabled = true;
            this.lstRawData.ItemHeight = 16;
            this.lstRawData.Location = new System.Drawing.Point(8, 42);
            this.lstRawData.Name = "lstRawData";
            this.lstRawData.Size = new System.Drawing.Size(768, 212);
            this.lstRawData.TabIndex = 0;
            this.lstRawData.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChangedListBox_Selected);
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(51, 523);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(80, 26);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split At:";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(344, 480);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(125, 40);
            this.btnReplace.TabIndex = 2;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.OnReplaceBookInformationDataButton_Clicked);
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(4, 400);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(253, 37);
            this.txtAuthor.TabIndex = 3;
            this.txtAuthor.Text = "Author Name";
            this.txtAuthor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(265, 400);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 37);
            this.txtTitle.TabIndex = 4;
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.Location = new System.Drawing.Point(527, 400);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(253, 37);
            this.txtSeries.TabIndex = 5;
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(40, 323);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(247, 29);
            this.btnTitle.TabIndex = 6;
            this.btnTitle.Text = "Selected Text Title";
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.OnSelectedTextTitleButton_Clicked);
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.Location = new System.Drawing.Point(497, 323);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(247, 29);
            this.btnSeries.TabIndex = 7;
            this.btnSeries.Text = "Selected Text Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.OnSelectedTextSeriesButton_Clicked);
            // 
            // txtRawData
            // 
            this.txtRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawData.Location = new System.Drawing.Point(8, 266);
            this.txtRawData.Multiline = true;
            this.txtRawData.Name = "txtRawData";
            this.txtRawData.ReadOnly = true;
            this.txtRawData.Size = new System.Drawing.Size(764, 48);
            this.txtRawData.TabIndex = 8;
            this.txtRawData.Text = "Raw Data";
            // 
            // lblAuthors
            // 
            this.lblAuthors.BackColor = System.Drawing.Color.Yellow;
            this.lblAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthors.Location = new System.Drawing.Point(4, 370);
            this.lblAuthors.Name = "lblAuthors";
            this.lblAuthors.Size = new System.Drawing.Size(253, 24);
            this.lblAuthors.TabIndex = 9;
            this.lblAuthors.Text = "Authors Name";
            this.lblAuthors.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(268, 373);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 24);
            this.lblTitle.TabIndex = 10;
            this.lblTitle.Text = "Book Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.Yellow;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(528, 373);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(253, 24);
            this.lblSeries.TabIndex = 11;
            this.lblSeries.Text = "Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Yellow;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 9);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(768, 27);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblReplace
            // 
            this.lblReplace.BackColor = System.Drawing.Color.Yellow;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(253, 450);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(279, 24);
            this.lblReplace.TabIndex = 13;
            this.lblReplace.Text = "Replace With Corrected Information";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RawDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthors);
            this.Controls.Add(this.txtRawData);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.btnReplace);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lstRawData);
            this.Name = "RawDataInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fix Raw Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRawData;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.TextBox txtRawData;
        private System.Windows.Forms.Label lblAuthors;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblReplace;
    }
}