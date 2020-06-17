// BookList
// 
// BookListMainWindow.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 08  14  2019
// 
// 08  13   2019
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

namespace BookList
{
    using System;
    using System.Windows.Forms;

    /// <summary>
    ///     Select operation type to be performed on the records contained in list books.
    ///     Display all records contained in the list books data.
    /// </summary>
    public partial class BookListWindow : Form
    {
        private ToolTip tTip;

        public BookListWindow()
        {
            this.InitializeComponent();
            this.SetToolTips();
            this.FillListBoxWithData();
        }

        private void FillListBoxWithData()
        {

        }


        private void OnAddNewRecordButton_Clicked(object sender, EventArgs e)
        {
        }

        private void OnCancelCurrentOperation_Clicked(object sender, EventArgs e)
        {
        }

        private void OnDeleteSelectedRecordButton_Clicked(object sender, EventArgs e)
        {
        }

        private void OnEditSelectedRecordButton_Clicked(object sender, EventArgs e)
        {
        }

        private void OnQuitApplicationButton_Clicked(object sender, EventArgs e)
        {
        }

        private void OnSelectedIndexChangedLIstBox_Clicked(object sender, EventArgs e)
        {
        }

        private void OnUpdateBookListWithRecordChangesButton_Clicked(object sender, EventArgs e)
        {
        }

        private void SetToolTips()
        {
            this.tTip = new ToolTip();
            this.tTip.SetToolTip(this.btnAdd, "Select to add a new book record.");
            this.tTip.SetToolTip(this.btnCancel, "Select this to cancel current operation.");
            this.tTip.SetToolTip(this.btnDelete, "Select to delete record selected in list box.");
            this.tTip.SetToolTip(this.btnEdit, "Select to edit selected record in the list box.");
            this.tTip.SetToolTip(this.btnUpdate, "Select this to update book list record with changes.");
            this.tTip.SetToolTip(this.lstBooks, "Select record to edit or delete from book list.");
        }
    }
}