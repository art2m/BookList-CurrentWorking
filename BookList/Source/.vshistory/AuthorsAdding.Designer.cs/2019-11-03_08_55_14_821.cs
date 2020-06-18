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
            this.txtFirstAuthor = new System.Windows.Forms.TextBox();
            this.lblFirstAuthor = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.flpButtons = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlAuthors = new System.Windows.Forms.Panel();
            this.rbtnOneAuthor = new System.Windows.Forms.RadioButton();
            this.rbtnTwoAuthors = new System.Windows.Forms.RadioButton();
            this.rbtnThreeAuthors = new System.Windows.Forms.RadioButton();
            this.lblSecondAuthor = new System.Windows.Forms.Label();
            this.txtSecondAuthor = new System.Windows.Forms.TextBox();
            this.lblThirdAuthor = new System.Windows.Forms.Label();
            this.txtThirdAuthor = new System.Windows.Forms.TextBox();
            this.flpButtons.SuspendLayout();
            this.pnlAuthors.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtFirstAuthor
            // 
            this.txtFirstAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstAuthor.Location = new System.Drawing.Point(195, 163);
            this.txtFirstAuthor.Multiline = true;
            this.txtFirstAuthor.Name = "txtFirstAuthor";
            this.txtFirstAuthor.Size = new System.Drawing.Size(395, 32);
            this.txtFirstAuthor.TabIndex = 0;
            // 
            // lblFirstAuthor
            // 
            this.lblFirstAuthor.BackColor = System.Drawing.Color.Yellow;
            this.lblFirstAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstAuthor.Location = new System.Drawing.Point(195, 123);
            this.lblFirstAuthor.Name = "lblFirstAuthor";
            this.lblFirstAuthor.Size = new System.Drawing.Size(395, 32);
            this.lblFirstAuthor.TabIndex = 1;
            this.lblFirstAuthor.Text = "First authors name";
            this.lblFirstAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            // lblSecondAuthor
            // 
            this.lblSecondAuthor.BackColor = System.Drawing.Color.Yellow;
            this.lblSecondAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSecondAuthor.Location = new System.Drawing.Point(195, 214);
            this.lblSecondAuthor.Name = "lblSecondAuthor";
            this.lblSecondAuthor.Size = new System.Drawing.Size(395, 32);
            this.lblSecondAuthor.TabIndex = 15;
            this.lblSecondAuthor.Text = "Second Authors Name";
            this.lblSecondAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSecondAuthor
            // 
            this.txtSecondAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecondAuthor.Location = new System.Drawing.Point(195, 256);
            this.txtSecondAuthor.Multiline = true;
            this.txtSecondAuthor.Name = "txtSecondAuthor";
            this.txtSecondAuthor.Size = new System.Drawing.Size(395, 32);
            this.txtSecondAuthor.TabIndex = 16;
            // 
            // lblThirdAuthor
            // 
            this.lblThirdAuthor.BackColor = System.Drawing.Color.Yellow;
            this.lblThirdAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThirdAuthor.Location = new System.Drawing.Point(195, 310);
            this.lblThirdAuthor.Name = "lblThirdAuthor";
            this.lblThirdAuthor.Size = new System.Drawing.Size(395, 32);
            this.lblThirdAuthor.TabIndex = 17;
            this.lblThirdAuthor.Text = "Third Authors Name";
            this.lblThirdAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtThirdAuthor
            // 
            this.txtThirdAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThirdAuthor.Location = new System.Drawing.Point(195, 354);
            this.txtThirdAuthor.Multiline = true;
            this.txtThirdAuthor.Name = "txtThirdAuthor";
            this.txtThirdAuthor.Size = new System.Drawing.Size(395, 32);
            this.txtThirdAuthor.TabIndex = 18;
            // 
            // AdditionOfBookAuthors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PeachPuff;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.txtThirdAuthor);
            this.Controls.Add(this.lblThirdAuthor);
            this.Controls.Add(this.txtSecondAuthor);
            this.Controls.Add(this.lblSecondAuthor);
            this.Controls.Add(this.pnlAuthors);
            this.Controls.Add(this.flpButtons);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblFirstAuthor);
            this.Controls.Add(this.txtFirstAuthor);
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

        private System.Windows.Forms.TextBox txtFirstAuthor;
        private System.Windows.Forms.Label lblFirstAuthor;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.FlowLayoutPanel flpButtons;
        private System.Windows.Forms.Panel pnlAuthors;
        private System.Windows.Forms.RadioButton rbtnThreeAuthors;
        private System.Windows.Forms.RadioButton rbtnTwoAuthors;
        private System.Windows.Forms.RadioButton rbtnOneAuthor;
        private System.Windows.Forms.Label lblSecondAuthor;
        private System.Windows.Forms.TextBox txtSecondAuthor;
        private System.Windows.Forms.Label lblThirdAuthor;
        private System.Windows.Forms.TextBox txtThirdAuthor;
    }
}