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
        ///     Initializes a new instance of the <see cref="BookTitleLocatorWin" /> class.
        /// </summary>
        public BookTitleLocatorWin()
        {
            this.InitializeComponent();
            this.btnSelect.Enabled = true;
            BookListPathsProperties.AuthorsNameCurrent = string.Empty;

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;

            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        }

        /// <summary>
        ///     Called when [close search by authors button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     Called when [search enter key press text box clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void OnSearchEnterKeyPressTextBox_Clicked(object sender, KeyEventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (e.KeyValue == (char) Keys.Enter)
            {
                this.btnSearch.PerformClick();
            }
        }

        /// <summary>
        ///     Called when [select all authors button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnSelectAllAuthorsButton_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            BookDataProperties.SetAllAuthorsSearch = true;
            BookDataProperties.SetSingleAuthorSearch = false;

            var searchStr = this.txtTitle.Text.Trim();

            if (!this._valid.ValidateStringIsNotNull(searchStr)) return;
            if (!this._valid.ValidateStringHasLength(searchStr)) return;

            searchStr = searchStr.ToLower();

            BookDataProperties.SetBookTitleSearchString = searchStr;

            var cls1 = new AuthorOperationsClass();

            cls1.FillListWithAuthorsNames();

            cls1.AllAuthorsLoop();
        }

        /// <summary>
        ///     Called when [select author button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnSelectSingleAuthorButton_Click(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var win = new AuthorsListingWin())
            {
                win.ShowDialog();
            }

            if (!this._valid.ValidateStringHasLength(BookListPathsProperties.AuthorsNameCurrent)) return;

            this.lblAuthor.Text = BookListPathsProperties.AuthorsNameCurrent;

            BookDataProperties.SetSingleAuthorSearch = true;
            BookDataProperties.SetAllAuthorsSearch = false;

            this.txtTitle.Select();
        }

        /// <summary>
        ///     Called when [show all titles for author button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnShowAllTitlesSingleAuthorButton_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

            var cls1 = new CombinePathsClass();
            var filePath =
                cls1.CombineDirectoryPathWithFileName(dirAuthors, BookListPathsProperties.CurrentWorkingFileName);

            var cls2 = new BookDataCollection();
            cls2.ClearCollection();

            var cls3 = new InputClass();
            cls3.ReadTitlesFromFileLoop(filePath);

            var cls4 = new AuthorOperationsClass();
            cls4.ShowAllBookTitlesBySingleAuthorLoop();

            this.lstTiltes.Items.Clear();
        }

        /// <summary>
        ///     Called when [title search button click].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnTitleSearchSingleAuthorButton_Click(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var searchStr = this.txtTitle.Text.Trim();

            if (!this._valid.ValidateStringIsNotNull(searchStr)) return;
            if (!this._valid.ValidateStringHasLength(searchStr)) return;

            BookDataProperties.SetBookTitleSearchString = searchStr;

            var cls1 = new AuthorOperationsClass();
            if (BookDataProperties.SetSingleAuthorSearch)
            {
                cls1.SearchBookTitleBySingleAuthor();
            }
            else if (BookDataProperties.SetAllAuthorsSearch)

            {
                cls1.SearchBookAuthorAllTitles();
            }
        }
    }
}