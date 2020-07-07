// BookList
// 
// VolumeBookNamesNumbers.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 07    07   2020
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

namespace BookList.Collections
{
    /// <summary>
    ///     Holds the possible series volume or book number.
    /// </summary>
    public static class VolumeBookNamesNumbers
    {
        /// <summary>The string value of the word vol, volume or book and the number.</summary>
        private static readonly List<string> BookVolumeNameNumber = new List<string>();

        /// <summary>
        ///     Add a new <paramref name="item" /> to the collection.
        /// </summary>
        /// <param name="item">The item to be added to the collection.</param>
        public static void AddItem(string item)
        {
            if (ContainsItem(item))
            {
                return;
            }

            BookVolumeNameNumber.Add(item);
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            BookVolumeNameNumber.Clear();
        }

        /// <summary>
        ///     Check to see if the list all ready contains the <paramref name="item" />.
        /// </summary>
        /// <param name="item">The name of the <paramref name="item" /> to check for.</param>
        /// <returns>
        ///     <see langword="true" /> if list contains <paramref name="item" />
        ///     else false.
        /// </returns>
        public static bool ContainsItem(string item)
        {
            return BookVolumeNameNumber.Contains(item);
        }

        /// <summary>
        ///     Get all items contained in the collection.
        /// </summary>
        /// <returns>All items contained in the collection.</returns>
        public static string[] GetAllItems()
        {
            var count = BookVolumeNameNumber.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++) origPath[i] = BookVolumeNameNumber[i];

            // All OK.
            return origPath;
        }

        /// <summary>
        ///     Return the selected item at <paramref name="index" />.
        /// </summary>
        /// <param name="index"> The position number of the item to be returned.</param>
        /// <returns>Item at <paramref name="index" />.</returns>
        public static string GetItemAt(int index)
        {
            var count = BookVolumeNameNumber.Count - 1;
            if (index < 0 || index > count) return string.Empty;

            return BookVolumeNameNumber[index];
        }

        /// <summary>
        ///     return the index of the <paramref name="item" />.
        /// </summary>
        /// <param name="item">the item to find the index of.</param>
        /// <returns>
        ///     index of the <paramref name="item" /> if found.
        /// </returns>
        public static int GetItemIndex(string item)
        {
            return BookVolumeNameNumber.IndexOf(item);
        }

        /// <summary>
        ///     Gets the count of items contained in the collection.
        /// </summary>
        /// <returns>Count of items contained in the collection.</returns>
        public static int GetItemsCount()
        {
            return BookVolumeNameNumber.Count;
        }

        /// <summary>
        ///     Removes <paramref name="item" /> from collection.
        /// </summary>
        /// <param name="item">The item to be removed.</param>
        /// <returns>
        ///     True if removed else false.
        /// </returns>
        public static bool RemoveItem(string item)
        {
            return BookVolumeNameNumber.Remove(item);
        }


        /// <summary>
        ///     Remove item from collection.
        /// </summary>
        /// <param name="index">The position of the item to be removed.</param>
        /// <returns>
        ///     True if item removed else <see langword="false" />.
        /// </returns>
        public static bool RemoveItemAt(int index)
        {
            var count = BookVolumeNameNumber.Count - 1;

            if (index < 0 || index > count) return false;

            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            BookVolumeNameNumber.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        /// <summary>
        ///     Sort the collection.
        /// </summary>
        public static void SortCollection()
        {
            BookVolumeNameNumber.Sort();
        }
    }
}