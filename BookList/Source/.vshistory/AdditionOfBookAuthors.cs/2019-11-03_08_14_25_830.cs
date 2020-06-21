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
            this.txtAuthor.Text = string.Empty;
            this.txtSeries.Text = string.Empty;
            this.txtTitle.Text = string.Empty;
            this.txtVolume.Text = string.Empty;
            this.txtAuthor.Focus();
        }

        private void OnCancelOperationButton_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnSaveRecordButton_Clicked(object sender, System.EventArgs e)
        {

        }

        private void OnBookIsSeriesCheckBox_Clicked(object sender, System.EventArgs e)
        {

        }
    }
}