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

    public partial class RawDataInput : Form
    {
        public RawDataInput()
        {
            this.InitializeComponent();
            this.FillRawDataListBoxWithBookInformation();
        }

    

        private void OnSelectedTextTitleButton_Clicked(object sender, EventArgs e)
        {

        }

        private void OnSelectedTextSeriesButton_Clicked(object sender, EventArgs e)
        {

        }

        private void FillRawDataListBoxWithBookInformation()
        {
            for (var index = 0; index < RawDataCollection.GetItemsCount(); index++)
            {
                this.lstRawData.Items.Add(RawDataCollection.GetItemAt(index));
            }
        }
    }
}
