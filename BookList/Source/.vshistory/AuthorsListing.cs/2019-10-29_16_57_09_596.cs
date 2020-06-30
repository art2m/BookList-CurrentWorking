//---------------------------------------------------------------------------------------------------------------
// BookList
// 
// AuthorsListing.cs
//
// File:     BookList.sln
//
// Author:   Art2M]
// Email     art2m@live.com   
// Company:  
// Date:     10/25/2019
//
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//----------------------------------------------------------------------------------------------------------------

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

        private void OnSelectedIndexChangedListBox_Selected(object sender, EventArgs e)
        {
            this.lblAuthor.Text = this.lstAuthor.SelectedItem.ToString();
            this.authorName = this.txtAuthor.Text.Trim();
        }

        private void OnSearchAuthorsListButton_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.authorName)) return;

            foreach (var author in this.lstAuthor.Items)
            {
                var temp = author.ToString();
                temp = temp.ToLower();
                var searchString = this.authorName.ToLower();
                var retVal = temp.Contains(searchString);

                if (!retVal) continue;

                this.lblAuthor.Text = temp;

                MyMessagesClass.InformationMessage = "List contains this author name. " + temp;
                MyMessagesClass.ShowInformationMessage(MyMessagesClass.InformationMessage, "Search");
            }
        }
    }
}