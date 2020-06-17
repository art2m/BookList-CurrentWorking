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
    using Classes;
    using Collections;
    using PropertiesClasses;

    public partial class SearchOfBookTitles : Form
    {
        public SearchOfBookTitles()
        {
            InitializeComponent();
            this.btnSelect.Enabled = false;
            BookListPropertiesClass.AuthorsNameCurrent = string.Empty;
        }

        private void CloseSearchByAuthorsButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SearchAllAuthorsRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = false;
        }

        private void SearchByAuthorRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = true;
        }

        private void SelectAuthorButtonClicked(object sender, EventArgs e)
        {
            using (var win = new AuthorsListing())
            {
                win.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;
            this.txtAuthorName.Text = BookListPropertiesClass.AuthorsNameCurrent;
        }

        private void OnTitleSearchButtonClicked(object sender, EventArgs e)
        {
           if (this.rdbSpecific.Checked) this.SearchBookTitlesBySingleAuthor();

           if (this.rdbAll.Checked) this.SearchBookTitlesAllAuthors();
        }

        private void SearchBookTitlesAllAuthors()
        {

            AuthorsDirectoryFilesClass.GetAllAuthorFilePathsContainedInAuthorDirectory();

            for (var i = 0; i < AuthorsFileNamesCollection.ItemsCount(); i++)
            {
                var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();
                var filePath = 
            }
        }

        private void FindTitlesInString()
        {
            var s2 = this.txtAuthorName.Text.Trim();

            if (string.IsNullOrEmpty(s2)) return;

            for (var i = 0; i < TitleNamesCollection.ItemsCount(); i++)
            {
                var s1 = TitleNamesCollection.GetItemAt(i);

                if (s1.Contains(s2))
                {
                    this.lstTiltes.Items.Add(s1);
                }
            }
        }

        private void SearchBookTitlesBySingleAuthor()
        {
            var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPropertiesClass.CurrentWorkingFileName);

            TitleNamesCollection.ClearCollection();

            FileInputClass.ReadTitlesFromFile(filePath);

            this.FindTitlesInString();

            if (this.lstTiltes.Items.Count < 1)
            {
                this.lstTiltes.Items.Add("No titles with this search criteria were found.");
            }
        }

    }
}
