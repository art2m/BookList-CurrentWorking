using System;
using System.Windows.Forms;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    public partial class AuthorsListing : Form
    {
        public AuthorsListing()
        {
            this.InitializeComponent();
            this.FillListWithAuthorsNames();
        }

        private void FillListWithAuthorsNames()
        {
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
                this.lstAuthor.Items.Add(AuthorsFileNamesCollection.GetItemAt(index));
        }

        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnOkButton_Clicked(object sender, EventArgs e)
        {
            BookListPropertiesClass.AuthorsNameCurrent = this.lblAuthor.Text;

            this.Close();
        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.lblAuthor.Text = this.lstAuthor.SelectedItem.ToString();
        }
    }
}