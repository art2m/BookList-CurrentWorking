using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

namespace BookList.Source
{
    using System.Diagnostics;
    using System.Runtime.CompilerServices;
    using System.Windows.Forms.VisualStyles;
    using Classes;
    using Collections;
    using PropertiesClasses;

    public partial class RawDataInput : Form
    {
        private int selIndex = -1;

        public RawDataInput()
        {
            this.InitializeComponent();
            this.LoadRawData();
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

        private void LoadRawData()
        {
            this.lstRawData.Sorted = true;

            this.GetRawDataFromFile();
            this.FillRawDataListBoxWithBookInformation();
            this.lblInfo.Text = "Select book information to format into correct style.";
        }

        private void FillRawDataListBoxWithBookInformation()
        {
            for (var index = 0; index < RawDataCollection.GetItemsCount(); index++)
            {
                this.lstRawData.Items.Add(RawDataCollection.GetItemAt(index));
            }
        }

        private void GetRawDataFromFile()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            var fileName = AuthorsFileNamesCollection.GetItemAt(0);

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            this.GetAuthorsName(fileName);

            if (!DataStorageOperationsClass.AddRawDataReadFromFileToRawDataCollection(filePath)) return;
        }

        private void GetAuthorsName(string fileName)
        {
            var author = AuthorsTextOperations.SplitFileNameFormFileExtension(fileName);

            this.lblInfo.Text = "Authors Name:  " + author;
        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.txtRawData.Text = this.lstRawData.SelectedItem.ToString();
            this.selIndex = this.lstRawData.SelectedIndex;
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

            lstTemp.Add(sb.ToString());

            this.RefillListBoxWithCorrectedBookInformationItem(lstTemp);
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

        private void RefillListBoxWithCorrectedBookInformationItem(List<string> lstTemp)
        {
            this.lstRawData.Items.Clear();
            for (int index = 0; index < lstTemp.Count; index++)
            {
                this.lstRawData.Items.Add(lstTemp[index].ToString());
            }
        }
    }
}