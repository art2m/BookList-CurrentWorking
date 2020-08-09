using System;
using System.Diagnostics;
using System.Windows.Forms;
using BookList.Collections;

namespace BookList.Source
{
    using BookListCurrent.ClassesProperties;

    /// <summary>Displays the authors names so user can select which author to display book titles for.</summary>
    public partial class AuthorsListing : Form
    {
        /// <summary>Initializes a new instance of the <see cref="AuthorsListing" /> class.</summary>
        public AuthorsListing()
        {
            this.InitializeComponent();
            this.FillListWithAuthorsNames();
        }

        /// <summary>Fills the Author names list collection with authors names.</summary>
        private void FillListWithAuthorsNames()
        {
            var coll = new AuthorNamesList();
            this.lstAuthor.Sorted = true;

            for (var index = 0; index < coll.ItemsCount(); index++)
                this.lstAuthor.Items.Add(coll.GetItemAt(index));

        }

        /// <summary>Called when [cancel operation button clicked].</summary>
        /// <param name="sender">  Source of the event</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Called when [ok button clicked].</summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnOkButton_Clicked(object sender, EventArgs e)
        {
            var coll = new BookInformation();

            BookListPaths.AuthorsNameCurrent = this.lblAuthor.Text;
            coll.ClearCollection();
           // BookInformation.AddItem(BookListPropertiesClass.AuthorsNameCurrent);
            //MyMessagesClass.ShowInformationMessageBox(BookListPropertiesClass.CurrentWorkingFileName,
            //   "Testing", "fum");

            this.Close();
        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.lblAuthor.Text = this.lstAuthor.SelectedItem.ToString();
            BookListPaths.CurrentWorkingFileName = this.lblAuthor.Text;
        }
    }
}