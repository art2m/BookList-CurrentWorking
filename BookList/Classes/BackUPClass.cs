// BookListCurrent
//
// BackUP.cs
//
// art2m
//
// art2m
//
// 07    17   2020
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

using BookList.Collections;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="BackUpClass" /> .
    /// </summary>
    public static class BackUpClass
    {
        /// <summary>
        ///     Create a backup of all unformatted data. This will allow the user to
        ///     roll back changes.
        /// </summary>
        public static void AddToBackUpList()
        {
            var coll = new DataBackUpCollection();
            var collData = new BookDataCollection();
            for (var index = 0; index < collData.GetItemsCount(); index++) coll.AddItem(collData.GetItemAt(index));
        }
    }
}