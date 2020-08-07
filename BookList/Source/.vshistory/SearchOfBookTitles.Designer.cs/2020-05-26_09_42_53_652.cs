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
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbSpecific = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(37, 38);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(112, 17);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.TabStop = true;
            this.rdbAll.Text = "Search All Authors";
            this.rdbAll.UseVisualStyleBackColor = true;
            // 
            // rdbSpecific
            // 
            this.rdbSpecific.Location = new System.Drawing.Point(244, 38);
            this.rdbSpecific.Name = "rdbSpecific";
            this.rdbSpecific.Size = new System.Drawing.Size(104, 24);
            this.rdbSpecific.TabIndex = 1;
            this.rdbSpecific.TabStop = true;
            this.rdbSpecific.Text = "Search Specific Author";
            this.rdbSpecific.UseVisualStyleBackColor = true;
            // 
            // SearchOfBookTitles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rdbSpecific);
            this.Controls.Add(this.rdbAll);
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SearchOfBookTitles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchOfBookTitles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbSpecific;
    }
}