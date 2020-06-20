namespace BookList.Collections
{
    using System;
    using System.Collections.Generic;

    using JetBrains.Annotations;

    /// <summary>
    /// Defines the <see cref="UnformattedDataCollection" />.
    /// </summary>
    public static class UnformattedDataCollection
    {
        /// <summary>
        /// Defines the RawData.
        /// </summary>
        private static readonly List<string> RawData = new List<string>();

        /// <summary>
        /// The AddItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        public static void AddItem([NotNull] string value)
        {
            value = value.Trim();

            if (ContainsItem(value)) return;
            if (string.IsNullOrEmpty(value)) return;

            RawData.Add(value);
        }

        /// <summary>
        /// The ClearCollection.
        /// </summary>
        public static void ClearCollection()
        {
            RawData.Clear();
        }

        /// <summary>
        /// The ContainsItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool ContainsItem([NotNull] string value)
        {
            return RawData.Contains(value);
        }

        /// <summary>
        /// The GetAllItems.
        /// </summary>
        /// <returns>The <see cref="string[]" />.</returns>
        public static string[] GetAllItems()
        {
            var count = RawData.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var values = new string[count];

            for (var i = 0; i < count; i++) values[i] = RawData[i];

            // All OK.
            return values;
        }

        /// <summary>
        /// The GetItemAt.
        /// </summary>
        /// <param name="index">The index<see cref="int" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string GetItemAt(int index)
        {
            return RawData[index];
        }

        /// <summary>
        /// The GetItemIndex.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="int" />.</returns>
        public static int GetItemIndex(string value)
        {
            return RawData.IndexOf(value);
        }

        /// <summary>
        /// The GetItemsCount.
        /// </summary>
        /// <returns>The <see cref="int" />.</returns>
        public static int GetItemsCount()
        {
            return RawData.Count;
        }

        /// <summary>
        /// The RemoveItem.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool RemoveItem(string value)
        {
            return RawData.Remove(value);
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

            RawData.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        /// <summary>
        /// The SortCollection.
        /// </summary>
        public static void SortCollection()
        {
            RawData.Sort();
        }
    }
}
