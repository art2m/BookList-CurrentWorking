namespace BookList.Collections
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Defines the <see cref="AuthorTitlesDictionaryCollection" />
    /// </summary>
    public static class AuthorTitlesDictionaryCollection
    {
        /// <summary>
        /// Defines the DicData
        /// </summary>
        private static readonly Dictionary<string, List<string>> DicData = new Dictionary<string, List<string>>();

        /// <summary>
        /// Adds the items.
        /// </summary>
        /// <param name="author">The author key.</param>
        /// <param name="titles">The titles for each author key.</param>
        public static void AddItems(string author, List<string> titles)
        {
            DicData.Add(author, titles);
        }

        /// <summary>
        /// Clears the collection.
        /// </summary>
        public static void ClearCollection()
        {
            DicData.Clear();
        }

        /// <summary>
        /// Determines whether [contains key item] [the specified author].
        /// </summary>
        /// <param name="author">The author.</param>
        /// <returns>The <see cref="bool"/></returns>
        public static bool ContainsKeyItem(string author)
        {
            return DicData.ContainsKey(author);
        }

        /// <summary>
        /// Determines whether [contains value item] [the specified author].
        /// </summary>
        /// <param name="author">The author.</param>
        /// <param name="title">The title.</param>
        /// <returns>The <see cref="bool"/></returns>
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

        /// <summary>
        /// Gets the value at key.
        /// </summary>
        /// <param name="author">The author.</param>
        /// <returns>List of titles for this author.</returns>
        public static List<string> GetValueAtKey(string author)
        {
            var keyList = new List<string>(DicData.Keys);
            

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
        /// Get the index of this  item.
        /// </summary>
        /// <param name="author">The item to get the index of.</param>
        /// <returns>the index or else -1.</returns>
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
        /// Get the count of Key items contained in the collection.
        /// </summary>
        /// <returns>The <see cref="int"/></returns>
        public static int ItemsCount()
        {
            return DicData.Count;
        }

        /// <summary>
        /// Remove the item at selected index.
        /// </summary>
        /// <param name="author">The author</param>
        /// <returns>True if item is removed else false.</returns>
        public static bool RemoveKeyValue(string author)
        {
            DicData.Remove(author);

            return !ContainsKeyItem(author);
        }

        /// <summary>
        /// Removes the value at key.
        /// </summary>
        /// <param name="author">The author.</param>
        /// <param name="title">The title.</param>
        /// <returns>true if title removed from collection else false.</returns>
        public static bool RemoveValueAtKey(string author, string title)
        {
            var keyList = new List<string>(DicData.Keys);
            var valueList = new List<string>();

            foreach (var key in keyList.Where(key => key.Equals(author, StringComparison.CurrentCultureIgnoreCase)))
            {
                valueList = DicData[author];

                foreach (var value in valueList.Where(value =>
                    value.Equals(title, StringComparison.CurrentCultureIgnoreCase)))
                {
                    valueList.Remove(title);
                    if (valueList.Contains(title)) continue;
                    var retVal = RemoveKeyValue(author);

                    if (retVal) AddItems(author, valueList);
                    return true;
                }

                return false;
            }

            return false;
        }
    }
}
