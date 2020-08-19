using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BookList.Classes;

namespace BookList.Source
{
    /// <summary>
    /// Designer 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class BookTitleLocatorWin
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
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lstTiltes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitle.Location = new System.Drawing.Point(83, 460);
            this.txtTitle.Multiline = true;
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(627, 37);
            this.txtTitle.TabIndex = 5;
            this.txtTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnSearchEnterKeyPressTextBox_Clicked);
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(74, 415);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(627, 36);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Enter Partial or full book title.";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(620, 505);
            this.btnClose.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnClose.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(150, 45);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButton_Clicked);
            // 
            // lblAuthor
            // 
            this.lblAuthor.BackColor = System.Drawing.Color.Yellow;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAuthor.Location = new System.Drawing.Point(83, 39);
            this.lblAuthor.MaximumSize = new System.Drawing.Size(618, 32);
            this.lblAuthor.MinimumSize = new System.Drawing.Size(618, 32);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(618, 32);
            this.lblAuthor.TabIndex = 8;
            this.lblAuthor.Text = "Authors Name.";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelectAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectAll.Location = new System.Drawing.Point(339, 89);
            this.btnSelectAll.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnSelectAll.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(150, 45);
            this.btnSelectAll.TabIndex = 10;
            this.btnSelectAll.Text = "Select All Authors";
            this.btnSelectAll.UseVisualStyleBackColor = false;
            this.btnSelectAll.Click += new System.EventHandler(this.OnSelectAllAuthorsButton_Clicked);
            // 
            // btnSelect
            // 
            this.btnSelect.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.Location = new System.Drawing.Point(110, 89);
            this.btnSelect.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnSelect.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(150, 45);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "Select Author";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.OnSelectSingleAuthorButton_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(83, 505);
            this.btnSearch.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnSearch.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 45);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search By Title";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.OnTitleSearchSingleAuthorButton_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowAll.Location = new System.Drawing.Point(262, 505);
            this.btnShowAll.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnShowAll.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(150, 45);
            this.btnShowAll.TabIndex = 12;
            this.btnShowAll.Text = "Show All Titles";
            this.btnShowAll.UseVisualStyleBackColor = false;
            this.btnShowAll.Click += new System.EventHandler(this.OnShowAllTitlesSingleAuthorButton_Clicked);
            // 
            // lstTiltes
            // 
            this.lstTiltes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTiltes.FormattingEnabled = true;
            this.lstTiltes.ItemHeight = 18;
            this.lstTiltes.Location = new System.Drawing.Point(77, 168);
            this.lstTiltes.Name = "lstTiltes";
            this.lstTiltes.Size = new System.Drawing.Size(627, 220);
            this.lstTiltes.TabIndex = 13;
            // 
            // BookTitleLocatorWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSeaGreen;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.lstTiltes);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnSelectAll);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.lblAuthor);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BookTitleLocatorWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchOfBookTitles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private Button btnClose;
        private Label lblTitle;
        private TextBox txtTitle;

        #endregion

        private Label lblAuthor;
        private Button btnSelectAll;
        private Button btnSelect;
        private Button btnSearch;
        private Button btnShowAll;
        private ListBox lstTiltes;
    }
}