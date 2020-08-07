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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAuthors = new System.Windows.Forms.Panel();
            this.rbtnOneAuthor = new System.Windows.Forms.RadioButton();
            this.rbtnTwoAuthors = new System.Windows.Forms.RadioButton();
            this.rbtnThreeAuthors = new System.Windows.Forms.RadioButton();
            this.flpButtons.SuspendLayout();
            this.pnlAuthors.SuspendLayout();
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
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(101, 11);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 36);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.OnAddNewBookRecordButton_Clicked);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(230, 11);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(123, 36);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.OnCancelOperationButton_Clicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(359, 11);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(123, 36);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.OnSaveRecordButton_Clicked);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(649, 513);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 36);
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
            // pnlAuthors
            // 
            this.pnlAuthors.Controls.Add(this.rbtnThreeAuthors);
            this.pnlAuthors.Controls.Add(this.rbtnTwoAuthors);
            this.pnlAuthors.Controls.Add(this.rbtnOneAuthor);
            this.pnlAuthors.Location = new System.Drawing.Point(192, 35);
            this.pnlAuthors.Name = "pnlAuthors";
            this.pnlAuthors.Size = new System.Drawing.Size(457, 48);
            this.pnlAuthors.TabIndex = 14;
            // 
            // rbtnOneAuthor
            // 
            this.rbtnOneAuthor.AutoSize = true;
            this.rbtnOneAuthor.BackColor = System.Drawing.Color.Gold;
            this.rbtnOneAuthor.Checked = true;
            this.rbtnOneAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOneAuthor.Location = new System.Drawing.Point(48, 13);
            this.rbtnOneAuthor.Name = "rbtnOneAuthor";
            this.rbtnOneAuthor.Size = new System.Drawing.Size(92, 20);
            this.rbtnOneAuthor.TabIndex = 1;
            this.rbtnOneAuthor.Text = "One Author";
            this.rbtnOneAuthor.UseVisualStyleBackColor = false;
            // 
            // rbtnTwoAuthors
            // 
            this.rbtnTwoAuthors.AutoSize = true;
            this.rbtnTwoAuthors.BackColor = System.Drawing.Color.Gold;
            this.rbtnTwoAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnTwoAuthors.Location = new System.Drawing.Point(182, 14);
            this.rbtnTwoAuthors.Name = "rbtnTwoAuthors";
            this.rbtnTwoAuthors.Size = new System.Drawing.Size(100, 20);
            this.rbtnTwoAuthors.TabIndex = 2;
            this.rbtnTwoAuthors.Text = "Two Authors";
            this.rbtnTwoAuthors.UseVisualStyleBackColor = false;
            // 
            // rbtnThreeAuthors
            // 
            this.rbtnThreeAuthors.AutoSize = true;
            this.rbtnThreeAuthors.BackColor = System.Drawing.Color.Gold;
            this.rbtnThreeAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnThreeAuthors.Location = new System.Drawing.Point(312, 14);
            this.rbtnThreeAuthors.Name = "rbtnThreeAuthors";
            this.rbtnThreeAuthors.Size = new System.Drawing.Size(110, 20);
            this.rbtnThreeAuthors.TabIndex = 3;
            this.rbtnThreeAuthors.Text = "Three Authors";
            this.rbtnThreeAuthors.UseVisualStyleBackColor = false;
            // 
            // AdditionOfBookAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.pnlAuthors);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Name = "AdditionOfBookAuthors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adding New Authors";
            this.flpButtons.ResumeLayout(false);
            this.pnlAuthors.ResumeLayout(false);
            this.pnlAuthors.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Panel pnlAuthors;
        private System.Windows.Forms.RadioButton rbtnThreeAuthors;
        private System.Windows.Forms.RadioButton rbtnTwoAuthors;
        private System.Windows.Forms.RadioButton rbtnOneAuthor;
    }
}