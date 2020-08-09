// BookList
// 
// AuthorsOperations.cs
// 
// art2m
// 
// 08    08   2020
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
        /// Deceleration of Message Box Object.
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// Deceleration of Messages Object.
        /// </summary>
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        ///     Declare validation class Object.
        /// </summary>
        private readonly Validation _validate = new Validation();

        /// <summary>
        ///     <para></para>
        ///     <para>
        ///         Initializes a new instance of the <see cref="AuthorsOperations" /> class.
        ///     </para>
        /// </summary>
        public AuthorsOperations()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Add dash between authors first middle and last name. This allows the
        ///     program to tell where each name begins and ends.
        /// </summary>
        /// <param name="author">The Author<see cref="string" />.</param>
        /// <returns>Return the authors name with dashes installed.</returns>
        public string AddDashBetweenAuthorsFirstMiddleLastName(string author)
        {
            var validate = new Validation();
            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = AddDashToAuthorName(author.Trim());

            return AddFileExtension(authorName);
        }

        /// <summary>
        ///     The GetAllAuthorFilePathsContainedInAuthorDirectory.
        /// </summary>
        public void GetAllAuthorFilePathsContainedInAuthorDirectory()
        {
            var authorFilePaths = GetAllFileNamesContainedInAuthorsDirectory
                (BookListPaths.PathAuthorsDirectory);

            GetAuthorFileNameFromPath(authorFilePaths);
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
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!_validate.ValidateStringIsNotNull(author)) return string.Empty;

            if (!_validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = AddDash(author.Trim());
            var fileName = AddFileExtension(authorName);

            if (CheckFileNameHasExtension(fileName)) return fileName;

            _msgBox.Msg = _myMsg.MsgUnableToCreateAuthorFileName;
            _msgBox.ShowErrorMessageBox();
            return string.Empty;
        }

        /// <summary>
        ///     Return the author name and the .dat extension.
        /// </summary>
        /// <param name="fileName">
        ///     The file Name <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     The <see cref="System.String" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public string SplitFileNameFormFileExtension(string fileName)
        {
            if (!_validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            return !_validate.ValidateStringHasLength(fileName) ? string.Empty : Path.GetExtension(fileName);
        }

        /// <summary>
        ///     The UpdateAuthorsNamesWithFileNames.
        /// </summary>
        public void UpdateAuthorsNamesWithFileNames()
        {
            GetAuthorFileNamesFromAuthorsList();
            GetAllAuthorFilePathsContainedInAuthorDirectory();
            GetAuthorFileNamesAddToAuthorsNamesList();
        }

        /// <summary>
        ///     The AddAuthorFileNamesToCollection.
        /// </summary>
        /// <param name="fileName">The file name<see cref="string" />.</param>
        private static void AddAuthorFileNamesToCollection(string fileName)
        {
            fileName = fileName.Trim();

            if (string.IsNullOrEmpty(fileName)) return;
            if (string.IsNullOrWhiteSpace(fileName)) return;

            var coll = new AuthorsFileNames();

            if (coll.ContainsItem(fileName)) return;
            coll.AddItem(fileName);
        }

        /// <summary>
        ///     The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The directory path<see cref="string" />.</param>
        /// <returns>The <see cref="List{T}" />.</returns>
        private static IEnumerable<string> GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");
            var fileNames = new List<string>(fileArray);

            return fileNames;
        }

        /// <summary>
        ///     The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The author file paths<see cref="IEnumerable{string}" />.</param>
        private static void GetAuthorFileNameFromPath(IEnumerable<string> authorFilePaths)
        {
            var collFile = new AuthorsFileNames();

            collFile.ClearCollection();

            foreach (var authorPath in authorFilePaths)
            {
                var filePath = authorPath.Trim();

                var fileName = Path.GetFileName(filePath);

                AddAuthorFileNamesToCollection(fileName);
            }
        }

        /// <summary>
        ///     Make the list of author names match the FileNames.
        /// </summary>
        private static void GetAuthorFileNamesAddToAuthorsNamesList()
        {
            var collList = new AuthorNamesList();
            var collFile = new AuthorsFileNames();

            collList.ClearCollection();
            for (var index = 0; index < collFile.ItemsCount(); index++)
                collList.AddItem(collFile.GetItemAt(index));
        }

        /// <summary>
        ///     The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        private static void GetAuthorFileNamesFromAuthorsList()
        {
            var coll = new AuthorNamesList();
            var input = new Input();

            var authorNames = input.ReadAuthorNamesFromFile(BookListPaths.PathAuthorsNamesListFile);

            coll.ClearCollection();
            foreach (var name in authorNames) coll.AddItem(name);
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
            var validate = new Validation();

            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = string.Empty;

            foreach (var letter in author)
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());

            return authorName;
        }
        /// <summary>
        ///     Add the file extension '.dat' to the file name.
        /// </summary>
        /// <param name="author">The file name to add file extension to.</param>
        /// <returns>file name with extension.</returns>
        private string AddFileExtension(string author)
        {
            if (!_validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!_validate.ValidateStringHasLength(author)) return string.Empty;

            const string extension = ".dat";

            return string.Concat(author, extension);
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
    }
}