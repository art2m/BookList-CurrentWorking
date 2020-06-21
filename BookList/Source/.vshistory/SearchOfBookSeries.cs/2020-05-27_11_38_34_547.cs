using System.Windows.Forms;

namespace BookList.Source
{
    public partial class SearchOfBookSeries : Form
    {
        public SearchOfBookSeries()
        {
            this.InitializeComponent();
        }

        private void SearchByAuthorRadioButtonClicked(object sender, System.EventArgs e)
        {
            this.btnSelect.Enabled = true;
        }

        private void SearchAllAuthorsRadioButtonClicked(object sender, System.EventArgs e)
        {
            this.btnSelect.Enabled = false;
        }
    }
}