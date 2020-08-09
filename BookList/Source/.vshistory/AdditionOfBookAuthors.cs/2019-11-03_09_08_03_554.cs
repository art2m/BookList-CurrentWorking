// BookList
// 
// AdditionOfBookAuthors.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 11  03  2019
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

    public partial class AdditionOfBookAuthors : Form
    {
        public AdditionOfBookAuthors()
        {
            this.InitializeComponent();
        }

        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
            this.txtFirstAuthor.Text = string.Empty;
            this.txtSecondAuthor.Text = string.Empty;
            this.txtThirdAuthor.Text = string.Empty;
        }

        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
        }

        private void OnCloseAddingNewAuthorButton_Close(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OnOneAuthorRadioButton_Clicked(object sender, EventArgs e)
        {
            this.lblFirstAuthor.Enabled = true;
            this.lblSecondAuthor.Enabled = false;
            this.lblThirdAuthor.Enabled = false;

            this.txtFirstAuthor.Enabled = true;
            this.txtSecondAuthor.Enabled = false;
            this.txtThirdAuthor.Enabled = false;
        }

        private void OnSaveRecordButton_Clicked(object sender, EventArgs e)
        {
        }

        private void OnThreeAuthorsRadioButton_Clicked(object sender, EventArgs e)
        {
            this.lblFirstAuthor.Enabled = true;
            this.lblSecondAuthor.Enabled = true;
            this.lblThirdAuthor.Enabled = true;

            this.txtFirstAuthor.Enabled = true;
            this.txtSecondAuthor.Enabled = true;
            this.txtThirdAuthor.Enabled = true;
        }

        private void OnTwoAuthorsRadioButton_Clicked(object sender, EventArgs e)
        {
            this.lblFirstAuthor.Enabled = true;
            this.lblSecondAuthor.Enabled = true;
            this.lblThirdAuthor.Enabled = false;

            this.txtFirstAuthor.Enabled = true;
            this.txtSecondAuthor.Enabled = true;
            this.txtThirdAuthor.Enabled = false;
        }
    }
}