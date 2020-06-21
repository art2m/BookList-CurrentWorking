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
            this.chkSeries = new System.Windows.Forms.CheckBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(195, 133);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(395, 32);
            this.txtAuthor.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Yellow;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(195, 95);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(395, 32);
            this.lblAuthor.TabIndex = 1;
            this.lblAuthor.Text = "Authors name";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.Yellow;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(12, 209);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(344, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book title.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(12, 259);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(344, 32);
            this.txtTitle.TabIndex = 3;
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.Yellow;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(426, 218);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(344, 32);
            this.lblSeries.TabIndex = 4;
            this.lblSeries.Text = "Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.Location = new System.Drawing.Point(426, 259);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(344, 32);
            this.txtSeries.TabIndex = 5;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Yellow;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(312, 312);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(160, 32);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Series volume number";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(312, 348);
            this.txtVolume.Multiline = true;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(160, 32);
            this.txtVolume.TabIndex = 7;
            // 
            // chkSeries
            // 
            this.chkSeries.BackColor = System.Drawing.Color.Bisque;
            this.chkSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeries.Location = new System.Drawing.Point(306, 27);
            this.chkSeries.Name = "chkSeries";
            this.chkSeries.Size = new System.Drawing.Size(172, 36);
            this.chkSeries.TabIndex = 8;
            this.chkSeries.Text = "Book Is Series";
            this.chkSeries.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(130, 426);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(337, 426);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(544, 426);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Location = new System.Drawing.Point(653, 516);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.TabIndex = 12;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // AdditionOfBookAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.chkSeries);
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
        private System.Windows.Forms.CheckBox chkSeries;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}