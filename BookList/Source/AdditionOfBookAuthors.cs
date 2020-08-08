// BookList
// 
// AdditionOfBookAuthors.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 08    07   2020
// 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>

using System;
using System.IO;
using System.Windows.Forms;
using BookList.Classes;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Defines the <see cref="AdditionOfBookAuthors" />.
    /// </summary>
    public partial class AdditionOfBookAuthors : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AdditionOfBookAuthors" /> class.
        /// </summary>
        public AdditionOfBookAuthors()
        {
            InitializeComponent();
            SetInitialControlsState();
        }

        /// <summary>
        ///     The OnAddNewBookRecordButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            txtAuthor.Enabled = true;
            txtAuthor.Text = string.Empty;
            txtAuthor.Focus();
        }

        /// <summary>
        ///     The OnCancelOperationButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />.</param>
        /// <param name="e">The e<see cref="EventArgs" />.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        /// <summary>
        ///     The OnCloseAddingNewAuthorButton_Close.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        ///     The OnSaveRecordButton_Clicked.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnSaveRecordButton_Clicked(object sender, EventArgs e)
        {
            var dirFileOp = new DirectoryFileClass();

            var dirAuthors = BookListPaths.PathToAuthorsDirectory;

            var authorOp = new AuthorsTextOperations();

            var fileName = authorOp.AddDashBetweenAuthorsFirstMiddleLastName(txtAuthor.Text);

            if (string.IsNullOrEmpty(fileName)) return;
            if (!Directory.Exists(dirAuthors)) return;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(dirAuthors, fileName);

            dirFileOp.CreateNewFile(filePath);
        }

        /// <summary>
        ///     Sets the initial state of the controls.
        /// </summary>
        private void SetInitialControlsState()
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtAuthor.Enabled = false;
            lblInfo.Text = MyStrings.lblInfoAddAuthor;
        }
    }
}