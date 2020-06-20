// BookList
// 
// AuthorsTextOperations.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 11  09  2019
// 
// 11  09   2019
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

namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AuthorsTextOperations" />.
    /// </summary>
    public class AuthorsTextOperations
    {
        /// <summary>
        /// The AddDashToAuthorName.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string AddDashToAuthorName(string author)
        {
            var authorName = string.Empty;
            foreach (var letter in author)
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());

            return authorName;
        }

        /// <summary>
        /// The AddFileExtension.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string AddFileExtension(string author)
        {
            const string Ext = ".dat";

            return string.Concat(author, Ext);
        }

        /// <summary>
        /// The AddUnderscoreBetweenAuthorNames.
        /// </summary>
        /// <param name="nameFirst">The nameFirst<see cref="string" />.</param>
        /// <param name="nameSecond">The nameSecond<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string AddUnderscoreBetweenAuthorNames(string nameFirst, string nameSecond)
        {
            var fileName = string.Concat(nameFirst, "_");
            fileName = string.Concat(fileName, nameSecond);
            return fileName;
        }

        /// <summary>
        /// The BookAuthorName.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string BookAuthorName(string author)
        {
            if (string.IsNullOrEmpty(author.Trim())) return string.Empty;

            var authorName = this.AddDashToAuthorName(author.Trim());

            return this.AddFileExtension(author);
        }

        /// <summary>
        /// The BookAuthorName.
        /// </summary>
        /// <param name="authorFirst">The authorFirst<see cref="string" />.</param>
        /// <param name="authorSecond">The authorSecond<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string BookAuthorName(string authorFirst, string authorSecond)
        {
            if (string.IsNullOrEmpty(authorFirst.Trim())) return string.Empty;
            if (string.IsNullOrEmpty(authorSecond.Trim())) return string.Empty;

            var authorNameFirst = authorFirst.Trim();
            authorNameFirst = this.AddDashToAuthorName(authorNameFirst);

            var authorNameSecond = authorSecond.Trim();
            authorNameSecond = this.AddDashToAuthorName(authorNameSecond);

            var fileName = this.AddUnderscoreBetweenAuthorNames(authorFirst, authorNameSecond);

            return this.AddFileExtension(fileName);
        }

        /// <summary>
        /// The BookAuthorName.
        /// </summary>
        /// <param name="authorFirst">The authorFirst<see cref="string" />.</param>
        /// <param name="authorSecond">The authorSecond<see cref="string" />.</param>
        /// <param name="authorThird">The authorThird<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string BookAuthorName(string authorFirst, string authorSecond, string authorThird)
        {
            if (string.IsNullOrEmpty(authorFirst)) return string.Empty;
            if (string.IsNullOrEmpty(authorSecond)) return string.Empty;
            if (string.IsNullOrEmpty(authorThird)) return string.Empty;

            authorFirst = authorFirst.Trim();
            authorFirst = this.AddDashToAuthorName(authorFirst);

            authorSecond = authorSecond.Trim();
            authorSecond = this.AddDashToAuthorName(authorSecond);

            authorThird = authorThird.Trim();
            authorThird = this.AddDashToAuthorName(authorThird);

            var fileName = this.AddUnderscoreBetweenAuthorNames(authorFirst, authorSecond);
            fileName = this.AddUnderscoreBetweenAuthorNames(fileName, authorThird);

            return this.AddFileExtension(fileName);
        }

        /// <summary>
        /// The CheckForMultipleAuthors.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public bool CheckForMultipleAuthors(string author)
        {
            return author.Contains("_");
        }

        /// <summary>
        /// The GetAuthorNameFromFileName.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string GetAuthorNameFromFileName(string fileName)
        {
            var name = SplitFileNameFormFileExtension(fileName);

            // TODO: remove '-' from author first last name. check for more then one author.

            var author = ReplaceFirstLatNameSeparatorWithSpace(name);

            return author;
        }

        /// <summary>
        /// The GetTheIndexOfAuthorNamesSeparator.
        /// </summary>
        /// <param name="name">The name<see cref="string" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public int GetTheIndexOfAuthorNamesSeparator(string name)
        {
            var index = name.IndexOf("_", StringComparison.Ordinal);

            return index;
        }

        /// <summary>
        /// The ReplaceFirstLatNameSeparatorWithSpace.
        /// </summary>
        /// <param name="name">The name<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string ReplaceFirstLatNameSeparatorWithSpace(string name)
        {
            var temp = new char();
            var author = string.Empty;

            foreach (var letter in name)
            {
                switch (letter)
                {
                    case '-':
                        temp = ' ';
                        break;
                    default:
                        temp = letter;
                        break;
                }

                author = string.Concat(author, temp.ToString());
            }

            return author;
        }

        /// <summary>
        /// The SplitAuthorsAtSeperator.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <param name="names">The names<see cref="string" />.</param>
        /// <returns>The <see cref="List{string}" />.</returns>
        public List<string> SplitAuthorsAtSeperator(int index, string names)
        {
            var authorsNames = new List<string>();

            var authors = names.Split('_');

            foreach (var name in authors) authorsNames.Add(name);

            return authorsNames;
        }

        /// <summary>
        /// The SplitFileNameFormFileExtension.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string SplitFileNameFormFileExtension(string fileName)
        {
            var temp = fileName.Split('.');

            return temp.Length < 1 ? fileName : temp[0];
        }

        /// <summary>
        /// The SplitMultipleAuthors.
        /// </summary>
        /// <param name="authors">The authors<see cref="string" />.</param>
        /// <returns>The <see cref="List{string}" />.</returns>
        public List<string> SplitMultipleAuthors(string authors)
        {
            var authorNames = new List<string>();

            var retVal = this.CheckForMultipleAuthors(authors);

            if (!retVal)
            {
                authorNames.Add(authors);
                return authorNames;
            }

            var index = this.GetTheIndexOfAuthorNamesSeparator(authors);

            authorNames = this.SplitAuthorsAtSeperator(index, authors);

            // TODO: this splits two authors names, Should check for third author?
            return authorNames;
        }

        /// <summary>
        /// The SplitStringAtStartOfBookTitle.
        /// </summary>
        public static void SplitStringAtStartOfBookTitle()
        {
        }
    }
}
