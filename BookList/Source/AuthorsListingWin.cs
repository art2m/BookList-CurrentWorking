using System;
using System.Reflection;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>Displays the authors names so user can select which author to
    /// display book titles for.</summary>
    public partial class AuthorsListingWin : Form
    {
        /// <summary>
        /// Declaration of  MyMessageBox <c>object</c>.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>Initializes a new instance of the <see cref="AuthorsListingWin" /> class.</summary>
        public AuthorsListingWin()
        {
            InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;

            FillListWithAuthorsNames();
        }

        /// <summary>Fills the Author names list collection with authors names.</summary>
        private void FillListWithAuthorsNames()
        {
            var coll = new AuthorNamesCollection();
            lstAuthor.Sorted = true;
            for (var index = 0; index < coll.ItemsCount(); index++)
                lstAuthor.Items.Add(coll.GetItemAt(index));
        }

        /// <summary>Called when [cancel operation button clicked].</summary>
        /// <param name="sender">  Source of the event</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Called when [ok button clicked].</summary>
        /// <param name="sender">The source of the event</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnOKButton_Clicked(object sender, EventArgs e)
        {
            var coll = new BookDataCollection();
            
            BookListPathsProperties.AuthorsNameCurrent = lblAuthor.Text;
            var clsComb = new CombinePathsClass();

            var filePath = clsComb.CombineDirectoryPathWithFileName(BookListPathsProperties.PathAuthorsDirectory,
                BookListPathsProperties.AuthorsNameCurrent);

            var valid = new ValidationClass();
            var msgBox = new MyMessageBoxClass();

            if (!valid.ValidateStringHasLength(filePath))
            {
                msgBox.Msg = "Unable to complete the operation.";
                msgBox.ShowErrorMessageBox();
                return;
            }

            BookListPathsProperties.PathOfCurrentWorkingFile = filePath;

            coll.ClearCollection();
            Close();
        }

        /// <summary>
        /// Called when [selected index changed ListBox selected].
        /// Get the authors name user selected save to CurrentWorkingFileName property
        /// for use in other places all so place in the label.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            lblAuthor.Text = lstAuthor.SelectedItem.ToString();
            BookListPathsProperties.CurrentWorkingFileName = lblAuthor.Text;
        }
    }
}