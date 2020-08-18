// BookListCurrent
//
// FileClass.cs
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
using System.IO;
using System.Reflection;
using System.Windows.Forms;

using BookList.Collections;

using JetBrains.Annotations;

namespace BookList.Classes
{
    using PropertiesClasses;

    /// <summary>
    ///     Class that contains code to create directories and files.
    /// </summary>
    public class FileClass
    {
        /// <summary>
        /// Declaration of MyMessagesBox Object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        /// Declaration of ValidationClass Object.
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Initializes members of the <see cref="FileClass" /> class.
        /// </summary>
        public FileClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }


        /// <summary>
        ///     The CreateNewFile.
        /// </summary>
        /// <param name="filePath">The filePath <see cref="string" /> .</param>
        /// <returns>
        ///     The <see cref="bool" /> .
        /// </returns>
        public bool CreateNewFile(string filePath)
        {
            if (!this._validate.ValidateStringIsNotNull(filePath)) return false;
            if (!this._validate.ValidateStringHasLength(filePath)) return false;
            if (File.Exists(filePath)) return true;

            _ = File.Create(filePath);

            if (!File.Exists(filePath)) return false;

            BookListPathsProperties.PathOfCurrentWorkingFile = filePath;

            return true;
        }

        /// <summary>
        /// Gets the author file names list file path.
        /// </summary>
        /// <returns>True if file found else False.</returns>
        public bool GetAuthorFileNamesListFilePath()
        {
            var dirFileOp = new FileClass();
            var validate = new ValidationClass();

            var dirPath = BookListPathsProperties.PathAuthorsListDirectory;

            var fileName = BookListPathsProperties.NameAuthorsListFile;

            var cls = new CombinePathsClass();
            var filePath = cls.CombineDirectoryPathWithFileName(
                dirPath, fileName);

            var fileExists = validate.ValidateFileExists(filePath, true);

            if (!fileExists)
            {
                var dlgResult = this._msgBox.ShowQuestionMessageBox();

                // Create directory if it does not exist.
                if (dlgResult == DialogResult.Yes)
                {
                    dirFileOp.CreateNewFile(filePath);

                    if (validate.ValidateFileExists(filePath, true))
                    {
                        BookListPathsProperties.PathAuthorsNamesListFile = filePath;
                        return true;
                    }
                    else
                    {
                        // return no directory created.
                        BookListPathsProperties.PathAuthorsNamesListFile = String.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPathsProperties.PathAuthorsNamesListFile = String.Empty;
                    return false;
                }
            }
            else
            {
                BookListPathsProperties.PathAuthorsNamesListFile = filePath;
                return true;
            }
        }

        /// <summary>
        /// Gets the book list titles file path.
        /// </summary>
        /// <returns>True if path found else False.</returns>
        public bool GetBookListTitlesFilePath()
        {
            var dirFileOp = new FileClass();
            var validate = new ValidationClass();

            var dirPath = BookListPathsProperties.PathTitlesDirectory;

            var fileName = BookListPathsProperties.NameTitlesBookListFile;

            var cls = new CombinePathsClass();
            var filePath = cls.CombineDirectoryPathWithFileName(
                dirPath, fileName);

            var fileExists = validate.ValidateFileExists(filePath, true);

            if (!fileExists)
            {
                var dlgResult = this._msgBox.ShowQuestionMessageBox();

                // Create directory if it does not exist.
                if (dlgResult == DialogResult.Yes)
                {
                    dirFileOp.CreateNewFile(filePath);

                    if (validate.ValidateFileExists(filePath, true))
                    {
                        BookListPathsProperties.PathTitleNamesListFile = filePath;
                        return true;
                    }
                    else
                    {
                        // return no directory created.
                        BookListPathsProperties.PathTitleNamesListFile = String.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPathsProperties.PathTitleNamesListFile = String.Empty;
                    return false;
                }
            }
            else
            {
                BookListPathsProperties.PathTitleNamesListFile = filePath;
                return true;
            }
        }

        /// <summary>
        ///     Initialize all Required files.
        /// </summary>
        /// <returns>
        ///     True if all initialized else False.
        /// </returns>
        public bool InitializeFilePaths()
        {
            var retVal = this.GetBookListTitlesFilePath();

            return retVal && this.GetAuthorFileNamesListFilePath();
        }


        /// <summary>
        ///  Remove the .dat file extension from the file name.
        /// </summary>
        /// <param name="fileName">The file name to remove .dat from.</param>
        /// <returns> File name minus the file extension.</returns>
        public string RemoveFileExtension(string fileName)
        {
            if (!this._validate.ValidateStringIsNotNull(fileName)) return String.Empty;
            return !this._validate.ValidateStringHasLength(fileName) ? String.Empty : Path.GetExtension(fileName);
        }

        /// <summary>
        ///     The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The author file paths<see cref="IEnumerable{string}" />.</param>
        public void GetAuthorFileNameFromPath(IEnumerable<string> authorFilePaths)
        {
            var collFile = new AuthorsFileNamesCollection();

            collFile.ClearCollection();

            foreach (var authorPath in authorFilePaths)
            {
                var filePath = authorPath.Trim();

                var fileName = Path.GetFileName(filePath);

                var clsAuthor = new AuthorOperationsClass();
                clsAuthor.AddAuthorFileNamesToCollection(fileName);
            }
        }

        /// <summary>
        ///     Add the file extension '.dat' to the file name.
        /// </summary>
        /// <param name="author">The file name to add file extension to.</param>
        /// <returns>file name with extension.</returns>
        public string AddFileExtension(string author)
        {
            if (!this._validate.ValidateStringIsNotNull(author)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(author)) return String.Empty;

            const string extension = ".dat";

            return string.Concat(author, extension);
        }

        /// <summary>
        ///     Get all author names contained in the Authors Directory.
        /// </summary>
        /// <param name="dirPath">The directory path<see cref="string" />.</param>
        /// <returns>The <see cref="List{T}" />.</returns>
        public IEnumerable<string> GetAFileNamesFromAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");
            var fileNames = new List<string>(fileArray);

            return fileNames;
        }

        /// <summary>
        ///     The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        public void GetAuthorFileNamesFromAuthorsList()
        {
            var coll = new AuthorNamesCollection();
            var input = new InputClass();

            var authorNames = input.ReadAuthorNamesFromFile(BookListPathsProperties.PathAuthorsNamesListFile);

            coll.ClearCollection();
            foreach (var name in authorNames) coll.AddItem(name);
        }

        /// <summary>
        ///     Check to see if file name contains extension '.dat'.
        /// </summary>
        /// <param name="fileName">The authors name to check.</param>
        /// <returns>True if contains file extension '.dat' else False.</returns>
        // ReSharper disable once MemberCanBeMadeStatic.Local
        public bool CheckFileNameHasExtension(string fileName)
        {
            var extension = Path.GetExtension(fileName);

            return extension.Contains("dat");
        }

        /// <summary>
        ///     The GetAllAuthorFilePathsContainedInAuthorDirectory.
        /// </summary>
        public void GetAllAuthorFilePathsContainedInAuthorDirectory()
        {
            var authorFilePaths = GetAFileNamesFromAuthorsDirectory
                (BookListPathsProperties.PathAuthorsDirectory);

            var clsFile = new FileClass();
            clsFile.GetAuthorFileNameFromPath(authorFilePaths);
        }
    }
}