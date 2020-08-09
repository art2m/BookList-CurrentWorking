// BookList
//
// AdditionOfBookAuthors.cs
//
// Art2M
//
// art2m@live.com
//
// 11  09  2019
//
// 11  09   2019
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace BookList.Source
{
    using BookList.Classes;
    using System;
    using System.IO;
    using System.Windows.Forms;
    using BookListCurrent.ClassesProperties;

    /// <summary>
    /// Defines the <see cref="AdditionOfBookAuthors" />.
    /// </summary>
    public partial class AdditionOfBookAuthors : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionOfBookAuthors"/> class.
        /// </summary>
        public AdditionOfBookAuthors()
        {
            this.InitializeComponent();
            this.SetInitialControlsState();
        }

        /// <summary>
        /// The OnAddNewBookRecordButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            this.txtAuthor.Enabled = true;
            this.txtAuthor.Text = string.Empty;
            this.txtAuthor.Focus();
        }

        /// <summary>
        /// The OnCancelOperationButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />.</param>
        /// <param name="e">The e<see cref="EventArgs" />.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        /// <summary>
        /// The OnCloseAddingNewAuthorButton_Close.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// The OnSaveRecordButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnSaveRecordButton_Clicked(object sender, EventArgs e)
        {
            var dirFileOp = new DirectoryFileClass();

            var dirAuthors = BookListPaths.PathAuthorsDirectory;

            var authorOp = new AuthorsOperations();

            var fileName = authorOp.AddDashBetweenAuthorsFirstMiddleLastName(this.txtAuthor.Text);

            if (string.IsNullOrEmpty(fileName)) return;
            if (!Directory.Exists(dirAuthors)) return;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(dirAuthors, fileName);

            dirFileOp.CreateNewFile(filePath);
        }

        /// <summary>
        /// Sets the initial state of the controls.
        /// </summary>
        private void SetInitialControlsState()
        {
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.txtAuthor.Enabled = false;
            this.lblInfo.Text = MyStrings.lblInfoAddAuthor;
        }
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        this.txtAuthor = new System.Windows.Forms.TextBox();
        this.lblAuthor = new System.Windows.Forms.Label();
        this.btnClose = new System.Windows.Forms.Button();
        this.lblInfo = new System.Windows.Forms.Label();
        this.btnAdd = new System.Windows.Forms.Button();
        this.btnCancel = new System.Windows.Forms.Button();
        this.btnSave = new System.Windows.Forms.Button();
        this.SuspendLayout();
        // 
        // txtAuthor
        // 
        this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.txtAuthor.Location = new System.Drawing.Point(85, 243);
        this.txtAuthor.Multiline = true;
        this.txtAuthor.Name = "txtAuthor";
        this.txtAuthor.Size = new System.Drawing.Size(615, 32);
        this.txtAuthor.TabIndex = 2;
        // 
        // lblAuthor
        // 
        this.lblAuthor.BackColor = System.Drawing.Color.Yellow;
        this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.lblAuthor.Location = new System.Drawing.Point(85, 203);
        this.lblAuthor.Name = "lblAuthor";
        this.lblAuthor.Size = new System.Drawing.Size(615, 32);
        this.lblAuthor.TabIndex = 1;
        this.lblAuthor.Text = "Enter Authors Name";
        this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnClose
        // 
        this.btnClose.BackColor = System.Drawing.Color.LightCoral;
        this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.btnClose.Location = new System.Drawing.Point(620, 505);
        this.btnClose.MaximumSize = new System.Drawing.Size(150, 45);
        this.btnClose.MinimumSize = new System.Drawing.Size(150, 45);
        this.btnClose.Name = "btnClose";
        this.btnClose.Size = new System.Drawing.Size(150, 45);
        this.btnClose.TabIndex = 6;
        this.btnClose.Text = "Close";
        this.btnClose.UseVisualStyleBackColor = false;
        this.btnClose.Click += new System.EventHandler(this.OnCloseAddingNewAuthorButton_Close);
        // 
        // lblInfo
        // 
        this.lblInfo.BackColor = System.Drawing.Color.Yellow;
        this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.lblInfo.Location = new System.Drawing.Point(12, 69);
        this.lblInfo.Name = "lblInfo";
        this.lblInfo.Size = new System.Drawing.Size(760, 32);
        this.lblInfo.TabIndex = 0;
        this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        // 
        // btnAdd
        // 
        this.btnAdd.BackColor = System.Drawing.Color.LightSteelBlue;
        this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.btnAdd.Location = new System.Drawing.Point(85, 303);
        this.btnAdd.Name = "btnAdd";
        this.btnAdd.Size = new System.Drawing.Size(150, 45);
        this.btnAdd.TabIndex = 3;
        this.btnAdd.Text = "Add";
        this.btnAdd.UseVisualStyleBackColor = false;
        // 
        // btnCancel
        // 
        this.btnCancel.BackColor = System.Drawing.Color.LightSteelBlue;
        this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.btnCancel.Location = new System.Drawing.Point(317, 303);
        this.btnCancel.Name = "btnCancel";
        this.btnCancel.Size = new System.Drawing.Size(150, 45);
        this.btnCancel.TabIndex = 4;
        this.btnCancel.Text = "Cancel";
        this.btnCancel.UseVisualStyleBackColor = false;
        // 
        // btnSave
        // 
        this.btnSave.BackColor = System.Drawing.Color.LightSteelBlue;
        this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
        this.btnSave.Location = new System.Drawing.Point(549, 303);
        this.btnSave.Name = "btnSave";
        this.btnSave.Size = new System.Drawing.Size(150, 45);
        this.btnSave.TabIndex = 5;
        this.btnSave.Text = "Save";
        this.btnSave.UseVisualStyleBackColor = false;
        // 
        // AdditionOfBookAuthors
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.Aquamarine;
        this.ClientSize = new System.Drawing.Size(790, 567);
        this.Controls.Add(this.btnAdd);
        this.Controls.Add(this.btnCancel);
        this.Controls.Add(this.btnSave);
        this.Controls.Add(this.lblInfo);
        this.Controls.Add(this.btnClose);
        this.Controls.Add(this.lblAuthor);
        this.Controls.Add(this.txtAuthor);
        this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
        this.MaximizeBox = false;
        this.MaximumSize = new System.Drawing.Size(800, 600);
        this.MinimumSize = new System.Drawing.Size(800, 600);
        this.Name = "AdditionOfBookAuthors";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Adding New Authors";
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    private System.Windows.Forms.Button btnAdd;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Label lblAuthor;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.TextBox txtAuthor;
}