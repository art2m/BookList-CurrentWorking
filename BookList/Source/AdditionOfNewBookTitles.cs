// BookList
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
using System.Text;
using System.Windows.Forms;
using BookList.Classes;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Defines the <see cref="AdditionOfNewBookTitles" />
    ///     Add New Book Information to Authors File.
    ///     Added items book title only if not series.
    ///     Added items for series book title, series name, volume number.
    /// </summary>
    public partial class AdditionOfNewBookTitles : Form
    {
        /// <summary>
        ///     Defines the isBookSeries.
        ///     Checked book is series else unchecked not series.
        /// </summary>
        private bool _isBookSeries;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdditionOfNewBookTitles" /> class.
        /// </summary>
        public AdditionOfNewBookTitles()
        {
            this.InitializeComponent();
            this.InitializeControlsState();
        }

        /// <summary>
        ///     The Sets initial controls state so user must select
        ///     an author before proceeding.
        /// </summary>
        private void InitializeControlsState()
        {
            this.btnAdd.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnExisting.Enabled = true;
            this.btnNew.Enabled = true;
            this.btnSave.Enabled = false;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        /// <summary>
        ///     The OnAddExistingAuthorButton_Clicked
        ///     Displays a form with list of existing authors to chose one from.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnAddExistingAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var dlg = new AuthorsListing())
            {
                dlg.ShowDialog();
            }

            this.lblAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent.Trim();
            this.SetAddingNewBookControlsState();
        }

        /// <summary>
        ///     The OnAddNewAuthorButton_Clicked
        ///     Displays form where new authors can be added and new author file created.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnAddNewAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookAuthors())
            {
                win.ShowDialog();
            }

            this.lblAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent;
            this.SetAddingNewBookControlsState();
        }

        /// <summary>
        ///     The OnAddNewBookRecordButton_Clicked
        ///     Enable the text boxes needed to add either single new book
        ///     or a book from a series.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;

            this.txtTitle.Enabled = true;
            this.txtTitle.Focus();

            if (this._isBookSeries)
            {
                this.txtSeries.Enabled = true;
                this.txtVolume.Enabled = true;
                return;
            }

            this.txtSeries.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        /// <summary>
        ///     The OnCancelOperationButton_Clicked
        ///     The user canceled clear all entered data and set the series state to not a series.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.txtSeries.Enabled = false;
            this.txtSeries.Text = string.Empty;
            this.txtTitle.Enabled = false;
            this.txtTitle.Text = string.Empty;
            this.txtVolume.Enabled = false;
            this.txtVolume.Text = string.Empty;
            this.chkSeries.Checked = false;
            this._isBookSeries = false;
        }

        /// <summary>
        ///     The OnCloseAdditionOfBookTitlesButton_Clicked
        ///     Close the form.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs" />Instance containing the event data.</param>
        private void OnCloseAdditionOfBookTitlesButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        ///     The OnIsBookSeriesCheckBox_Clicked
        ///     If checked then set isBookSeries true else false.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnIsBookSeriesCheckBox_Clicked(object sender, EventArgs e)
        {
            this._isBookSeries = this.chkSeries.Checked;
        }

        /// <summary>
        ///     The OnKeyPressNumericOnlyAllowedTextBox_Clicked
        ///     The user must enter a numeric value for the current book in the series.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="KeyPressEventArgs" />Instance containing the event data.</param>
        private void OnKeyPressNumericOnlyAllowedTextBox_Clicked(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true; //Just Digits
            if (e.KeyChar == (char) 8) e.Handled = false; //Allow Backspace
        }

        /// <summary>
        ///     The OnSaveBookRecordButton_Clicked
        ///     If not series save book title.
        ///     If series save book title, book series name, book volume number.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnSaveBookRecordButton_Clicked(object sender, EventArgs e)
        {
            var filePath = BookListPropertiesClass.PathOfCurrentWorkingFile;

            if (!this.chkSeries.Checked)
            {
                FileOutputClass.WriteBookTitleSeriesVolumeNamesToAuthorsFile(filePath,
                    BookListPropertiesClass.AuthorsNameCurrent);
                return;
            }

            var volume = "Book Series Number " + this.txtVolume.Text.Trim();
            var sb = new StringBuilder(this.txtTitle.Text.Trim());
            sb.Append("(");
            sb.Append(this.txtSeries.Text.Trim());
            sb.Append(")");
            sb.Append(volume);
            var bookInfo = sb.ToString();
            FileOutputClass.WriteBookTitleSeriesVolumeNamesToAuthorsFile(filePath, bookInfo);
        }

        /// <summary>
        ///     The SetAddingNewBookControlsState
        /// </summary>
        private void SetAddingNewBookControlsState()
        {
            this.btnCancel.Enabled = true;
            this.btnExisting.Enabled = true;
            this.btnNew.Enabled = true;
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = true;
        }
    }
}