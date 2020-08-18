// BookListMainWin
//
// AdditionOfBookTitles.cs
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using BookList.Classes;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Defines the <see cref="BookTitleAddingWin" />Add New Book Information
    ///     to Authors File. Added items book title only if not series. Added
    ///     items for series book title, series name, volume number.
    /// </summary>
    public partial class BookTitleAddingWin : Form
    {
        /// <summary>
        /// Declaration of message box object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Defines the isBookSeries.
        ///     If checked book is series else not checked not series.
        /// </summary>
        private bool _isBookSeries;

        /// <summary>
        ///     Initializes a new instance of the <see cref="BookTitleAddingWin" /> class.
        /// </summary>
        public BookTitleAddingWin()
        {
            InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;

            InitializeControlsState();
        }

        /// <summary>
        ///     The Sets initial controls state so user must select
        ///     an author before proceeding.
        /// </summary>
        private void InitializeControlsState()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            btnAdd.Enabled = false;
            btnCancel.Enabled = false;
            btnExisting.Enabled = true;
            btnAddNewAuthor.Enabled = true;
            btnSave.Enabled = false;
            txtSeries.Enabled = false;
            txtTitle.Enabled = false;
        }

        /// <summary>
        ///     The OnAddExistingAuthorButton_Clicked
        ///     Displays a form with list of existing authors to chose one from.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnAddExistingAuthorButton_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var dlg = new AuthorsListingWin())
            {
                dlg.ShowDialog();
            }

            lblAuthor.Text = BookListPathsProperties.AuthorsNameCurrent.Trim();
            SetAddingNewBookControlsState();
        }


        /// <summary>
        ///     The OnAddNewBookTitleButton_Clicked
        ///     Enable the text boxes needed to add either single new book
        ///     or a book from a series.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookTitleButton_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(BookListPathsProperties.AuthorsNameCurrent)) return;

            txtTitle.Enabled = true;
            txtTitle.Focus();

            if (_isBookSeries)
            {
                txtSeries.Enabled = true;
                txtVolume.Enabled = true;
                return;
            }

            txtSeries.Enabled = false;
            txtVolume.Enabled = false;
        }

        /// <summary>
        ///     The OnCancelOperationButton_Clicked
        ///     The user canceled clear all entered data and set the series state to not a series.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            txtSeries.Enabled = false;
            txtSeries.Text = string.Empty;
            txtTitle.Enabled = false;
            txtTitle.Text = string.Empty;
            txtVolume.Enabled = false;
            txtVolume.Text = string.Empty;
            chkSeries.Checked = false;
            _isBookSeries = false;
        }

        /// <summary>
        ///     The OnCloseAdditionOfBookTitlesButton_Clicked
        ///     Close the form.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnCloseAdditionOfBookTitlesButton_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     The OnIsBookSeriesCheckBox_Clicked
        ///     If checked then set isBookSeries true else false.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnIsBookSeriesCheckBox_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            _isBookSeries = chkSeries.Checked;
        }

        /// <summary>
        ///     The OnKeyPressNumericOnlyAllowedTextBox_Clicked
        ///     The user must enter a numeric value for the current book in the series.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs" />Instance containing the event data.</param>
        private void OnKeyPressNumericOnlyAllowedTextBox_Clicked(object sender, KeyPressEventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!char.IsDigit(e.KeyChar)) e.Handled = true; //Just Digits
            if (e.KeyChar == (char) 8) e.Handled = false; //Allow Backspace
        }

        /// <summary>
        ///     The OnSaveBookRecordButton_Clicked
        ///     If not series save book title.
        ///     If series save book title, book series name, book volume number.
        /// </summary>
        /// <param name="sender">The source of the event.<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnSaveBookRecordButton_Clicked(object sender, EventArgs e)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var clsOutput = new OutputClass();

            var filePath = BookListPathsProperties.PathOfCurrentWorkingFile;

            if (!chkSeries.Checked)
            {
                clsOutput.WriteAuthorsTitlesToFile(filePath);
                return;
            }

            var seriesOp = new SeriesOperationsClass();

            var bookInfo = seriesOp.FormatBookSeriesData(txtSeries.Text, txtTitle.Text, txtVolume.Text);


            var bookTitle = txtTitle.Text.Trim();
            var retVal = CheckThatAuthorsFileDoesNotContainThisBookTitle(filePath, bookTitle);


            if (retVal)
            {
                _msgBox.Msg = "This book title is all ready contained in the authors file.";
                _msgBox.ShowInformationMessageBox();
                return;
            }

            if (clsOutput.WriteAuthorsTitlesSeriesToFile(filePath, bookInfo))
            {
                _msgBox.Msg = "The book title and series information have been successfully saved. ";
                _msgBox.ShowInformationMessageBox();
            }
        }

        /// <summary>
        /// Checks the that authors file does not contain This book title.
        /// </summary>
        /// <param name="filePath">The path to the authors file.</param>
        /// <param name="bookTitle">Title of book to check if contained in authors file all ready..</param>
        /// <returns></returns>
        private bool CheckThatAuthorsFileDoesNotContainThisBookTitle(string filePath, string bookTitle)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var clsInput = new InputClass();

            var bookData = clsInput.ReadAllBookTitlesFromAuthorsFile(filePath);

            if (!bookData.Any()) return false;

            var titleOp = new TitlesOperationClass();
            var titles = titleOp.GetBookTitleFromBookData(bookData);

            if (!titles.Any()) return false;

            var valid = new ValidationClass();

            // true if book title is all ready contained in authors file else false.
            return valid.ValidateAuthorsFileDoesNotContainThisBookTitle(titles, bookTitle);
        }

        /// <summary>
        ///     The SetAddingNewBookControlsState
        /// </summary>
        private void SetAddingNewBookControlsState()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            btnCancel.Enabled = true;
            btnExisting.Enabled = true;
            btnAddNewAuthor.Enabled = true;
            btnAdd.Enabled = true;
            btnSave.Enabled = true;
        }

        /// <summary>
        /// Called when [add new author button clicked]. 
        /// </summary>
        /// <param name="sender">The source of the event..</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnAddNewAuthorButton_Clicked(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            using (var win = new BookAuthorAddingWin())
            {
                win.ShowDialog();
            }
        }
    }
}