using System.Windows.Forms;

namespace BookList.Source
{
    /// <summary>
    /// Designer
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    partial class BookList
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lblSearch = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddTitles = new System.Windows.Forms.Button();
            this.btnAddAuthors = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.btnEditTitles = new System.Windows.Forms.Button();
            this.btnEditAuthors = new System.Windows.Forms.Button();
            this.pnlRawData = new System.Windows.Forms.Panel();
            this.btnUnfromatted = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.mnuFileTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddAuthor = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAddTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEditTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSearchTitles = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUnformattedTop = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFormat = new System.Windows.Forms.ToolStripMenuItem();
            this.lblFormat = new System.Windows.Forms.Label();
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
            this.btnQuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnQuit.Location = new System.Drawing.Point(620, 505);
            this.btnQuit.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnQuit.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(150, 45);
            this.btnQuit.TabIndex = 9;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.OnQuitApplicationButton_Clicked);
            // 
            // btnSearchTitles
            // 
            this.btnSearchTitles.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSearchTitles.Location = new System.Drawing.Point(2, 78);
            this.btnSearchTitles.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnSearchTitles.Name = "btnSearchTitles";
            this.btnSearchTitles.Size = new System.Drawing.Size(150, 45);
            this.btnSearchTitles.TabIndex = 1;
            this.btnSearchTitles.Text = "Book Titles";
            this.btnSearchTitles.UseVisualStyleBackColor = false;
            this.btnSearchTitles.Click += new System.EventHandler(this.OnSearchTitlesButton_Clicked);
            // 
            // btnSearchAuthors
            // 
            this.btnSearchAuthors.BackColor = System.Drawing.Color.SpringGreen;
            this.btnSearchAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSearchAuthors.Location = new System.Drawing.Point(2, 11);
            this.btnSearchAuthors.MaximumSize = new System.Drawing.Size(150, 45);
            this.btnSearchAuthors.MinimumSize = new System.Drawing.Size(150, 45);
            this.btnSearchAuthors.Name = "btnSearchAuthors";
            this.btnSearchAuthors.Size = new System.Drawing.Size(150, 45);
            this.btnSearchAuthors.TabIndex = 0;
            this.btnSearchAuthors.Text = "Authors";
            this.btnSearchAuthors.UseVisualStyleBackColor = false;
            this.btnSearchAuthors.Click += new System.EventHandler(this.OnSearchAuthorsButton_Clicked);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlSearch.Controls.Add(this.btnSearchAuthors);
            this.pnlSearch.Controls.Add(this.btnSearchTitles);
            this.pnlSearch.Location = new System.Drawing.Point(182, 108);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(154, 135);
            this.pnlSearch.TabIndex = 3;
            // 
            // lblSearch
            // 
            this.lblSearch.BackColor = System.Drawing.Color.Yellow;
            this.lblSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblSearch.Location = new System.Drawing.Point(181, 47);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(154, 49);
            this.lblSearch.TabIndex = 1;
            this.lblSearch.Text = "Search By:";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblAdd
            // 
            this.lblAdd.BackColor = System.Drawing.Color.Yellow;
            this.lblAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblAdd.Location = new System.Drawing.Point(445, 47);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(154, 49);
            this.lblAdd.TabIndex = 2;
            this.lblAdd.Text = "Add New By:";
            this.lblAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.Controls.Add(this.btnAddTitles);
            this.panel1.Controls.Add(this.btnAddAuthors);
            this.panel1.Location = new System.Drawing.Point(445, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(154, 135);
            this.panel1.TabIndex = 4;
            // 
            // btnAddTitles
            // 
            this.btnAddTitles.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddTitles.Location = new System.Drawing.Point(2, 78);
            this.btnAddTitles.Name = "btnAddTitles";
            this.btnAddTitles.Size = new System.Drawing.Size(150, 45);
            this.btnAddTitles.TabIndex = 1;
            this.btnAddTitles.Text = "Book Titles";
            this.btnAddTitles.UseVisualStyleBackColor = false;
            this.btnAddTitles.Click += new System.EventHandler(this.OnAddTitlesButton_Click);
            // 
            // btnAddAuthors
            // 
            this.btnAddAuthors.BackColor = System.Drawing.Color.Turquoise;
            this.btnAddAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAddAuthors.Location = new System.Drawing.Point(2, 11);
            this.btnAddAuthors.Name = "btnAddAuthors";
            this.btnAddAuthors.Size = new System.Drawing.Size(150, 45);
            this.btnAddAuthors.TabIndex = 0;
            this.btnAddAuthors.Text = "Authors";
            this.btnAddAuthors.UseVisualStyleBackColor = false;
            this.btnAddAuthors.Click += new System.EventHandler(this.OnAddAuthorsButton_Click);
            // 
            // lblEdit
            // 
            this.lblEdit.BackColor = System.Drawing.Color.Yellow;
            this.lblEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblEdit.Location = new System.Drawing.Point(182, 284);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(154, 49);
            this.lblEdit.TabIndex = 5;
            this.lblEdit.Text = "Edit By:";
            this.lblEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.BurlyWood;
            this.pnlEdit.Controls.Add(this.btnEditTitles);
            this.pnlEdit.Controls.Add(this.btnEditAuthors);
            this.pnlEdit.Location = new System.Drawing.Point(182, 345);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(154, 135);
            this.pnlEdit.TabIndex = 7;
            // 
            // btnEditTitles
            // 
            this.btnEditTitles.BackColor = System.Drawing.Color.Bisque;
            this.btnEditTitles.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEditTitles.Location = new System.Drawing.Point(2, 78);
            this.btnEditTitles.Name = "btnEditTitles";
            this.btnEditTitles.Size = new System.Drawing.Size(150, 45);
            this.btnEditTitles.TabIndex = 1;
            this.btnEditTitles.Text = "Book Titles";
            this.btnEditTitles.UseVisualStyleBackColor = false;
            this.btnEditTitles.Click += new System.EventHandler(this.OnEditTitlesButton_Clicked);
            // 
            // btnEditAuthors
            // 
            this.btnEditAuthors.BackColor = System.Drawing.Color.Bisque;
            this.btnEditAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEditAuthors.Location = new System.Drawing.Point(2, 11);
            this.btnEditAuthors.Name = "btnEditAuthors";
            this.btnEditAuthors.Size = new System.Drawing.Size(150, 45);
            this.btnEditAuthors.TabIndex = 0;
            this.btnEditAuthors.Text = "Authors";
            this.btnEditAuthors.UseVisualStyleBackColor = false;
            this.btnEditAuthors.Click += new System.EventHandler(this.OnEditAuthorsButton_Clicked);
            // 
            // pnlRawData
            // 
            this.pnlRawData.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.pnlRawData.Controls.Add(this.btnUnfromatted);
            this.pnlRawData.Location = new System.Drawing.Point(445, 345);
            this.pnlRawData.Name = "pnlRawData";
            this.pnlRawData.Size = new System.Drawing.Size(154, 77);
            this.pnlRawData.TabIndex = 8;
            // 
            // btnUnfromatted
            // 
            this.btnUnfromatted.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnUnfromatted.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnUnfromatted.Location = new System.Drawing.Point(2, 18);
            this.btnUnfromatted.MinimumSize = new System.Drawing.Size(100, 34);
            this.btnUnfromatted.Name = "btnUnfromatted";
            this.btnUnfromatted.Size = new System.Drawing.Size(150, 45);
            this.btnUnfromatted.TabIndex = 0;
            this.btnUnfromatted.Text = "Unformatted ";
            this.btnUnfromatted.UseVisualStyleBackColor = false;
            this.btnUnfromatted.Click += new System.EventHandler(this.OnFormatDataButton_Clicked);
            // 
            // mnuMain
            // 
            this.mnuMain.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuFileTop, this.mnuAddTop, this.mnuEditTop, this.mnuSearchTop, this.mnuUnformattedTop});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(780, 28);
            this.mnuMain.TabIndex = 0;
            // 
            // mnuFileTop
            // 
            this.mnuFileTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuExit});
            this.mnuFileTop.Name = "mnuFileTop";
            this.mnuFileTop.Size = new System.Drawing.Size(45, 24);
            this.mnuFileTop.Text = "File";
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(185, 24);
            this.mnuExit.Text = "Exit Application";
            this.mnuExit.Click += new System.EventHandler(this.OnExitApplicationMenuItem_Clicked);
            // 
            // mnuAddTop
            // 
            this.mnuAddTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuAddAuthor, this.mnuAddTitles});
            this.mnuAddTop.Name = "mnuAddTop";
            this.mnuAddTop.Size = new System.Drawing.Size(136, 24);
            this.mnuAddTop.Text = "Add New Record";
            // 
            // mnuAddAuthor
            // 
            this.mnuAddAuthor.Name = "mnuAddAuthor";
            this.mnuAddAuthor.Size = new System.Drawing.Size(152, 24);
            this.mnuAddAuthor.Text = "Author";
            this.mnuAddAuthor.Click += new System.EventHandler(this.OnAddAuthorsMenu_Click);
            // 
            // mnuAddTitles
            // 
            this.mnuAddTitles.Name = "mnuAddTitles";
            this.mnuAddTitles.Size = new System.Drawing.Size(152, 24);
            this.mnuAddTitles.Text = "Book Titles";
            this.mnuAddTitles.Click += new System.EventHandler(this.OnAddTitlesMenu_Click);
            // 
            // mnuEditTop
            // 
            this.mnuEditTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuEditAuthors, this.mnuEditTitles});
            this.mnuEditTop.Name = "mnuEditTop";
            this.mnuEditTop.Size = new System.Drawing.Size(99, 24);
            this.mnuEditTop.Text = "Edit Record";
            // 
            // mnuEditAuthors
            // 
            this.mnuEditAuthors.Name = "mnuEditAuthors";
            this.mnuEditAuthors.Size = new System.Drawing.Size(152, 24);
            this.mnuEditAuthors.Text = "Authors";
            this.mnuEditAuthors.Click += new System.EventHandler(this.OnEditAuthorsMenu_Clicked);
            // 
            // mnuEditTitles
            // 
            this.mnuEditTitles.Name = "mnuEditTitles";
            this.mnuEditTitles.Size = new System.Drawing.Size(152, 24);
            this.mnuEditTitles.Text = "Book Titles";
            this.mnuEditTitles.Click += new System.EventHandler(this.OnEditTitlesMenu_Clicked);
            // 
            // mnuSearchTop
            // 
            this.mnuSearchTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuSearchAuthors, this.mnuSearchTitles});
            this.mnuSearchTop.Name = "mnuSearchTop";
            this.mnuSearchTop.Size = new System.Drawing.Size(125, 24);
            this.mnuSearchTop.Text = "Search Records";
            // 
            // mnuSearchAuthors
            // 
            this.mnuSearchAuthors.Name = "mnuSearchAuthors";
            this.mnuSearchAuthors.Size = new System.Drawing.Size(152, 24);
            this.mnuSearchAuthors.Text = "Authors";
            this.mnuSearchAuthors.Click += new System.EventHandler(this.OnSearchAuthorsMenu_Clicked);
            // 
            // mnuSearchTitles
            // 
            this.mnuSearchTitles.Name = "mnuSearchTitles";
            this.mnuSearchTitles.Size = new System.Drawing.Size(152, 24);
            this.mnuSearchTitles.Text = "Book Titles";
            this.mnuSearchTitles.Click += new System.EventHandler(this.OnSearchTitlesMenu_Clicked);
            // 
            // mnuUnformattedTop
            // 
            this.mnuUnformattedTop.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {this.mnuFormat});
            this.mnuUnformattedTop.Name = "mnuUnformattedTop";
            this.mnuUnformattedTop.Size = new System.Drawing.Size(167, 24);
            this.mnuUnformattedTop.Text = "Unformatted Records";
            // 
            // mnuFormat
            // 
            this.mnuFormat.Name = "mnuFormat";
            this.mnuFormat.Size = new System.Drawing.Size(185, 24);
            this.mnuFormat.Text = "Format Records";
            this.mnuFormat.Click += new System.EventHandler(this.OnFormatRecordsMenu_Clicked);
            // 
            // lblFormat
            // 
            this.lblFormat.BackColor = System.Drawing.Color.Yellow;
            this.lblFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.lblFormat.Location = new System.Drawing.Point(445, 284);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(154, 49);
            this.lblFormat.TabIndex = 6;
            this.lblFormat.Text = "Format";
            this.lblFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(780, 557);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.pnlRawData);
            this.Controls.Add(this.pnlEdit);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblAdd);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.btnQuit);
            this.Controls.Add(this.mnuMain);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.mnuMain;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(150, 45);
            this.Name = "BookList";
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

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnAddAuthors;
        private System.Windows.Forms.Button btnAddTitles;
        private System.Windows.Forms.Button btnEditAuthors;
        private System.Windows.Forms.Button btnEditTitles;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Button btnSearchAuthors;
        private System.Windows.Forms.Button btnSearchTitles;
        private System.Windows.Forms.Button btnUnfromatted;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.ToolStripMenuItem mnuAddAuthor;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTitles;
        private System.Windows.Forms.ToolStripMenuItem mnuAddTop;
        private System.Windows.Forms.ToolStripMenuItem mnuEditAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTitles;
        private System.Windows.Forms.ToolStripMenuItem mnuEditTop;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuFileTop;
        private System.Windows.Forms.ToolStripMenuItem mnuFormat;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchTitles;
        private System.Windows.Forms.ToolStripMenuItem mnuSearchTop;
        private System.Windows.Forms.ToolStripMenuItem mnuUnformattedTop;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.Panel pnlRawData;
        private System.Windows.Forms.Panel pnlSearch;

        #endregion
    }
}

