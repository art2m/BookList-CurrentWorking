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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.btnTitle = new System.Windows.Forms.Button();
            this.btnSeries = new System.Windows.Forms.Button();
            this.txtRawData = new System.Windows.Forms.TextBox();
            this.lblSep = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblSepSymbol = new System.Windows.Forms.Label();
            this.pnlChange = new System.Windows.Forms.Panel();
            this.lblReplace = new System.Windows.Forms.Label();
            this.btnReplace = new System.Windows.Forms.Button();
            this.RawDataMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BookDataFormatingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.pnlChange.SuspendLayout();
            this.RawDataMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(653, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCloseRawDataInputButton_Clicked);
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.Color.Yellow;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 50);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(768, 27);
            this.lblInfo.TabIndex = 12;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(31, 124);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 37);
            this.txtTitle.TabIndex = 16;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.Location = new System.Drawing.Point(488, 120);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(253, 37);
            this.txtSeries.TabIndex = 17;
            this.txtSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.Aquamarine;
            this.btnTitle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(84, 39);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(142, 29);
            this.btnTitle.TabIndex = 18;
            this.btnTitle.Text = "Selected Text Title";
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.OnSelectedTextTitleButton_Clicked);
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.Aquamarine;
            this.btnSeries.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.Location = new System.Drawing.Point(488, 49);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(142, 29);
            this.btnSeries.TabIndex = 19;
            this.btnSeries.Text = "Selected Text Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.OnSelectedTextSeriesButton_Clicked);
            // 
            // txtRawData
            // 
            this.txtRawData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRawData.Location = new System.Drawing.Point(16, 93);
            this.txtRawData.Multiline = true;
            this.txtRawData.Name = "txtRawData";
            this.txtRawData.ReadOnly = true;
            this.txtRawData.Size = new System.Drawing.Size(756, 43);
            this.txtRawData.TabIndex = 20;
            this.txtRawData.Text = "Raw Data";
            // 
            // lblSep
            // 
            this.lblSep.BackColor = System.Drawing.Color.Yellow;
            this.lblSep.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSep.Location = new System.Drawing.Point(304, 93);
            this.lblSep.Name = "lblSep";
            this.lblSep.Size = new System.Drawing.Size(156, 24);
            this.lblSep.TabIndex = 21;
            this.lblSep.Text = "Seperation Symbol";
            this.lblSep.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(31, 93);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 24);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Book Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.Yellow;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(488, 93);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(253, 24);
            this.lblSeries.TabIndex = 23;
            this.lblSeries.Text = "Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSepSymbol
            // 
            this.lblSepSymbol.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSepSymbol.Location = new System.Drawing.Point(336, 124);
            this.lblSepSymbol.Name = "lblSepSymbol";
            this.lblSepSymbol.Size = new System.Drawing.Size(69, 36);
            this.lblSepSymbol.TabIndex = 25;
            this.lblSepSymbol.Text = "-";
            this.lblSepSymbol.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlChange
            // 
            this.pnlChange.Controls.Add(this.lblReplace);
            this.pnlChange.Controls.Add(this.btnReplace);
            this.pnlChange.Controls.Add(this.lblSepSymbol);
            this.pnlChange.Controls.Add(this.lblSeries);
            this.pnlChange.Controls.Add(this.lblTitle);
            this.pnlChange.Controls.Add(this.lblSep);
            this.pnlChange.Controls.Add(this.btnSeries);
            this.pnlChange.Controls.Add(this.btnTitle);
            this.pnlChange.Controls.Add(this.txtSeries);
            this.pnlChange.Controls.Add(this.txtTitle);
            this.pnlChange.Location = new System.Drawing.Point(11, 253);
            this.pnlChange.Name = "pnlChange";
            this.pnlChange.Size = new System.Drawing.Size(763, 238);
            this.pnlChange.TabIndex = 13;
            // 
            // lblReplace
            // 
            this.lblReplace.BackColor = System.Drawing.Color.Yellow;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(242, 164);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(279, 24);
            this.lblReplace.TabIndex = 26;
            this.lblReplace.Text = "Replace With Corrected Information";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReplace
            // 
            this.btnReplace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnReplace.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReplace.Location = new System.Drawing.Point(323, 194);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(125, 40);
            this.btnReplace.TabIndex = 25;
            this.btnReplace.Text = "Replace";
            this.btnReplace.UseVisualStyleBackColor = false;
            this.btnReplace.Click += new System.EventHandler(this.OnReplaceBookInformationDataButton_Clicked);
            // 
            // RawDataMenu
            // 
            this.RawDataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.BookDataFormatingMenu});
            this.RawDataMenu.Location = new System.Drawing.Point(0, 0);
            this.RawDataMenu.Name = "RawDataMenu";
            this.RawDataMenu.Size = new System.Drawing.Size(784, 24);
            this.RawDataMenu.TabIndex = 28;
            this.RawDataMenu.Text = "RawDataMenu";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose,
            this.mnuSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(164, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.OnCloseMenuItem_Clicked);
            // 
            // mnuSave
            // 
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(164, 22);
            this.mnuSave.Text = "Save All Changes";
            this.mnuSave.Click += new System.EventHandler(this.OnSaveAllChangesMenuItem_Clicked);
            // 
            // BookDataFormatingMenu
            // 
            this.BookDataFormatingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAuthors});
            this.BookDataFormatingMenu.Name = "BookDataFormatingMenu";
            this.BookDataFormatingMenu.Size = new System.Drawing.Size(131, 20);
            this.BookDataFormatingMenu.Text = "Book Data Formating";
            // 
            // mnuAuthors
            // 
            this.mnuAuthors.Name = "mnuAuthors";
            this.mnuAuthors.Size = new System.Drawing.Size(116, 22);
            this.mnuAuthors.Text = "Authors";
            this.mnuAuthors.Click += new System.EventHandler(this.OnDisplayAllAuthorsMenuItem_Clicked);
            // 
            // btnFirst
            // 
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(21, 145);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(78, 23);
            this.btnFirst.TabIndex = 29;
            this.btnFirst.Text = "<< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(107, 145);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(78, 23);
            this.btnNext.TabIndex = 30;
            this.btnNext.Text = "> Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(195, 145);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(91, 23);
            this.btnPrevious.TabIndex = 31;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            // 
            // btnLast
            // 
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(294, 145);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(78, 23);
            this.btnLast.TabIndex = 32;
            this.btnLast.Text = ">> Last";
            this.btnLast.UseVisualStyleBackColor = true;
            // 
            // RawDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.pnlChange);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.RawDataMenu);
            this.Controls.Add(this.txtRawData);
            this.MainMenuStrip = this.RawDataMenu;
            this.Name = "RawDataInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Data For Adding To Books Read Collection.";
            this.pnlChange.ResumeLayout(false);
            this.pnlChange.PerformLayout();
            this.RawDataMenu.ResumeLayout(false);
            this.RawDataMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.TextBox txtRawData;
        private System.Windows.Forms.Label lblSep;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblSepSymbol;
        private System.Windows.Forms.Panel pnlChange;
        private System.Windows.Forms.MenuStrip RawDataMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookDataFormatingMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Button btnReplace;
    }
}