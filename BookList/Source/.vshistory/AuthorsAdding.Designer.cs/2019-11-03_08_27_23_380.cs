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
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.rbtnOneAuthor = new System.Windows.Forms.RadioButton();
            this.rbtnTwoAuthors = new System.Windows.Forms.RadioButton();
            this.rbtnThreeAuthors = new System.Windows.Forms.RadioButton();
            this.flpAuthors = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddAuthor = new System.Windows.Forms.Button();
            this.flpButtons.SuspendLayout();
            this.flpAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAuthor.Location = new System.Drawing.Point(195, 142);
            this.txtAuthor.Multiline = true;
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(395, 32);
            this.txtAuthor.TabIndex = 0;
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Yellow;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(195, 104);
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
            this.lblTitle.Location = new System.Drawing.Point(15, 238);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(362, 32);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Book title.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(15, 279);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(362, 32);
            this.txtTitle.TabIndex = 3;
            // 
            // lblSeries
            // 
            this.lblSeries.BackColor = System.Drawing.Color.Yellow;
            this.lblSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeries.Location = new System.Drawing.Point(407, 238);
            this.lblSeries.Name = "lblSeries";
            this.lblSeries.Size = new System.Drawing.Size(362, 32);
            this.lblSeries.TabIndex = 4;
            this.lblSeries.Text = "Book Series";
            this.lblSeries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSeries
            // 
            this.txtSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSeries.Location = new System.Drawing.Point(407, 279);
            this.txtSeries.Multiline = true;
            this.txtSeries.Name = "txtSeries";
            this.txtSeries.Size = new System.Drawing.Size(362, 32);
            this.txtSeries.TabIndex = 5;
            // 
            // lblVolume
            // 
            this.lblVolume.BackColor = System.Drawing.Color.Yellow;
            this.lblVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVolume.Location = new System.Drawing.Point(288, 335);
            this.lblVolume.Name = "lblVolume";
            this.lblVolume.Size = new System.Drawing.Size(208, 32);
            this.lblVolume.TabIndex = 6;
            this.lblVolume.Text = "Series book number";
            this.lblVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtVolume
            // 
            this.txtVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVolume.Location = new System.Drawing.Point(288, 377);
            this.txtVolume.Multiline = true;
            this.txtVolume.Name = "txtVolume";
            this.txtVolume.Size = new System.Drawing.Size(208, 32);
            this.txtVolume.TabIndex = 7;
            // 
            // chkSeries
            // 
            this.chkSeries.BackColor = System.Drawing.Color.Orange;
            this.chkSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkSeries.Location = new System.Drawing.Point(102, 27);
            this.chkSeries.Name = "chkSeries";
            this.chkSeries.Size = new System.Drawing.Size(172, 36);
            this.chkSeries.TabIndex = 8;
            this.chkSeries.Text = "Book Is Series";
            this.chkSeries.UseVisualStyleBackColor = false;
            this.chkSeries.Click += new System.EventHandler(this.OnBookIsSeriesCheckBox_Clicked);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Location = new System.Drawing.Point(101, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(110, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnAddNewBookRecordButton_Clicked);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Location = new System.Drawing.Point(217, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelOperationButton_Clicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Location = new System.Drawing.Point(333, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(110, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnSaveRecordButton_Clicked);
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
            this.btnClose.Click += new System.EventHandler(this.OnCloseAddingNewAuthorButton_Close);
            // 
            // flpButtons
            // 
            this.flpButtons.BackColor = System.Drawing.Color.DarkKhaki;
            this.flpButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpButtons.Controls.Add(this.btnAdd);
            this.flpButtons.Controls.Add(this.btnCancel);
            this.flpButtons.Controls.Add(this.btnSave);
            this.flpButtons.Location = new System.Drawing.Point(106, 436);
            this.flpButtons.Name = "flpButtons";
            this.flpButtons.Padding = new System.Windows.Forms.Padding(98, 8, 8, 8);
            this.flpButtons.Size = new System.Drawing.Size(572, 59);
            this.flpButtons.TabIndex = 13;
            // 
            // rbtnOneAuthor
            // 
            this.rbtnOneAuthor.BackColor = System.Drawing.Color.LightBlue;
            this.rbtnOneAuthor.Checked = true;
            this.rbtnOneAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOneAuthor.Location = new System.Drawing.Point(18, 13);
            this.rbtnOneAuthor.Name = "rbtnOneAuthor";
            this.rbtnOneAuthor.Size = new System.Drawing.Size(116, 28);
            this.rbtnOneAuthor.TabIndex = 14;
            this.rbtnOneAuthor.TabStop = true;
            this.rbtnOneAuthor.Text = "One Author";
            this.rbtnOneAuthor.UseVisualStyleBackColor = false;
            // 
            // rbtnTwoAuthors
            // 
            this.rbtnTwoAuthors.BackColor = System.Drawing.Color.LightBlue;
            this.rbtnTwoAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTwoAuthors.Location = new System.Drawing.Point(140, 13);
            this.rbtnTwoAuthors.Name = "rbtnTwoAuthors";
            this.rbtnTwoAuthors.Size = new System.Drawing.Size(116, 28);
            this.rbtnTwoAuthors.TabIndex = 15;
            this.rbtnTwoAuthors.Text = "Two Authors";
            this.rbtnTwoAuthors.UseVisualStyleBackColor = false;
            // 
            // rbtnThreeAuthors
            // 
            this.rbtnThreeAuthors.BackColor = System.Drawing.Color.LightBlue;
            this.rbtnThreeAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThreeAuthors.Location = new System.Drawing.Point(262, 13);
            this.rbtnThreeAuthors.Name = "rbtnThreeAuthors";
            this.rbtnThreeAuthors.Size = new System.Drawing.Size(116, 28);
            this.rbtnThreeAuthors.TabIndex = 16;
            this.rbtnThreeAuthors.Text = "Three Authors";
            this.rbtnThreeAuthors.UseVisualStyleBackColor = false;
            // 
            // flpAuthors
            // 
            this.flpAuthors.Controls.Add(this.rbtnOneAuthor);
            this.flpAuthors.Controls.Add(this.rbtnTwoAuthors);
            this.flpAuthors.Controls.Add(this.rbtnThreeAuthors);
            this.flpAuthors.Location = new System.Drawing.Point(285, 17);
            this.flpAuthors.Name = "flpAuthors";
            this.flpAuthors.Padding = new System.Windows.Forms.Padding(15, 10, 10, 10);
            this.flpAuthors.Size = new System.Drawing.Size(395, 59);
            this.flpAuthors.TabIndex = 17;
            // 
            // btnAddAuthor
            // 
            this.btnAddAuthor.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAddAuthor.Enabled = false;
            this.btnAddAuthor.Location = new System.Drawing.Point(325, 180);
            this.btnAddAuthor.Name = "btnAddAuthor";
            this.btnAddAuthor.Size = new System.Drawing.Size(110, 36);
            this.btnAddAuthor.TabIndex = 18;
            this.btnAddAuthor.Text = "Add Next Author";
            this.btnAddAuthor.UseVisualStyleBackColor = false;
            this.btnAddAuthor.Click += new System.EventHandler(this.OnAddNextNewAuthorButton_Clicked);
            // 
            // AdditionOfBookAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btnAddAuthor);
            this.Controls.Add(this.flpAuthors);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.btnClose);
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
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding New Authors";
            this.flpButtons.ResumeLayout(false);
            this.flpAuthors.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.RadioButton rbtnOneAuthor;
        private System.Windows.Forms.RadioButton rbtnTwoAuthors;
        private System.Windows.Forms.RadioButton rbtnThreeAuthors;
        private System.Windows.Forms.FlowLayoutPanel flpAuthors;
        private System.Windows.Forms.Button btnAddAuthor;
    }
}