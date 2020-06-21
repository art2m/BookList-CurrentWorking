using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookList.Interfaces;

namespace BookList.Collections

{
    /// ********************************************************************************
    /// <summary>
    /// 
    /// </summary>
    /// ********************************************************************************
    public static class BookSeriesCollection
    {
        private static readonly List<string> SeriesList = new List<string>();

        public static void AddItem(string item)
        {
            if (ContainsItem(item)) return;

            SeriesList.Add(item);
        }

        public static void ClearCollection()
        {
            SeriesList.Clear();
        }

        public static bool ContainsItem(string value)
        {
            return SeriesList.Contains(value);
        }

        public static string[] GetAllItems()
        {
            var count = SeriesList.Count;

            // No genre Folders Found
            if (count - 1 < 1)
            {
                return Array.Empty<string>();
            }

            var bookInfo = new string[count];

            for (var i = 0; i < count; i++)
            {
                bookInfo[i] = SeriesList[i];
            }

            // All OK.
            return bookInfo;
        }

        public static string GetItemAt(int index)
        {
            return SeriesList[index];
        }

        public static int GetItemIndex(string value)
        {
            return SeriesList.IndexOf(value);
        }

        public static int GetItemsCount()
        {
            return SeriesList.Count;
        }

        public static bool RemoveItem(string value)
        {
            return SeriesList.Remove(value);
        }

        public static bool RemoveItemAt(int index)
        {
            // Get item to be removed for check that it is gone.
            var item = GetItemAt(index);

            SeriesList.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !ContainsItem(item);
        }

        public static void SortCollection()
        {
            SeriesList.Sort();
        }
    }
}
