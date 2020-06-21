using System.ComponentModel;

namespace BookList.Source
{
    partial class AdditionOfBookAuthors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblSeries = new System.Windows.Forms.Label();
            this.txtSeries = new System.Windows.Forms.TextBox();
            this.lblVolume = new System.Windows.Forms.Label();
            this.txtVolume = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(161, 71);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(395, 32);
            this.txtAuthor.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.Location = new System.Drawing.Point(161, 33);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(395, 32);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Authors name";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.Location = new System.Drawing.Point(51, 147);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(100, 23);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book title.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(72, 197);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // lblSeries
            // 
            this.lblSeries.Location = new System.Drawing.Point(218, 156);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(100, 23);
            this.lblSeries.TabIndex = 4;
            this.lblSeries.Text = "Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSeries
            // 
            this.txtSeries.Location = new System.Drawing.Point(218, 197);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(100, 20);
            this.txtSeries.TabIndex = 5;
            // 
            // lblVolume
            // 
            this.lblVolume.Location = new System.Drawing.Point(387, 171);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(100, 23);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Series volume number";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVolume
            // 
            this.txtVolume.Location = new System.Drawing.Point(443, 199);
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(100, 20);
            this.txtVolume.TabIndex = 7;
            // 
            // AdditionOfBookAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtVolume);
            this.Controls.Add(this.lblVolume);
            this.Controls.Add(this.txtSeries);
            this.Controls.Add(this.lblSeries);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Name = "AdditionOfBookAuthors";
            this.Text = "Adding New Authors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblSeries;
        private System.Windows.Forms.TextBox txtSeries;
        private System.Windows.Forms.Label lblVolume;
        private System.Windows.Forms.TextBox txtVolume;
    }
}