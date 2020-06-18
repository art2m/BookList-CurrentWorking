using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookList.Source
{
    using System.Diagnostics;
    using Classes;
    using Collections;
    using PropertiesClasses;

    public partial class RawDataInput : Form
    {
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
                var msg = "You must select the title of the book from text in text box.";
                MyMessagesClass.InformationMessage = msg;
                MyMessagesClass.ShowInformationMessageBox();
            }
            this.txtTitle.Text = title;
        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {
            var series = this.txtRawData.SelectedText;
            this.txtSeries.Text = series;
        }

        private void LoadRawData()
        {
            GetRawDataFromFile();
            this.FillRawDataListBoxWithBookInformation();
        }

        private void FillRawDataListBoxWithBookInformation()
        {
            for (var index = 0; index < RawDataCollection.GetItemsCount(); index++)
            {
                this.lstRawData.Items.Add(RawDataCollection.GetItemAt(index));
            }
        }

        private static void GetRawDataFromFile()
        {
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            var fileName = AuthorsFileNamesCollection.GetItemAt(0);

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            if (!DataStorageOperationsClass.AddRawDataReadFromFileToRawDataCollection(filePath)) return;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtRawData.Text = this.lstRawData.SelectedItem.ToString();
        }
    }
}