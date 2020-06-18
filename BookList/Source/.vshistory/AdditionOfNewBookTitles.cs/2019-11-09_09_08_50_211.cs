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

namespace BookList.Source
{
    using System;
    using System.Text;
    using System.Windows.Forms;
    using Classes;
    using PropertiesClasses;

    /// <summary>
    /// Defines the <see cref="AdditionOfNewBookTitles" />
    /// Add New Book Information to Authors File.
    /// Added items book title only if not series.
    /// Added items for series book title, series name, volume number.
    /// </summary>
    public partial class AdditionOfNewBookTitles : Form
    {
        /// <summary>
        /// Defines the isBookSeries.
        /// Checked book is series else unchecked not series.
        /// </summary>
        private bool isBookSeries;

        /// <summary>
        /// Initializes a new instance of the <see cref="AdditionOfNewBookTitles"/> class.
        /// </summary>
        public AdditionOfNewBookTitles()
        {
            this.InitializeComponent();
            this.InitializeControlsState();
        }

        /// <summary>
        /// The Sets initial controls state so user must select
        /// an author before proceeding.
        /// </summary>
        private void InitializeControlsState()
        {
            this.btnAdd.Enabled = false;
            this.btnCancel.Enabled = false;
            this.btnExisting.Enabled = true;
            this.btnNew.Enabled = true;
            this.btnSave.Enabled = false;
            this.txtAuthor.ReadOnly = true;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        /// <summary>
        /// The OnAddExistingAuthorButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/>The source of the event.</param>
        /// <param name="e">The e<see cref="EventArgs"/>Instance containing the event data.</param>
        private void OnAddExistingAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var dlg = new AuthorsListing())
            {
                dlg.ShowDialog();
            }

            this.txtAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent.Trim();
            this.SetAddingNewBookControlsState();
        }

        /// <summary>
        /// The OnAddNewAuthorButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void OnAddNewAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookAuthors())
            {
                win.ShowDialog();
            }

            this.txtAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent;
            this.SetAddingNewBookControlsState();
        }

        /// <summary>
        /// The OnAddNewBookRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            if (this.txtAuthor.Text.Trim().Length == 0) return;

            this.txtTitle.Enabled = true;
            this.txtTitle.Focus();

            if (this.isBookSeries)
            {
                this.txtSeries.Enabled = true;
                this.txtVolume.Enabled = true;
                return;
            }

            this.txtSeries.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        /// <summary>
        /// The OnCancelOperationButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.txtAuthor.Enabled = false;
            this.txtAuthor.Text = string.Empty;
            this.txtSeries.Enabled = false;
            this.txtSeries.Text = string.Empty;
            this.txtTitle.Enabled = false;
            this.txtTitle.Text = string.Empty;
            this.txtVolume.Enabled = false;
            this.txtVolume.Text = string.Empty;
            this.chkSeries.Checked = false;
        }

        /// <summary>
        /// The OnCloseAdditionOfBookTitlesButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="EventArgs"/></param>
        private void OnCloseAdditionOfBookTitlesButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// The OnIsBookSeriesCheckBox_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnIsBookSeriesCheckBox_Clicked(object sender, EventArgs e)
        {
            this.isBookSeries = this.chkSeries.Checked;
        }

        /// <summary>
        /// The OnKeyPressNumericOnlyAllowedTextBox_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="KeyPressEventArgs"/></param>
        private void OnKeyPressNumericOnlyAllowedTextBox_Clicked(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar)) e.Handled = true; //Just Digits
            if (e.KeyChar == (char) 8) e.Handled = false; //Allow Backspace
        }

        /// <summary>
        /// The OnSaveBookRecordButton_Clicked
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
                FileOutputClass.WriteBookTitleSeriesVolumeNamesToAuthorsFile(filePath, this.txtAuthor.Text);
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
        /// The SetAddingNewBookControlsState
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