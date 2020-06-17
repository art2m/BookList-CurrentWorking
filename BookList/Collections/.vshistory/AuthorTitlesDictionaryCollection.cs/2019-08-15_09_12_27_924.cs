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

        public static bool ContainsValueItem(string author, string title)
        {
            var keyList = new List<string>(DicData.Keys);
            var valueList = new List<string>();

            foreach (var key in keyList.Where(key => key.Equals(author, StringComparison.CurrentCultureIgnoreCase)))
            {
                valueList = DicData[author];

                foreach (var value in valueList)
                {
                    return value.Equals(title, StringComparison.CurrentCultureIgnoreCase);
                }
            }

            return false;
        }


        public static List<string> GetValueAtKey(string author)
        {
            var keyList = new List<string>(DicData.Keys);
            var valueList = new List<string>();

            foreach (var key in keyList)
            {
                if (key.Equals(author, StringComparison.CurrentCultureIgnoreCase))
                {
                    return DicData[author];
                }
            }

            return new List<string>();
        }

        /// <summary>
        ///     Get the index of this  item.
        /// </summary>
        /// <param name="author">The item to get the index of.</param>
        /// <returns>the index or else -1.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static int GetItemIndex(string author)
        {
            var keyList = new List<string>(DicData.Keys);

            for (var index = 0; index < keyList.Count; index++)
            {
                var key = keyList[index];
                if (key.Equals(author, StringComparison.CurrentCultureIgnoreCase))
                {
                    return index;
                }
            }

            return -1;
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
        ///     Remove the item at selected index.
        /// </summary>
        /// <param name="author"></param>
        /// <returns>True if item is removed else false.</returns>
        /// <created>art2m,5/19/2019</created>
        /// <changed>art2m,5/19/2019</changed>
        public static bool RemoveKeyValue(string author)
        {
            DicData.Remove(author);

            return !ContainsKeyItem(author);
        }

        public static bool RemoveValueAtKey(string author)
        {

        }
    }
}