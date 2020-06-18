namespace BookList.Source
{
    partial class SearchOfBookTitles
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
            this.pnlRadioButton = new System.Windows.Forms.Panel();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbSpecific = new System.Windows.Forms.RadioButton();
            this.txtbxAuthorName = new System.Windows.Forms.TextBox();
            this.pnlRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRadioButton
            // 
            this.pnlRadioButton.BackColor = System.Drawing.Color.Plum;
            this.pnlRadioButton.Controls.Add(this.rdbSpecific);
            this.pnlRadioButton.Controls.Add(this.rdbAll);
            this.pnlRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlRadioButton.Location = new System.Drawing.Point(83, 14);
            this.pnlRadioButton.Name = "pnlRadioButton";
            this.pnlRadioButton.Size = new System.Drawing.Size(618, 66);
            this.pnlRadioButton.TabIndex = 2;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbAll.Location = new System.Drawing.Point(379, 23);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(135, 20);
            this.rdbAll.TabIndex = 1;
            this.rdbAll.Text = "Search All Authors";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbSpecific
            // 
            this.rdbSpecific.AutoSize = true;
            this.rdbSpecific.Checked = true;
            this.rdbSpecific.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSpecific.Location = new System.Drawing.Point(105, 23);
            this.rdbSpecific.Name = "rdbSpecific";
            this.rdbSpecific.Size = new System.Drawing.Size(161, 20);
            this.rdbSpecific.TabIndex = 2;
            this.rdbSpecific.TabStop = true;
            this.rdbSpecific.Text = "Search Specific Author";
            this.rdbSpecific.UseVisualStyleBackColor = true;
            // 
            // txtbxAuthorName
            // 
            this.txtbxAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxAuthorName.Location = new System.Drawing.Point(86, 134);
            this.txtbxAuthorName.Multiline = true;
            this.txtbxAuthorName.Name = "txtbxAuthorName";
            this.txtbxAuthorName.Size = new System.Drawing.Size(614, 37);
            this.txtbxAuthorName.TabIndex = 3;
            // 
            // SearchOfBookTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtbxAuthorName);
            this.Controls.Add(this.pnlRadioButton);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SearchOfBookTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchOfBookTitles";
            this.pnlRadioButton.ResumeLayout(false);
            this.pnlRadioButton.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlRadioButton;
        private System.Windows.Forms.RadioButton rdbSpecific;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.TextBox txtbxAuthorName;
    }
}