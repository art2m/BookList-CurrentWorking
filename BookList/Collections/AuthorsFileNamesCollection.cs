namespace BookList.Collections
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Defines the <see cref="AuthorsFileNamesCollection" />.
    /// </summary>
    public static class AuthorsFileNamesCollection
    {
        /// <summary>
        /// Contains collection of Book titles..
        /// </summary>
        private static readonly List<string> AuthorFileNames = new List<string>();

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

            AuthorFileNames.Add(word);
        }

        /// <summary>
        /// The ClearCollection.
        /// </summary>
        public static void ClearCollection()
        {
            AuthorFileNames.Clear();
        }

        /// <summary>
        /// The ContainsItem.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool ContainsItem(string word)
        {
            return AuthorFileNames.Contains(word);
        }

        /// <summary>
        /// The GetAllItems.
        /// </summary>
        /// <returns>The <see cref="string[]" />.</returns>
        public static string[] GetAllItems()
        {
            var count = AuthorFileNames.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++) origPath[i] = AuthorFileNames[i];

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
            return AuthorFileNames[index];
        }

        /// <summary>
        /// The GetItemIndex.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int GetItemIndex(string word)
        {
            return AuthorFileNames.IndexOf(word);
        }

        /// <summary>
        /// The ItemsCount.
        /// </summary>
        /// <returns>The <see cref="int" />.</returns>
        public static int ItemsCount()
        {
            return AuthorFileNames.Count;
        }

        /// <summary>
        /// The RemoveItem.
        /// </summary>
        /// <param name="word">The word<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool RemoveItem(string word)
        {
            return AuthorFileNames.Remove(word);
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

            AuthorFileNames.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        /// <summary>
        /// The SortCollection.
        /// </summary>
        public static void SortCollection()
        {
            AuthorFileNames.Sort();
        }
    }
}
