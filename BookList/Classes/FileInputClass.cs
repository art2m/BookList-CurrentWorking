// BookList
//
// FileInputClass.cs
//
// Art2M
//
// art2m@live.com
//
// 11  04  2019
//
// 10  26   2019
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
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using BookList.Collections;

    /// <summary>
    /// Defines the <see cref="FileInputClass" />.
    /// </summary>
    public  class FileInputClass
    {
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        /// Initializes  members of the <see cref="FileInputClass"/> class.
        /// </summary>
        public FileInputClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        /// Read all authors names from authors list. Used to find the Authors file.
        /// </summary>
        /// <param name="filePath">The file path to the Authors List.</param>
        public  void ReadAuthorsNamesFromFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            AuthorNamesListCollection.ClearCollection();

            try
            { 
                if (!this._validate.ValidateStringIsNotNull(filePath)) return;
                if (!this._validate.ValidateStringHasLength(filePath)) return;
                if (!this._validate.CheckForInvalidPathCharacters(filePath)) return;
                if (!this._validate.ValidateFileExists(filePath)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) AuthorNamesListCollection.AddItem(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = "Not enough memory to continue. Try closing other windows.";
                ;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }

        /// <summary>
        /// The ReadAuthorNamesFromFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="List{string}" />.</returns>
        public  List<string> ReadAuthorNamesFromFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var data = new List<string>();
            try
            {
                if (!this._validate.ValidateStringIsNotNull(filePath)) return new List<string>();
                if (!this._validate.ValidateStringHasLength(filePath)) return new List<string>();
                if (!this._validate.CheckForInvalidPathCharacters(filePath)) return new List<string>();
                if (!this._validate.ValidateFileExists(filePath)) return new List<string>();

                using (var sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) data.Add(line);
                }

                return data;
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = "Not enough memory to continue. Try closing other windows.";
                ;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
        }

        /// <summary>
        /// The ReadTitlesFromFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        public  void ReadTitlesFromFile(string filePath)
        {
            try
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (!this._validate.ValidateStringIsNotNull(filePath)) return;
                if (!this._validate.ValidateStringHasLength(filePath)) return;
                if (!this._validate.CheckForInvalidPathCharacters(filePath)) return;
                if (!this._validate.ValidateFileExists(filePath)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) UnformattedDataCollection.AddItem(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = "Not enough memory to continue. Try closing other windows.";
                ;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }

        public  void ReadBookDataFromFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) return;
        }

        /// <summary>
        /// The ReadUnformattedDataFromFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        public  void ReadUnformattedDataFromFile(string filePath)
        {
            try
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (!this._validate.ValidateStringIsNotNull(filePath)) return;
                if (!this._validate.ValidateStringHasLength(filePath)) return;
                if (!this._validate.CheckForInvalidPathCharacters(filePath)) return;
                if (!this._validate.ValidateFileExists(filePath)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) UnformattedDataCollection.AddItem(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = "Not enough memory to continue. Try closing other windows.";
                ;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }
    }
}