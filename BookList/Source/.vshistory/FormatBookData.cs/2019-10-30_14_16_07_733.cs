// BookList
//
// UnformattedData.cs
//
// Art2M
//
// art2m@live.com
//
// 10  29  2019
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

namespace BookList.Source
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Windows.Forms;
    using Classes;
    using Collections;
    using PropertiesClasses;

    public partial class UnformattedData : Form
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

        public UnformattedData()
        {
            this.InitializeComponent();
            this.mnuAuthors.PerformClick();
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

        private void GetSelectedSeriesText()
        {
            this.series = this.txtData.SelectedText;
            this.series = this.series.Trim();
        }

        private void GetSelectedTitleText()
        {
            this.title = this.txtData.SelectedText;

            this.title = this.title.Trim();
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

        private void LoadUnformattedData()
        {
            this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(this.filePath)) return;

            FileInputClass.ReadTitlesFromFile(this.filePath);

            DataStorageOperationsClass.AddToBackUpList(this.dataCopy);

            this.totalCount = this.dataCopy.Count;
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

            if ((this.index + 1) > this.dataCopy.Count) return;

            this.index = this.dataCopy.Count - 1;

            this.txtData.Text = this.dataCopy[this.index];

            this.pos = this.dataCopy.Count;

            this.DisplayRecordCountAndPosition();
        }

        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count == 0) return;

            // pos zero based.
            if ((this.index + 1) >= this.dataCopy.Count) return;

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

        private void OnReplaceBookInformationDataButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count < 1) return;
            if (string.IsNullOrWhiteSpace(this.title)) return;
            if (string.IsNullOrWhiteSpace(this.series)) return;

            var sb = new StringBuilder();

            sb.Append(this.title);
            sb.Append("-");
            sb.Append(this.series);

            this.txtData.Text = sb.ToString();

            this.dataCopy.RemoveAt(this.index);
            this.dataCopy.Add(sb.ToString());

            this.btnLast.PerformClick();

            this.txtSeries.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.series = string.Empty;
            this.title = string.Empty;
        }

        private void OnSaveAllChangesButton_Clicked(object sender, EventArgs e)
        {
            if (this.dataCopy.Count > 1) return;

            FileOutputClass.WriteAuthorsTitlesToFile(this.filePath, this.dataCopy);

            this.dataCopy.Clear();
        }

        private void OnSaveAllChangesMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnSave.PerformClick();
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedSeriesText();

            if (string.IsNullOrEmpty(this.series)) return;

            this.txtSeries.Text = this.series;

            this.ValidateTitleTextDoesNotMatchSeriesText();
        }


        private void OnSelectedTextTitleButton_Clicked(object sender, EventArgs e)
        {
            this.GetSelectedTitleText();

            if (string.IsNullOrEmpty(this.title)) return;

            this.txtTitle.Text = this.title;

            this.ValidateTitleTextDoesNotMatchSeriesText();
        }

        private void ValidateTitleTextDoesNotMatchSeriesText()
        {
            try
            {
                if (this.title.Equals(this.series))
                {
                    throw new NotSupportedException();
                }
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage =
                    "The title of the book and the book series must not be the same. " + ex;
                MyMessagesClass.ShowErrorMessageBox();
            }
        }
    }
}