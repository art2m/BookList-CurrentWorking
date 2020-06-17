// BookList
// 
// RawDataInput.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 10  25  2019
// 
// 10  25   2019
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

    public partial class UnformattedData : Form
    {
        //private int selIndex = -1;

        private string CurrentInfo = string.Empty;
        private string filePath = string.Empty;

        /// <summary>
        /// Back up of the Authors File Names Collection For Restoring Before Changes.
        /// </summary>
        private List<string> DataCopy = new List<string>();

        private int index = 0;
        private int pos = 0;
        private string series = string.Empty;
        private string title = string.Empty;
        private int totalCount = 0;

        public UnformattedData()
        {
            this.InitializeComponent();
            this.mnuAuthors.PerformClick();
        }

        private void GetAuthorsName(string fileName)
        {
            var author = AuthorsTextOperations.SplitFileNameFormFileExtension(fileName);

            this.lblInfo.Text = string.Concat("Authors Name  ", author);
        }

        private string GetUnformattedDataFrom()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            if (!AuthorsFileNamesCollection.ContainsItem(BookListPropertiesClass.AuthorsNameCurrent))
                return string.Empty;

            var index = AuthorsFileNamesCollection.GetItemIndex(BookListPropertiesClass.AuthorsNameCurrent);

            var fileName = AuthorsFileNamesCollection.GetItemAt(index);

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            this.filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            this.GetAuthorsName(fileName);

            return this.filePath;
        }

        private void LoadUnformattedData()
        {
            this.filePath = this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(this.filePath)) return;

            FileInputClass.ReadTitlesFromFile(this.filePath);

            DataStorageOperationsClass.AddToBackUpList(this.DataCopy);

            this.totalCount = this.DataCopy.Count;
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
            BookListPropertiesClass.AuthorsNameCurrent = string.Empty;
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
            if (this.DataCopy.Count == 0) return;
            if (this.DataCopy.Count < 1) return;

            this.index = 0;
            this.txtData.Text = this.DataCopy[this.index];

            this.pos = this.index + 1;

            var sb = new StringBuilder("Record position ");
            sb.Append(this.pos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            //this.txtData.Focus();
        }

        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;

            if ((this.index + 1) > this.DataCopy.Count) return;

            this.index = this.DataCopy.Count - 1;

            this.txtData.Text = this.DataCopy[this.index];

            this.pos = this.DataCopy.Count;

            var sb = new StringBuilder("Record position ");
            sb.Append(this.pos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            // this.txtData.Focus();
        }

        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;

            // pos zero based.
            if ((this.index + 1) >= this.DataCopy.Count) return;

            this.index++;

            this.txtData.Text = this.DataCopy[this.index];

            this.pos = this.index + 1;

            var sb = new StringBuilder("Record position ");

            sb.Append(this.pos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            //this.txtData.Focus();
        }

        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;

            if (this.index == 0) return;

            this.index--;

            this.txtData.Text = this.DataCopy[this.index];

            this.pos = this.index + 1;

            var sb = new StringBuilder("Record position ");
            sb.Append(this.pos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            //this.txtData.Focus();
        }

        private void OnReplaceBookInformationDataButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count < 1) return;
            if (string.IsNullOrWhiteSpace(this.title)) return;
            if (string.IsNullOrWhiteSpace(this.series)) return;

            var sb = new StringBuilder();

            sb.Append(this.title);
            sb.Append("-");
            sb.Append(this.series);

            this.txtData.Text = sb.ToString();

            this.DataCopy.RemoveAt(this.index);
            this.DataCopy.Add(sb.ToString());

            this.btnLast.PerformClick();

            this.txtSeries.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.series = string.Empty;
            this.title = string.Empty;
        }

        private void OnSaveAllChangesButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count > 1) return;

            FileOutputClass.WriteAuthorsTitlesToFile();
        }

        private void OnSaveAllChangesMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnSave.PerformClick();
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            this.series = this.txtData.SelectedText;
            this.series = this.series.Trim();

            if (string.IsNullOrEmpty(this.series))
            {
                const string Msg = "You must select the title of the book from text in text box.";

                MyMessagesClass.InformationMessage = Msg;
                MyMessagesClass.ShowInformationMessageBox();
            }

            if (this.series.Equals(this.title)) return;

            this.txtSeries.Text = this.series;
        }

        private void OnSelectedTextTitleButton_Clicked(object sender, EventArgs e)
        {
            this.title = this.txtData.SelectedText;

            this.title = this.title.Trim();

            if (string.IsNullOrEmpty(this.title))
            {
                const string Msg = "You must select the title of the book from text in text box.";

                MyMessagesClass.InformationMessage = Msg;
                MyMessagesClass.ShowInformationMessageBox();
            }

            if (this.title.Equals(this.series)) return;

            this.txtTitle.Text = this.title;
            this.btnReplace.Enabled = false;
        }
    }
}