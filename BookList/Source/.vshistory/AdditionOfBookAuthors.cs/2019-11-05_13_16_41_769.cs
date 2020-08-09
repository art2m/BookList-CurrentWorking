// BookList
// 
// AdditionOfBookAuthors.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 11  03  2019
// 
// 10  26   2019
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
    /// Defines the <see cref="AdditionOfBookAuthors" />
    /// </summary>
    public partial class AdditionOfBookAuthors : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionOfBookAuthors"/> class.
        /// </summary>
        public AdditionOfBookAuthors()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Create Authors FileName
        /// Add underscore to separate multiple authors.
        /// Add .dat file extension to file name.
        /// </summary>
        /// <returns>The <see cref="string"/>File name or returns empty string.</returns>
        private string CreateAuthorsFileName()
        {
            var retVal = this.txtFirstAuthor.Text.Trim();
            retVal = string.Concat(retVal, ".dat");

            if (this.rbtnTwoAuthors.Checked)
            {
                retVal = string.Concat(retVal, "_");
                retVal = string.Concat(retVal, this.txtSecondAuthor.Text.Trim());

                if (retVal.Length <= 5) retVal = string.Empty;
            }
            else if (this.rbtnThreeAuthors.Checked)
            {
                retVal = string.Concat(retVal, "_");
                retVal = string.Concat(retVal, this.txtSecondAuthor.Text.Trim());
                retVal = string.Concat(retVal, "_");
                retVal = string.Concat(retVal, this.txtThirdAuthor.Text.Trim());

                if (retVal.Length <= 6) retVal = string.Empty;
            }

            return retVal;
        }

        /// <summary>
        /// The OnAddNewBookRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            this.txtFirstAuthor.Text = string.Empty;
            this.txtSecondAuthor.Text = string.Empty;
            this.txtThirdAuthor.Text = string.Empty;
            this.txtFirstAuthor.Focus();
        }

        /// <summary>
        /// The OnCancelOperationButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.btnAdd.PerformClick();
        }

        /// <summary>
        /// The OnCloseAddingNewAuthorButton_Close
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The OnOneAuthorRadioButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
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
        /// The OnSaveRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
        private void OnSaveRecordButton_Clicked(object sender, EventArgs e)
        {

            // TODO: need to put multiple autors to gether before creating author names.
            // TODO: need to check file does not exist then after creating file do
            var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();

            var fileName = this.CreateAuthorsFileName();
            if (string.IsNullOrEmpty(fileName)) return;
            if (!Directory.Exists(dirAuthors)) return;

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors, fileName);

            if (!File.Exists(filePath))
            {
                File.Create(filePath).Dispose();
            }
        }

        /// <summary>
        /// The OnThreeAuthorsRadioButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
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
        /// The OnTwoAuthorsRadioButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
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
