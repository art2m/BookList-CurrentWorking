// BookList
// 
// FormatBookData.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 06  18  2020
// 
// 06  18   2020
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
    using PropertiesClasses;

    public partial class FormatBookData : Form
    {
        private const string Caption = "Select Title name then select series name then volume number.";
        private const string Caption1 = "Move to first book record.";
        private const string Caption10 = "Book series name is displayed here after selecting.";
        private const string Caption11 = "The book title name is displayed here after selecting.";
        private const string Caption12 = "the book volume is displayed here after selecting.";
        private const string Caption2 = "Move to next book record.";
        private const string Caption3 = "Move to previous book record.";
        private const string Caption4 = "Move to last book record.";
        private const string Caption5 = "Format the book title, series and book title.";
        private const string Caption6 = "Select to save all formatted book data";
        private const string Caption7 = "Get the user selected series name.";
        private const string Caption8 = "Get the user selected title name.";
        private const string Caption9 = "Get the user selected volume number.";
        private const string Str0 = "Authors Name  ";
        private const string V = "The book title and/or book series must not be the same as book volume. ";
        private const string V1 = "The title of the book and the book series must not be the same. ";
        private const string Value = "Record position ";

        /// <summary>
        ///     Back up of the Authors File Names Collection For Restoring Before Changes.
        /// </summary>
        private readonly List<string> _dataCopy = new List<string>();

        private string _filePath = string.Empty;
        private int _index;

        private bool _match;
        private int _pos;
        private string _series = string.Empty;
        private string _title = string.Empty;
        private int _totalCount;
        private string _volume = string.Empty;

        public FormatBookData()
        {
            this.InitializeComponent();

            this.mnuAuthors.PerformClick();
            this.SetAllControlsToolTips();
            this.btnReplace.Enabled = false;
            this.btnSave.Enabled = false;
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
            var sb = new StringBuilder(Value);
            sb.Append(this._pos.ToString());
            sb.Append(" of ");
            sb.Append(this._totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
        }

        private void GetAuthorsName(string fileName)
        {
            var author = AuthorsTextOperations.SplitFileNameFormFileExtension(fileName);

            this.lblInfo.Text = string.Concat(Str0, author);
        }

        private void GetSelectedBookVolumeText()
        {
            this._volume = this.txtData.SelectedText.Trim();
        }

        private void GetSelectedSeriesText()
        {
            this._series = this.txtData.SelectedText.Trim();
        }

        private void GetSelectedTitleText()
        {
            this._title = this.txtData.SelectedText.Trim();
        }

        private void GetUnformattedDataFrom()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            this._filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath,
                BookListPropertiesClass.AuthorsNameCurrent);

            this.GetAuthorsName(BookListPropertiesClass.AuthorsNameCurrent);
        }

        private void IsSeriesFormatBookInformation()
        {
            var sb = new StringBuilder();

            sb.Append(this._title);
            sb.Append(" ");
            sb.Append("(");
            sb.Append(this._series);
            sb.Append(")");
            sb.Append(" ");
            sb.Append(this._volume);

            this.txtData.Text = sb.ToString();

            this._dataCopy.RemoveAt(this._index);
            this._dataCopy.Add(sb.ToString());

            this.btnLast.PerformClick();

            this.txtSeries.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.txtVolume.Text = string.Empty;
            this._series = string.Empty;
            this._title = string.Empty;
        }

        private void LoadUnformattedData()
        {
            this.BookIsNotASeriesControlSettings();

            this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(this._filePath)) return;

            FileInputClass.ReadTitlesFromFile(this._filePath);

            DataStorageOperationsClass.AddToBackUpList(this._dataCopy);

            this._totalCount = this._dataCopy.Count;
        }

        private void MoveToFirstRecord()
        {
            if (this._dataCopy.Count <= 0) return;

            this._index = 0;
            this.txtData.Text = this._dataCopy[this._index];

            this._pos = this._index + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void NotSeriesFormatTitleOnly()
        {
            var sb = new StringBuilder();
            sb.Append(this._title);

            this.txtData.Text = this._title;
            this._dataCopy.RemoveAt(this._index);
            this._dataCopy.Add(sb.ToString());

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

            this.MoveToFirstRecord();

            // this.btnFirst.PerformClick();
        }

        private void OnFormatBookInformationButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count < 1) return;

            if (this.rbtnNotSeries.Checked && !this.rbtnIsSeries.Checked)
            {
                this.NotSeriesFormatTitleOnly();
            }

            this.IsSeriesFormatBookInformation();
            this.btnSave.Enabled = true;
        }

        private void OnMoveFirstButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count <= 0) return;

            this._index = 0;
            this.txtData.Text = this._dataCopy[this._index];

            this._pos = this._index + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count == 0) return;

            if (this._index + 1 > this._dataCopy.Count) return;

            this._index = this._dataCopy.Count - 1;

            this.txtData.Text = this._dataCopy[this._index];

            this._pos = this._dataCopy.Count;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count == 0) return;

            // pos zero based.
            if (this._index + 1 >= this._dataCopy.Count) return;

            this._index++;

            this.txtData.Text = this._dataCopy[this._index];

            this._pos = this._index + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count == 0) return;

            if (this._index == 0) return;

            this._index--;

            this.txtData.Text = this._dataCopy[this._index];

            this._pos = this._index + 1;

            this.DisplayRecordCountAndPosition();
        }


        private void OnSaveAllChangesMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnSave.PerformClick();
        }

        private void OnSaveChangesButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count < 1) return;

            if (!this._match) return;

            FileOutputClass.WriteAuthorsTitlesToFile(this._filePath, this._dataCopy);

            this._dataCopy.Clear();

            this._match = false;
        }

        private void OnSelectedTextBookVolumeButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedBookVolumeText();

            if (string.IsNullOrEmpty(this._volume)) return;

            this.txtVolume.Enabled = true;
            this.txtVolume.Text = this._volume;

            this.ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText();
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedSeriesText();

            if (string.IsNullOrEmpty(this._series)) return;

            this.txtSeries.Enabled = true;
            this.txtSeries.Text = this._series;

            this.ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText();
        }

        private void OnSelectedTextTitleButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedTitleText();

            if (string.IsNullOrEmpty(this._title))
            {
                this.txtTitle.Text = this.txtTitle.Text = string.Empty;
            }

            this.txtTitle.Enabled = true;
            this.txtTitle.Text = this._title;

            this.ValidateTitleTextDoesNotMatchSeriesTextAndOrVolumeText();

            this.btnReplace.Enabled = true;
        }

        private void SetAllControlsToolTips()
        {
            this.tipTool.SetToolTip(this.txtData, Caption);
            this.tipTool.SetToolTip(this.btnFirst, Caption1);
            this.tipTool.SetToolTip(this.btnNext, Caption2);
            this.tipTool.SetToolTip(this.btnPrevious, Caption3);
            this.tipTool.SetToolTip(this.btnLast, Caption4);
            this.tipTool.SetToolTip(this.btnReplace, Caption5);
            this.tipTool.SetToolTip(this.btnSave, Caption6);
            this.tipTool.SetToolTip(this.btnSeries, Caption7);
            this.tipTool.SetToolTip(this.btnTitle, Caption8);
            this.tipTool.SetToolTip(this.btnVolume, Caption9);
            this.tipTool.SetToolTip(this.txtSeries, Caption10);
            this.tipTool.SetToolTip(this.txtTitle, Caption11);
            this.tipTool.SetToolTip(this.txtVolume, Caption12);
        }

        private void ValidateSeriesVolumeTextDoesNotMatch()
        {
            var msg = string.Empty;

            if (this._match) return;

            try
            {
                if (string.IsNullOrEmpty(this._series) || string.IsNullOrEmpty(this._volume)) return;

                if (!this._volume.Equals(this._series))
                {
                    this._match = true;
                    return;
                }

                this._match = false;

                msg = V;
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

            if (this._match) return;

            try
            {
                if (string.IsNullOrEmpty(this._title) || string.IsNullOrEmpty(this._series)) return;

                if (!this._title.Equals(this._series))
                {
                    this._match = true;
                    return;
                }

                this._match = false;

                msg = V1;
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
            if (this._match) return;

            try
            {
                if (string.IsNullOrEmpty(this._title) || string.IsNullOrEmpty(this._volume)) return;

                if (!this._volume.Equals(this._title))
                {
                    this._match = true;
                    return;
                }

                this._match = false;

                msg = V1;
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