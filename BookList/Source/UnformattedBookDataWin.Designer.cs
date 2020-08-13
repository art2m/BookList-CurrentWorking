namespace BookList.Source
{
    /// <summary>
    /// Used to format any data which was added by copy paste to the
    /// authors file.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class UnformattedBookDataWin
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
            this.lblSave = new System.Windows.Forms.Label();
            this.btnVolume = new System.Windows.Forms.Button();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblSeries = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSeries = new System.Windows.Forms.Button();
            this.btnTitle = new System.Windows.Forms.Button();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblReplace = new System.Windows.Forms.Label();
            this.btnFormat = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblUndoChange = new System.Windows.Forms.Label();
            this.btnUndo = new System.Windows.Forms.Button();
            this.txtBookInfo = new System.Windows.Forms.TextBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.Yellow;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSave.Location = new System.Drawing.Point(281, 346);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(221, 34);
            this.lblSave.TabIndex = 12;
            this.lblSave.Text = "Save all changes.";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnVolume.Location = new System.Drawing.Point(602, 258);
            this.btnVolume.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnVolume.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(150, 45);
            this.btnVolume.TabIndex = 10;
            this.btnVolume.Text = "Volume Number";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.OnVolumeNumberButton_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtVolume.Location = new System.Drawing.Point(558, 214);
            this.txtVolume.Multiline = true;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(217, 37);
            this.txtVolume.TabIndex = 7;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Yellow;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblVolume.Location = new System.Drawing.Point(558, 171);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(217, 34);
            this.lblVolume.TabIndex = 4;
            this.lblVolume.Text = "Get Hiighlighted Volume ";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSave.Location = new System.Drawing.Point(339, 392);
            this.btnSave.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnSave.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 45);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save Change";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnSaveChangesButton_Click);
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.Yellow;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSeries.Location = new System.Drawing.Point(281, 171);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(253, 34);
            this.lblSeries.TabIndex = 3;
            this.lblSeries.Text = "Get Highlighted Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 171);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 34);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Get Highlighted Book Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSeries.Location = new System.Drawing.Point(339, 257);
            this.btnSeries.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnSeries.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(150, 45);
            this.btnSeries.TabIndex = 9;
            this.btnSeries.Text = "Book Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.OnSeriesButton_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnTitle.Location = new System.Drawing.Point(66, 257);
            this.btnTitle.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnTitle.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(150, 45);
            this.btnTitle.TabIndex = 8;
            this.btnTitle.Text = "Book Title";
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.OnBookTitleButton_Click);
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtSeries.Location = new System.Drawing.Point(283, 214);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(253, 37);
            this.txtSeries.TabIndex = 6;
            this.txtSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtTitle.Location = new System.Drawing.Point(8, 214);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 37);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReplace
            // 
            this.lblReplace.BackColor = System.Drawing.Color.Yellow;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblReplace.Location = new System.Drawing.Point(8, 346);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(221, 34);
            this.lblReplace.TabIndex = 11;
            this.lblReplace.Text = "Format book information";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnFormat.Location = new System.Drawing.Point(66, 392);
            this.btnFormat.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnFormat.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(150, 45);
            this.btnFormat.TabIndex = 14;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.OnFormatBookInformationButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnClose.Location = new System.Drawing.Point(620, 505);
            this.btnClose.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnClose.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 45);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButton_Clicked);
            // 
            // lblUndoChange
            // 
            this.lblUndoChange.BackColor = System.Drawing.Color.Yellow;
            this.lblUndoChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblUndoChange.Location = new System.Drawing.Point(558, 346);
            this.lblUndoChange.Name = "lblUndoChange";
            this.lblUndoChange.Size = new System.Drawing.Size(219, 34);
            this.lblUndoChange.TabIndex = 13;
            this.lblUndoChange.Text = "Undo last save changes.";
            this.lblUndoChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUndo.Location = new System.Drawing.Point(602, 392);
            this.btnUndo.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnUndo.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(150, 45);
            this.btnUndo.TabIndex = 16;
            this.btnUndo.Text = "Undo changes.";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.OnUndoChangesButton_Click);
            // 
            // txtBookInfo
            // 
            this.txtBookInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtBookInfo.Location = new System.Drawing.Point(8, 56);
            this.txtBookInfo.Multiline = true;
            this.txtBookInfo.Name = "txtBookInfo";
            this.txtBookInfo.ReadOnly = true;
            this.txtBookInfo.Size = new System.Drawing.Size(768, 40);
            this.txtBookInfo.TabIndex = 1;
            this.txtBookInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(768, 34);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UnformattedBookDataWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(790, 567);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.txtBookInfo);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.btnVolume);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnSeries);
            this.Controls.Add(this.btnTitle);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblUndoChange);
            this.Controls.Add(this.btnUndo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "UnformattedBookDataWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Unformatted Book Data";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblUndoChange;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtBookInfo;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtVolume;

        #endregion
    }
}