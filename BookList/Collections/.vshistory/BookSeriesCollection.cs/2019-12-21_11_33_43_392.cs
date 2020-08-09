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
            if (ContainsItem(item)) return;

            SeriesList.Add(item);
        }

        public void ClearCollection()
        {
            SeriesList.Clear();
        }

        public bool ContainsItem(string value)
        {
            throw new NotImplementedException();
        }

        public string[] GetAllItems()
        {
            throw new NotImplementedException();
        }

        public string GetItemAt(int index)
        {
            throw new NotImplementedException();
        }

        public int GetItemIndex(string value)
        {
            throw new NotImplementedException();
        }

        public int GetItemsCount()
        {
            throw new NotImplementedException();
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
