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
    public partial class ModifyTitlesBookList : Form
    {
        private ToolTip tTip;

        public ModifyTitlesBookList()
        {
            InitializeComponent();

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

        private void OnCloseModifyTilesBookListButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
