// BookList
//
// SearchOfBookTitles.cs
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
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    /// Search for book title contained in authors file.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchOfBookTitles : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOfBookTitles"/> class.
        /// </summary>
        public SearchOfBookTitles()
        {
            this.InitializeComponent();
            this.btnSelect.Enabled = true;
            BookListPaths.AuthorsNameCurrent = string.Empty;
        }

        /// <summary>
        /// Finds the titles in string.
        /// </summary>
        private void FindTitlesInString()
        {
            var s2 = this.txtTitle.Text.Trim();

            if (string.IsNullOrEmpty(s2)) return;
            s2 = s2.ToLower();

            var coll = new BookInfoCollection();

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
        /// Called when [close search by authors button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnCloseSearchByAuthorsButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Called when /[search all authors RadioButton clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchAllAuthorsRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = false;
        }

        /// <summary>
        /// Called when [search by author Radio button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSearchByAuthorRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = true;
        }

        /// <summary>
        /// Called when [select author button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSelectAuthorButtonClicked(object sender, EventArgs e)
        {
            using (var win = new AuthorsListing())
            {
                win.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPaths.AuthorsNameCurrent)) return;
            this.txtAuthorName.Text = BookListPaths.AuthorsNameCurrent;
        }

        /// <summary>
        /// Called when [title search button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnTitleSearchButton_Clicked(object sender, EventArgs e)
        {
            if (this.rdbSpecific.Checked) this.SearchBookTitleBySingleAuthor();

            if (this.rdbAll.Checked) this.SearchBookTitleAllAuthors();
        }
        /// <summary>
        /// Search all authors for desired book title.
        /// </summary>
        private void SearchBookTitleAllAuthors()
        {
            var authorDirFiles = new AuthorsDirectoryFilesClass();


            authorDirFiles.GetAllAuthorFilePathsContainedInAuthorDirectory(BookListPaths.PathToAuthorsDirectory);

            SearchForBookTitleAllAuthorsCollection();

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
            var dirFileOp = new DirectoryFileClass();
            var fileInput = new FileInputClass();

            var dirAuthors = BookListPaths.PathToAuthorsDirectory;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPaths.CurrentWorkingFileName);

            var coll = new BookInfoCollection();

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
        /// Search book title in all authors book collection.
        /// </summary>
        private void SearchForBookTitleAllAuthorsCollection()
        {
            var dirFileOp = new DirectoryFileClass();
            var fileInput = new FileInputClass();
            var coll = new BookInfoCollection();
            coll.ClearCollection();
            this.lstTiltes.Items.Clear();

            var collAuthor = new AuthorsFileNamesCollection();

            for (var i = 0; i < collAuthor.ItemsCount(); i++)
            {
                var fileName = collAuthor.GetItemAt(i);
                var dirAuthors = BookListPaths.PathToAuthorsDirectory;
                var filePath = dirFileOp.CombineDirectoryPathWithFileName(dirAuthors,
                    fileName);
                this.txtAuthorName.Text = fileName;

                fileInput.ReadTitlesFromFile(filePath);
                this.FindTitlesInString();
            }

        }
    }
}