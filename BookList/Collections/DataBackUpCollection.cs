// BookListCurrent
//
// DataBackUp.cs
//
// art2m
//
// art2m
//
// 07    20   2020
//
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
//
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>

using System.Collections.Generic;

using BookList.Classes;
using BookList.Interfaces;

using JetBrains.Annotations;

namespace BookList.Collections
{
    /// <summary>
    ///     Collection to hold backup book information data before being changed.
    /// </summary>
    public class DataBackUpCollection : IMyCollection
    {
        /// <summary>
        ///     List containing the data before being changed.
        /// </summary>
        private static  List<string> _coll = new List<string>();

        /// <summary>
        ///     Declare validation class object.
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Add new item to the collection.
        /// </summary>
        public bool AddItem([NotNull] string value)
        {
            value = value.Trim();

            if (!this._validate.ValidateStringIsNotNull(value)) return false;
            if (!this._validate.ValidateStringHasLength(value)) return false;

            if (this.ContainsItem(value)) return false;
            if (string.IsNullOrEmpty(value)) return false;

            _coll.Add(value);
            return true;
        }

        /// <summary>
        /// Fill collection from an array
        /// </summary>
        /// <param name="fileList"></param>
        /// <returns>True if list filled else false.</returns>
        public bool AddList(List<string> fileList)
        {
            if (fileList == null) return false;
            if (fileList.Count < 1) return false;

            _coll.Clear();

            _coll = new List<string>(fileList);

            return _coll.Count > 0;
        }

        /// <summary>
        ///     Clears the collection.
        /// </summary>
        public void ClearCollection()
        {
            _coll.Clear();
        }

        /// <summary>
        ///     Contained in collection.
        /// </summary>
        /// <param name="value">The string to check for.</param>
        /// <returns>true if contained in the collection else false.</returns>
        public bool ContainsItem(string value)
        {
            if (!this._validate.ValidateStringIsNotNull(value)) return false;
            if (!this._validate.ValidateStringHasLength(value)) return false;
            return _coll.Contains(value);
        }

        /// <summary>
        ///     Return all items.
        /// </summary>
        /// <returns>
        ///     All items contained in the collection.
        /// </returns>
        public List<string> GetAllItems()
        {
            return _coll;
        }

        /// <summary>
        ///     Return the value at the given position.
        /// </summary>
        /// <param name="index">The position of the oven.</param>
        /// <returns>The item found at this position.</returns>
        public string GetItemAt(int index)
        {
            var count = _coll.Count;
            return !this._validate.ValidateIndex(index, count)
                ? string.Empty
                : _coll[index];
        }

        /// <summary>
        ///     find the position of this value.
        /// </summary>
        /// <param name="value">The value to search for.</param>
        /// <returns>the position number the item is located at.</returns>
        public int GetItemIndex(string value)
        {
            if (!this._validate.ValidateStringIsNotNull(value)) return -1;
            if (!this._validate.ValidateStringHasLength(value)) return -1;
            return _coll.IndexOf(value);
        }

        public int GetItemsCount()
        {
            throw new System.NotImplementedException();
        }

        /// <summary>
        ///     Gets the count of items contained in the collection.
        /// </summary>
        /// <returns>
        ///     Count of items contained in the collection.
        /// </returns>
        public int ItemsCount()
        {
            return _coll.Count;
        }

        /// <summary>
        ///     Find this item in the collection and
        ///     remove it.
        /// </summary>
        /// <param name="value">The item to find.</param>
        /// <returns>True if removed else false.</returns>
        public bool RemoveItem(string value)
        {
            if (!this._validate.ValidateStringIsNotNull(value)) return false;
            return this._validate.ValidateStringHasLength(value) && _coll.Remove(value);
        }

        /// <summary>
        ///     The position of the item to be removed.
        /// </summary>
        /// <param name="index">The position in the collection.</param>
        /// <returns>True if removed else false.</returns>
        public bool RemoveItemAt(int index)
        {
            var count = _coll.Count;

            if (!this._validate.ValidateIndex(index, count)) return false;
            // Get item to be removed for check that it is gone.
            var item = this.GetItemAt(index);

            _coll.RemoveAt(index);

            // Check to see if item is no longer in collection
            return !this.ContainsItem(item);
        }

        /// <summary>
        ///     Sort the collection.
        /// </summary>
        public void SortCollection()
        {
            _coll.Sort();
        }
    }
}