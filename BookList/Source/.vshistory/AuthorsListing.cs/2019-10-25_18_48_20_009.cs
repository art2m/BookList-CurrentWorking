
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookList.Source
{
    using Collections;

    public partial class AuthorsListing : Form
    {
        public AuthorsListing()
        {
            this.InitializeComponent();
            this.FillListWithAuthorsNames();
        }

        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OnOkButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.lblAuthor.Text = this.lstAuthor.SelectedItem.ToString();
        }

        private void FillListWithAuthorsNames()
        {
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                this.lstAuthor.Items.Add(AuthorsFileNamesCollection.GetItemAt(index));
            }
        }
    }
}
