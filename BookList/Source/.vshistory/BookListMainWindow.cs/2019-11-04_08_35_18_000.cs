﻿// BookList
//
// BookListMainWindow.cs
//
// Art2M
//
// art2m@live.com
//
// 10  24  2019
//
// 10  24   2019
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
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Select operation type to be performed on the records contained in list books.
    ///     Display all records contained in the list books data.
    /// </summary>
    public partial class BookListWindow : Form
    {
        public BookListWindow()
        {
            InitializeComponent();
            AuthorsDirectoryFilesClass.UpdateAuthorsNamesWithFileNames();
        }

        private void OnAddAuthorsButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookAuthors())
            {
                win.ShowDialog();
            }
        }

        private void OnAddSeriesButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnAddTitlesButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new AdditionOfBookTitles())
            {
                win.ShowDialog();
            }
        }

        private void OnEditAuthorsButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new EditingOfBookAuthor())
            {
                win.ShowDialog();
            }
        }

        private void OnEditSeriesButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnEditTitlesButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnQuitApplicationButton_Clicked(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void OnSearchAuthorsButton_Clicked(object sender, EventArgs e)
        {
            FileOutputClass.WriteArthurFileNamesToListFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            using (var win = new SearchOfBookAuthors())
            {
                win.ShowDialog();
            }
        }

        private void OnSearchSeriesButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnSearchTitlesButton_Clicked(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void OnExitApplicationMenuItem_Clicked(object sender, EventArgs e)
        {
            btnQuit.PerformClick();
        }

        private void OnUnformattedDataButton_Clicked(object sender, EventArgs e)
        {
            using (var win = new FormatBookData())
            {
                win.ShowDialog();
            }
        }

        private void OnFormatRecordsMenuItem_Clicked(object sender, EventArgs e)
        {
            btnUnfromatted.PerformClick();
        }
    }
}