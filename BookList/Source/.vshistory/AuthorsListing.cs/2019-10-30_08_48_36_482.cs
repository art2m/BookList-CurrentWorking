// BookList
// 
// AuthorsListing.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 10  30  2019
// 
// 10  26   2019
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace BookList.Source
{
    using System;
    using System.Windows.Forms;
    using Classes;
    using Collections;
    using PropertiesClasses;

    public partial class AuthorsListing : Form
    {
        private string authorName = string.Empty;

        public AuthorsListing()
        {
            this.InitializeComponent();
            this.FillListWithAuthorsNames();
        }

        private void FillListWithAuthorsNames()
        {
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                this.lstAuthor.Items.Add(AuthorsFileNamesCollection.GetItemAt(index));
            }
        }

        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnOkButton_Clicked(object sender, EventArgs e)
        {
            BookListPropertiesClass.AuthorsNameCurrent = this.lblAuthor.Text;

            this.Close();
        }

        private void OnSearchAuthorsListButton_Clicked(object sender, EventArgs e)
        {
            foreach (var value in this.lstAuthor.Items)
            {
                var author = value.ToString();
                author = author.ToLower();

                var searchString = this.authorName.ToLower();
                var retVal = author.Contains(searchString);

                if (!retVal) continue;



                this.lblAuthor.Text = author;

                MyMessagesClass.InformationMessage = "List contains this author name. " + author;
                MyMessagesClass.ShowInformationMessage(MyMessagesClass.InformationMessage, "Search");
            }
        }

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.lblAuthor.Text = this.lstAuthor.SelectedItem.ToString();
            this.authorName = this.txtAuthor.Text.Trim();
        }
    }
}