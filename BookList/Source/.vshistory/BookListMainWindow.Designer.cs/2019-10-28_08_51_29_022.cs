﻿using System.Windows.Forms;

namespace BookList.Source
{
    partial class BookListWindow
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
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnSearchTitles = new System.Windows.Forms.Button();
            this.btnSearchAuthors = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.btnSearchSeries = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddSeries = new System.Windows.Forms.Button();
            this.btnAddTitles = new System.Windows.Forms.Button();
            this.btnAddAuthors = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnEditSeries = new System.Windows.Forms.Button();
            this.btnEditTitles = new System.Windows.Forms.Button();
            this.btnEditAuthors = new System.Windows.Forms.Button();
            this.pnlRawData = new System.Windows.Forms.Panel();
            this.btnUnfromatted = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFileTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnformattedTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddSereis = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchSeries = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlSearch.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pnlEdit.SuspendLayout();
            this.pnlRawData.SuspendLayout();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.LightCoral;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Location = new System.Drawing.Point(643, 505);
            this.btnQuit.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(125, 40);
            this.btnQuit.TabIndex = 15;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.OnQuitApplicationButton_Clicked);
            // 
            // btnSearchTitles
            // 
            this.btnSearchTitles.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchTitles.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchTitles.Location = new System.Drawing.Point(25, 88);
            this.btnSearchTitles.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnSearchTitles.Name = "btnSearchTitles";
            this.btnSearchTitles.Size = new System.Drawing.Size(125, 40);
            this.btnSearchTitles.TabIndex = 16;
            this.btnSearchTitles.Text = "Book Titles";
            this.btnSearchTitles.UseVisualStyleBackColor = false;
            this.btnSearchTitles.Click += new System.EventHandler(this.OnSearchTitlesButton_Clicked);
            // 
            // btnSearchAuthors
            // 
            this.btnSearchAuthors.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchAuthors.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchAuthors.Location = new System.Drawing.Point(25, 21);
            this.btnSearchAuthors.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnSearchAuthors.Name = "btnSearchAuthors";
            this.btnSearchAuthors.Size = new System.Drawing.Size(125, 40);
            this.btnSearchAuthors.TabIndex = 18;
            this.btnSearchAuthors.Text = "Authors";
            this.btnSearchAuthors.UseVisualStyleBackColor = false;
            this.btnSearchAuthors.Click += new System.EventHandler(this.OnSearchAuthorsButton_Clicked);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlSearch.Controls.Add(this.btnSearchSeries);
            this.pnlSearch.Controls.Add(this.btnSearchAuthors);
            this.pnlSearch.Controls.Add(this.btnSearchTitles);
            this.pnlSearch.Location = new System.Drawing.Point(25, 108);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(173, 218);
            this.pnlSearch.TabIndex = 19;
            // 
            // btnSearchSeries
            // 
            this.btnSearchSeries.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchSeries.Location = new System.Drawing.Point(25, 160);
            this.btnSearchSeries.Name = "btnSearchSeries";
            this.btnSearchSeries.Size = new System.Drawing.Size(125, 40);
            this.btnSearchSeries.TabIndex = 19;
            this.btnSearchSeries.Text = "Series";
            this.btnSearchSeries.UseVisualStyleBackColor = false;
            this.btnSearchSeries.Click += new System.EventHandler(this.OnSearchSeriesButton_Clicked);
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Yellow;
            this.lblSearch.Location = new System.Drawing.Point(24, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(173, 49);
            this.lblSearch.TabIndex = 20;
            this.lblSearch.Text = "Search By:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Yellow;
            this.lblAdd.Location = new System.Drawing.Point(288, 47);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(173, 49);
            this.lblAdd.TabIndex = 21;
            this.lblAdd.Text = "Add New By:";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.btnAddSeries);
            this.panel1.Controls.Add(this.btnAddTitles);
            this.panel1.Controls.Add(this.btnAddAuthors);
            this.panel1.Location = new System.Drawing.Point(288, 112);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 218);
            this.panel1.TabIndex = 22;
            // 
            // btnAddSeries
            // 
            this.btnAddSeries.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddSeries.Location = new System.Drawing.Point(24, 160);
            this.btnAddSeries.Name = "btnAddSeries";
            this.btnAddSeries.Size = new System.Drawing.Size(125, 40);
            this.btnAddSeries.TabIndex = 2;
            this.btnAddSeries.Text = "Series";
            this.btnAddSeries.UseVisualStyleBackColor = false;
            this.btnAddSeries.Click += new System.EventHandler(this.OnAddSeriesButton_Clicked);
            // 
            // btnAddTitles
            // 
            this.btnAddTitles.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddTitles.Location = new System.Drawing.Point(24, 88);
            this.btnAddTitles.Name = "btnAddTitles";
            this.btnAddTitles.Size = new System.Drawing.Size(125, 40);
            this.btnAddTitles.TabIndex = 1;
            this.btnAddTitles.Text = "Book Titles";
            this.btnAddTitles.UseVisualStyleBackColor = false;
            this.btnAddTitles.Click += new System.EventHandler(this.OnAddTitlesButton_Clicked);
            // 
            // btnAddAuthors
            // 
            this.btnAddAuthors.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddAuthors.Location = new System.Drawing.Point(24, 21);
            this.btnAddAuthors.Name = "btnAddAuthors";
            this.btnAddAuthors.Size = new System.Drawing.Size(125, 40);
            this.btnAddAuthors.TabIndex = 0;
            this.btnAddAuthors.Text = "Authors";
            this.btnAddAuthors.UseVisualStyleBackColor = false;
            this.btnAddAuthors.Click += new System.EventHandler(this.OnAddAuthorsButton_Clicked);
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.Yellow;
            this.lblEdit.Location = new System.Drawing.Point(552, 47);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(173, 49);
            this.lblEdit.TabIndex = 23;
            this.lblEdit.Text = "Edit By:";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlEdit.Controls.Add(this.btnEditSeries);
            this.pnlEdit.Controls.Add(this.btnEditTitles);
            this.pnlEdit.Controls.Add(this.btnEditAuthors);
            this.pnlEdit.Location = new System.Drawing.Point(552, 119);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(173, 218);
            this.pnlEdit.TabIndex = 24;
            // 
            // btnEditSeries
            // 
            this.btnEditSeries.BackColor = System.Drawing.Color.Bisque;
            this.btnEditSeries.Location = new System.Drawing.Point(26, 160);
            this.btnEditSeries.Name = "btnEditSeries";
            this.btnEditSeries.Size = new System.Drawing.Size(125, 40);
            this.btnEditSeries.TabIndex = 2;
            this.btnEditSeries.Text = "Series";
            this.btnEditSeries.UseVisualStyleBackColor = false;
            this.btnEditSeries.Click += new System.EventHandler(this.OnEditSeriesButton_Clicked);
            // 
            // btnEditTitles
            // 
            this.btnEditTitles.BackColor = System.Drawing.Color.Bisque;
            this.btnEditTitles.Location = new System.Drawing.Point(26, 88);
            this.btnEditTitles.Name = "btnEditTitles";
            this.btnEditTitles.Size = new System.Drawing.Size(125, 40);
            this.btnEditTitles.TabIndex = 1;
            this.btnEditTitles.Text = "Book Titles";
            this.btnEditTitles.UseVisualStyleBackColor = false;
            this.btnEditTitles.Click += new System.EventHandler(this.OnEditTitlesButton_Clicked);
            // 
            // btnEditAuthors
            // 
            this.btnEditAuthors.BackColor = System.Drawing.Color.Bisque;
            this.btnEditAuthors.Location = new System.Drawing.Point(26, 21);
            this.btnEditAuthors.Name = "btnEditAuthors";
            this.btnEditAuthors.Size = new System.Drawing.Size(125, 40);
            this.btnEditAuthors.TabIndex = 0;
            this.btnEditAuthors.Text = "Authors";
            this.btnEditAuthors.UseVisualStyleBackColor = false;
            this.btnEditAuthors.Click += new System.EventHandler(this.OnEditAuthorsButton_Clicked);
            // 
            // pnlRawData
            // 
            this.pnlRawData.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlRawData.Controls.Add(this.btnUnfromatted);
            this.pnlRawData.Location = new System.Drawing.Point(34, 356);
            this.pnlRawData.Name = "pnlRawData";
            this.pnlRawData.Size = new System.Drawing.Size(174, 169);
            this.pnlRawData.TabIndex = 25;
            // 
            // btnUnfromatted
            // 
            this.btnUnfromatted.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUnfromatted.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUnfromatted.Location = new System.Drawing.Point(20, 18);
            this.btnUnfromatted.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnUnfromatted.Name = "btnUnfromatted";
            this.btnUnfromatted.Size = new System.Drawing.Size(125, 40);
            this.btnUnfromatted.TabIndex = 19;
            this.btnUnfromatted.Text = "Unformatted ";
            this.btnUnfromatted.UseVisualStyleBackColor = false;
            this.btnUnfromatted.Click += new System.EventHandler(this.OnUnformattedDataButton_Clicked);
            // 
            // mnuMain
            // 
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFileTop,
            this.mnuAddTop,
            this.mnuEditTop,
            this.mnuSearchTop,
            this.mnuUnformattedTop});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(790, 24);
            this.mnuMain.TabIndex = 26;
            // 
            // mnuFileTop
            // 
            this.mnuFileTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuExit});
            this.mnuFileTop.Name = "mnuFileTop";
            this.mnuFileTop.Size = new System.Drawing.Size(37, 20);
            this.mnuFileTop.Text = "File";
            // 
            // mnuAddTop
            // 
            this.mnuAddTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAddAuthor,
            this.mnuAddTitles,
            this.mnuAddSereis});
            this.mnuAddTop.Name = "mnuAddTop";
            this.mnuAddTop.Size = new System.Drawing.Size(108, 20);
            this.mnuAddTop.Text = "Add New Record";
            // 
            // mnuEditTop
            // 
            this.mnuEditTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuEditAuthors,
            this.mnuEditTitles,
            this.mnuEditSeries});
            this.mnuEditTop.Name = "mnuEditTop";
            this.mnuEditTop.Size = new System.Drawing.Size(79, 20);
            this.mnuEditTop.Text = "Edit Record";
            // 
            // mnuSearchTop
            // 
            this.mnuSearchTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSearchAuthors,
            this.mnuSearchTitles,
            this.mnuSearchSeries});
            this.mnuSearchTop.Name = "mnuSearchTop";
            this.mnuSearchTop.Size = new System.Drawing.Size(99, 20);
            this.mnuSearchTop.Text = "Search Records";
            // 
            // mnuUnformattedTop
            // 
            this.mnuUnformattedTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFormat});
            this.mnuUnformattedTop.Name = "mnuUnformattedTop";
            this.mnuUnformattedTop.Size = new System.Drawing.Size(132, 20);
            this.mnuUnformattedTop.Text = "Unformatted Records";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(180, 22);
            this.mnuExit.Text = "Exit Application";
            this.mnuExit.Click += new System.EventHandler(this.OnExitApplicationMenuItem_Clicked);
            // 
            // mnuAddAuthor
            // 
            this.mnuAddAuthor.Name = "mnuAddAuthor";
            this.mnuAddAuthor.Size = new System.Drawing.Size(180, 22);
            this.mnuAddAuthor.Text = "Author";
            // 
            // mnuAddTitles
            // 
            this.mnuAddTitles.Name = "mnuAddTitles";
            this.mnuAddTitles.Size = new System.Drawing.Size(180, 22);
            this.mnuAddTitles.Text = "Book Titles";
            // 
            // mnuAddSereis
            // 
            this.mnuAddSereis.Name = "mnuAddSereis";
            this.mnuAddSereis.Size = new System.Drawing.Size(180, 22);
            this.mnuAddSereis.Text = "Series";
            // 
            // mnuEditAuthors
            // 
            this.mnuEditAuthors.Name = "mnuEditAuthors";
            this.mnuEditAuthors.Size = new System.Drawing.Size(180, 22);
            this.mnuEditAuthors.Text = "Authors";
            // 
            // mnuEditTitles
            // 
            this.mnuEditTitles.Name = "mnuEditTitles";
            this.mnuEditTitles.Size = new System.Drawing.Size(180, 22);
            this.mnuEditTitles.Text = "Book Titles";
            // 
            // mnuEditSeries
            // 
            this.mnuEditSeries.Name = "mnuEditSeries";
            this.mnuEditSeries.Size = new System.Drawing.Size(180, 22);
            this.mnuEditSeries.Text = "Series";
            // 
            // mnuSearchAuthors
            // 
            this.mnuSearchAuthors.Name = "mnuSearchAuthors";
            this.mnuSearchAuthors.Size = new System.Drawing.Size(180, 22);
            this.mnuSearchAuthors.Text = "Authors";
            // 
            // mnuSearchTitles
            // 
            this.mnuSearchTitles.Name = "mnuSearchTitles";
            this.mnuSearchTitles.Size = new System.Drawing.Size(180, 22);
            this.mnuSearchTitles.Text = "Book Titles";
            // 
            // mnuSearchSeries
            // 
            this.mnuSearchSeries.Name = "mnuSearchSeries";
            this.mnuSearchSeries.Size = new System.Drawing.Size(180, 22);
            this.mnuSearchSeries.Text = "Series";
            // 
            // mnuFormat
            // 
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(180, 22);
            this.mnuFormat.Text = "Format Records";
            // 
            // BookListWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(790, 567);
            this.Controls.Add(this.pnlRawData);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "BookListWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book List Main Window";
            this.pnlSearch.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.pnlEdit.ResumeLayout(false);
            this.pnlRawData.ResumeLayout(false);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Label lblSearch;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSearchAuthors;
        private System.Windows.Forms.Button btnSearchTitles;
        private System.Windows.Forms.Button btnAddAuthors;
        private System.Windows.Forms.Button btnSearchSeries;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Button btnEditTitles;
        private System.Windows.Forms.Button btnEditAuthors;
        private System.Windows.Forms.Button btnEditSeries;
        private System.Windows.Forms.Button btnAddSeries;
        private System.Windows.Forms.Button btnAddTitles;
        private Panel pnlRawData;
        private Button btnUnfromatted;
        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuFileTop;
        private ToolStripMenuItem mnuAddTop;
        private ToolStripMenuItem mnuEditTop;
        private ToolStripMenuItem mnuSearchTop;
        private ToolStripMenuItem mnuUnformattedTop;
        private ToolStripMenuItem mnuExit;
        private ToolStripMenuItem mnuAddTitles;
        private ToolStripMenuItem mnuAddAuthor;
        private ToolStripMenuItem mnuAddSereis;
        private ToolStripMenuItem mnuEditAuthors;
        private ToolStripMenuItem mnuEditTitles;
        private ToolStripMenuItem mnuEditSeries;
        private ToolStripMenuItem mnuSearchAuthors;
        private ToolStripMenuItem mnuSearchTitles;
        private ToolStripMenuItem mnuSearchSeries;
        private ToolStripMenuItem mnuFormat;
    }
}

