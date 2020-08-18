// BookList
//
// BookTitleLocatorWin.cs
//
// Arthur Melanson
//
// art2m
//
// 08    12   2020
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
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Used to check if This book title has been read.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BookTitleLocatorWin : Form
    {
        /// <summary>
        ///     Declaration of MyMessageBoxClass object;
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declaration of ValidationClass object.
        /// </summary>
        private readonly ValidationClass _valid = new ValidationClass();

        /// <summary>
        /// All authors when true is used to show what type of searc to perform.
        /// </summary>
        private bool _setAllAuthorsSearch;

        /// <summary>
        /// The single author when true is used to show what type of search
        /// to perform.
        /// </summary>
        private bool _setSingleAuthorSearch;

        /// <summary>
        ///     Initializes a new instance of the <see cref="BookTitleLocatorWin" /> class.
        /// </summary>
        public BookTitleLocatorWin()
        {
            InitializeComponent();
            btnSelect.Enabled = true;
            BookListPathsProperties.AuthorsNameCurrent = string.Empty;

            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        }

        /// <summary>
        /// true if Searching all authors and all titles else false.
        /// </summary>
        private bool SearchAllAuthors { get; set; } = false;

        /// <summary>
        /// Gets or sets a value indicating whether [set all authors search].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set all authors search]; otherwise, <c>false</c>.
        /// </value>
        private bool SetAllAuthorsSearch
        {
            get => _setAllAuthorsSearch;
            set => _setAllAuthorsSearch = value;
        }

        /// <summary>
        /// Gets or sets a value indicating whether [set single author search].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [set single author search]; otherwise, <c>false</c>.
        /// </value>
        private bool SetSingleAuthorSearch
        {
            get => _setSingleAuthorSearch;
            set => _setSingleAuthorSearch = value;
        }

        /// <summary>
        /// Loop threw all authors.
        /// </summary>
        private void AllAuthorsLoop()
        {
            var coll = new AuthorNamesCollection();

            var totalCount = coll.GetItemsCount();

            if (totalCount == 0) return;

            Debug.AutoFlush = true;
            Debug.Indent();
            Debug.WriteLine("All Authors loop - Authors Count  " + coll.GetItemsCount().ToString());
            Debug.Unindent();

            for (int index = 0; index < totalCount; index++)
            {
                if (!_valid.ValidateStringIsNotNull(coll.GetItemAt(index))) continue;

                var author = coll.GetItemAt(index).Trim();

                if (!_valid.ValidateStringIsNotNull(author)) continue;

                BookListPathsProperties.CurrentWorkingFileName = coll.GetItemAt(index);

                SearchBookTitleBySingleAuthor();
            }
        }

        /// <summary>
        ///     Authors the names search loop.
        /// </summary>
        private void AuthorNamesSearchLoop()
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var fileInput = new InputClass();

            var clsInput = new InputClass();

            var collAuthor = new AuthorsFileNamesCollection();

            var totalCount = collAuthor.GetItemsCount();

            for (var i = 0; i < totalCount; i++)
            {
                var fileName = collAuthor.GetItemAt(i);

                var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

                var cls = new CombinePathsClass();

                var filePath = cls.CombineDirectoryPathWithFileName(dirAuthors, fileName);

                lblAuthor.Text = fileName;

                fileInput.ReadTitlesFromFileLoop(filePath);

                FindTitlesInString();
            }
        }

        /// <summary>
        ///     Books the titles search loop.
        /// </summary>
        private void BookTitlesSearchLoop(string search)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new BookDataCollection();

            for (var i = 0; i < coll.GetItemsCount(); i++)
            {
                var s1 = coll.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(search))
                {
                    lstTiltes.Items.Add(s1);
                }
            }
        }
        /// <summary>
        /// Search all authors titles.
        /// </summary>
        /// <param name="search">The book title to search for.</param>
        private void BookTitlesSearchLoopAllAuthors(string search)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new BookDataCollection();
            var cnt = coll.GetItemsCount();

            Debug.AutoFlush = true;
            Debug.Indent();
            Debug.WriteLine("BookTitlesSearchLoopAllAuthors  " + coll.GetItemsCount().ToString());
            Debug.Unindent();

            for (var i = 0; i < coll.GetItemsCount(); i++)
            {
                var s1 = coll.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(search))
                {
                    lstTiltes.Items.Add(s1);
                }
            }


        }

        /// <summary>Fills the Author names list collection with authors names.</summary>
        private void FillListWithAuthorsNames()
        {
            var coll = new AuthorNamesCollection();
            var clsInput = new InputClass();

            coll.ClearCollection();

            clsInput.ReadAuthorsNamesFromFile(BookListPathsProperties.PathAuthorsNamesListFile);

            coll.SortCollection();
        }

        /// <summary>
        ///     Finds the titles in string.
        /// </summary>
        private void FindTitlesInString()
        {
            var search = txtTitle.Text.Trim();

            if (string.IsNullOrEmpty(search)) return;
            search = search.ToLower();

            lstTiltes.Items.Clear();

            if (SearchAllAuthors)
            {
                BookTitlesSearchLoopAllAuthors(search);
            }
            else
            {
                BookTitlesSearchLoop(search);
            }
        }


        /// <summary>
        ///     Called when [close search by authors button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Called when [search enter key press text box clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void OnSearchEnterKeyPressTextBox_Clicked(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char) Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }

        /// <summary>
        /// Called when [select all authors button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSelectAllAuthorsButton_Clicked(object sender, EventArgs e)
        {
            SetAllAuthorsSearch = true;
            SetSingleAuthorSearch = false;

            SearchAllAuthors = true;
            

            FillListWithAuthorsNames();

            AllAuthorsLoop();
        }
        /// <summary>
        ///     Called when [select author button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnSelectSingleAuthorButton_Click(object sender, EventArgs e)
        {
            using (var win = new AuthorsListingWin())
            {
                win.ShowDialog();
            }

            if (!_valid.ValidateStringHasLength(BookListPathsProperties.AuthorsNameCurrent)) return;

            lblAuthor.Text = BookListPathsProperties.AuthorsNameCurrent;

            SearchAllAuthors = false;

            SetSingleAuthorSearch = true;
            SetAllAuthorsSearch = false;

            txtTitle.Select();
        }

        /// <summary>
        ///     Called when [show all titles for author button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnShowAllTitlesSingleAuthorButton_Clicked(object sender, EventArgs e)
        {
            lstTiltes.Items.Clear();

            var fileInput = new InputClass();

            var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

            var cls = new CombinePathsClass();
            var filePath = cls.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPathsProperties.CurrentWorkingFileName);

            var coll = new BookDataCollection();

            coll.ClearCollection();
            lstTiltes.Items.Clear();

            fileInput.ReadTitlesFromFileLoop(filePath);

            ShowAllBookTitlesBySingleAuthorLoop();
        }

        /// <summary>
        ///     Called when [title search button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnTitleSearchSingleAuthorButton_Click(object sender, EventArgs e)
        {
            if (SetSingleAuthorSearch) SearchBookTitleBySingleAuthor();

            else if (SetAllAuthorsSearch) SearchBookAuthorAllTitles();
        }

        /// <summary>
        ///     Searches the book title all authors.
        /// </summary>
        private void SearchBookAuthorAllTitles()
        {
            var clsFile = new FileClass();

            clsFile.GetAllAuthorFilePathsContainedInAuthorDirectory();

            var coll = new BookDataCollection();
            coll.ClearCollection();
            lstTiltes.Items.Clear();

            // FindTitlesInString();

            AuthorNamesSearchLoop();


            if (lstTiltes.Items.Count < 1)
            {
                lstTiltes.Items.Add("No titles with this search criteria were found.");
            }
        }

        /// <summary>
        ///     Searches the book title by single author.
        /// </summary>
        private void SearchBookTitleBySingleAuthor()
        {
            var fileInput = new InputClass();

            var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

            var cls = new CombinePathsClass();


            var filePath = cls.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPathsProperties.CurrentWorkingFileName);

            var coll = new BookDataCollection();

            coll.ClearCollection();
            lstTiltes.Items.Clear();

            fileInput.ReadTitlesFromFileLoop(filePath);

            FindTitlesInString();

            if (lstTiltes.Items.Count < 1)
            {
                lstTiltes.Items.Add("No titles with this search criteria were found.");
                SearchAllAuthors = false;
            }
        }
        /// <summary>
        ///     Shows all book titles by single author loop.
        /// </summary>
        private void ShowAllBookTitlesBySingleAuthorLoop()
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new BookDataCollection();

            var totalCount = coll.GetItemsCount();

            for (var i = 0; i < coll.GetItemsCount(); i++)
            {
                var s1 = coll.GetItemAt(i);

                if (!_valid.ValidateStringIsNotNull(s1)) return;

                s1 = s1.Trim();
                if (!_valid.ValidateStringHasLength(s1)) return;

                lstTiltes.Items.Add(s1);
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}