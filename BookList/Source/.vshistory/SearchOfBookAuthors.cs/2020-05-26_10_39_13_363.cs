using System;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;

namespace BookList.Source
{
    using PropertiesClasses;

    public partial class SearchOfBookAuthors : Form
    {
        private const string V = "List contains this author name. ";
        private const string MethodName = "Search";

        public SearchOfBookAuthors()
        {
            InitializeComponent();
            this.LoadListBoxWithAuthorNames();
        }


        private void LoadListBoxWithAuthorNames()
        {
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                var authorName = AuthorNamesListCollection.GetItemAt(index);
                this.lstSearch.Items.Add(authorName);
            }

            if (this.lstSearch != null) this.lstSearch.Sorted = true;
        }

        private void SearchByAuthorsNameButtonClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.txtSearch.Text.Trim())) return;

            foreach (var author in this.lstSearch.Items)
            {
                var temp = author.ToString();
                temp = temp.ToLower();
                var searchString = txtSearch.Text.Trim();
                searchString = searchString.ToLower();
                var retVal = temp.Contains(searchString);

                if (!retVal) continue;
                MyMessagesClass.InformationMessage = V + temp;
                MyMessagesClass.ShowInformationMessage(MyMessagesClass.InformationMessage, MethodName);
            }
        }

        private void SelectedIndexChangedListBoxClicked(object sender, EventArgs e)
        {
           
        }

        private void SelectedAuthorButtonClicked(object sender, EventArgs e)
        {
            this.txtSearch.Text = this.txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(this.txtSearch.Text)) return;

            this.txtSearch.Text = this.lstSearch.SelectedItem.ToString();
            BookListPropertiesClass.AuthorsNameCurrent = this.txtSearch.Text;

            this.btnClose.PerformClick();
        }

        private void CloseSearchBuTitleButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}