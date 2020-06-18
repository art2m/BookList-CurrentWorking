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
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lstTiltes = new System.Windows.Forms.ListBox();
            this.pnlRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRadioButton
            // 
            this.pnlRadioButton.BackColor = System.Drawing.Color.Plum;
            this.pnlRadioButton.Controls.Add(this.rdbSpecific);
            this.pnlRadioButton.Controls.Add(this.rdbAll);
            this.pnlRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlRadioButton.Location = new System.Drawing.Point(83, 12);
            this.pnlRadioButton.Name = "pnlRadioButton";
            this.pnlRadioButton.Size = new System.Drawing.Size(618, 51);
            this.pnlRadioButton.TabIndex = 2;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbAll.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rdbAll.Location = new System.Drawing.Point(382, 15);
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
            this.rdbSpecific.Location = new System.Drawing.Point(108, 15);
            this.rdbSpecific.Name = "rdbSpecific";
            this.rdbSpecific.Size = new System.Drawing.Size(161, 20);
            this.rdbSpecific.TabIndex = 2;
            this.rdbSpecific.TabStop = true;
            this.rdbSpecific.Text = "Search Specific Author";
            this.rdbSpecific.UseVisualStyleBackColor = true;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(85, 80);
            this.txtAuthorName.Multiline = true;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(618, 37);
            this.txtAuthorName.TabIndex = 3;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("DejaVu Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(330, 153);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(139, 45);
            this.btnSelect.TabIndex = 6;
            this.btnSelect.Text = "Select Author";
            this.btnSelect.UseVisualStyleBackColor = false;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(83, 480);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(618, 37);
            this.txtTitle.TabIndex = 7;
            // 
            // lstTiltes
            // 
            this.lstTiltes.FormattingEnabled = true;
            this.lstTiltes.Location = new System.Drawing.Point(85, 208);
            this.lstTiltes.Name = "lstTiltes";
            this.lstTiltes.Size = new System.Drawing.Size(627, 251);
            this.lstTiltes.TabIndex = 8;
            // 
            // SearchOfBookTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lstTiltes);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtAuthorName);
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
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.ListBox lstTiltes;
    }
}