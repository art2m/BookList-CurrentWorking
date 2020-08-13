// BookListCurrent
//
// InputClass.cs
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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;

using BookList.Collections;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="InputClass" /> .
    /// </summary>
    public class InputClass
    {
        /// <summary>
        /// Deceleration Message box _object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        /// Deceleration Message _object
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Initializes members of the <see cref="InputClass" /> class.
        /// </summary>
        public InputClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Read all authors names from authors list. Used to find the Authors
        ///     file.
        /// </summary>
        /// <param name="filePath">The file path to the Authors List.</param>
        public void ReadAuthorsNamesFromFile(string filePath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var coll = new AuthorNamesList();
            coll.ClearCollection();


            try
            {
                if (!this._validate.ValidateStringIsNotNull(filePath)) return;
                if (!this._validate.ValidateStringHasLength(filePath)) return;
                if (!this._validate.ValidateFileExists(filePath, true)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) coll.AddItem(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                this._msgBox.Msg = "Not enough memory to continue. Try closing other windows.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
        }

        /// <summary>
        ///     The ReadAuthorNamesFromFile.
        /// </summary>
        /// <param name="filePath">The FilePath <see cref="string" /> .</param>
        /// <returns>
        ///    list containing the author names read from file.
        /// </returns>
        public List<string> ReadAuthorNamesFromFile(string filePath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var data = new List<string>();
            try
            {
                if (!this._validate.ValidateStringIsNotNull(filePath)) return new List<string>();
                if (!this._validate.ValidateStringHasLength(filePath)) return new List<string>();
                if (!this._validate.ValidateFileExists(filePath, true)) return new List<string>();

                using (var sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) data.Add(line);
                }

                return data;
            }
            catch (OutOfMemoryException ex)
            {
                this._msgBox.Msg = "Not enough memory to continue. Try closing other windows.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
        }

        /// <summary>
        /// Read the book title from file add to <see cref="BookData"/>
        /// collection.
        /// </summary>
        /// <param name="filePath">The path to the authors file. <see cref="String" /> .</param>
        public void ReadTitlesFromFile(string filePath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                var coll = new BookData();


                if (!this._validate.ValidateStringIsNotNull(filePath)) return;
                if (!this._validate.ValidateStringHasLength(filePath)) return;
                if (!this._validate.ValidateFileExists(filePath, true)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) coll.AddItem(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                this._msgBox.Msg = "Not enough memory to continue. Try closing other windows.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
        }

        /// <summary>
        /// Reads the book data from file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public void ReadBookDataFromFile(string filePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        ///     The ReadUnformattedDataFromFile.
        /// </summary>
        /// <param name="filePath">The FilePath <see cref="string" /> .</param>
        public void ReadUnformattedDataFromFile(string filePath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                if (!this._validate.ValidateStringIsNotNull(filePath)) return;
                if (!this._validate.ValidateStringHasLength(filePath)) return;
                if (!this._validate.ValidateFileExists(filePath, true)) return;

                var coll = new BookData();
                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) coll.AddItem(line);
                }
            }
            catch (OutOfMemoryException ex)
            {
                this._msgBox.Msg = "Not enough memory to continue. Try closing other windows.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
        }

        /// <summary>
        /// Reads all book titles from authors file.
        /// Used to check if book title is all ready in the authors
        /// file.
        /// </summary>
        /// <param name="filePath"> The path to authors file to be read from.</param>
        /// <param name="bookInfo">The book title to see if the artist file all ready contains it.</param>
        public List<string> ReadAllBookTitlesFromAuthorsFile(string filePath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var bookData = new List<string>();


            using (var sr = new StreamReader(filePath))
            {
                string line;

                while ((line = sr.ReadLine()) != null) bookData.Add(line);
            }

            return bookData;
        }
    }
}