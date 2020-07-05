// BookList
// 
// FormatUnformattedBookData.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 07    03   2020
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
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    /// <see cref="DataFormats.Format"/> selected book information.
    /// </summary>
    public partial class FormatUnformattedBookData : Form
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="FormatUnformattedBookData" /> class.
        /// </summary>
        public FormatUnformattedBookData()
        {
            InitializeComponent();
            SetAllControlsToolTips();
            SetInitialControlState();

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

        /// <summary>
        /// If book is a series Set the control settings.
        /// </summary>
        private void BookIsASeriesControlSettings()
        {
            btnFormat.Enabled = false;
            btnSave.Enabled = false;
            btnSeries.Enabled = false;
            btnTitle.Enabled = true;
            btnUndo.Enabled = false;
            btnVolume.Enabled = false;
            txtSeries.Enabled = false;
            txtTitle.Enabled = true;
            txtVolume.Enabled = false;
        }

        /// <summary>
        /// Book is not a series set control settings.
        /// </summary>
        private void BookIsNotASeriesControlSettings()
        {
            btnFormat.Enabled = false;
            btnSave.Enabled = false;
            btnSeries.Enabled = false;
            btnTitle.Enabled = true;
            btnUndo.Enabled = false;
            btnVolume.Enabled = false;
            txtSeries.Enabled = false;
            txtTitle.Enabled = true;
            txtVolume.Enabled = false;
        }

        /// <summary>
        /// Set the controls state after successful save.
        /// </summary>
        private void ControlsStateAfterSuccessfulSave()
        {
            btnFormat.Enabled = false;
            btnSave.Enabled = false;
            btnSeries.Enabled = false;
            btnTitle.Enabled = false;
            btnUndo.Enabled = true;
            btnVolume.Enabled = false;
            txtSeries.Enabled = false;
            txtTitle.Enabled = false;
            txtVolume.Enabled = false;
        }

        /// <summary>
        /// Gets the selected book volume text that user has highlighted in the
        /// text box info. Then place it in the text box Volume.
        /// </summary>
        private void GetSelectedBookVolumeText()
        {
            FormatBookDataProperties.BookSeriesVolumeNumber = txtBookInfo.SelectedText.Trim();
        }

        /// <summary>
        ///     Gets the selected series text that the user has highlighted in the textbookInfo text box.
        ///     Then place it in the series text box.
        /// </summary>
        private void GetSelectedSeriesText()
        {
            FormatBookDataProperties.NameOfBookSeries = txtBookInfo.SelectedText.Trim();
        }

        /// <summary>
        ///     Gets the selected title text that the user has highlighted in the book Info text box.
        ///     Then place it in the title text box.
        /// </summary>
        private void GetSelectedTitleText()
        {
            FormatBookDataProperties.ContainsBookTitle = txtBookInfo.SelectedText.Trim();
        }

        /// <summary>
        /// Are the series format book information.
        /// <see cref="DataFormats.Format"/> the series name of the book by
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

            txtBookInfo.Text = sb.ToString();

            UnformattedDataCollection.RemoveItemAt(FormatBookDataProperties.BookTitleRecordsCount);
            UnformattedDataCollection.AddItem(sb.ToString());

            FormatBookDataProperties.NameOfBookSeries = string.Empty;
            FormatBookDataProperties.ContainsBookTitle = string.Empty;
        }

        /// <summary>
        ///     Try to find the name of book series then place it into the series text box.
        /// </summary>
        private void LocateSeriesName()
        {
            // TODO: Check  collection  for book with same part of name  to try to find books in series.
            // TODO: Once located then put that portion into the series box.
            var bookInfo = txtBookInfo.Text.Trim();
        }

        /// <summary>
        ///     Try to find the book title then place it into the title text box.
        /// </summary>
        private void LocateTitleName()
        {
        }

        /// <summary>
        ///     Try to find the book volume number then place it into the volume number text box.
        /// </summary>
        private void LocateVolumeNumber()
        {
        }

        /// <summary>
        /// Book not series format title and replace original title with new
        /// title.
        /// </summary>
        private void NotSeriesFormatTitleOnly()
        {
            var sb = new StringBuilder();
            sb.Append(FormatBookDataProperties.ContainsBookTitle);
            sb.Append("*");

            txtBookInfo.Text = FormatBookDataProperties.ContainsBookTitle;
            UnformattedDataCollection.RemoveItemAt(FormatBookDataProperties.BookTitleRecordsCount);
            UnformattedDataCollection.AddItem(sb.ToString());
            UnformattedDataCollection.SortCollection();

            txtTitle.Text = string.Empty;
        }

        /// <summary>
        ///     On auto format book information button
        ///     Attempt to automatically format the selected Book title, series and volume number.
        ///     If unable to then user must manually format the book title, series, and volume number.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnAutoFormatBookInformationButton_Click(object sender, EventArgs e)
        {
            var autoFormat = new AutoFormatClass();

            var bookInfo = txtBookInfo.Text.Trim();

            var bookData =
                autoFormat.LocateSeriesPartOfBookInformation(FormatBookDataProperties.PathToCurrentAuthorsFile,
                    bookInfo);

            if (bookData == null) return;
            if (bookData.Count == 0) return;
        }

        /// <summary>
        ///     Ons the book title button_ click.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Instance containing the event data.</param>
        private void OnBookTitleButton_Click(object sender, EventArgs e)
        {
            var len = txtTitle.SelectionLength;
            if (len <= 0) return;

            GetSelectedTitleText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.ContainsBookTitle))
            {
                txtTitle.Text = txtTitle.Text = string.Empty;
            }

            txtTitle.Enabled = true;
            txtTitle.Text = FormatBookDataProperties.ContainsBookTitle;

            if (!FormatBookDataProperties.BookIsSeries) btnFormat.Enabled = true;

            btnSeries.Enabled = true;

            if (FormatBookDataProperties.BookIsSeries)
            {
                lblInfo.Text = MyStrings.SelectSeries;
            }
        }

        /// <summary>
        /// Called when [close button clicked]. Close the
        /// <see cref="DataFormats.Format"/> Unformatted Book Data windows form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            FormatBookDataProperties.UnformattedBookInformation = string.Empty;
            Close();
        }

        /// <summary>
        /// Called when [format book information button click].
        /// <see cref="DataFormats.Format"/> the book information for series or
        /// nto series.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnFormatBookInformationButton_Click(object sender, EventArgs e)
        {
            if (UnformattedDataCollection.GetItemsCount() < 1) return;

            if (string.IsNullOrEmpty(txtTitle.Text.Trim())) return;

            if (!FormatBookDataProperties.BookIsSeries)
            {
                NotSeriesFormatTitleOnly();
                btnSave.Enabled = true;
                return;
            }

            IsSeriesFormatBookInformation();
            btnSave.Enabled = true;
        }

        /// <summary>
        /// Called when [save changes button click]. Save the changes made on
        /// the book information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnSaveChangesButton_Click(object sender, EventArgs e)
        {
            var fileOutput = new FileOutputClass();

            var validate = new ValidationClass();

            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (UnformattedDataCollection.GetItemsCount() < 1) return;
            if (string.IsNullOrEmpty(txtTitle.Text.Trim())) return;

            if (FormatBookDataProperties.BookIsSeries)
            {
                if (!validate.ValidateBookSeriesIsFormatted(txtBookInfo.Text)) return;
                if (!fileOutput.WriteBookTitleSeriesVolumeNamesToAuthorsFile(FormatBookDataProperties
                    .PathToCurrentAuthorsFile))
                {
                    MyMessagesClass.ErrorMessage = "Failed to complete save. Check over data and try again.";
                    MyMessagesClass.ShowErrorMessageBox();
                    return;
                }
            }

            if (!validate.ValidateBookNotSeriesIsFormatted(txtBookInfo.Text)) return;

            if (!fileOutput.WriteAuthorsTitlesToFile(FormatBookDataProperties.PathToCurrentAuthorsFile))
            {
                MyMessagesClass.ErrorMessage = "Failed to complete save. Check over data and try again.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            ControlsStateAfterSuccessfulSave();
        }

        /// <summary>
        /// Called when [series button click]. Set the is series property to
        /// <see langword="true"/> for series or <see langword="false"/> for not
        /// a series.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnSeriesButton_Click(object sender, EventArgs e)
        {
            var validate = new ValidationClass();

            var len = txtSeries.SelectionLength;
            if (len <= 0) return;

            GetSelectedSeriesText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.NameOfBookSeries)) return;

            txtSeries.Enabled = true;
            txtSeries.Text = FormatBookDataProperties.NameOfBookSeries;

            // If the title and series name match then exit operation.
            if (validate.ValidateTitleSeriesTextDoesNotMatch())
            {
                MyMessagesClass.ErrorMessage = "The book title name can not be the same as the book series name.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            lblInfo.Text = MyStrings.SelectVolumeNumber;
            btnVolume.Enabled = true;
        }

        /// <summary>
        /// Called when [undo changes button click]. Roll back changes made to
        /// book information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">
        /// The <see cref="EventArgs" /> instance containing the event data.
        /// </param>
        private void OnUndoChangesButton_Click(object sender, EventArgs e)
        {
            // TODO Need to add code for undoing Changes.
        }

        /// <summary>Called when [volume number button click].
        /// Check that volume test does not match title or series text. Place volume name and or number into text box.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnVolumeNumberButton_Click(object sender, EventArgs e)
        {
            var validate = new ValidationClass();

            var len = txtVolume.SelectionLength;
            if (len <= 0) return;

            GetSelectedBookVolumeText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.BookSeriesVolumeNumber)) return;

            txtVolume.Enabled = true;
            txtVolume.Text = FormatBookDataProperties.BookSeriesVolumeNumber;

            if (validate.ValidateTitleVolumeTextDoesNotMatch())
            {
                MyMessagesClass.ErrorMessage = "The book title name can not be the same as the book volume.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            if (validate.ValidateSeriesVolumeTextDoesNotMatch())
            {
                MyMessagesClass.ErrorMessage = "The book series name can not be the same as the book volume.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            btnFormat.Enabled = true;
        }

        /// <summary>
        /// Sets all controls tool tips.
        /// </summary>
        private void SetAllControlsToolTips()
        {
            using (var tTip = new ToolTip())

            {
                tTip.SetToolTip(txtBookInfo, FormatBookDataProperties.TipTxtData);

                tTip.SetToolTip(btnFormat, FormatBookDataProperties.TipBtnReplace);

                tTip.SetToolTip(btnSave, FormatBookDataProperties.TipBtnSave);

                tTip.SetToolTip(btnSeries, FormatBookDataProperties.TipBtnSeries);

                tTip.SetToolTip(btnTitle, FormatBookDataProperties.TipBtnTitle);

                tTip.SetToolTip(btnVolume, FormatBookDataProperties.TipBtnVolume);

                tTip.SetToolTip(txtSeries, FormatBookDataProperties.TipTxtSeries);

                tTip.SetToolTip(txtTitle, FormatBookDataProperties.TipTxtTitle);

                tTip.SetToolTip(txtVolume, FormatBookDataProperties.TipTxtVolume);

                tTip.SetToolTip(btnAutoFormat, FormatBookDataProperties.TipAutoFormat);
            }
        }

        /// <summary>
        /// Sets the initial state of the control.
        /// </summary>
        private void SetInitialControlState()
        {
            lblInfo.Text = MyStrings.selectTitle;
            if (FormatBookDataProperties.BookIsSeries)
            {
                BookIsASeriesControlSettings();
            }
            else
            {
                BookIsNotASeriesControlSettings();
            }

            txtBookInfo.Text = FormatBookDataProperties.UnformattedBookInformation;
            btnSave.DialogResult = DialogResult.OK;
        }
    }
}