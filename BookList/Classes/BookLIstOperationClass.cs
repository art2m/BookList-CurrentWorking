// BookList
// 
// BookListOperationsClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 10  07  2019
// 
// 08  14   2019
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace BookList.Classes
{
    using BookList.PropertiesClasses;

    /// <summary>
    /// Defines the <see cref="BookListOperationsClass" />.
    /// </summary>
    public class BookListOperationsClass
    {
        /// <summary>
        /// The CheckBookListStringIsFileName.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public bool CheckBookListStringIsFileName(string value)
        {
            if (value.Contains("***")) return false;

            var fileName = GetFileNameFromString(value);
            return true;
        }

        /// <summary>
        /// The GetFileNameFromString.
        /// </summary>
        /// <param name="value">The value<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        private static string GetFileNameFromString(string value)
        {
            var validate = new ValidationClass();

            if (validate.ValidateStringIsNotNull(value)) return string.Empty;
            if (validate.ValidateStringHasLength(value)) return string.Empty;
            
            var fileName = value.Replace("*", "");

            if (!validate.ValidateStringHasLength(fileName)) return string.Empty;

            BookListPropertiesClass.CurrentWorkingFileName = fileName;
            return fileName;
        }
    }
}
