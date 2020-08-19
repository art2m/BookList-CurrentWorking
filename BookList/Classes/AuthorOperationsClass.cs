// BookList
// 
// AuthorOperationsClass.cs
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
using System.Diagnostics;
using System.Reflection;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Classes
{
    /// <summary>
    ///     Contains operations on book Authors.
    /// </summary>
    public class AuthorOperationsClass
    {
        /// <summary>
        ///     Deceleration of Message Box Object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declare validation class Object.
        /// </summary>
        private readonly ValidationClass _valid = new ValidationClass();

        /// <summary>
        ///     <para></para>
        ///     <para>
        ///         Initializes a new instance of the <see cref="AuthorOperationsClass" /> class.
        ///     </para>
        /// </summary>
        public AuthorOperationsClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;

            Debug.Listeners.Add(new TextWriterTraceListener(Console.Out));
        }

        /// <summary>
        ///     Add dash between authors first middle and last name. This allows the
        ///     program to tell where each name begins and ends.
        /// </summary>
        /// <param name="author">The Author<see cref="string" />.</param>
        /// <returns>Return the authors name with dashes installed.</returns>
        public string AddDashBetweenAuthorsFirstMiddleLastName(string author)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

         
            if (!this._valid.ValidateStringIsNotNull(author)) return string.Empty;
            if (!this._valid.ValidateStringHasLength(author)) return string.Empty;

            var authorName = this.AddDashToAuthorName(author.Trim());

            var clsFile = new FileClass();
            return clsFile.AddFileExtension(authorName);
        }

        /// <summary>
        ///     Make file name from authors name.
        /// </summary>
        /// <param name="author">
        ///     The Author <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     Return the authors name with dashes installed.
        /// </returns>
        public string CreateAuthorFileName(string author)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._valid.ValidateStringIsNotNull(author)) return string.Empty;

            if (!this._valid.ValidateStringHasLength(author)) return string.Empty;

            var cls1 = this.AddDash(author.Trim());
            var cls2 = new FileClass();
            var fileName = cls2.AddFileExtension(cls1);

            if (cls2.CheckFileNameHasExtension(fileName)) return fileName;

            this._msgBox.Msg = "Unable to create the authors file name.";
            this._msgBox.ShowErrorMessageBox();
            return string.Empty;
        }

        /// <summary>
        ///     Check that the list of author names matches the names of all author files
        ///     contained in the bookList  Authors directory.
        /// </summary>
        public void UpdateAuthorsNamesWithFileNames()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var cls = new FileClass();
            cls.GetAuthorFileNamesFromAuthorsList();
            cls.GetAllAuthorFilePathsContainedInAuthorDirectory();
            this.GetAuthorFileNamesAddToAuthorsNamesList();
        }


        /// <summary>
        ///     Add item to the AuthorsFileName collection.
        /// </summary>
        /// <param name="fileName">The file name<see cref="string" />.</param>
        public void AddAuthorFileNamesToCollection(string fileName)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            fileName = fileName.Trim();

            if (string.IsNullOrEmpty(fileName)) return;
            if (string.IsNullOrWhiteSpace(fileName)) return;

            var coll = new AuthorsFileNamesCollection();

            if (coll.ContainsItem(fileName)) return;
            coll.AddItem(fileName);
        }

        /// <summary>
        ///     Make the list of author names match the FileNames.
        /// </summary>
        private void GetAuthorFileNamesAddToAuthorsNamesList()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll1 = new AuthorNamesCollection();
            var coll2 = new AuthorsFileNamesCollection();

            coll1.ClearCollection();
            for (var index = 0; index < coll2.GetItemsCount(); index++)
                coll1.AddItem(coll2.GetItemAt(index));
        }

        /// <summary>
        ///     add a dash to authors name so first middle and last name can be
        ///     identified by the program.
        /// </summary>
        /// <param name="author">
        ///     The Author <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     The <see cref="System.String" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Local
        private string AddDash(string author)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var authorName = string.Empty;
            foreach (var letter in author)
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());

            return authorName;
        }

        /// <summary>
        ///     add a dash to authors name so first middle and last name can be identified
        ///     by the program.
        /// </summary>
        /// <param name="author">The Author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        private string AddDashToAuthorName(string author)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var validate = new ValidationClass();

            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = string.Empty;

            foreach (var letter in author)
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());

            return authorName;
        }

        /// <summary>Fills the Author names list collection with authors names.</summary>
        public void FillListWithAuthorsNames()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new AuthorNamesCollection();
            coll.ClearCollection();

            var cls = new InputClass();
            cls.ReadAuthorsNamesFromFile(BookListPathsProperties.PathAuthorsNamesListFile);

            coll.SortCollection();
        }

        /// <summary>
        /// Loop threw all authors.
        /// </summary>
        public void AllAuthorsLoop()
        {
            var coll = new AuthorNamesCollection();

            var totalCount = coll.GetItemsCount();

            if (totalCount == 0) return;

            Debug.AutoFlush = true;
            Debug.Indent();
            Debug.WriteLine("All Authors loop - Authors Count  " + coll.GetItemsCount().ToString());
            Debug.Unindent();

            for (var index = 0; index < totalCount; index++)
            {
                if (!this._valid.ValidateStringIsNotNull(coll.GetItemAt(index))) continue;

                var author = coll.GetItemAt(index).Trim();

                if (!this._valid.ValidateStringIsNotNull(author)) continue;

                BookListPathsProperties.CurrentWorkingFileName = coll.GetItemAt(index);

                this.SearchBookTitleBySingleAuthor();
            }
        }

        /// <summary>
        ///     Searches the book title by single author.
        /// </summary>
        public void SearchBookTitleBySingleAuthor()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            
            var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

            var cls1 = new CombinePathsClass();
            var filePath = cls1.CombineDirectoryPathWithFileName(dirAuthors,
                BookListPathsProperties.CurrentWorkingFileName);

            var coll = new BookDataCollection();
            coll.ClearCollection();

            var titles = new BookTitlesCollection();

            titles.ClearCollection();

            var cls2 = new InputClass();
            cls2.ReadTitlesFromFileLoop(filePath);

            this.FindTitlesInString();

            if (titles.GetItemsCount() < 1)
            {
                titles.AddItem("No titles with this search criteria were found.");
            }
        }

        /// <summary>
        ///     Finds the titles in string.
        /// </summary>
        private void FindTitlesInString()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new BookTitlesCollection();
            coll.ClearCollection();

            this.BookTitlesSearchLoop();
        }

        /// <summary>
        /// Search all authors titles.
        /// </summary>
        /// <param name="search">The book title to search for.</param>
        private void BookTitlesSearchLoopAllAuthors()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._valid.ValidateStringIsNotNull(BookDataProperties.SetBookTitleSearchString)) return;
            if (!this._valid.ValidateStringHasLength(BookDataProperties.SetBookTitleSearchString.Trim())) return;

            var searchStr = BookDataProperties.SetBookTitleSearchString.Trim().ToLower();

            var coll1 = new BookDataCollection();

            Debug.AutoFlush = true;
            Debug.Indent();
            Debug.WriteLine("BookTitlesSearchLoopAllAuthors  " + coll1.GetItemsCount().ToString());
            Debug.Unindent();

            var coll2 = new BookTitlesCollection();
            for (var i = 0; i < coll1.GetItemsCount(); i++)
            {
                var s1 = coll1.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(searchStr))
                {
                    coll2.AddItem(s1);
                }
            }
        }

        /// <summary>
        ///     Books the titles search loop.
        /// </summary>
        private void BookTitlesSearchLoop()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._valid.ValidateStringIsNotNull(BookDataProperties.SetBookTitleSearchString)) return;
            if (!this._valid.ValidateStringHasLength(BookDataProperties.SetBookTitleSearchString.Trim())) return;

            var searchStr = BookDataProperties.SetBookTitleSearchString.Trim().ToLower();

            var coll1 = new BookDataCollection();

            var coll2 = new BookTitlesCollection();

            for (var i = 0; i < coll1.GetItemsCount(); i++)
            {
                var s1 = coll1.GetItemAt(i);
                s1 = s1.ToLower();

                if (s1.Contains(searchStr))
                {
                    coll2.AddItem(s1);
                }
            }
        }

        /// <summary>
        ///     Authors the names search loop.
        /// </summary>
        private void AuthorNamesSearchLoop()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            

            var coll1 = new AuthorsFileNamesCollection();
            var totalCount = coll1.GetItemsCount();

            for (var i = 0; i < totalCount; i++)
            {
                var fileName = coll1.GetItemAt(i);

                var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

                var coll2 = new CombinePathsClass();
                var filePath = coll2.CombineDirectoryPathWithFileName(dirAuthors, fileName);

                var coll3 = new InputClass();
                coll3.ReadTitlesFromFileLoop(filePath);

                this.FindTitlesInString();
            }
        }

        /// <summary>
        ///     Searches the book title all authors.
        /// </summary>
        public void SearchBookAuthorAllTitles()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var cls1 = new FileClass();
            cls1.GetAllAuthorFilePathsContainedInAuthorDirectory();

            var coll1 = new BookDataCollection();
            coll1.ClearCollection();
            
            this.AuthorNamesSearchLoop();

            
            var coll2 = new BookTitlesCollection();

            if (coll2.GetItemsCount() < 1)
            {
                coll2.AddItem("No titles with this search criteria were found.");
            }
        }

        /// <summary>
        ///     Shows all book titles by single author loop.
        /// </summary>
        public void ShowAllBookTitlesBySingleAuthorLoop()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll1 = new BookDataCollection();
            var coll2 = new BookTitlesCollection();
            for (var i = 0; i < coll1.GetItemsCount(); i++)
            {
                var s1 = coll1.GetItemAt(i);

                if (!this._valid.ValidateStringIsNotNull(s1)) return;

                s1 = s1.Trim();
                if (!this._valid.ValidateStringHasLength(s1)) return;

                coll2.AddItem(s1);
            }
        }
    }
}