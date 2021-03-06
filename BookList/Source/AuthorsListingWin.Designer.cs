﻿namespace BookList.Source
{
    /// <summary>
    /// Show a list of author files contained in the Book list directory.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class AuthorsListingWin
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
            this.lstAuthor = new System.Windows.Forms.ListBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstAuthor
            // 
            this.lstAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lstAuthor.FormattingEnabled = true;
            this.lstAuthor.ItemHeight = 16;
            this.lstAuthor.Location = new System.Drawing.Point(12, 12);
            this.lstAuthor.Name = "lstAuthor";
            this.lstAuthor.Size = new System.Drawing.Size(432, 436);
            this.lstAuthor.TabIndex = 0;
            this.lstAuthor.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChangedListBox_Selected);
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Moccasin;
            this.lblAuthor.Location = new System.Drawing.Point(12, 457);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(432, 32);
            this.lblAuthor.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCancel.Location = new System.Drawing.Point(12, 509);
            this.btnCancel.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnCancel.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 45);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelOperationButton_Clicked);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOK.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOK.Location = new System.Drawing.Point(294, 509);
            this.btnOK.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnOK.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(150, 45);
            this.btnOK.TabIndex = 3;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.OnOKButton_Clicked);
            // 
            // AuthorsListingWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 561);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.lstAuthor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "AuthorsListingWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Select Author From List";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.ListBox lstAuthor;

        #endregion
    }
}