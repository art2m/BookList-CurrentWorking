﻿// BookList
// 
// FormatBookData.cs
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
    using System.Diagnostics;
    using System.Text;
    using System.Windows.Forms;
    using Classes;
    using PropertiesClasses;

    public partial class FormatBookData : Form
    {
        /// <summary>
        ///     Back up of the Authors File Names Collection For Restoring Before Changes.
        /// </summary>
        private readonly List<string> _dataCopy = new List<string>();

        public FormatBookData()
        {
            this.InitializeComponent();

            this.mnuAuthors.PerformClick();
            this.SetAllControlsToolTips();
        }


        private void DisplayRecordCountAndPosition()
        {
            var sb = new StringBuilder(FormatBookDataProperties.TipLblPosition);
            sb.Append(FormatBookDataProperties.CurrentPositionInTitlesRecords.ToString());
            sb.Append(" of ");
            sb.Append(FormatBookDataProperties.RecordsTotalCount.ToString());

            this.lblPosition.Text = sb.ToString();
        }

        private void GetAuthorsName(string fileName)
        {
            var author = AuthorsTextOperations.SplitFileNameFormFileExtension(fileName);

            this.lblInfo.Text = string.Concat(FormatBookDataProperties.TipLblInfo, author);
        }


        private void GetUnformattedDataFrom()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            FormatBookDataProperties.PathToCurrentAuthorsFile =
                DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath,
                    BookListPropertiesClass.AuthorsNameCurrent);

            this.GetAuthorsName(BookListPropertiesClass.AuthorsNameCurrent);
        }


        private void LoadUnformattedData()
        {
            this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(FormatBookDataProperties.PathToCurrentAuthorsFile)) return;

            FileInputClass.ReadTitlesFromFile(FormatBookDataProperties.PathToCurrentAuthorsFile);

            DataStorageOperationsClass.AddToBackUpList(this._dataCopy);

            FormatBookDataProperties.RecordsTotalCount = this._dataCopy.Count;
        }

        private void MoveToFirstRecord()
        {
            if (this._dataCopy.Count <= 0) return;

            FormatBookDataProperties.BookTitleRecordsCount = 0;
            this.txtData.Text = this._dataCopy[FormatBookDataProperties.BookTitleRecordsCount];

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnBookIsNotSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            FormatBookDataProperties.BookIsSeries = false;
        }

        private void OnBookIsSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            FormatBookDataProperties.BookIsSeries = true;
        }

        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnCloseMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnClose.PerformClick();
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

        private void OnFormatBookInformationButton_Click(object sender, EventArgs e)
        {
            var temp = this.txtData.Text.Trim();

            if (string.IsNullOrEmpty(temp)) return;

            FormatBookDataProperties.UnformattedBookInformation = temp;

            using (var dlg = new FormatUnformattedBookData())
            {
                dlg.ShowDialog();
            }
        }

        private void OnMoveFirstButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count <= 0) return;

            FormatBookDataProperties.BookTitleRecordsCount = 0;
            this.txtData.Text = this._dataCopy[FormatBookDataProperties.BookTitleRecordsCount];

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count == 0) return;

            if (FormatBookDataProperties.BookTitleRecordsCount + 1 > this._dataCopy.Count) return;

            FormatBookDataProperties.BookTitleRecordsCount = this._dataCopy.Count - 1;

            this.txtData.Text = this._dataCopy[FormatBookDataProperties.BookTitleRecordsCount];

            FormatBookDataProperties.CurrentPositionInTitlesRecords = this._dataCopy.Count;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count == 0) return;

            // pos zero based.
            if (FormatBookDataProperties.BookTitleRecordsCount + 1 >= this._dataCopy.Count) return;

            FormatBookDataProperties.BookTitleRecordsCount++;

            this.txtData.Text = this._dataCopy[FormatBookDataProperties.BookTitleRecordsCount];

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            if (this._dataCopy.Count == 0) return;

            if (FormatBookDataProperties.BookTitleRecordsCount == 0) return;

            FormatBookDataProperties.BookTitleRecordsCount--;

            this.txtData.Text = this._dataCopy[FormatBookDataProperties.BookTitleRecordsCount];

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            this.DisplayRecordCountAndPosition();
        }


        private void SetAllControlsToolTips()
        {
            //this.tipTool.SetToolTip(this.txtData, FormatBookDataProperties.TipTxtData);
            this.tipTool.SetToolTip(this.btnFirst, FormatBookDataProperties.TipBtnFirst);
            this.tipTool.SetToolTip(this.btnNext, FormatBookDataProperties.TipBtnNext);
            this.tipTool.SetToolTip(this.btnPrevious, FormatBookDataProperties.TipBtnPrevious);
            this.tipTool.SetToolTip(this.btnLast, FormatBookDataProperties.TipBtnLast);
        }
    }
}