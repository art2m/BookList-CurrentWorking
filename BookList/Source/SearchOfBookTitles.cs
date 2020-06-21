﻿// BookList
//
// SearchOfBookTitles.cs
//
// Art2M
//
// art2m@live.com
//
// 05  26  2020
//
// 05  26   2020
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

using System;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    public partial class SearchOfBookTitles : Form
    {
        public SearchOfBookTitles()
        {
            this.InitializeComponent();
            this.btnSelect.Enabled = true;
            BookListPropertiesClass.AuthorsNameCurrent = string.Empty;
        }

        private void OnCloseSearchByAuthorsButtonClicked(object sender, EventArgs e)
        {
            this.Close();
        }


        private void FindTitlesInString()
        {
            var s2 = this.txtTitle.Text.Trim();

            if (string.IsNullOrEmpty(s2)) return;
            s2 = s2.ToLower();

            for (var i = 0; i < BookInfoCollection.ItemsCount(); i++)
            {
                var s1 = BookInfoCollection.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(s2))
                {
                    this.lstTiltes.Items.Add(s1);
                }
            }
        }

        private void OnTitleSearchButtonClicked(object sender, EventArgs e)
        {
            if (this.rdbSpecific.Checked) this.SearchBookTitleBySingleAuthor();

            if (this.rdbAll.Checked) this.SearchBookTitleAllAuthors();
        }

        private void OnSearchAllAuthorsRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = false;
        }

        private void SearchBookTitleAllAuthors()
        {
            AuthorsDirectoryFilesClass.GetAllAuthorFilePathsContainedInAuthorDirectory();

            BookInfoCollection.ClearCollection();
            this.lstTiltes.Items.Clear();

            for (var i = 0; i < AuthorsFileNamesCollection.ItemsCount(); i++)
            {
                var fileName = AuthorsFileNamesCollection.GetItemAt(i);
                var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();
                var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors,
                    fileName);
                this.txtAuthorName.Text = fileName;

                FileInputClass.ReadTitlesFromFile(filePath);
                this.FindTitlesInString();
            }

            if (this.lstTiltes.Items.Count < 1)
            {
                this.lstTiltes.Items.Add("No titles with this search criteria were found.");
            }
        }

        private void SearchBookTitleBySingleAuthor()
        {
            var dirAuthors = AuthorsDirectoryFilesClass.GetPathToAuthorsDirectory();

            var filePath = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPropertiesClass.CurrentWorkingFileName);

            BookInfoCollection.ClearCollection();
            this.lstTiltes.Items.Clear();

            FileInputClass.ReadTitlesFromFile(filePath);

            this.FindTitlesInString();

            if (this.lstTiltes.Items.Count < 1)
            {
                this.lstTiltes.Items.Add("No titles with this search criteria were found.");
            }
        }

        private void OnSearchByAuthorRadioButtonClicked(object sender, EventArgs e)
        {
            this.btnSelect.Enabled = true;
        }

        private void OnSelectAuthorButtonClicked(object sender, EventArgs e)
        {
            using (var win = new AuthorsListing())
            {
                win.ShowDialog();
            }

            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;
            this.txtAuthorName.Text = BookListPropertiesClass.AuthorsNameCurrent;
        }
    }
}