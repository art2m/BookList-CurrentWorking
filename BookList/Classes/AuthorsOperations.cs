// BookListCurrent
//
// AuthorsOperations.cs
//
// art2m
//
// art2m
//
// 07    20   2020
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
using System.IO;
using System.Reflection;
using BookList.Collections;
using BookListCurrent.ClassesProperties;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="AuthorsOperations" /> .
    /// </summary>
    public class AuthorsOperations
    {
        /// <summary>
        /// The MSG box
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// My MSG
        /// </summary>
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        /// Declare validation class _object.
        /// </summary>
        private readonly Validation _validate = new Validation();

        /// <summary>
        ///   <para></para>
        ///   <para>Initializes a new instance of the <see cref="AuthorsOperations" /> class.
        /// </para>
        /// </summary>
        public AuthorsOperations()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     add a dash to authors name so first middle and last name can be
        ///     identified by the program.
        /// </summary>
        /// <param name="author">
        ///     The _author <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     The <see cref="System.String" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Local
        private string AddDash(string author)
        {
            var authorName = String.Empty;
            foreach (var letter in author)
            {
                authorName = String.Concat(authorName, Char.IsWhiteSpace(letter) ? "-" : letter.ToString());
            }

            return authorName;
        }

        /// <summary>
        /// add a dash to authors name so first middle and last name can be
        /// identified by the program.
        /// </summary>
        /// <param name="author">The _author <see cref="String" /> .</param>
        /// <returns>
        /// The <see cref="String" /> .
        /// </returns>
        private string AddDashToAuthorName(string author)
        {
            var validate = new Validation();

            if (!validate.ValidateStringIsNotNull(author)) return String.Empty;
            if (!validate.ValidateStringHasLength(author)) return String.Empty;

            var authorName = String.Empty;

            foreach (var letter in author)
            {
                authorName = String.Concat(authorName, Char.IsWhiteSpace(letter) ? "-" : letter.ToString());
            }

            return authorName;
        }


        /// <summary>
        /// Add dash between authors first middle and last name. This allows the
        /// program to tell where each name begins and ends.
        /// </summary>
        /// <param name="author">The _author<see cref="string" />.</param>
        /// <returns>Return the authors name with dashes installed.</returns>
        public string AddDashBetweenAuthorsFirstMiddleLastName(string author)
        {
            var validate = new Validation();
            if (!validate.ValidateStringIsNotNull(author)) return String.Empty;
            if (!validate.ValidateStringHasLength(author)) return String.Empty;

            var authorName = AddDashToAuthorName(author.Trim());

            return AddFileExtension(authorName);
        }


        /// <summary>
        ///     Add the file extension '.dat' to the file name.
        /// </summary>
        /// <param name="author">The file name to add file extension to.</param>
        /// <returns> file name with extension.</returns>
        private string AddFileExtension(string author)
        {
            if (!this._validate.ValidateStringIsNotNull(author)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(author)) return String.Empty;

            const string extension = ".dat";

            return String.Concat(author, extension);
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
        public string MakeAuthorFileName(string author)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(author)) return String.Empty;

            if (!this._validate.ValidateStringHasLength(author)) return String.Empty;

            var authorName = this.AddDash(author.Trim());
            var fileName = this.AddFileExtension(authorName);

            if (this.CheckFileNameHasExtension(fileName)) return fileName;

            this._msgBox.Msg = this._myMsg.MsgUnableToCreateAuthorFileName;
            this._msgBox.ShowErrorMessageBox();
            return String.Empty;
        }

        /// <summary>
        ///     Check to see if file name contains extension '.dat'.
        /// </summary>
        /// <param name="fileName">The authors name to check.</param>
        /// <returns>True if contains file extension '.dat' else False.</returns>
        // ReSharper disable once MemberCanBeMadeStatic.Local
        private bool CheckFileNameHasExtension(string fileName)
        {
            var extension = Path.GetExtension(fileName);

            return extension.Contains("dat");
        }

        /// <summary>
        ///     Return the author name and the .dat extension.
        /// </summary>
        /// <param name="fileName">
        ///     The FileName <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     The <see cref="System.String" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public string SplitFileNameFormFileExtension(string fileName)
        {
            if (!this._validate.ValidateStringIsNotNull(fileName)) return String.Empty;
            return !this._validate.ValidateStringHasLength(fileName) ? String.Empty : Path.GetExtension(fileName);
        }

        /// <summary>
        ///     Gets the all author file paths contained in author directory.
        /// </summary>
        /// <param name="dirAuthorPath">The pat to the authors directory.</param>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public bool GetAllAuthorFilePathsContainedInAuthorDirectory(string dirAuthorPath)
        {
            var validate = new Validation();

            if (!validate.ValidateStringIsNotNull(dirAuthorPath)) return false;
            if (!validate.ValidateStringHasLength(dirAuthorPath)) return false;
            return validate.ValidateDirectoryExists(dirAuthorPath) && GetAllFileNamesContainedInAuthorsDirectory(dirAuthorPath);
        }

        /// <summary>
        ///     The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The directory path<see cref="string" />.</param>
        private bool GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");

            return fileArray.Length != 0 && GetAuthorFileNameFromPath(fileArray);
        }

        /// <summary>
        ///     Make the list of author names match the FileNames.
        /// </summary>
        private bool GetAuthorFileNamesAddToAuthorsNamesList()
        {
            var clsAuthor = new AuthorsFileNames();
            var coll = new AuthorsFileNames();

            coll.ClearCollection();
            for (var index = 0; index < clsAuthor.ItemsCount(); index++)
                coll.AddItem(clsAuthor.GetItemAt(index));

            return coll.ItemsCount() != 0;
        }

        /// <summary>
        ///     The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        private bool GetAuthorFileNamesFromAuthorsList()
        {
            var clsAuthor = new AuthorsFileNames();
            var fileInput = new Input();
            var validate = new Validation();

            clsAuthor.ClearCollection();

            if (!validate.ValidateFileExists(BookListPaths.PathAuthorsNamesListFile, true)) return false;

            fileInput.ReadAuthorsNamesFromFile(BookListPaths.PathAuthorsNamesListFile);

            clsAuthor.SortCollection();
            return clsAuthor.ItemsCount() != 0;
        }

        /// <summary>
        ///     The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The AuthorFilePaths<see cref="IEnumerable{T}" />.</param>
        private bool GetAuthorFileNameFromPath(string[] authorFilePaths)
        {
            var clsAuthor = new AuthorsFileNames();

            if (authorFilePaths == null) return false;
            if (authorFilePaths.Length == 0) return false;

            clsAuthor.ClearCollection();

            var fileName = new string[authorFilePaths.Length];
            for (var index = 0; index < authorFilePaths.Length; index++)
            {
                var filePath = authorFilePaths[index].Trim();

                var temp = Path.GetFileName(filePath);
                fileName[index] = temp;
            }

            var coll = new AuthorsFileNames();
            return coll.AddArray(fileName);
        }

        /// <summary>
        ///     The UpdateAuthorsNamesWithFileNames.
        /// </summary>
        public bool UpdateAuthorsNamesWithFileNames()
        {
            return GetAuthorFileNamesFromAuthorsList() && GetAuthorFileNamesAddToAuthorsNamesList();
        }
    }
}