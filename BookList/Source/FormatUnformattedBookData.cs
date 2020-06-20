// BookList
// 
// FormatUnformattedBookData.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 06  19  2020
// 
// 06  19   2020
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
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Forms;
    using Classes;
    using PropertiesClasses;

    public partial class FormatUnformattedBookData : Form
    {
        /// <summary>
        ///     Back up of the Authors File Names Collection For Restoring Before Changes.
        /// </summary>
        private readonly List<string> _dataCopy = new List<string>();

        public FormatUnformattedBookData()
        {
            this.InitializeComponent();
            this.SetAllControlsToolTips();
            this.SetInitialControlState();
            
        }

        private void BookIsASeriesControlSettings()
        {
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
            this.btnTitle.Enabled = true;
            this.btnUndo.Enabled = true;
            this.btnVolume.Enabled = false;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        private void GetSelectedTitleText()
        {
            FormatBookDataProperties.ContainsBookTitle = this.txtBookInfo.SelectedText.Trim();
        }

        private void GetSelectedSeriesText()
        {
            FormatBookDataProperties.NameOfBookSeries = this.txtBookInfo.SelectedText.Trim();
        }

        private void GetSelectedBookVolumeText()
        {
            FormatBookDataProperties.BookSeriesVolumeNumber = this.txtBookInfo.SelectedText.Trim();
        }

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

            this._dataCopy.RemoveAt(FormatBookDataProperties.BookTitleRecordsCount);
            this._dataCopy.Add(sb.ToString());

            this.txtSeries.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.txtVolume.Text = string.Empty;
            FormatBookDataProperties.NameOfBookSeries = string.Empty;
            FormatBookDataProperties.ContainsBookTitle = string.Empty;
        }

        private void NotSeriesFormatTitleOnly()
        {
            var sb = new StringBuilder();
            sb.Append(FormatBookDataProperties.ContainsBookTitle);

            this.txtBookInfo.Text = FormatBookDataProperties.ContainsBookTitle;
            this._dataCopy.RemoveAt(FormatBookDataProperties.BookTitleRecordsCount);
            this._dataCopy.Add(sb.ToString());

            this.txtTitle.Text = string.Empty;
        }

        private void OnBookTitleButton_Click(object sender, EventArgs e)
        {
            this.GetSelectedTitleText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.ContainsBookTitle))
            {
                this.txtTitle.Text = this.txtTitle.Text = string.Empty;
            }

            this.txtTitle.Enabled = true;
            this.txtTitle.Text = FormatBookDataProperties.ContainsBookTitle;

            //this.btnFormat.Enabled = true;
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
            if (this._dataCopy.Count < 1) return;

            if (!FormatBookDataProperties.BookIsSeries)
            {
                this.NotSeriesFormatTitleOnly();
            }

            this.IsSeriesFormatBookInformation();
            this.btnSave.Enabled = true;
        }

        private void OnSaveChangesButton_Click(object sender, EventArgs e)
        {
            if (this._dataCopy.Count < 1) return;

            if (FileOutputClass.WriteAuthorsTitlesToFile(FormatBookDataProperties.PathToCurrentAuthorsFile,
                this._dataCopy))
            {
                var myMsg = "Failed to complete save. Check over data and try again.";
                MyMessagesClass.ShowErrorMessage(myMsg, "OnSaveChangesButton_Click");
            }

            this._dataCopy.Clear();

            FormatBookDataProperties.BookIsSeries = false;
            this.ControlsStateAfterSuccessfulSave();
        }

        private void OnSeriesButton_Click(object sender, EventArgs e)
        {
            this.GetSelectedSeriesText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.NameOfBookSeries)) return;

            this.txtSeries.Enabled = true;
            this.txtSeries.Text = FormatBookDataProperties.NameOfBookSeries;

            // If the title and series name match then exit operation.
            if (ValidationClass.ValidateTitleSeriesTextDoesNotMatch())
            {
                var myMsg = "The book title name can not be the same as the book series name.";
                MyMessagesClass.ShowErrorMessage(myMsg, "OnSeriesButton_Clicked");
                return;
            }

            this.lblInfo.Text = MyStrings.SelectVolumeNumber;
            this.btnVolume.Enabled = true;
        }

        private void OnVolumeNumberButton_Click(object sender, EventArgs e)
        {
            this.GetSelectedBookVolumeText();

            if (string.IsNullOrEmpty(FormatBookDataProperties.BookSeriesVolumeNumber)) return;

            this.txtVolume.Enabled = true;
            this.txtVolume.Text = FormatBookDataProperties.BookSeriesVolumeNumber;

            if (ValidationClass.ValidateTitleVolumeTextDoesNotMatch())
            {
                var myMsg = "The book title name can not be the same as the book volume.";
                MyMessagesClass.ShowErrorMessage(myMsg, "OnVolumeNumberButton_Click");
                return;
            }

            if (ValidationClass.ValidateSeriesVolumeTextDoesNotMatch())
            {
                var myMsg = "The book series name can not be the same as the book volume.";
                MyMessagesClass.ShowErrorMessage(myMsg, "OnVolumeNumberButton_click");
                return;
            }

            this.btnFormat.Enabled = true;
        }

        private void SetAllControlsToolTips()
        {
            var tTip = new ToolTip();

            tTip.SetToolTip(this.txtBookInfo, FormatBookDataProperties.TipTxtData);

            tTip.SetToolTip(this.btnFormat, FormatBookDataProperties.TipBtnReplace);

            tTip.SetToolTip(this.btnSave, FormatBookDataProperties.TipBtnSave);

            tTip.SetToolTip(this.btnSeries, FormatBookDataProperties.TipBtnSeries);

            tTip.SetToolTip(this.btnTitle, FormatBookDataProperties.TipBtnTitle);

            tTip.SetToolTip(this.btnVolume, FormatBookDataProperties.TipBtnVolume);

            tTip.SetToolTip(this.txtSeries, FormatBookDataProperties.TipTxtSeries);

            tTip.SetToolTip(this.txtTitle, FormatBookDataProperties.TipTxtTitle);

            tTip.SetToolTip(this.txtVolume, FormatBookDataProperties.TipTxtVolume);
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
        }
    }
}