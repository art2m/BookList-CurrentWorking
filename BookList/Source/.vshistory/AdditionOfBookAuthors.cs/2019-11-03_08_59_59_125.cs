using System.Windows.Forms;

namespace BookList.Source
{
    public partial class AdditionOfBookAuthors : Form
    {
        public AdditionOfBookAuthors()
        {
            InitializeComponent();
        }

        private void OnAddNewBookRecordButton_Clicked(object sender, System.EventArgs e)
        {
            this.txtFirstAuthor.Text = string.Empty;
            this.txtSecondAuthor.Text = string.Empty;
            this.txtThirdAuthor.Text = string.Empty;
        }

        private void OnCancelOperationButton_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnSaveRecordButton_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnCloseAddingNewAuthorButton_Close(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void OnOneAuthorRadioButton_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnTwhoAuthorsRadioButton_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnThreeAuthorsRadioButton_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}