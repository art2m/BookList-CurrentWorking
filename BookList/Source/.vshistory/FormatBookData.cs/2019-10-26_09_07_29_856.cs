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

    public partial class RawDataInput : Form
    {
        private int selIndex = -1;

        public RawDataInput()
        {
            this.InitializeComponent();
        }

        private void FillRawDataListBoxWithBookInformation()
        {
            for (var index = 0; index < RawDataCollection.GetItemsCount(); index++)
            {
                this.lstRawData.Items.Add(RawDataCollection.GetItemAt(index));
            }
        }

        private void GetAuthorsName(string fileName)
        {
            var author = AuthorsTextOperations.SplitFileNameFormFileExtension(fileName);

            this.lblInfo.Text = string.Concat("Authors Name  ", author);
        }

        private void GetRawDataFromFile()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            if (!AuthorsFileNamesCollection.ContainsItem(BookListPropertiesClass.AuthorsNameCurrent)) return;

            var index = AuthorsFileNamesCollection.GetItemIndex(BookListPropertiesClass.AuthorsNameCurrent);

            var fileName = AuthorsFileNamesCollection.GetItemAt(index);

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            this.GetAuthorsName(fileName);

            if (!DataStorageOperationsClass.AddRawDataReadFromFileToRawDataCollection(filePath)) return;
        }

        private void LoadRawData()
        {
            this.lstRawData.Sorted = true;

            this.GetRawDataFromFile();
            this.FillRawDataListBoxWithBookInformation();
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
                this.LoadRawData();
            }
        }

        private void OnReplaceBookInformationDataButton_Clicked(object sender, EventArgs e)
        {
            var index = this.lstRawData.SelectedIndex;

            if (index != this.selIndex)
            {
                MyMessagesClass.ErrorMessage = "Currently selected text does not match previously selected text.";
                MyMessagesClass.ShowErrorMessageBox();
                return;
            }

            var lstTemp = this.RemoveBookInformationTextFromListBox(index);

            var sb = new StringBuilder();

            sb.Append(this.txtTitle.Text);
            sb.Append("-");
            sb.Append(this.txtSeries.Text);

            this.txtRawData.Text = sb.ToString();

            lstTemp.Add(sb.ToString());

            this.RefillListBoxWithCorrectedBookInformationItem(lstTemp);
        }

        private void OnSaveAllChangesMenuItem_Clicked(object sender, EventArgs e)
        {
            if (this.lstRawData.Items.Count == 0) return;

            AuthorsFileNamesCollection.ClearCollection();

            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                
            }

        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.txtRawData.Text = this.lstRawData.SelectedItem.ToString();
            this.selIndex = this.lstRawData.SelectedIndex;
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            var series = this.txtRawData.SelectedText;
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
            var title = this.txtRawData.SelectedText;

            if (string.IsNullOrEmpty(title))
            {
                const string Msg = "You must select the title of the book from text in text box.";

                MyMessagesClass.InformationMessage = Msg;
                MyMessagesClass.ShowInformationMessageBox();
            }

            this.txtTitle.Text = title;
        }

        private void RefillListBoxWithCorrectedBookInformationItem(List<string> lstTemp)
        {
            this.lstRawData.Items.Clear();
            for (var index = 0; index < lstTemp.Count; index++)
            {
                this.lstRawData.Items.Add(lstTemp[index]);
            }
        }

        private List<string> RemoveBookInformationTextFromListBox(int index)
        {
            var lstTemp = new List<string>();

            for (var i = 0; i < this.lstRawData.Items.Count; i++)
            {
                lstTemp.Add(this.lstRawData.Items[i].ToString());
            }

            lstTemp.RemoveAt(index);

            return lstTemp;
        }
    }
}