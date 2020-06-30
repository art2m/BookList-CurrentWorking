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

using BookList.PropertiesClasses;

namespace BookList.Source
{
    using BookList.Classes;
    using System;
    using System.IO;
    using System.Windows.Forms;

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
            var dirAuthors = BookListPropertiesClass.PathToAuthorsDirectory;

            var authorOp = new AuthorsTextOperations();

            var fileName = AuthorsTextOperations.AddDashBetweenAuthorsFirstMiddleLastName(this.txtAuthor.Text);

            if (string.IsNullOrEmpty(fileName)) return;
            if (!Directory.Exists(dirAuthors)) return;

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors, fileName);

            DirectoryFileOperationsClass.CreateNewFile(filePath);
        }

        private void SetInitialControlsState()
        {
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = false;
            this.btnCancel.Enabled = false;
            this.txtAuthor.Enabled = false;
            this.lblInfo.Text = MyStrings.lblInfoAddAuthor;
        }
    }
}