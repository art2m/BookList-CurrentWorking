// BookList
//
// AuthorNamesList.cs
//
// Arthur Melanson
//
// art2m
//
// 08    12   2020
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

using System;
using System.Collections.Generic;
using BookList.Classes;
using BookList.Interfaces;
using JetBrains.Annotations;

namespace BookList.Collections
{
    /// <summary>
    ///     This Contains a collection of all book authorsNames in the file.
    /// </summary>
    public class AuthorNamesCollection : IMyCollection
    {
        /// <summary>
        ///     Defines the Author Names list.
        /// </summary>
        private static List<string> _coll = new List<string>();

        /// <summary>
        ///     Declare validation class <c>object</c>.
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Add new <paramref name="item" /> to the collection.
        /// </summary>
        public bool AddItem([NotNull] string item)
        {
            if (!_validate.ValidateStringIsNotNull(item)) return false;
            if (!_validate.ValidateStringHasLength(item)) return false;

            if (ContainsItem(item)) return false;

            _coll.Add(item);
            return true;
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
        /// <returns>
        ///     True if contained in the collection else False.
        /// </returns>
        public bool ContainsItem([NotNull] string value)
        {
            if (!_validate.ValidateStringIsNotNull(value)) return false;
            return _validate.ValidateStringHasLength(value) && _coll.Contains(value);
        }

        /// <summary>
        ///     Get all items contained in the collection.
        /// </summary>
        /// <returns>List of all items in collection.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<string> GetAllItems()
        {
            return _coll;
        }


        /// <summary>
        ///     Return the item at the given position.
        /// </summary>
        /// <param name="index">The position of the oven.</param>
        /// <returns>
        ///     The item found at This position.
        /// </returns>
        public string GetItemAt(int index)
        {
            var count = _coll.Count;
            return !_validate.ValidateIndex(index, count)
                ? string.Empty
                : _coll[index];
        }

        /// <summary>
        ///     find the position of _this item.
        /// </summary>
        /// <param name="value">The item to search for.</param>
        /// <returns>
        ///     the position number the item is located at.
        /// </returns>
        public int GetItemIndex([NotNull] string value)
        {
            if (!_validate.ValidateStringIsNotNull(value)) return -1;
            if (!_validate.ValidateStringHasLength(value)) return -1;
            return _coll.IndexOf(value);
        }

        /// <summary>
        ///     Get item count.
        /// </summary>
        /// <exception cref="NotImplementedException" />
        /// <returns>
        ///     The <see cref="Int32" /> .
        /// </returns>
        public int GetItemsCount()
        {
            return _coll.Count;
        }

        /// <summary>
        ///     Find This item in the collection and remove it.
        /// </summary>
        /// <param name="value">The item to find.</param>
        /// <returns>
        ///     True if removed else False.
        /// </returns>
        public bool RemoveItem([NotNull] string value)
        {
            if (_validate.ValidateStringIsNotNull(value)) return false;
            return !_validate.ValidateStringHasLength(value) && _coll.Remove(value);
        }

        /// <summary>
        ///     The position of the item to be removed.
        /// </summary>
        /// <param name="index">The position in the collection.</param>
        /// <returns>
        ///     True if removed else False.
        /// </returns>
        public bool RemoveItemAt(int index)
        {
            var count = _coll.Count;

            if (!_validate.ValidateIndex(index, count)) return false;

            var item = GetItemAt(index);
            _coll.RemoveAt(index);
            return !ContainsItem(item);
        }

        /// <summary>
        ///     Sort the collection.
        /// </summary>
        public void SortCollection()
        {
            _coll.Sort();
        }

        /// <summary>
        ///     Adds the array.
        /// </summary>
        /// <param name="authorsNames">The authorsNames.</param>
        /// <returns>true if list is added else false.</returns>
        public bool AddList(List<string> authorsNames)
        {
            if (authorsNames == null) return false;
            if (authorsNames.Count <= 1) return false;

            _coll.Clear();

            _coll = new List<string>(authorsNames);

            return _coll.Count > 0;
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
    }
}