namespace BookList.Source
{
    partial class FormatUnformattedBookData
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
            this.btnAutoFormat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblSave
            // 
            this.lblSave.BackColor = System.Drawing.Color.Yellow;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(281, 283);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(221, 24);
            this.lblSave.TabIndex = 40;
            this.lblSave.Text = "Save all changes made to file.";
            this.lblSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnVolume
            // 
            this.btnVolume.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolume.Location = new System.Drawing.Point(602, 230);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.Size = new System.Drawing.Size(115, 36);
            this.btnVolume.TabIndex = 39;
            this.btnVolume.Text = "Volume Number";
            this.btnVolume.UseVisualStyleBackColor = false;
            this.btnVolume.Click += new System.EventHandler(this.OnVolumeNumberButton_Click);
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(558, 186);
            this.txtVolume.Multiline = true;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(217, 37);
            this.txtVolume.TabIndex = 38;
            this.txtVolume.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Yellow;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(558, 155);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(217, 24);
            this.lblVolume.TabIndex = 37;
            this.lblVolume.Text = "Get Hiighlighted Volume Number";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(339, 316);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 36);
            this.btnSave.TabIndex = 36;
            this.btnSave.Text = "Save Change";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnSaveChangesButton_Click);
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.Yellow;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(281, 155);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(253, 24);
            this.lblSeries.TabIndex = 35;
            this.lblSeries.Text = "Get Highlighted Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(8, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(253, 24);
            this.lblTitle.TabIndex = 34;
            this.lblTitle.Text = "Get Highlighted Book Title";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSeries
            // 
            this.btnSeries.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeries.Location = new System.Drawing.Point(339, 229);
            this.btnSeries.Name = "btnSeries";
            this.btnSeries.Size = new System.Drawing.Size(115, 36);
            this.btnSeries.TabIndex = 29;
            this.btnSeries.Text = "Book Series";
            this.btnSeries.UseVisualStyleBackColor = false;
            this.btnSeries.Click += new System.EventHandler(this.OnSeriesButton_Click);
            // 
            // btnTitle
            // 
            this.btnTitle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTitle.Location = new System.Drawing.Point(66, 229);
            this.btnTitle.Name = "btnTitle";
            this.btnTitle.Size = new System.Drawing.Size(115, 36);
            this.btnTitle.TabIndex = 28;
            this.btnTitle.Text = "Book Title";
            this.btnTitle.UseVisualStyleBackColor = false;
            this.btnTitle.Click += new System.EventHandler(this.OnBookTitleButton_Click);
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.Location = new System.Drawing.Point(283, 186);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(253, 37);
            this.txtSeries.TabIndex = 33;
            this.txtSeries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(8, 186);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(253, 37);
            this.txtTitle.TabIndex = 32;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReplace
            // 
            this.lblReplace.BackColor = System.Drawing.Color.Yellow;
            this.lblReplace.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReplace.Location = new System.Drawing.Point(8, 283);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(221, 24);
            this.lblReplace.TabIndex = 31;
            this.lblReplace.Text = "Format selected book information";
            this.lblReplace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnFormat
            // 
            this.btnFormat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(66, 316);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(110, 36);
            this.btnFormat.TabIndex = 30;
            this.btnFormat.Text = "Format";
            this.btnFormat.UseVisualStyleBackColor = false;
            this.btnFormat.Click += new System.EventHandler(this.OnFormatBookInformationButton_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(652, 375);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButton_Clicked);
            // 
            // lblUndoChange
            // 
            this.lblUndoChange.BackColor = System.Drawing.Color.Yellow;
            this.lblUndoChange.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUndoChange.Location = new System.Drawing.Point(558, 283);
            this.lblUndoChange.Name = "lblUndoChange";
            this.lblUndoChange.Size = new System.Drawing.Size(219, 24);
            this.lblUndoChange.TabIndex = 41;
            this.lblUndoChange.Text = "Undo last save changes.";
            this.lblUndoChange.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(602, 316);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(110, 36);
            this.btnUndo.TabIndex = 42;
            this.btnUndo.Text = "Undo changes.";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.OnUndoChangesButton_Click);
            // 
            // txtBookInfo
            // 
            this.txtBookInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtBookInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBookInfo.Location = new System.Drawing.Point(8, 56);
            this.txtBookInfo.Multiline = true;
            this.txtBookInfo.Name = "txtBookInfo";
            this.txtBookInfo.ReadOnly = true;
            this.txtBookInfo.Size = new System.Drawing.Size(768, 40);
            this.txtBookInfo.TabIndex = 43;
            this.txtBookInfo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblInfo
            // 
            this.lblInfo.BackColor = System.Drawing.SystemColors.Info;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 19);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(768, 27);
            this.lblInfo.TabIndex = 44;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAutoFormat
            // 
            this.btnAutoFormat.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAutoFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoFormat.Location = new System.Drawing.Point(334, 105);
            this.btnAutoFormat.Name = "btnAutoFormat";
            this.btnAutoFormat.Size = new System.Drawing.Size(115, 36);
            this.btnAutoFormat.TabIndex = 45;
            this.btnAutoFormat.Text = "Auto Format";
            this.btnAutoFormat.UseVisualStyleBackColor = false;
            this.btnAutoFormat.Click += new System.EventHandler(this.OnAutoFormatBookInformationButton_Click);
            // 
            // FormatUnformattedBookData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 421);
            this.Controls.Add(this.btnAutoFormat);
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
            this.Name = "FormatUnformattedBookData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Unformatted Book Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.Button btnVolume;
        private System.Windows.Forms.TextBox txtVolume;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnSeries;
        private System.Windows.Forms.Button btnTitle;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Button btnFormat;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblUndoChange;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.TextBox txtBookInfo;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Button btnAutoFormat;
    }
}