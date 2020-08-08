using System;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace BookList.Collections
{
    public static class UnformattedDataCollection
    {
        private static readonly List<string> RawData = new List<string>();

        public static void AddItem([NotNull] string value)
        {
            value = value.Trim();

            if (ContainsItem(value)) return;
            if (string.IsNullOrEmpty(value)) return;

            RawData.Add(value);
        }

        public static void ClearCollection()
        {
            RawData.Clear();
        }

        public static bool ContainsItem([NotNull] string value)
        {
            return RawData.Contains(value);
        }

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

        public static string GetItemAt(int index)
        {
            return RawData[index];
        }

        public static int GetItemIndex(string value)
        {
            return RawData.IndexOf(value);
        }

        public static int GetItemsCount()
        {
            return RawData.Count;
        }

        public static bool RemoveItem(string value)
        {
            return RawData.Remove(value);
        }

        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            RawData.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        public static void SortCollection()
        {
            RawData.Sort();
        }
    }
}