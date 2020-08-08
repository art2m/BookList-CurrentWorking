// BookList
//
// AdditionOfBookTitles.cs
//
// Art2M
//
// art2m@live.com
//
// 11  05  2019
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

using System.Text;
using BookList.Classes;

namespace BookList.Source
{
    using System;
    using System.Windows.Forms;
    using PropertiesClasses;

    /// <summary>
    ///     Defines the <see cref="AdditionOfBookTitles" />
    /// </summary>
    public partial class AdditionOfBookTitles : Form
    {
        private bool isBookSeries;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdditionOfBookTitles" /> class.
        /// </summary>
        public AdditionOfBookTitles()
        {
            this.InitializeComponent();
            this.InitializeControlsState();
        }

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

        private void OnAddExistingAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var dlg = new AuthorsListing())
            {
                dlg.ShowDialog();
            }

            this.txtAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent.Trim();
            this.SetAddingNewBookControlsState();
        }

        private void OnAddNewAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookAuthors())
            {
                win.ShowDialog();
            }

            this.txtAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent;
            this.SetAddingNewBookControlsState();
        }

        private void SetAddingNewBookControlsState()
        {
            this.btnCancel.Enabled = true;
            this.btnExisting.Enabled = true;
            this.btnNew.Enabled = true;
            this.btnAdd.Enabled = true;
            this.btnSave.Enabled = true;
        }

        /// <summary>
        ///
        ///     The OnAddNewBookRecordButton_Clicked
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
        ///     The OnCancelOperationButton_Clicked
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
        }

        /// <summary>
        ///     The OnIsBookSeriesCheckBox_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnIsBookSeriesCheckBox_Clicked(object sender, EventArgs e)
        {
            this.isBookSeries = this.chkSeries.Checked;
        }

        /// <summary>
        ///     The OnSaveBookRecordButton_Clicked
        /// If not series save book title.
        /// If series save book title, book series name, book volume number.
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnSaveBookRecordButton_Clicked(object sender, EventArgs e)
        {
            // TODO: Need to format book info data with and with out series volume info.
            // TODO: Check that volume only allows numbers and then add "book volume" to number.
            var filePath = BookListPropertiesClass.PathOfCurrentWorkingFile;

            if (!this.chkSeries.Checked)
            {
                FileOutputClass.WriteBookTitleSeriesVolumeNamesToAuthorsFile(filePath, this.txtAuthor.Text);
                return;
            }

            var sb = new StringBuilder(this.txtTitle.Text.Trim());
            sb.Append("(");
            sb.Append(this.txtSeries.Text.Trim());
            sb.Append(")");
            sb.Append(this.txtVolume.Text.Trim());
            var bookInfo = sb.ToString();
            FileOutputClass.WriteBookTitleSeriesVolumeNamesToAuthorsFile(filePath, bookInfo);
        }

        private void OnCloseAdditionOfBookTitlesButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}