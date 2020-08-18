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

using System.Reflection;

using BookList.Collections;

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
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     <para></para>
        ///     <para>
        ///         Initializes a new instance of the <see cref="AuthorOperationsClass" /> class.
        ///     </para>
        /// </summary>
        public AuthorOperationsClass()
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
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var validate = new ValidationClass();
            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = AddDashToAuthorName(author.Trim());

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
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!_validate.ValidateStringIsNotNull(author)) return string.Empty;

            if (!_validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = AddDash(author.Trim());

            var clsFile = new FileClass();
            var fileName = clsFile.AddFileExtension(authorName);

            if (clsFile.CheckFileNameHasExtension(fileName)) return fileName;

            _msgBox.Msg = "Unable to create the authors file name.";
            _msgBox.ShowErrorMessageBox();
            return string.Empty;
        }

        /// <summary>
        ///     Check that the list of author names matches the names of all author files
        ///     contained in the bookList  Authors directory.
        /// </summary>
        public void UpdateAuthorsNamesWithFileNames()
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var clsFile = new FileClass();
            clsFile.GetAuthorFileNamesFromAuthorsList();
            clsFile.GetAllAuthorFilePathsContainedInAuthorDirectory();
            GetAuthorFileNamesAddToAuthorsNamesList();
        }


        /// <summary>
        ///     Add item to the AuthorsFileName collection.
        /// </summary>
        /// <param name="fileName">The file name<see cref="string" />.</param>
        public void AddAuthorFileNamesToCollection(string fileName)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

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
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var collList = new AuthorNamesCollection();
            var collFile = new AuthorsFileNamesCollection();

            collList.ClearCollection();
            for (var index = 0; index < collFile.GetItemsCount(); index++)
                collList.AddItem(collFile.GetItemAt(index));
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
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var validate = new ValidationClass();

            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = string.Empty;

            foreach (var letter in author)
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());

            return authorName;
        }
    }
}