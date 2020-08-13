using System.Windows.Forms;

namespace BookList.Source
{
    /// <summary>
    /// Edit the selected book title.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BookTitlesEditorWin : Form
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EditingOfBookTitles"/> class.
        /// </summary>
        public BookTitlesEditorWin()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Called when [close adding new author button close].
        /// Close the window.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}