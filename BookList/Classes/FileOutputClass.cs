// BookListCurrent
//
// FileOutputClass.cs
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
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;
using BookList.Collections;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="FileOutputClass" /> .
    /// </summary>
    public class FileOutputClass
    {
        private readonly MyMessageBox _msgBox = new MyMessageBox();
        private readonly ValidationClass _validate = new ValidationClass();

        public FileOutputClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Write arthur names to file.
        /// </summary>
        /// <param name="filePath"><see cref="Path" /> to write file to.</param>
        /// <returns>
        ///     True if file is written else false.
        /// </returns>
        public bool WriteArthurFileNamesToListFile(string filePath)
        {
            if (!this._validate.ValidateStringIsNotNull(filePath)) return false;
            if (!this._validate.ValidateStringHasLength(filePath)) return false;
            if (!this._validate.ValidateFileExists(filePath, true)) return false;

            try
            {
                var coll = new AuthorNamesListCollection();

                using (var streamWriter = new StreamWriter(filePath, false))
                {
                    for (var index = 0; index < coll.ItemsCount(); index++)
                    {
                        if (!this._validate.IndexGreaterThanZeroLessThenCollectionCount(index, coll.ItemsCount()))
                            continue;
                        var item = coll.GetItemAt(index);
                        // if index out of range will return empty string. so skip adding.
                        if (string.IsNullOrEmpty(item)) continue;
                        streamWriter.WriteLine(coll.GetItemAt(index));
                    }
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                this._msgBox.Msg = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                this._msgBox.Msg = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                this._msgBox.Msg = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());
            }

            return false;
        }

        /// <summary>
        ///     Adding new author titles, series and volume to authors file.
        /// </summary>
        /// <param name="filePath">The path to authors file to write too.</param>
        /// <param name="bookInfo">The title, series, and volume.</param>
        /// <returns>True if added else false.</returns>
        public bool WriteAuthorsTitlesSeriesToFile(string filePath, string bookInfo)
        {
            if (!this._validate.ValidateStringIsNotNull(filePath)) return false;
            if (!this._validate.ValidateStringHasLength(filePath)) return false;
            if (!this._validate.ValidateFileExists(filePath, true)) return false;
            if (!this._validate.ValidateStringIsNotNull(bookInfo)) return false;
            if (!this._validate.ValidateStringHasLength(bookInfo)) return false;

            using (var writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(bookInfo);
            }

            return true;
        }

        /// <summary>
        ///     If adding new user then write there name to the Art2MSpell user
        ///     names file.
        /// </summary>
        /// <param name="filePath">The filePath <see cref="string" /> .</param>
        /// <returns>
        ///     True if write successful else false.
        /// </returns>
        public bool WriteAuthorsTitlesToFile(string filePath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                var coll = new UnformattedDataCollection();
                var validate = new ValidationClass();

                // Append line to the file.
                using (var writer = new StreamWriter(filePath, false))
                {
                    var count = coll.ItemsCount();
                    for (var index = 0; index < coll.ItemsCount(); index++)

                        writer.WriteLine(coll.GetItemAt(index));

                    return true;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                this._msgBox.Msg = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (ArgumentNullException ex)
            {
                this._msgBox.Msg = $"The path variable contains a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                this._msgBox.Msg = $"The file path value is a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                this._msgBox.Msg = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                this._msgBox.Msg = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                this._msgBox.Msg = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                this._msgBox.Msg = $"File path has invalid characters in it. {filePath}";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
            }

            return false;
        }

        /// <summary>
        ///     writes book info to the authors file. If Not book series then writes
        ///     book title name. if Series writes book title, series name, volume
        ///     number.
        /// </summary>
        /// <param name="filePath">.</param>
        /// <param name="bookInfo">.</param>
        public bool WriteBookTitleSeriesVolumeNamesToAuthorsFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) return false;
                if (!File.Exists(filePath)) return false;

                var coll = new UnformattedDataCollection();

                using (var writer = new StreamWriter(filePath, true))
                {
                    for (var i = 0; i < coll.ItemsCount(); i++)
                        writer.WriteLine(coll.GetItemAt(i));
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                this._msgBox.Msg = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentNullException ex)
            {
                this._msgBox.Msg = $"The path variable contains a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                this._msgBox.Msg = $"The file path value is a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                this._msgBox.Msg = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
                return false;
            }
            catch (PathTooLongException ex)
            {
                this._msgBox.Msg = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
                return false;
            }
            catch (SecurityException ex)
            {
                this._msgBox.Msg = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());
                return false;
            }
            catch (IOException ex)
            {
                this._msgBox.Msg = $"File path has invalid characters in it. {filePath}";

                Debug.WriteLine(ex.ToString());

                this._msgBox.ShowErrorMessageBox();
                return false;
            }
        }
    }
}