// Art2MSpell
//
// BookInfoCollection.cs
//
// Art2M
//
// art2m@live.com
//
// 05  20  2019
//
// 05  20   2019
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
    /// This contains the titles of all books read.
    /// </summary>
    public static class BookInfoCollection
    {
        /// <summary>
        /// Defines the WordsList.
        /// </summary>
        private static readonly List<string> WordsList = new List<string>();

        /// <summary>
        /// The AddItem.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        public static void AddItem(string word)
        {
            if (ContainsItem(word))
            {
                return;
            }

            WordsList.Add(word);
        }

        /// <summary>
        /// The ClearCollection.
        /// </summary>
        public static void ClearCollection()
        {
            WordsList.Clear();
        }

        /// <summary>
        /// The ContainsItem.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool ContainsItem(string word)
        {
            return WordsList.Contains(word);
        }

        /// <summary>
        /// The GetAllItems.
        /// </summary>
        /// <returns>The <see cref="string[]" />.</returns>
        public static string[] GetAllItems()
        {
            var count = WordsList.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++) origPath[i] = WordsList[i];

            // All OK.
            return origPath;
        }

        /// <summary>
        /// The GetItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string GetItemAt(int index)
        {
            return WordsList[index];
        }

        /// <summary>
        /// The GetItemIndex.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int GetItemIndex(string word)
        {
            return WordsList.IndexOf(word);
        }

        /// <summary>
        /// The ItemsCount.
        /// </summary>
        /// <returns>The <see cref="int" />.</returns>
        public static int ItemsCount()
        {
            return WordsList.Count;
        }

        /// <summary>
        /// The RemoveItem.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool RemoveItem(string word)
        {
            return WordsList.Remove(word);
        }

        /// <summary>
        /// The RemoveItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            WordsList.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        /// <summary>
        /// The SortCollection.
        /// </summary>
        public static void SortCollection()
        {
            WordsList.Sort();
        }
    }
}
