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
    using System.Collections.Generic;

    /// <summary>
    ///     Defines the <see cref="AutomaticBookInfoFormat" />
    /// </summary>
    public class AutomaticBookInfoFormat
    {
        /// <summary>
        ///     The CheckIfBookIsSeries
        /// </summary>
        /// <param name="bookInfo">The bookInfo<see cref="string" /></param>
        /// <returns>The <see cref="bool" /></returns>
        private void CheckIfBookIsSeries(string bookInfo)
        {
            var book = bookInfo.ToUpper();
            var find = "book";
            find = find.ToUpper();

            if (book.Contains(find))
            {
                var charBookInfo = bookInfo.ToCharArray();

                foreach (char item in charBookInfo )
                {
                    if item.
                }
            }
        }

        /// <summary>
        ///     The FormatUnformattedBookInformation
        /// </summary>
        /// <param name="unformatted">The unformatted<see cref="List{string}" /></param>
        /// <returns>The <see cref="List{string}" /></returns>
        public List<string> FormatUnformattedBookInformation(List<string> unformatted)
        {
            var bookFormatted = new List<string>();

            foreach (var bookInfo in unformatted)
            {
               
            }

            return bookFormatted;
        }
    }
}