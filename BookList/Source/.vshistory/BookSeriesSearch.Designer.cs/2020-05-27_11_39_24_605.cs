using System.ComponentModel;

namespace BookList.Source
{
    partial class SearchOfBookSeries
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
            this.pnlRadioButton = new System.Windows.Forms.Panel();
            this.rdbSpecific = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.pnlRadioButton.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlRadioButton
            // 
            this.pnlRadioButton.BackColor = System.Drawing.Color.Plum;
            this.pnlRadioButton.Controls.Add(this.rdbSpecific);
            this.pnlRadioButton.Controls.Add(this.rdbAll);
            this.pnlRadioButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pnlRadioButton.Location = new System.Drawing.Point(93, 12);
            this.pnlRadioButton.Name = "pnlRadioButton";
            this.pnlRadioButton.Size = new System.Drawing.Size(618, 44);
            this.pnlRadioButton.TabIndex = 3;
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
            this.rdbSpecific.Click += new System.EventHandler(this.SearchByAuthorRadioButtonClicked);
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
            this.rdbAll.Click += new System.EventHandler(this.SearchAllAuthorsRadioButtonClicked);
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthorName.Location = new System.Drawing.Point(93, 62);
            this.txtAuthorName.Multiline = true;
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(618, 37);
            this.txtAuthorName.TabIndex = 4;
            this.txtAuthorName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("DejaVu Sans Mono", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(323, 105);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(139, 45);
            this.btnSelect.TabIndex = 7;
            this.btnSelect.Text = "Select Author";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.SelectAuthorButtonClicked);
            // 
            // SearchOfBookSeries
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtAuthorName);
            this.Controls.Add(this.pnlRadioButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "SearchOfBookSeries";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchOfBookSeries";
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
    }
}