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
    using System;
    using System.IO;
    using System.Windows.Forms;
    using Classes;

    /// <summary>
    ///     Defines the <see cref="AdditionOfBookAuthors" />
    /// </summary>
    public partial class AdditionOfBookAuthors : Form
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AdditionOfBookAuthors" /> class.
        /// </summary>
        public AdditionOfBookAuthors()
        {
            this.InitializeComponent();
        }


        /// <summary>
        ///     The OnAddNewBookRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            this.txtFirstAuthor.Text = string.Empty;
            this.txtSecondAuthor.Text = string.Empty;
            this.txtThirdAuthor.Text = string.Empty;
            this.txtFirstAuthor.Focus();
        }

        /// <summary>
        ///     The OnCancelOperationButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" /></param>
        /// <param name="e">The e<see cref="EventArgs" /></param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        /// <summary>
        ///     The OnCloseAddingNewAuthorButton_Close
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     The OnOneAuthorRadioButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnOneAuthorRadioButton_Clicked(object sender, EventArgs e)
        {
            this.lblFirstAuthor.Enabled = true;
            this.lblSecondAuthor.Enabled = false;
            this.lblThirdAuthor.Enabled = false;

            this.txtFirstAuthor.Enabled = true;
            this.txtSecondAuthor.Enabled = false;
            this.txtThirdAuthor.Enabled = false;
        }

        /// <summary>
        ///     The OnSaveRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnSaveRecordButton_Clicked(object sender, EventArgs e)
        {
            var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();

            var authorOp = new AuthorsTextOperations();
            var fileName = string.Empty;

            if (this.rbtnOneAuthor.Checked)
            {
                fileName = authorOp.BookAuthorName(this.txtFirstAuthor.Text);
            }
            else if (this.rbtnTwoAuthors.Checked)
            {
                fileName = authorOp.BookAuthorName(this.txtFirstAuthor.Text, this.txtSecondAuthor.Text);
            }
            else if (this.rbtnThreeAuthors.Checked)
            {
                fileName = authorOp.BookAuthorName(this.txtFirstAuthor.Text, this.txtSecondAuthor.Text, this
                    .txtThirdAuthor.Text);
            }

            if (string.IsNullOrEmpty(fileName)) return;
            if (!Directory.Exists(dirAuthors)) return;

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors, fileName);

            DirectoryFileOperationsClass.CreateNewFile(filePath);
        }


        /// <summary>
        ///     The OnThreeAuthorsRadioButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnThreeAuthorsRadioButton_Clicked(object sender, EventArgs e)
        {
            this.lblFirstAuthor.Enabled = true;
            this.lblSecondAuthor.Enabled = true;
            this.lblThirdAuthor.Enabled = true;

            this.txtFirstAuthor.Enabled = true;
            this.txtSecondAuthor.Enabled = true;
            this.txtThirdAuthor.Enabled = true;
        }

        /// <summary>
        ///     The OnTwoAuthorsRadioButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnTwoAuthorsRadioButton_Clicked(object sender, EventArgs e)
        {
            this.lblFirstAuthor.Enabled = true;
            this.lblSecondAuthor.Enabled = true;
            this.lblThirdAuthor.Enabled = false;

            this.txtFirstAuthor.Enabled = true;
            this.txtSecondAuthor.Enabled = true;
            this.txtThirdAuthor.Enabled = false;
        }
    }
}