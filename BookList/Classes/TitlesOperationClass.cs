// BookList
// 
// TitlesOperationClass.cs
//
// art2m
// 
// 08    13   2020
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
using System.Linq;
using System.Reflection;

namespace BookList.Classes
{
    /// <summary>
    ///     Contains operations on book titles.
    /// </summary>
    public class TitlesOperationClass
    {
        /// <summary>
        ///     Declaration of message box object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declaration of validation class object.
        /// </summary>
        private readonly ValidationClass _valid = new ValidationClass();


        /// <summary>
        ///     Initializes a new instance of the <see cref="TitlesOperationClass" /> class.
        /// </summary>
        public TitlesOperationClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        /// Gets the book title from book data.
        /// </summary>
        /// <param name="bookData">The book data.</param>
        /// <returns>A list with book titles by author.</returns>
        public List<string> GetBookTitleFromBookData(IEnumerable<string> bookData)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var bookTitles = new List<string>();

            if (!bookData.Any()) return new List<string>();

            foreach (var item in bookData)
            {
                var title = SeparateBookTitle(item);

                bookTitles.Add(title);
            }

            return bookTitles;
        }

        /// <summary>
        /// Separates the book title from the other data.
        /// </summary>
        /// <param name="item">The book data title, series, volume.</param>
        /// <returns>Book title</returns>
        private string SeparateBookTitle(string item)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var getPos = item.IndexOf("(", StringComparison.Ordinal);
            var endIndex = getPos;
            const int startIndex = 0;

            if (endIndex < 1) return string.Empty;


            return item.Substring(startIndex, endIndex);
        }
    }
}