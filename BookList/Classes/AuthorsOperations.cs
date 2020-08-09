// BookListCurrent
//
// AuthorsTextOperations.cs
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

using System.IO;
using System.Reflection;
using BookListCurrent.ClassesProperties;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="AuthorsTextOperations" /> .
    /// </summary>
    public class AuthorsTextOperations
    {
        private readonly MyMessageBox _msgBox = new MyMessageBox();
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        ///     Declare validation class object.
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///   <para></para>
        ///   <para>Initializes a new instance of the <see cref="AuthorsTextOperations" /> class.
        /// </para>
        /// </summary>
        public AuthorsTextOperations()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     add a dash to authors name so first middle and last name can be
        ///     identified by the program.
        /// </summary>
        /// <param name="author">
        ///     The author <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     The <see cref="System.String" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Local
        private string AddDash(string author)
        {
            var authorName = string.Empty;
            foreach (var letter in author)
            {
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());
            }

            return authorName;
        }

        /// <summary>
        /// add a dash to authors name so first middle and last name can be identified
        /// by the program.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        private string AddDashToAuthorName(string author)
        {
            var validate = new ValidationClass();

            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = string.Empty;

            foreach (var letter in author)
            {
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());
            }

            return authorName;
        }


        /// <summary>
        /// Add dash between authors first middle and last name. This allows the
        /// program to tell where each name begins and ends.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>Return the authors name with dashes installed.</returns>
        public string AddDashBetweenAuthorsFirstMiddleLastName(string author)
        {
            var validate = new ValidationClass();
            if (!validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = AddDashToAuthorName(author.Trim());

            return AddFileExtension(authorName);
        }


        /// <summary>
        ///     Add the file extension '.dat' to the file name.
        /// </summary>
        /// <param name="author">The file name to add file extension to.</param>
        /// <returns>File name with extension.</returns>
        private string AddFileExtension(string author)
        {
            if (!this._validate.ValidateStringIsNotNull(author)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(author)) return string.Empty;

            const string extension = ".dat";

            return string.Concat(author, extension);
        }

        /// <summary>
        ///     Make file name from authors name.
        /// </summary>
        /// <param name="author">
        ///     The author <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     Return the authors name with dashes installed.
        /// </returns>
        public string MakeAuthorFileName(string author)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(author)) return string.Empty;

            if (!this._validate.ValidateStringHasLength(author)) return string.Empty;

            var authorName = this.AddDash(author.Trim());
            var fileName = this.AddFileExtension(authorName);

            if (this.CheckFileNameHasExtension(fileName)) return fileName;

            this._msgBox.Msg = this._myMsg.MsgUnableToCreateAuthorFileName;
            this._msgBox.ShowErrorMessageBox();
            return string.Empty;
        }

        /// <summary>
        ///     Check to see if file name contains extension '.dat'.
        /// </summary>
        /// <param name="fileName">The authors name to check.</param>
        /// <returns>True if contains file extension '.dat' else false.</returns>
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
        ///     The fileName <see cref="System.String" /> .
        /// </param>
        /// <returns>
        ///     The <see cref="System.String" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public string SplitFileNameFormFileExtension(string fileName)
        {
            if (!this._validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            return !this._validate.ValidateStringHasLength(fileName) ? string.Empty : Path.GetExtension(fileName);
        }
    }
}