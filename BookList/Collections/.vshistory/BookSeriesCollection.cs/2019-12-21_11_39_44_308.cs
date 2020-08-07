using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookList.Interfaces;

namespace BookList.Collections

{
    class BookSeriesCollection : BookList.Interfaces.IMyCollection
    {
        private static readonly List<string> SeriesList = new List<string>();

        public void AddItem(string item)
        {
            if (this.ContainsItem(item)) return;

            SeriesList.Add(item);
        }

        public void ClearCollection()
        {
            SeriesList.Clear();
        }

        public bool ContainsItem(string value)
        {
            return SeriesList.Contains(value);
        }

        public string[] GetAllItems()
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

        public string GetItemAt(int index)
        {
            return SeriesList[index];
        }

        public int GetItemIndex(string value)
        {
            return SeriesList.IndexOf(value);
        }

        public int GetItemsCount()
        {
            return SeriesList.cou
        }

        public bool RemoveItem(string value)
        {
            throw new NotImplementedException();
        }

        public bool RemoveItemAt(int index)
        {
            throw new NotImplementedException();
        }

        public void SortCollection()
        {
            throw new NotImplementedException();
        }
    }
}
