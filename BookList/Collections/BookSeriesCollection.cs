// BookList
// 
// BookSeriesCollection.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 12  21  2019
// 
// 12  21   2019
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

namespace BookList.Collections
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Collection class to hold all series books found in authors file.
    /// </summary>
    public static class BookSeriesCollection
    {
        /// <summary>
        /// Defines the SeriesList.
        /// </summary>
        private static readonly List<string> SeriesList = new List<string>();

        /// <summary>
        /// The AddItem.
        /// </summary>
        /// <param name="item">The item<see cref="string"/>.</param>
        public static void AddItem(string item)
        {
            if (ContainsItem(item)) return;

            SeriesList.Add(item);
        }

        /// <summary>
        /// The ClearCollection.
        /// </summary>
        public static void ClearCollection()
        {
            SeriesList.Clear();
        }

        /// <summary>
        /// Check to see if item is all ready in the list.
        /// </summary>
        /// <param name="value">The item to check if contained in the list.</param>
        /// <returns>true if in list else false.</returns>
        public static bool ContainsItem(string value)
        {
            return SeriesList.Contains(value);
        }

        /// <summary>
        /// The GetAllItems.
        /// </summary>
        /// <returns>The <see cref="string[]"/>.</returns>
        public static string[] GetAllItems()
        {
            var count = SeriesList.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var bookInfo = new string[count];

            for (var i = 0; i < count; i++) bookInfo[i] = SeriesList[i];

            // All OK.
            return bookInfo;
        }

        /// <summary>
        /// The GetItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="string"/>.</returns>
        public static string GetItemAt(int index)
        {
            return SeriesList[index];
        }

        /// <summary>
        /// The GetItemIndex.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="int"/>.</returns>
        public static int GetItemIndex(string value)
        {
            return SeriesList.IndexOf(value);
        }

        /// <summary>
        /// The GetItemsCount.
        /// </summary>
        /// <returns>The <see cref="int"/>.</returns>
        public static int GetItemsCount()
        {
            return SeriesList.Count;
        }

        /// <summary>
        /// The RemoveItem.
        /// </summary>
        /// <param name="value">The value<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool RemoveItem(string value)
        {
            return SeriesList.Remove(value);
        }

        /// <summary>
        /// The RemoveItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            SeriesList.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        /// <summary>
        /// The SortCollection.
        /// </summary>
        public static void SortCollection()
        {
            SeriesList.Sort();
        }
    }
}
