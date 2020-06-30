// BookList
//
// FormatUnformattedBookData.cs
//
// Art2M
//
// art2m@live.com
//
// 06  22  2020
//
// 06  22   2020
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
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    public partial class FormatUnformattedBookData : Form
    {
        public FormatUnformattedBookData()
        {
            this.InitializeComponent();
            this.SetAllControlsToolTips();
            this.SetInitialControlState();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }

            //  TODO: try to select series info programatically put in correct text box.
            // TODO: try to select title info programatically if not a series put in text box.
            // TODO: add button user can select if book info not right.
            // TODO: add text to lblInfo on how user can make selection manually.
            // TODO: Allow user to edit title, series and volume text boxes to fix missing or invalid data.
        }

        private void BookIsASeriesControlSettings()
        {
            this.btnFormat.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnSeries.Enabled = false;
            this.btnTitle.Enabled = true;
            this.btnUndo.Enabled = false;
            this.btnVolume.Enabled = false;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = true;
            this.txtVolume.Enabled = false;
        }

        private void BookIsNotASeriesControlSettings()
        {
            this.btnFormat.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnSeries.Enabled = false;
            this.btnTitle.Enabled = true;
            this.btnUndo.Enabled = false;
            this.btnVolume.Enabled = false;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = true;
            this.txtVolume.Enabled = false;
        }

        private void ControlsStateAfterSuccessfulSave()
        {
            this.btnFormat.Enabled = false;
            this.btnSave.Enabled = false;
            this.btnSeries.Enabled = false;
            this.btnTitle.Enabled = false;
            this.btnUndo.Enabled = true;
            this.btnVolume.Enabled = false;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        /// <summary>
        /// Gets the selected book volume text that user has  highlighted in the txtBookInfo text box.
        /// Then place it in the txtVolume text box.
        /// </summary>
        private void GetSelectedBookVolumeText()
        {
            FormatBookDataProperties.BookSeriesVolumeNumber = this.txtBookInfo.SelectedText.Trim();
        }

        /// <summary>
        /// Gets the selected series text that the user has highlighted in the textbookInfo text box.
        /// Then place it in the txtSeries text box.
        /// </summary>
        private void GetSelectedSeriesText()
        {
            FormatBookDataProperties.NameOfBookSeries = this.txtBookInfo.SelectedText.Trim();
        }

        /// <summary>
        /// Gets the selected title text that the user has highlighted in the textBookInfo text box.
        /// Then place it in the txtTitle text box..
        /// </summary>
        private void GetSelectedTitleText()
        {
            FormatBookDataProperties.ContainsBookTitle = this.txtBookInfo.SelectedText.Trim();
        }

        /// <summary>
        /// Are the series format book information. Format the series name of the book by
        /// surrounding it with parentheses.
        /// </summary>
        private void IsSeriesFormatBookInformation()
        {
            var sb = new StringBuilder();

            sb.Append(FormatBookDataProperties.ContainsBookTitle);
            sb.Append(" ");
            sb.Append("(");
            sb.Append(FormatBookDataProperties.NameOfBookSeries);
            sb.Append(")");
            sb.Append(" ");
            sb.Append(FormatBookDataProperties.BookSeriesVolumeNumber);

            this.txtBookInfo.Text = sb.ToString();

            UnformattedDataCollection.RemoveItemAt(FormatBookDataProperties.BookTitleRecordsCount);
            UnformattedDataCollection.AddItem(sb.ToString());

            FormatBookDataProperties.NameOfBookSeries = string.Empty;
            FormatBookDataProperties.ContainsBookTitle = string.Empty;
        }

        /// <summary>
        ///  Try to find the name of book series then place it into the series text box.
        /// </summary>
        private void LocateSeriesName()
        {
            // TODO: Check  collection  for book with same part of name  to try to find books in series.
            // TODO: Once located then put that portion into the series box.
            //BookListPropertiesClass.AuthorsNameCurrent;
            var bookInfo = this.txtBookInfo.Text.Trim();
        }

        /// <summary>
        /// Try to find the book title then place it into the title text box.
        /// </summary>
        private void LocateTitleName()
        {
        }

        /// <summary>
        /// Try to find the book volume number then place it into the volume number text box.
        /// </summary>
        private void LocateVolumeNumber()
        {
        }

        private void NotSeriesFormatTitleOnly()
        {
            var sb = new StringBuilder();
            sb.Append(FormatBookDataProperties.ContainsBookTitle);
            sb.Append("*");

            this.txtBookInfo.Text = FormatBookDataProperties.ContainsBookTitle;
            UnformattedDataCollection.RemoveItemAt(FormatBookDataProperties.BookTitleRecordsCount);
            UnformattedDataCollection.AddItem(sb.ToString());
            UnformattedDataCollection.SortCollection();

            this.txtTitle.Text = string.Empty;
        }

        /// <summary>
        /// On auto format book information button
        /// Attempt to automatically format the selected Book title, series and volume number.
        /// If unable to then user must manually format the book title, series, and volume number.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        public void OnAutoFormatBookInformationButton_Click(object sender, EventArgs e)
        {
            var autoFormat = new AutoFormatClass();

            var bookInfo = this.txtBookInfo.Text.Trim();

            var bookData =
                autoFormat.LocateSeriesPartOfBookInformation(FormatBookDataProperties.PathToCurrentAuthorsFile,
                    bookInfo);

            if (bookData == null) return;
            if (bookData.Count == 0) return;
        }

        /// <summary>
        /// Ons the book title button_ click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnBookTitleButton_Click(object sender, EventArgs e)
        {
            var len = this.txtTitle.SelectionLength;
            if (len <= 0) return;

            this.GetSelectedTitleText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.ContainsBookTitle))
            {
                this.txtTitle.Text = this.txtTitle.Text = string.Empty;
            }

            this.txtTitle.Enabled = true;
            this.txtTitle.Text = FormatBookDataProperties.ContainsBookTitle;

            if (!FormatBookDataProperties.BookIsSeries) this.btnFormat.Enabled = true;

            this.btnSeries.Enabled = true;

            if (FormatBookDataProperties.BookIsSeries)
            {
                this.lblInfo.Text = MyStrings.SelectSeries;
            }
        }

        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            FormatBookDataProperties.UnformattedBookInformation = string.Empty;
            this.Close();
        }

        private void OnFormatBookInformationButton_Click(object sender, EventArgs e)
        {
            if (UnformattedDataCollection.GetItemsCount() < 1) return;

            if (string.IsNullOrEmpty(this.txtTitle.Text.Trim())) return;

            if (!FormatBookDataProperties.BookIsSeries)
            {
                this.NotSeriesFormatTitleOnly();
                this.btnSave.Enabled = true;
                return;
            }

            this.IsSeriesFormatBookInformation();
            this.btnSave.Enabled = true;
        }

        private void OnSaveChangesButton_Click(object sender, EventArgs e)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (UnformattedDataCollection.GetItemsCount() < 1) return;
            if (string.IsNullOrEmpty(this.txtTitle.Text.Trim())) return;

            if (FormatBookDataProperties.BookIsSeries)
            {
                if (!ValidationClass.ValidateBookSeriesIsFormatted(this.txtBookInfo.Text)) return;
                if (!FileOutputClass.WriteBookTitleSeriesVolumeNamesToAuthorsFile(FormatBookDataProperties
                    .PathToCurrentAuthorsFile))
                {
                    MyMessagesClass.ErrorMessage = "Failed to complete save. Check over data and try again.";
                    MyMessagesClass.ShowErrorMessageBox();
                    return;
                }
            }

            if (!ValidationClass.ValidateBookNotSeriesIsFormatted(this.txtBookInfo.Text)) return;

            if (!FileOutputClass.WriteAuthorsTitlesToFile(FormatBookDataProperties.PathToCurrentAuthorsFile))
            {
                MyMessagesClass.ErrorMessage = "Failed to complete save. Check over data and try again.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            this.ControlsStateAfterSuccessfulSave();
        }

        private void OnSeriesButton_Click(object sender, EventArgs e)
        {
            var len = this.txtSeries.SelectionLength;
            if (len <= 0) return;

            this.GetSelectedSeriesText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.NameOfBookSeries)) return;

            this.txtSeries.Enabled = true;
            this.txtSeries.Text = FormatBookDataProperties.NameOfBookSeries;

            // If the title and series name match then exit operation.
            if (ValidationClass.ValidateTitleSeriesTextDoesNotMatch())
            {
                MyMessagesClass.ErrorMessage = "The book title name can not be the same as the book series name.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            this.lblInfo.Text = MyStrings.SelectVolumeNumber;
            this.btnVolume.Enabled = true;
        }

        private void OnUndoChangesButton_Click(object sender, EventArgs e)
        {
            // TODO Need to add code for undoing Changes.
        }

        private void OnVolumeNumberButton_Click(object sender, EventArgs e)
        {
            var len = this.txtVolume.SelectionLength;
            if (len <= 0) return;

            this.GetSelectedBookVolumeText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.BookSeriesVolumeNumber)) return;

            this.txtVolume.Enabled = true;
            this.txtVolume.Text = FormatBookDataProperties.BookSeriesVolumeNumber;

            if (ValidationClass.ValidateTitleVolumeTextDoesNotMatch())
            {
                MyMessagesClass.ErrorMessage = "The book title name can not be the same as the book volume.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            if (ValidationClass.ValidateSeriesVolumeTextDoesNotMatch())
            {
                MyMessagesClass.ErrorMessage = "The book series name can not be the same as the book volume.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            this.btnFormat.Enabled = true;
        }

        private void SetAllControlsToolTips()
        {
            using (var tTip = new ToolTip())

            {
                tTip.SetToolTip(this.txtBookInfo, FormatBookDataProperties.TipTxtData);

                tTip.SetToolTip(this.btnFormat, FormatBookDataProperties.TipBtnReplace);

                tTip.SetToolTip(this.btnSave, FormatBookDataProperties.TipBtnSave);

                tTip.SetToolTip(this.btnSeries, FormatBookDataProperties.TipBtnSeries);

                tTip.SetToolTip(this.btnTitle, FormatBookDataProperties.TipBtnTitle);

                tTip.SetToolTip(this.btnVolume, FormatBookDataProperties.TipBtnVolume);

                tTip.SetToolTip(this.txtSeries, FormatBookDataProperties.TipTxtSeries);

                tTip.SetToolTip(this.txtTitle, FormatBookDataProperties.TipTxtTitle);

                tTip.SetToolTip(this.txtVolume, FormatBookDataProperties.TipTxtVolume);

                tTip.SetToolTip(this.btnAutoFormat, FormatBookDataProperties.TipAutoFormat);
            }
        }

        private void SetInitialControlState()
        {
            this.lblInfo.Text = MyStrings.selectTitle;
            if (FormatBookDataProperties.BookIsSeries)
            {
                this.BookIsASeriesControlSettings();
            }
            else
            {
                this.BookIsNotASeriesControlSettings();
            }

            this.txtBookInfo.Text = FormatBookDataProperties.UnformattedBookInformation;
            this.btnSave.DialogResult = DialogResult.OK;
        }
    }
}