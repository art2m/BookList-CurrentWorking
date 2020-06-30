using System;
using System.Diagnostics;
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
            //AuthorNamesListCollection.ClearCollection();

            this.lstAuthor.Sorted = true;
            Debug.WriteLine(AuthorsFileNamesCollection.ItemsCount().ToString());

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
            BookInfoCollection.ClearCollection();
           // BookInfoCollection.AddItem(BookListPropertiesClass.AuthorsNameCurrent);
            //MyMessagesClass.ShowInformationMessageBox(BookListPropertiesClass.CurrentWorkingFileName,
            //   "Testing", "fum");

            this.Close();
        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.lblAuthor.Text = this.lstAuthor.SelectedItem.ToString();
            BookListPropertiesClass.CurrentWorkingFileName = this.lblAuthor.Text;
        }
    }
}