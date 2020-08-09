// BookList
//
// BookListMainWindow.cs
//
// Art2M
//
// art2m@live.com
//
// 10  24  2019
//
// 10  24   2019
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

namespace BookList.Source
{
    using BookListCurrent.ClassesProperties;

    /// <summary>
    ///     Select operation type to be performed on the records contained in list
    ///     books. Display all records contained in the list books data.
    /// </summary>
    public partial class BookList : Form
    {
        /// <summary>
        ///     <para>
        ///         Initializes a new instance of the <see cref="BookList" />
        ///     </para>
        ///     <para>class.</para>
        /// </summary>
        public BookList()
        {
            var authorOp = new AuthorsOperations();

            var dirFile = new Paths();

            InitializeComponent();
            dirFile.InitializeDirectoryPath();
            dirFile.InitializeFilePaths();
            authorOp.UpdateAuthorsNamesWithFileNames();
        }

        /// <summary>
        ///     Called when /[add authors button clicked]. Display form for adding
        ///     new author file to the book list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnAddAuthorsButton_Click(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookAuthors())
            {
                win.ShowDialog();
            }
        }

        /// <summary>
        ///     Called when /[add authors menu clicked]. Display form for adding new
        ///     author file to the book list.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnAddAuthorsMenu_Click(object sender, EventArgs e)
        {
            btnAddAuthors.PerformClick();
        }

        /// <summary>
        ///     Called when /[add titles button clicked]. Display form for adding
        ///     new book title to author file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnAddTitlesButton_Click(object sender, EventArgs e)
        {
            using (var win = new BookTitleNames())
            {
                win.ShowDialog();
            }
        }

        /// <summary>
        ///     Called when [add titles menu clicked]. Display form for adding new
        ///     book title to author file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnAddTitlesMenu_Click(object sender, EventArgs e)
        {
            btnAddTitles.PerformClick();
        }

        /// <summary>
        ///     Called when [edit authors button clicked]. Display form for editing
        ///     authors file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnEditAuthorsButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new BookAuthorEditor())
            {
                win.ShowDialog();
            }
        }

        /// <summary>
        ///     Called when [edit authors menu clicked]. Display form for editing
        ///     authors file.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnEditAuthorsMenu_Clicked(object sender, EventArgs e)
        {
            btnEditAuthors.PerformClick();
        }

        /// <summary>
        ///     Called when [edit titles button clicked]. Display form for editing
        ///     the book title.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        /// <exception cref="NotImplementedException" />
        private void OnEditTitlesButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     Called when [edit titles menu clicked]. Display form for editing the
        ///     book title.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnEditTitlesMenu_Clicked(object sender, EventArgs e)
        {
            btnEditTitles.PerformClick();
        }

        /// <summary>
        ///     Called when [exit application menu item clicked]. Exit the Book List
        ///     application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnExitApplicationMenuItem_Clicked(object sender, EventArgs e)
        {
            btnQuit.PerformClick();
        }

        /// <summary>
        ///     Called when [data button clicked]. Display the form for formatting
        ///     unformatted data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnFormatDataButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new FormatBookData())
            {
                win.ShowDialog();
            }
        }

        /// <summary>
        ///     Called when [format records menu item clicked]. Display form for
        ///     formatting any unformatted book data.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnFormatRecordsMenu_Clicked(object sender, EventArgs e)
        {
            btnUnfromatted.PerformClick();
        }

        /// <summary>
        ///     Called when [quit application button clicked]. Exit the book list
        ///     application.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnQuitApplicationButton_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        ///     Called when [search authors button clicked]. Display the form for
        ///     searching authors.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnSearchAuthorsButton_Clicked(object sender, EventArgs e)
        {
            var fileOutput = new Output();

            fileOutput.WriteArthurFileNamesToListFile(BookListPaths.PathAuthorsNamesListFile);

            using (var win = new BookAuthorLocator())
            {
                win.ShowDialog();
            }
        }

        /// <summary>
        ///     Called when [search authors menu clicked]. Display the form for
        ///     searching authors.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnSearchAuthorsMenu_Clicked(object sender, EventArgs e)
        {
            btnSearchAuthors.PerformClick();
        }

        /// <summary>
        ///     Called when [search titles button clicked]. Display the form for
        ///     searching book titles.
        /// </summary>
        /// <param name="sender">The source of the event data.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnSearchTitlesButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new BookTitleLocator())
            {
                win.ShowDialog();
            }
        }

        /// <summary>
        ///     Called when [search titles menu clicked]. Display the form for
        ///     searching book titles.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        ///     The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnSearchTitlesMenu_Clicked(object sender, EventArgs e)
        {
            btnSearchTitles.PerformClick();
        }
    }
}