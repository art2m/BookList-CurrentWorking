using System;
using System.Reflection;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;

namespace BookList.Source
{
    using BookListCurrent.ClassesProperties;

    public partial class BookAuthorLocator : Form
    {
        private const string V = "List contains this author name. ";
        private const string MethodName = "Search";

        public BookAuthorLocator()
        {
            this.InitializeComponent();
            this.LoadListBoxWithAuthorNames();
        }


        private void LoadListBoxWithAuthorNames()
        {
            var coll = new AuthorsFileNames();

            for (var index = 0; index < coll.ItemsCount(); index++)
            {
                var authorName = coll.GetItemAt(index);
                this.lstSearch.Items.Add(authorName);
            }

            if (this.lstSearch != null) this.lstSearch.Sorted = true;
        }

        private void SearchByAuthorsNameButtonClicked(object sender, EventArgs e)
        {
            var msgBox = new MyMessageBox();
            msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (string.IsNullOrEmpty(this.txtSearch.Text.Trim())) return;

            foreach (var author in this.lstSearch.Items)
            {
                var temp = author.ToString();
                temp = temp.ToLower();
                var searchString = this.txtSearch.Text.Trim();
                searchString = searchString.ToLower();
                var retVal = temp.Contains(searchString);



                if (!retVal) continue;
                msgBox.Msg = V + temp;
                msgBox.ShowInformationMessageBox();
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
            BookListPaths.AuthorsNameCurrent = this.txtSearch.Text;

            this.btnClose.PerformClick();
        }

        private void CloseSearchBuTitleButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}