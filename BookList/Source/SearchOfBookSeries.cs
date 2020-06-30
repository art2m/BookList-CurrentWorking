using System;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    public partial class SearchOfBookSeries : Form
    {
        public SearchOfBookSeries()
        {
            this.InitializeComponent();
            this.btnSelect.Enabled = true;
            BookListPropertiesClass.AuthorsNameCurrent = string.Empty;
        }

        private void FindTitlesInString()
        {
            var s2 = this.txtSeries.Text.Trim();

            s2 = s2.ToLower();
            if (string.IsNullOrEmpty(s2)) return;

            for (var i = 0; i < BookInfoCollection.ItemsCount(); i++)
            {
                var s1 = BookInfoCollection.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(s2))
                {
                    this.lstSeries.Items.Add(s1);
                }
            }
        }

        private void SearchBookSeriesAllAuthors()
        {
            AuthorsDirectoryFilesClass.GetAllAuthorFilePathsContainedInAuthorDirectory();

            BookInfoCollection.ClearCollection();
            this.lstSeries.Items.Clear();

            for (var i = 0; i < AuthorsFileNamesCollection.ItemsCount(); i++)
            {
                var fileName = AuthorsFileNamesCollection.GetItemAt(i);
                var dirAuthors = BookListPropertiesClass.PathToAuthorsDirectory;
                var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors,
                    fileName);
                this.txtAuthorName.Text = fileName;

                FileInputClass.ReadTitlesFromFile(filePath);
                this.FindTitlesInString();
            }

            if (this.lstSeries.Items.Count < 1)
            {
                this.lstSeries.Items.Add("No titles with this search criteria were found.");
            }
        }

        private void SearchBookSeriesBySingleAuthor()
        {
            var dirAuthors = BookListPropertiesClass.PathToAuthorsDirectory;

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPropertiesClass.CurrentWorkingFileName);

            BookInfoCollection.ClearCollection();
            this.lstSeries.Items.Clear();

            FileInputClass.ReadTitlesFromFile(filePath);

            this.FindTitlesInString();

            if (this.lstSeries.Items.Count < 1)
            {
                this.lstSeries.Items.Add("No titles with this search criteria were found.");
            }
        }

        private void OnSeriesSearchButtonClicked(object sender, EventArgs e)
        {
            if (this.rdbSpecific.Checked) this.SearchBookSeriesBySingleAuthor();

            if (this.rdbAll.Checked) this.SearchBookSeriesAllAuthors();
        }

        private void OnSearchByAuthorRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = true;
        }

        private void OnSearchAllAuthorsRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = false;
        }

        private void OnSelectAuthorButtonClicked(object sender, EventArgs e)
        {
            using (var win = new AuthorsListing())
            {
                win.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;
            this.txtAuthorName.Text = BookListPropertiesClass.AuthorsNameCurrent;
        }

        private void OnCloseSearchByAuthorsButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}