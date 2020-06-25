using System.Drawing;
using System.Windows.Forms;

namespace BookList.Source
{
    partial class FormatBookData
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
            this.components = new System.ComponentModel.Container();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtData = new System.Windows.Forms.TextBox();
            this.RawDataMenu = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSave = new System.Windows.Forms.ToolStripMenuItem();
            this.BookDataFormatingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAuthors = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.lblPosition = new System.Windows.Forms.Label();
            this.pnlSeries = new System.Windows.Forms.Panel();
            this.rbtnNotSeries = new System.Windows.Forms.RadioButton();
            this.rbtnIsSeries = new System.Windows.Forms.RadioButton();
            this.tipTool = new System.Windows.Forms.ToolTip(this.components);
            this.btnFormat = new System.Windows.Forms.Button();
            this.RawDataMenu.SuspendLayout();
            this.pnlSeries.SuspendLayout();
            this.SuspendLayout();
            //
            // btnClose
            //
            this.btnClose.BackColor = System.Drawing.Color.LightCoral;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(662, 317);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(110, 36);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.OnCloseButton_Clicked);
            //
            // lblInfo
            //
            this.lblInfo.BackColor = System.Drawing.Color.Yellow;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(8, 36);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(768, 27);
            this.lblInfo.TabIndex = 8;
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // txtData
            //
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(8, 122);
            this.txtData.Multiline = true;
            this.txtData.Name = "txtData";
            this.txtData.ReadOnly = true;
            this.txtData.Size = new System.Drawing.Size(768, 34);
            this.txtData.TabIndex = 9;
            this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            //
            // RawDataMenu
            //
            this.RawDataMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.BookDataFormatingMenu});
            this.RawDataMenu.Location = new System.Drawing.Point(0, 0);
            this.RawDataMenu.Name = "RawDataMenu";
            this.RawDataMenu.Size = new System.Drawing.Size(784, 24);
            this.RawDataMenu.TabIndex = 10;
            this.RawDataMenu.Text = "RawDataMenu";
            //
            // fileToolStripMenuItem
            //
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuClose,
            this.mnuSave});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            //
            // mnuClose
            //
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(164, 22);
            this.mnuClose.Text = "Close";
            this.mnuClose.Click += new System.EventHandler(this.OnCloseMenuItem_Clicked);
            //
            // mnuSave
            //
            this.mnuSave.Name = "mnuSave";
            this.mnuSave.Size = new System.Drawing.Size(164, 22);
            this.mnuSave.Text = "Save All Changes";
            //
            // BookDataFormatingMenu
            //
            this.BookDataFormatingMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAuthors});
            this.BookDataFormatingMenu.Name = "BookDataFormatingMenu";
            this.BookDataFormatingMenu.Size = new System.Drawing.Size(131, 20);
            this.BookDataFormatingMenu.Text = "Book Data Formating";
            //
            // mnuAuthors
            //
            this.mnuAuthors.Name = "mnuAuthors";
            this.mnuAuthors.Size = new System.Drawing.Size(157, 22);
            this.mnuAuthors.Text = "Display Authors";
            this.mnuAuthors.Click += new System.EventHandler(this.OnDisplayAllAuthorsMenuItem_Clicked);
            //
            // btnFirst
            //
            this.btnFirst.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnFirst.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFirst.Location = new System.Drawing.Point(8, 169);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(92, 30);
            this.btnFirst.TabIndex = 0;
            this.btnFirst.Text = "<< First";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.OnMoveFirstButton_Clicked);
            //
            // btnNext
            //
            this.btnNext.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(233, 169);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(92, 30);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "> Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.OnMoveNextButton_Clicked);
            //
            // btnPrevious
            //
            this.btnPrevious.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.Location = new System.Drawing.Point(458, 169);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(92, 30);
            this.btnPrevious.TabIndex = 2;
            this.btnPrevious.Text = "< Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.OnMovePreviousButton_Clicked);
            //
            // btnLast
            //
            this.btnLast.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnLast.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLast.Location = new System.Drawing.Point(683, 169);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(92, 30);
            this.btnLast.TabIndex = 4;
            this.btnLast.Text = ">> Last";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.OnMoveLastButton_Clicked);
            //
            // lblPosition
            //
            this.lblPosition.BackColor = System.Drawing.SystemColors.Info;
            this.lblPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPosition.Location = new System.Drawing.Point(8, 89);
            this.lblPosition.Name = "lblPosition";
            this.lblPosition.Size = new System.Drawing.Size(768, 27);
            this.lblPosition.TabIndex = 18;
            this.lblPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // pnlSeries
            //
            this.pnlSeries.BackColor = System.Drawing.Color.Silver;
            this.pnlSeries.Controls.Add(this.rbtnNotSeries);
            this.pnlSeries.Controls.Add(this.rbtnIsSeries);
            this.pnlSeries.Location = new System.Drawing.Point(27, 215);
            this.pnlSeries.Name = "pnlSeries";
            this.pnlSeries.Size = new System.Drawing.Size(731, 49);
            this.pnlSeries.TabIndex = 23;
            //
            // rbtnNotSeries
            //
            this.rbtnNotSeries.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbtnNotSeries.Checked = true;
            this.rbtnNotSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnNotSeries.Location = new System.Drawing.Point(416, 10);
            this.rbtnNotSeries.Name = "rbtnNotSeries";
            this.rbtnNotSeries.Size = new System.Drawing.Size(130, 26);
            this.rbtnNotSeries.TabIndex = 1;
            this.rbtnNotSeries.TabStop = true;
            this.rbtnNotSeries.Text = "Book Not Series";
            this.rbtnNotSeries.UseVisualStyleBackColor = false;
            this.rbtnNotSeries.Click += new System.EventHandler(this.OnBookIsNotSeriesRadioButton_Clicked);
            //
            // rbtnIsSeries
            //
            this.rbtnIsSeries.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
            this.rbtnIsSeries.BackColor = System.Drawing.Color.LemonChiffon;
            this.rbtnIsSeries.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnIsSeries.Location = new System.Drawing.Point(184, 10);
            this.rbtnIsSeries.Name = "rbtnIsSeries";
            this.rbtnIsSeries.Size = new System.Drawing.Size(130, 26);
            this.rbtnIsSeries.TabIndex = 0;
            this.rbtnIsSeries.Text = "Book Is Series";
            this.rbtnIsSeries.UseVisualStyleBackColor = false;
            this.rbtnIsSeries.Click += new System.EventHandler(this.OnBookIsSeriesRadioButton_Clicked);
            //
            // btnFormat
            //
            this.btnFormat.BackColor = System.Drawing.Color.LightGreen;
            this.btnFormat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFormat.Location = new System.Drawing.Point(332, 278);
            this.btnFormat.Name = "btnFormat";
            this.btnFormat.Size = new System.Drawing.Size(121, 39);
            this.btnFormat.TabIndex = 24;
            this.btnFormat.Text = "Format Book Info";
            this.btnFormat.UseVisualStyleBackColor = true;
            this.btnFormat.Click += new System.EventHandler(this.OnFormatBookInformationButton_Click);
            //
            // FormatBookData
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(784, 365);
            this.Controls.Add(this.btnFormat);
            this.Controls.Add(this.pnlSeries);
            this.Controls.Add(this.lblPosition);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.RawDataMenu);
            this.Controls.Add(this.txtData);
            this.MainMenuStrip = this.RawDataMenu;
            this.Name = "FormatBookData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Format Data For Adding To Books Read Collection.";
            this.RawDataMenu.ResumeLayout(false);
            this.RawDataMenu.PerformLayout();
            this.pnlSeries.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.MenuStrip RawDataMenu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BookDataFormatingMenu;
        private System.Windows.Forms.ToolStripMenuItem mnuAuthors;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem mnuSave;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblPosition;
        private System.Windows.Forms.Panel pnlSeries;
        private System.Windows.Forms.RadioButton rbtnNotSeries;
        private System.Windows.Forms.RadioButton rbtnIsSeries;
        private System.Windows.Forms.ToolTip tipTool;
        private System.Windows.Forms.Button btnFormat;
    }
}