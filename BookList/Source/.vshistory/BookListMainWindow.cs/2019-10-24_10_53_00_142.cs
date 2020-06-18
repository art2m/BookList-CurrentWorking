using System;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;
using BookList.Source;

namespace BookList
{
    /// <summary>
    ///     Select operation type to be performed on the records contained in list books.
    ///     Display all records contained in the list books data.
    /// </summary>
    public partial class BookListWindow : Form
    {
        public BookListWindow()
        {
            InitializeComponent();
        }

        private static void GetRawDataFromFile()
        {
            var datStore = new DataStorageOperationsClass();
            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;
            var fileName = AuthorsFileNamesCollection.GetItemAt(0);
            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirPath, fileName);

            if (!datStore.AddRawDataReadFromFileToRawDataCollection(filePath)) return;
        }

        private void OnSearchAuthorsButton_Clicked(object sender, EventArgs e)
        {
            AuthorsDirectoryFilesClass.UpdateAuthorsNamesWithFileNames();
            FileOutputClass.WriteArthurFileNamesToListFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            using (var win = new SearchOfBookAuthors())
            {
                win.ShowDialog();
            }
        }

        private void OnQuitApplicationButton_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnSearchTitlesButton_Clicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnSearchSeriesButton_Clicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnAddAuthorsButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookAuthors())
            {
                win.ShowDialog();
            }
        }

        private void OnAddTitlesButton_Clicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnAddSeriesButton_Clicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnEditAuthorsButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new EditingOfBookAuthor())
            {
                win.ShowDialog();
            }
        }

        private void OnEditTitlesButton_Clicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void OnEditSeriesButton_Clicked(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void RawDataSortButtonClicked(object sender, EventArgs e)
        {

            GetRawDataFromFile();

        }

        //        private void OnRawDataSortButtonClicked(object sender, EventArgs e)
        //        {
        //            MyMessagesClass.InformationMessage = "Hello";
        //            MyMessagesClass.ShowInformationMessage(MyMessagesClass.InformationMessage,
        //                "On Raw Data sort Button Clicked");
        //        }
    }
}