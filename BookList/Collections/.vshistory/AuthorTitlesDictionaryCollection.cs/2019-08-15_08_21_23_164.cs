using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Collections
{
    public static class AuthorTitlesDictionaryCollection
    {
        private static readonly Dictionary<string, List<string>> DicData = new Dictionary<string, List<string>>();

        // private static List<string> LstTitles = new List<string>();

        public static void AddItems(string author, List<string> titles)
        {
            DicData.Add(author, titles);

        }

        public static void ClearCollection()
        {
            DicData.Clear();
        }

        public static bool ContainsKeyItem(string author)
        {
            return DicData.ContainsKey(author);
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

        /// <summary>
        ///     Get item at the specified index.
        /// </summary>
        /// <return>The word at this index.</return>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static string GetItemAt(int index)
        {
            return WordsList[index];
        }

        /// <summary>
        ///     Get the index of this  item.
        /// </summary>
        /// <param name="word">The item to get the index of.</param>
        /// <returns>the index or else -1.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static int GetItemIndex(string word)
        {
            return WordsList.IndexOf(word);
        }

        /// <summary>
        ///     Get the count of items contained in the collection.
        /// </summary>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static int ItemsCount()
        {
            return DicData.Count;
        }

        /// <summary>
        ///     Remove the specified word.
        /// </summary>
        /// <param name="word"></param>
        /// <returns>true if removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static bool RemoveItem(string word)
        {
            return WordsList.Remove(word);
        }

        /// <summary>
        ///     Remove the item at selected index.
        /// </summary>
        /// <param name="author"></param>
        /// <returns>True if item is removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static bool RemoveKey(string author)
        {
            DicData.Remove(author);

            return !ContainsKeyItem(author);
        }

       

    }
}
