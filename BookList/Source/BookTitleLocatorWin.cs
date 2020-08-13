// BookListMainWin
//
// BookTitleLocatorWin.cs
//
// Art2M
//
// art2m@live.com
//
// 05  26  2020
//
// 05  26   2020
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

using System;
using System.Windows.Forms;

using BookList.Classes;
using BookList.Collections;

namespace BookList.Source
{
    using PropertiesClasses;

    /// <summary>
    /// Used to check if This book title has been read.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BookTitleLocatorWin : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BookTitleLocatorWin"/> class.
        /// </summary>
        public BookTitleLocatorWin()
        {
            this.InitializeComponent();
            this.btnSelect.Enabled = true;
            BookListPathsProperties.AuthorsNameCurrent = string.Empty;
        }

        /// <summary>
        /// Called when [close search by authors button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseSearchByAuthorsButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Finds the titles in string.
        /// </summary>
        private void FindTitlesInString()
        {
            var s2 = this.txtTitle.Text.Trim();

            if (string.IsNullOrEmpty(s2)) return;
            s2 = s2.ToLower();

            var coll = new BookInformation();

            for (var i = 0; i < coll.ItemsCount(); i++)
            {
                var s1 = coll.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(s2))
                {
                    this.lstTiltes.Items.Add(s1);
                }
            }
        }

        /// <summary>
        /// Called when [title search button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTitleSearchButton_Click(object sender, EventArgs e)
        {
            if (this.rdbSpecific.Checked) this.SearchBookTitleBySingleAuthor();

            if (this.rdbAll.Checked) this.SearchBookTitleAllAuthors();
        }

        /// <summary>
        /// Called when [search all authors RadioButton clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchAllAuthorsRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = false;
        }

        /// <summary>
        /// Searches the book title all authors.
        /// </summary>
        private void SearchBookTitleAllAuthors()
        {
            var authorOp = new AuthorOperationsClass();
            var clsFile = new FileClass();
            var fileInput = new InputClass();

            clsFile.GetAllAuthorFilePathsContainedInAuthorDirectory();

            var coll = new BookInformation();
            coll.ClearCollection();
            this.lstTiltes.Items.Clear();

            var collAuthor = new AuthorsFileNames();

            for (var i = 0; i < collAuthor.ItemsCount(); i++)
            {
                var fileName = collAuthor.GetItemAt(i);
                var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

                var cls = new CombinePathsClass();
                var filePath = cls.CombineDirectoryPathWithFileName(dirAuthors,
                    fileName);
                this.txtAuthorName.Text = fileName;

                fileInput.ReadTitlesFromFile(filePath);
                this.FindTitlesInString();
            }

            if (this.lstTiltes.Items.Count < 1)
            {
                this.lstTiltes.Items.Add("No titles with this search criteria were found.");
            }
        }

        /// <summary>
        /// Searches the book title by single author.
        /// </summary>
        private void SearchBookTitleBySingleAuthor()
        {
            var dirFileOp = new FileClass();
            var fileInput = new InputClass();

            var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

            var cls = new CombinePathsClass();
            var filePath = cls.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPathsProperties.CurrentWorkingFileName);

            var coll = new BookInformation();

            coll.ClearCollection();
            this.lstTiltes.Items.Clear();

            fileInput.ReadTitlesFromFile(filePath);

            this.FindTitlesInString();

            if (this.lstTiltes.Items.Count < 1)
            {
                this.lstTiltes.Items.Add("No titles with this search criteria were found.");
            }
        }

        /// <summary>
        /// Called when [author search radio button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnAuthorSearchRadioButton_Click(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = true;
        }

        /// <summary>
        /// Called when [select author button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSelectAuthorButton_Click(object sender, EventArgs e)
        {
            using (var win = new AuthorsListingWin())
            {
                win.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPathsProperties.AuthorsNameCurrent)) return;
            this.txtAuthorName.Text = BookListPathsProperties.AuthorsNameCurrent;
        }
    }
}