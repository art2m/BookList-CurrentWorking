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
            var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPropertiesClass.CurrentWorkingFileName);

            FileInputClass.ReadTitlesFromFile(filePath);
        }

        private void FindTittelsInString()
        {
            "Titles"
        }



    }
}
