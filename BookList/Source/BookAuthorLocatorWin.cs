using System;
using System.Reflection;
using System.Windows.Forms;

using BookList.Classes;
using BookList.Collections;

namespace BookList.Source
{
    using PropertiesClasses;

    /// <summary>
    /// Search for author files for the author the user has entered.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BookAuthorLocatorWin : Form
    {
        /// <summary>
        /// Declaration of message box <see langword="object"/>.
        /// </summary>
        private MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        /// Declaration of validation class <see langword="object"/>.
        /// </summary>
        private const string V = "List contains this author name. ";


        /// <summary>
        /// Initializes a new instance of the <see cref="BookAuthorLocatorWin"/> class.
        /// </summary>
        public BookAuthorLocatorWin()
        {
            this.InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;

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
            var msgBox = new MyMessageBoxClass();
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
            BookListPathsProperties.AuthorsNameCurrent = this.txtSearch.Text;

            this.btnClose.PerformClick();
        }

        private void CloseSearchBuTitleButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}