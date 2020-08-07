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
using BookListCurrent.ClassesProperties;

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
            SetInitialControlState();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                var msgBox = new MyMessageBox();

                msgBox.NameOfClass = declaringType.Name;
            }
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

            var coll = new UnformattedDataCollection();

            coll.RemoveItemAt(FormatBookDataProperties.BookTitleRecordsCount);
            coll.AddItem(sb.ToString());

            FormatBookDataProperties.NameOfBookSeries = string.Empty;
            FormatBookDataProperties.ContainsBookTitle = string.Empty;
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

            var coll = new UnformattedDataCollection();

            coll.RemoveItemAt(FormatBookDataProperties.BookTitleRecordsCount);
            coll.AddItem(sb.ToString());
            coll.SortCollection();

            txtTitle.Text = string.Empty;
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
            var coll = new UnformattedDataCollection();

            if (coll.GetItemsCount() < 1) return;

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

            var msgBox = new MyMessageBox();


            msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new UnformattedDataCollection();

            if (coll.GetItemsCount() < 1) return;
            if (string.IsNullOrEmpty(txtTitle.Text.Trim())) return;

            if (FormatBookDataProperties.BookIsSeries)
            {
                if (!validate.ValidateBookSeriesIsFormatted(txtBookInfo.Text)) return;
                if (!fileOutput.WriteBookTitleSeriesVolumeNamesToAuthorsFile(FormatBookDataProperties
                    .PathToCurrentAuthorsFile))
                {
                    msgBox.Msg = "Failed to complete save. Check over data and try again.";

                    msgBox.ShowErrorMessageBox();

                    return;
                }
            }

            if (!validate.ValidateBookNotSeriesIsFormatted(txtBookInfo.Text)) return;

            if (!fileOutput.WriteAuthorsTitlesToFile(FormatBookDataProperties.PathToCurrentAuthorsFile))
            {
                msgBox.Msg = "Failed to complete save. Check over data and try again.";
                msgBox.ShowErrorMessageBox();
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
                var msgBox = new MyMessageBox();

                msgBox.Msg = "The book title name can not be the same as the book series name.";
                msgBox.ShowErrorMessageBox();
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
            throw new NotImplementedException();
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
                var msgBox = new MyMessageBox();

                msgBox.Msg = "The book title name can not be the same as the book volume.";
                msgBox.ShowErrorMessageBox();
                return;
            }

            if (validate.ValidateSeriesVolumeTextDoesNotMatch())
            {
                var msgBox = new MyMessageBox();
                msgBox.Msg = "The book series name can not be the same as the book volume.";
                msgBox.ShowErrorMessageBox();
                return;
            }

            btnFormat.Enabled = true;
        }


        /// <summary>
        /// Sets the initial state of the control.
        /// </summary>
        private void SetInitialControlState()
        {
            lblInfo.Text = MyStrings.selectTitle;
            btnFormat.Enabled = false;
            btnSave.Enabled = false;
            btnSeries.Enabled = false;
            btnTitle.Enabled = true;
            btnUndo.Enabled = false;
            btnVolume.Enabled = false;
            txtSeries.Enabled = false;
            txtTitle.Enabled = true;
            txtVolume.Enabled = false;

            txtBookInfo.Text = FormatBookDataProperties.UnformattedBookInformation;
            btnSave.DialogResult = DialogResult.OK;
        }
    }
}