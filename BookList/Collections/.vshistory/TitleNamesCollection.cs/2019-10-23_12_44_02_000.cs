// Art2MSpell
//
// TitleNamesCollection.cs
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
    public static class TitleNamesCollection

    {
        private static readonly List<string> WordsList = new List<string>();

        public static void AddItem(string word)
        {
            if (ContainsItem(word))
            {
                return;
            }

            WordsList.Add(word);
        }

        public static void ClearCollection()
        {
            WordsList.Clear();
        }

        public static bool ContainsItem(string word)
        {
            return WordsList.Contains(word);
        }

        public static string[] GetAllItems()
        {
            var count = WordsList.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++)
            {
                origPath[i] = WordsList[i];
            }

            // All OK.
            return origPath;
        }

        public static string GetItemAt(int index)
        {
            return WordsList[index];
        }

        public static int GetItemIndex(string word)
        {
            return WordsList.IndexOf(word);
        }

        public static int ItemsCount()
        {
            return WordsList.Count;
        }

        public static bool RemoveItem(string word)
        {
            return WordsList.Remove(word);
        }

        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            WordsList.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        public static void SortCollection()
        {
            WordsList.Sort();
        }
    }
}