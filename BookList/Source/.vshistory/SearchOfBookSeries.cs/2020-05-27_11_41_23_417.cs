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

        private void SelectAuthorButtonClicked(object sender, System.EventArgs e)
        {
            using (var win = new AuthorsListing())
            {
                win.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;
            this.txtAuthorName.Text = BookListPropertiesClass.AuthorsNameCurrent;
        }

        private void CloseSearchByAuthorsButtonClicked(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}