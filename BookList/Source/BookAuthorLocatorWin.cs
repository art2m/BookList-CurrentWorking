// BookList
// 
// BookAuthorLocatorWin.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 08    12   2020
// 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Search for author files for the author the user has entered.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    public partial class BookAuthorLocatorWin : Form
    {
        /// <summary>
        ///     Declaration of MessageBox object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declaration of ValidationClass object.
        /// </summary>
        private readonly ValidationClass _valid = new ValidationClass();

        /// <summary>
        ///     Decleration of AuthorsFileNamesCollection object.
        /// </summary>
        private readonly AuthorsFileNamesCollection _collNames = new AuthorsFileNamesCollection();

        /// <summary>
        ///     True when search results displayed in list box else false.
        /// </summary>
        private bool searchResults;

        /// <summary>
        ///     Initializes a new instance of the <see cref="BookAuthorLocatorWin" /> class.
        /// </summary>
        public BookAuthorLocatorWin()
        {
            InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;

            LoadListBoxWithAuthorNames();
        }


        /// <summary>
        ///     Loads the ListBox with author names.
        /// </summary>
        private void LoadListBoxWithAuthorNames()
        {
            searchResults = false;
            for (var index = 0; index < _collNames.GetItemsCount(); index++)
            {
                var authorName = _collNames.GetItemAt(index);
                lstSearch.Items.Add(authorName);
            }

            if (lstSearch != null) lstSearch.Sorted = true;

            lblSearch.Text = "Enter Author name first or last to search.";
            txtSearch.Select();
        }

        /// <summary>
        ///     Searches the by authors name button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SearchByAuthorsNameButton_Clicked(object sender, EventArgs e)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (_valid.ValidateStringIsNotNull(txtSearch.Text.Trim())) return;

            var str = txtSearch.Text.Trim();

            if (!_valid.ValidateStringHasLength(str)) return;

            SearchForAuthorsName(str);
        }

        /// <summary>
        ///     Searches the name of for authors.
        /// </summary>
        private void SearchForAuthorsName(string str)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            
            str = str.ToLower();

            lblSearch.Text = str;
            
            lstSearch.Items.Clear();
            
            AuthorNamesSearchLoop(str);

            DisplayMessageAfterSearch(str);

            searchResults = true;
        }

        /// <summary>
        /// Displays the message after search.
        /// </summary>
        /// <param name="str">The string.</param>
        private void DisplayMessageAfterSearch(string str)
        {
            if (lstSearch.Items.Count < 1)
            {
                _msgBox.Msg = "Author not located in list.";
                _msgBox.ShowInformationMessageBox();

                txtSearch.Text = string.Empty;

                return;
            }

            txtSearch.Text = string.Empty;

            lblSearch.Text = $"List of authors found. Using search criteria {str}";
        }

        /// <summary>
        /// Search author names for author entered by user.
        /// </summary>
        private void AuthorNamesSearchLoop(string str)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            lstSearch.Items.Clear();

            for (var i = 0; i < _collNames.GetItemsCount(); i++)
            {
                var val = _collNames.GetItemAt(i);

                val = val.ToLower();

                if (!_valid.ValidateStringHasLength(val)) continue;


                if (!val.Contains(str)) continue;

                lstSearch.Items.Add(val);
            }
        }

        /// <summary>
        ///     Selected index changed ListBox clicked.
        ///     Get the selected item from the list box.
        ///     Display item in text box.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SelectedIndexChangedListBoxClicked(object sender, EventArgs e)
        {
            txtSearch.Text = lstSearch.SelectedItem.ToString();
        }

        /// <summary>
        ///     Closes the search bu title button clicked.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CloseSearchButton_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        ///     Called when [open button clicked].
        ///     Open the Authors Directory for user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnOpenButton_Clicked(object sender, EventArgs e)
        {
            var dirPath = BookListPathsProperties.PathAuthorsDirectory;

            if (!_valid.ValidateStringIsNotNull(dirPath)) return;
            if (!_valid.ValidateStringHasLength(dirPath)) return;

            if (_valid.ValidateDirectoryExists(dirPath))
            {
                Process.Start(dirPath);
            }
            else
            {
                _msgBox.Msg = "Directory not found.";
                _msgBox.ShowInformationMessageBox();
            }
        }

        /// <summary>
        ///     Called when [reload list button clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnReloadListButton_Clicked(object sender, EventArgs e)
        {
            lstSearch.Items.Clear();
           
            txtSearch.Text = string.Empty;
            
            LoadListBoxWithAuthorNames();
            
            lblSearch.Text = "Enter Author name first or last to search.";
        }


        /// <summary>
        ///     Called when [search enter key press text box clicked].
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="KeyPressEventArgs" /> instance containing the event data.</param>
        private void OnSearchEnterKeyPressTextBox_Clicked(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}