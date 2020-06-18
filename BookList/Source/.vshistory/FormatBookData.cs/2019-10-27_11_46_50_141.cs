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

        private int index = 0;
        private int totalCount = 0;
        private int CurrPos = 0;

        /// <summary>
        /// Back up of the Authors File Names Collection For Restoring Before Changes.
        /// </summary>
        private List<string> DataCopy = new List<string>();

        public UnformattedData()
        {
            this.InitializeComponent();
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
            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            this.GetAuthorsName(fileName);

            return filePath;
        }

        private void LoadUnformattedData()
        {
            var filePath = this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(filePath)) return;

            FileInputClass.ReadTitlesFromFile(filePath);

            DataStorageOperationsClass.AddToBackUpList(this.DataCopy);

            this.totalCount = this.DataCopy.Count;
        }

        private void OnCloseMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnClose.Select();
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

            if (!string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent))
            {
                this.LoadUnformattedData();
            }

            this.btnFirst.PerformClick();
        }

        private void OnReplaceBookInformationDataButton_Clicked(object sender, EventArgs e)
        {
//            if (index != this.selIndex)
//            {
//                MyMessagesClass.ErrorMessage = "Currently selected text does not match previously selected text.";
//                MyMessagesClass.ShowErrorMessageBox();
//                return;
//            }

            var sb = new StringBuilder();

            sb.Append(this.txtTitle.Text);
            sb.Append("-");
            sb.Append(this.txtSeries.Text);

            this.txtData.Text = sb.ToString();

            this.DataCopy.RemoveAt(this.index);
            this.DataCopy.Add(sb.ToString());

            this.btnLast.PerformClick();
        }

        private void OnSaveAllChangesMenuItem_Clicked(object sender, EventArgs e)
        {
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            var series = this.txtData.SelectedText;
            series = series.Trim();

            if (string.IsNullOrEmpty(series))
            {
                const string Msg = "You must select the title of the book from text in text box.";

                MyMessagesClass.InformationMessage = Msg;
                MyMessagesClass.ShowInformationMessageBox();
            }

            this.txtSeries.Text = series;
        }

        private void OnSelectedTextTitleButton_Clicked(object sender, EventArgs e)
        {
            var title = this.txtData.SelectedText;

            title = title.Trim();

            if (title.eq)

            if (string.IsNullOrEmpty(title))
            {
                const string Msg = "You must select the title of the book from text in text box.";

                MyMessagesClass.InformationMessage = Msg;
                MyMessagesClass.ShowInformationMessageBox();
            }

            this.txtTitle.Text = title;

            
        }

        private void OnMoveFirstButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;
            if (this.DataCopy.Count < 1) return;

            this.index = 0;
            this.txtData.Text = this.DataCopy[this.index];

            this.CurrPos = this.index + 1;

            var sb = new StringBuilder("Record position ");
            sb.Append(this.CurrPos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            this.txtData.Focus();
        }

        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;

            // pos zero based.
            if ((this.index + 1) >= this.DataCopy.Count) return;

            this.index++;

            this.txtData.Text = this.DataCopy[this.index];

            this.CurrPos = this.index + 1;

            var sb = new StringBuilder("Record position ");

            sb.Append(this.CurrPos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            this.txtData.Focus();
        }

        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;

            if (this.index == 0) return;

            this.index--;

            this.txtData.Text = this.DataCopy[this.index];

            this.CurrPos = this.index + 1;

            var sb = new StringBuilder("Record position ");
            sb.Append(this.CurrPos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            this.txtData.Focus();
        }

        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            if (this.DataCopy.Count == 0) return;

            if ((this.index + 1) > this.DataCopy.Count) return;

            this.index = this.DataCopy.Count - 1;

            this.txtData.Text = this.DataCopy[this.index];

            this.CurrPos = this.DataCopy.Count;

            var sb = new StringBuilder("Record position ");
            sb.Append(this.CurrPos.ToString());
            sb.Append(" of ");
            sb.Append(this.totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
            this.txtData.Focus();
        }
    }
}