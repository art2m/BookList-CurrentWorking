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
            this.btnRemove = new System.Windows.Forms.Button();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstRawData
            // 
            this.lstRawData.FormattingEnabled = true;
            this.lstRawData.Location = new System.Drawing.Point(13, 13);
            this.lstRawData.Name = "lstRawData";
            this.lstRawData.Size = new System.Drawing.Size(768, 303);
            this.lstRawData.TabIndex = 0;
            // 
            // btnSplit
            // 
            this.btnSplit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSplit.Location = new System.Drawing.Point(18, 442);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(80, 26);
            this.btnSplit.TabIndex = 1;
            this.btnSplit.Text = "Split At:";
            this.btnSplit.UseVisualStyleBackColor = true;
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(173, 506);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(94, 26);
            this.btnRemove.TabIndex = 2;
            this.btnRemove.Text = "Remove:";
            this.btnRemove.UseVisualStyleBackColor = true;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(18, 371);
            this.txtAuthorName.Multiline = true;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(279, 37);
            this.txtAuthorName.TabIndex = 3;
            this.txtAuthorName.Text = "Author Name";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(324, 371);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(279, 37);
            this.txtTitle.TabIndex = 4;
            this.txtTitle.Text = "Book Title";
            // 
            // RawDataInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.lstRawData);
            this.Name = "RawDataInput";
            this.Text = "Fix Raw Data";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRawData;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.TextBox txtTitle;
    }
}