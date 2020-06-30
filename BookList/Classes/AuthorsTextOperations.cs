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
        /// add a dash to authors name so first middle and last name can be identified
        /// by the program.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        private static string AddDashToAuthorName(string author)
        {
            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(author)) return string.Empty;

            var authorName = string.Empty;
            foreach (var letter in author)
                authorName = string.Concat(authorName, char.IsWhiteSpace(letter) ? "-" : letter.ToString());

            return authorName;
        }

        /// <summary>
        /// Return the authors name with the .dat extension to be used as the file name.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        private static string AddFileExtension(string author)
        {
            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(author)) return string.Empty;
            const string extension = ".dat";

            return string.Concat(author, extension);
        }

        /// <summary>
        /// Add dash between authors first middle and last name. This allows the
        /// program to tell where each name begins and ends.
        /// </summary>
        /// <param name="author">The author<see cref="string" />.</param>
        /// <returns>Return the authors name with dashes installed.</returns>
        public static string AddDashBetweenAuthorsFirstMiddleLastName(string author)
        {
            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(author)) return string.Empty;

            var authorName = AddDashToAuthorName(author.Trim());

            return AddFileExtension(authorName);
        }

        /// <summary>
        /// Return the author name and the .dat extension.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string SplitFileNameFormFileExtension(string fileName)
        {
            var temp = fileName.Split('.');

            return temp.Length < 1 ? fileName : temp[0];
        }
    }
}