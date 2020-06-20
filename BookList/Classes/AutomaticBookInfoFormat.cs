// BookList
//
// AutomaticBookInfoFormat.cs
//
// Art2M
//
// art2m@live.com
//
// 12  21  2019
//
// 12  20   2019
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

    using BookList.Collections;

    /// <summary>
    /// Defines the <see cref="AutomaticBookInfoFormat" />.
    /// </summary>
    public class AutomaticBookInfoFormat
    {
        /// <summary>
        /// The AutoformattingNonSeriesBookInformation.
        /// </summary>
        public void AutoformattingNonSeriesBookInformation()
        {
            this.GetListOfSeriesReadForThisAuthor();
            this.GetListOfBooksContainedInSeries();
        }

        /// <summary>
        /// The GetListOfSeriesReadForThisAuthor.
        /// </summary>
        private void GetListOfSeriesReadForThisAuthor()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The GetListOfBooksContainedInSeries.
        /// </summary>
        private void GetListOfBooksContainedInSeries()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The AutoformattingSeriesBookInformation.
        /// </summary>
        public void AutoformattingSeriesBookInformation()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The CheckIfBookIsSeries.
        /// </summary>
        /// <param name="bookInfo">The bookInfo<see cref="string" />.</param>
        private void CheckIfBookIsSeries(string bookInfo)
        {
            var book = bookInfo.ToUpper();
            var find = "book";
            find = find.ToUpper();

            if (book.Contains(find))
            {
                //var charBookInfo = bookInfo.ToCharArray();

                foreach (var item in book)
                {
                    if (char.IsDigit(item))
                    {
                        this.SaveBookInfoAsSeries(book);
                        continue;
                    }

                    this.SaveBookAsNonSeries(book);
                }
            }
        }

        /// <summary>
        /// Entry point for formatting the book info data.
        /// </summary>
        /// <param name="unformatted">List containing all the books read by this author.</param>
        public void FormatUnformattedBookInformation(List<string> unformatted)
        {
            foreach (var bookInfo in unformatted) this.CheckIfBookIsSeries(bookInfo);
        }

        /// <summary>
        /// The SaveBookAsNonSeries.
        /// </summary>
        /// <param name="book">The book<see cref="string"/>.</param>
        private void SaveBookAsNonSeries(string book)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// The SaveBookInfoAsSeries.
        /// </summary>
        /// <param name="book">The book<see cref="string"/>.</param>
        private void SaveBookInfoAsSeries(string book)
        {
            BookSeriesCollection.AddItem(book);
        }
    }
}
