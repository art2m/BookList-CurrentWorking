namespace BookList.Source
{
    partial class DisplayAuthorTitlesResults
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
            this.lstTiltes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstTiltes
            // 
            this.lstTiltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTiltes.FormattingEnabled = true;
            this.lstTiltes.ItemHeight = 18;
            this.lstTiltes.Location = new System.Drawing.Point(79, 170);
            this.lstTiltes.Name = "lstTiltes";
            this.lstTiltes.Size = new System.Drawing.Size(627, 220);
            this.lstTiltes.TabIndex = 4;
            // 
            // DisplayAuthorTitlesResults
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lstTiltes);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "DisplayAuthorTitlesResults";
            this.Text = "Display Author Title Results";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstTiltes;
    }
}