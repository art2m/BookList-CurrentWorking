﻿// BookList
//
// UnformattedData.cs
//
// Art2M
//
// art2m@live.com
//
// 11  01  2019
//
// 10  31   2019
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
    using System.Diagnostics;
    using System.Text;
    using System.Windows.Forms;
    using Classes;
    using Collections;
    using PropertiesClasses;

    public partial class FormatBookData : Form
    {
        /// <summary>
        ///     Back up of the Authors File Names Collection For Restoring Before Changes.
        /// </summary>
        private readonly List<string> dataCopy = new List<string>();

        private string filePath = string.Empty;
        private int index;
        private int pos;
        private string series = string.Empty;
        private string title = string.Empty;
        private int totalCount;
        private string volume = string.Empty;

        public FormatBookData()
        {
            this.InitializeComponent();
        }

        private void BookIsASeriesControlSettings()
        {
            this.btnSeries.Enabled = true;
            this.btnTitle.Enabled = true;
            this.btnVolume.Enabled = true;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        private void BookIsNotASeriesControlSettings()
        {
            this.btnSeries.Enabled = false;
            this.btnTitle.Enabled = true;
            this.btnVolume.Enabled = false;
            this.txtSeries.Enabled = false;
            this.txtTitle.Enabled = false;
            this.txtVolume.Enabled = false;
        }

        private void DisplayRecordCountAndPosition()
        {
            var sb = new StringBuilder("Record position ");
            sb.Append(this.pos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
        }

        private void GetAuthorsName(string fileName)
        {
            var author = AuthorsTextOperations.SplitFileNameFormFileExtension(fileName);

            this.lblInfo.Text = string.Concat("Authors Name  ", author);
        }

        private void GetSelectedBookVolumeText()
        {
            this.volume = this.txtData.SelectedText.Trim();
        }

        private void GetSelectedSeriesText()
        {
            this.series = this.txtData.SelectedText.Trim();
        }

        private void GetSelectedTitleText()
        {
            this.title = this.txtData.SelectedText.Trim();
        }

        private void GetUnformattedDataFrom()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            if (!AuthorsFileNamesCollection.ContainsItem(BookListPropertiesClass.AuthorsNameCurrent)) return;

            var num = AuthorsFileNamesCollection.GetItemIndex(BookListPropertiesClass.AuthorsNameCurrent);

            var fileName = AuthorsFileNamesCollection.GetItemAt(num);

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            this.filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            this.GetAuthorsName(fileName);
        }

        private void IsSeriesFormatBookInformation()
        {
            var sb = new StringBuilder();

            sb.Append(this.title);
            sb.Append("-");
            sb.Append(this.series);
            sb.Append("_");
            sb.Append(this.volume);

            this.txtData.Text = sb.ToString();

            this.dataCopy.RemoveAt(this.index);
            this.dataCopy.Add(sb.ToString());

            this.btnLast.PerformClick();

            this.txtSeries.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.txtVolume.Text = string.Empty;
            this.series = string.Empty;
            this.title = string.Empty;
        }

        private void LoadUnformattedData()
        {
            this.BookIsNotASeriesControlSettings();

            this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(this.filePath)) return;

            FileInputClass.ReadTitlesFromFile(this.filePath);

            DataStorageOperationsClass.AddToBackUpList(this.dataCopy);

            this.totalCount = this.dataCopy.Count;
        }

        private void NotSeriesFormatTitleOnly()
        {
            var sb = new StringBuilder();
            sb.Append(this.title);

            this.txtData.Text = this.title;
            this.dataCopy.RemoveAt(this.index);
            this.dataCopy.Add(sb.ToString());

            this.btnLast.PerformClick();

            this.txtTitle.Text = string.Empty;
        }

        private void OnBookIsNotSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            this.BookIsNotASeriesControlSettings();
        }

        private void OnBookIsSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            this.BookIsASeriesControlSettings();
        }

        private void OnCloseMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnClose.PerformClick();
        }

        private void OnCloseRawDataInputButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnDisplayAllAuthorsMenuItem_Clicked(object sender, EventArgs e)
        {
            using (var dlg = new AuthorsListing())
            {
                dlg.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;

            this.LoadUnformattedData();

            this.btnFirst.PerformClick();
        }

        private void OnFormatBookInformationButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count < 1) return;

            if (this.rbtnNotSeries.Checked && !this.rbtnIsSeries.Checked)
            {
                this.NotSeriesFormatTitleOnly();
            }

            this.IsSeriesFormatBookInformation();
            this.btnSave.Enabled = true;
        }

        private void OnFormLoad_Event(object sender, EventArgs e)
        {
            this.mnuAuthors.PerformClick();

            this.SetAllControlsToolTips();

            this.btnReplace.Enabled = false;
            this.btnSave.Enabled = false;
        }

        private void OnMoveFirstButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count == 0) return;

            this.index = 0;
            this.txtData.Text = this.dataCopy[this.index];

            this.pos = this.index + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count == 0) return;

            if (this.index + 1 > this.dataCopy.Count) return;

            this.index = this.dataCopy.Count - 1;

            this.txtData.Text = this.dataCopy[this.index];

            this.pos = this.dataCopy.Count;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count == 0) return;

            // pos zero based.
            if (this.index + 1 >= this.dataCopy.Count) return;

            this.index++;

            this.txtData.Text = this.dataCopy[this.index];

            this.pos = this.index + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count == 0) return;

            if (this.index == 0) return;

            this.index--;

            this.txtData.Text = this.dataCopy[this.index];

            this.pos = this.index + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnSaveAllChangesButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count < 1) return;

            FileOutputClass.WriteAuthorsTitlesToFile(this.filePath, this.dataCopy);

            this.dataCopy.Clear();
        }

        private void OnSaveAllChangesMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnSave.PerformClick();
        }

        private void OnSelectedTextTitleButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedTitleText();

            if (string.IsNullOrEmpty(this.title)) return;

            this.txtTitle.Enabled = true;
            this.txtTitle.Text = this.title;

            this.ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText();

            this.btnReplace.Enabled = true;
        }

        private void OnSelectedTextBookVolumeButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedBookVolumeText();

            if (string.IsNullOrEmpty(this.volume)) return;

            this.txtVolume.Enabled = true;
            this.txtVolume.Text = this.volume;

            this.ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText();
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedSeriesText();

            if (string.IsNullOrEmpty(this.series)) return;

            this.txtSeries.Enabled = true;
            this.txtSeries.Text = this.series;

            this.ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText();
        }

        private void SetAllControlsToolTips()
        {
            this.tipTool.SetToolTip(this.txtData, "Select Title name then select series name then volume number.");
            this.tipTool.SetToolTip(this.btnFirst, "Move to first book record.");
            this.tipTool.SetToolTip(this.btnNext, "Move to next book record.");
            this.tipTool.SetToolTip(this.btnPrevious, "Move to previous book record.");
            this.tipTool.SetToolTip(this.btnLast, "Move to last book record.");
            this.tipTool.SetToolTip(this.btnReplace, "Format the book title, series and book title.");
            this.tipTool.SetToolTip(this.btnSave, "Select to save all formatted book data");
            this.tipTool.SetToolTip(this.btnSeries, "Get the user selected series name.");
            this.tipTool.SetToolTip(this.btnTitle, "Get the user selected title name.");
            this.tipTool.SetToolTip(this.btnVolume, "Get the user selected volume number.");
            this.tipTool.SetToolTip(this.txtSeries, "Book series name is displayed here after selecting.");
            this.tipTool.SetToolTip(this.txtTitle, "The book title name is displayed here after selecting.");
            this.tipTool.SetToolTip(this.txtVolume, "the book volume is displayed here after selecting.");
        }

        private void ValidateSeriesVolumeTextDoesNotMatch()
        {
            var msg = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(this.series) || string.IsNullOrEmpty(this.volume)) return;

                if (!this.volume.Equals(this.series)) return;

                msg = "The book title and/or book series must not be the same as book volume. ";
                throw new NotSupportedException();
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = msg + ex;
                MyMessagesClass.ShowErrorMessageBox();
            }
        }

        private void ValidateTitleSeriesTextDoesNotMatch()
        {
            var msg = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(this.title) || string.IsNullOrEmpty(this.series)) return;

                if (!this.title.Equals(this.series)) return;

                msg = "The title of the book and the book series must not be the same. ";
                throw new NotSupportedException();
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = msg + ex;
                MyMessagesClass.ShowErrorMessageBox();
            }
        }

        private void ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText()
        {
            if (!this.rbtnIsSeries.Checked) return;

            this.ValidateTitleSeriesTextDoesNotMatch();
            this.ValidateSeriesVolumeTextDoesNotMatch();
            this.ValidateTitleVolumeTextDoesNotMatch();
        }

        private void ValidateTitleVolumeTextDoesNotMatch()
        {
            var msg = string.Empty;

            try
            {
                if (string.IsNullOrEmpty(this.title) || string.IsNullOrEmpty(this.volume)) return;

                if (!this.volume.Equals(this.title)) return;

                msg = "The title of the book and the book series must not be the same. ";
                throw new NotSupportedException();
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = msg + ex;
                MyMessagesClass.ShowErrorMessageBox();
            }
        }
    }
}