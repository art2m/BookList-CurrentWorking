using System.Windows.Forms;

namespace BookList.Source
{
    /// <summary>
    /// Edit the book author.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class EditingOfBookAuthor : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditingOfBookAuthor"/> class.
        /// </summary>
        public EditingOfBookAuthor()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Called when /[close adding new author button close].
        /// Close window.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}