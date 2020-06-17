namespace BookList.Collections
{
    using System;
    using System.Collections.Generic;

    public class AuthorsFileNamesCollection
    {
        /// <summary>
        ///     Contains collection of Book titles.
        /// </summary>
        private static readonly List<string> AuthorFileNames = new List<string>();

        public static void AddItem(string word)
        {
            if (ContainsItem(word))
            {
                return;
            }

            AuthorFileNames.Add(word);
        }

        public static void ClearCollection()
        {
            AuthorFileNames.Clear();
        }

        public static bool ContainsItem(string word)
        {
            return AuthorFileNames.Contains(word);
        }

        public static string[] GetAllItems()
        {
            var count = AuthorFileNames.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var origPath = new string[count];

            for (var i = 0; i < count; i++)
            {
                origPath[i] = AuthorFileNames[i];
            }

            // All OK.
            return origPath;
        }

        public static string GetItemAt(int index)
        {
            return AuthorFileNames[index];
        }

        public static int GetItemIndex(string word)
        {
            return AuthorFileNames.IndexOf(word);
        }

        public static int ItemsCount()
        {
            return AuthorFileNames.Count;
        }

        public static bool RemoveItem(string word)
        {
            return AuthorFileNames.Remove(word);
        }

        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            AuthorFileNames.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        public static void SortCollection()
        {
            AuthorFileNames.Sort();
        }
    }
}