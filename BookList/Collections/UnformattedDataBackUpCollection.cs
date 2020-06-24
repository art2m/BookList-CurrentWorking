using System;
using System.Collections.Generic;
using BookList.Interfaces;
using JetBrains.Annotations;

namespace BookList.Collections
{
    /// <summary>
    /// Defines the <see cref="UnformattedDataCollection" />.
    /// Used By FormattedBookData.cs As a backup to UnformattedDataCollection.cs This data has not been
    /// modified by the user sot we can role back changes.
    /// </summary>
    public static class UnformattedDataBackUpCollection
    {
        private static readonly List<string> RawDataBkUp = new List<string>();

        public static void AddItem([NotNull] string value)
        {
            value = value.Trim();

            if (ContainsItem(value)) return;
            if (string.IsNullOrEmpty(value)) return;

            RawDataBkUp.Add(value);
        }

        public static void ClearCollection()
        {
            RawDataBkUp.Clear();
        }

        public static bool ContainsItem(string value)
        {
            return RawDataBkUp.Contains(value);
        }

        public static string[] GetAllItems()
        {
            var count = RawDataBkUp.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var values = new string[count];

            for (var i = 0; i < count; i++) values[i] = RawDataBkUp[i];

            // All OK.
            return values;
        }

        public static string GetItemAt(int index)
        {
            return RawDataBkUp[index];
        }

        public static int GetItemIndex(string value)
        {
            return RawDataBkUp.IndexOf(value);
        }

        public static int GetItemsCount()
        {
            return RawDataBkUp.Count;
        }

        public static bool RemoveItem(string value)
        {
            return RawDataBkUp.Remove(value);
        }

        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            RawDataBkUp.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        public static void SortCollection()
        {
            RawDataBkUp.Sort();
        }
    }
}