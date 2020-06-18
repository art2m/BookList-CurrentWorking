// BookList
// 
// AdditionOfBookTitles.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 11  05  2019
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
    using PropertiesClasses;

    /// <summary>
    ///     Defines the <see cref="AdditionOfBookTitles" />
    /// </summary>
    public partial class AdditionOfBookTitles : Form
    {
        private bool isBookSeries;

        /// <summary>
        ///     Initializes a new instance of the <see cref="AdditionOfBookTitles" /> class.
        /// </summary>
        public AdditionOfBookTitles()
        {
            this.InitializeComponent();
        }

        private void OnAddExistingAuthorButton_Clicked(object sender, EventArgs e)
        {
            using (var dlg = new AuthorsListing())
            {
                dlg.ShowDialog();
            }

            this.txtAuthor.Text = BookListPropertiesClass.AuthorsNameCurrent.Trim();
        }

        private void OnAddNewAuthorButton_Clicked(object sender, EventArgs e)
        {

        }

        /// <summary>
        ///     The OnAddNewBookRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnAddNewBookRecordButton_Clicked(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     The OnCancelOperationButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
        }

        /// <summary>
        ///     The OnIsBookSeriesCheckBox_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnIsBookSeriesCheckBox_Clicked(object sender, EventArgs e)
        {
            if (this.chkSeries.Checked)
            {
                this.isBookSeries = true;
                return;
            }

            this.isBookSeries = false;
        }

        /// <summary>
        ///     The OnSaveBookRecordButton_Clicked
        /// </summary>
        /// <param name="sender">The sender<see cref="object" />The source of the event.</param>
        /// <param name="e">The e<see cref="System.EventArgs" />Instance containing the event data.</param>
        private void OnSaveBookRecordButton_Clicked(object sender, EventArgs e)
        {
        }
    }
}