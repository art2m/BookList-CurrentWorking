using System;
using System.Reflection;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    /// Search for book authors that the user has read. These are files holding
    /// all book titles by that author.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class SearchOfBookAuthors : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchOfBookAuthors"/> class.
        /// </summary>
        public SearchOfBookAuthors()
        {
            this.InitializeComponent();
            this.LoadListBoxWithAuthorNames();
        }

        /// <summary>
        /// Closes the search bu title button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void CloseSearchBuTitleButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Loads the List Box with author names.
        /// </summary>
        private void LoadListBoxWithAuthorNames()
        {
            var coll = new AuthorsFileNamesCollection();

            for (var index = 0; index < coll.ItemsCount(); index++)
            {
                var authorName = coll.GetItemAt(index);
                this.lstSearch.Items.Add(authorName);
            }

            if (this.lstSearch != null) this.lstSearch.Sorted = true;
        }

        /// <summary>
        /// Searches the by authors name button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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
                msgBox.Msg = "List contains this author name. " + temp;
                msgBox.ShowInformationMessageBox();
            }
        }


        /// <summary>
        /// Get item selected in list box place in text box.
        /// </summary>
        /// <param name="sender">The source of the event..</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SelectedAuthorButtonClicked(object sender, EventArgs e)
        {
            this.txtSearch.Text = this.txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(this.txtSearch.Text)) return;

            this.txtSearch.Text = this.lstSearch.SelectedItem.ToString();
            BookListPaths.AuthorsNameCurrent = this.txtSearch.Text;

            this.btnClose.PerformClick();
        }

        /// <summary>
        /// Get the item selected by the user.
        /// </summary>
        /// <param name="sender">The source of thg event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// <exception cref="NotImplementedException"></exception>
        private void SelectedIndexChangedListBoxClicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}