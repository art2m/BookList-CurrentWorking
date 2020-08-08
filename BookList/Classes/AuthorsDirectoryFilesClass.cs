// BookList
//
// AuthorsDirectoryFilesClass.cs
//
// Arthur Melanson
//
// art2m
//
// 07    03   2020
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
using BookList.Collections;
using BookList.PropertiesClasses;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="AuthorsDirectoryFilesClass" />.
    /// </summary>
    public class AuthorsDirectoryFilesClass
    {
        /// <summary>
        /// The valid
        /// </summary>
        private readonly ValidationClass _valid = new ValidationClass();

        /// <summary>
        ///     Gets the all author file paths contained in author directory.
        /// </summary>
        /// <param name="dirAuthorPath">The pat to the authors directory.</param>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public bool GetAllAuthorFilePathsContainedInAuthorDirectory([NotNull] string dirAuthorPath)
        {
            var validate = new ValidationClass();

            if (!validate.ValidateStringIsNotNull(dirAuthorPath)) return false;
            if (!validate.ValidateStringHasLength(dirAuthorPath)) return false;
            if (!validate.ValidateDirectoryExists(dirAuthorPath)) return false;

            var retVal = GetAllFileNamesContainedInAuthorsDirectory(dirAuthorPath);
            return retVal;
        }

        /// <summary>
        ///     The UpdateAuthorsNamesWithFileNames.
        /// </summary>
        public bool UpdateAuthorsNamesWithFileNames()
        {
            if (!GetAuthorFileNamesFromAuthorsList()) return false;
            return GetAuthorFileNamesAddToAuthorsNamesList();
        }

        /// <summary>
        ///     The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        private static bool GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");

            return fileArray.Length != 0 && GetAuthorFileNameFromPath(fileArray);
        }

        /// <summary>
        ///     The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The authorFilePaths<see cref="IEnumerable{string}" />.</param>
        private static bool GetAuthorFileNameFromPath([NotNull] string[] authorFilePaths)
        {
            var clsAuthor = new AuthorsFileNamesCollection();

            if (authorFilePaths == null) return false;
            if (authorFilePaths.Length == 0) return false;

            clsAuthor.ClearCollection();

            var fileName = new string[authorFilePaths.Length];
            for (var index = 0; index < authorFilePaths.Length; index++)
            {
                var filePath = authorFilePaths[index].Trim();

                var temp = Path.GetFileName(filePath);
                fileName[index] = temp;
            }

            var coll = new AuthorsFileNamesCollection();
            return coll.AddArray(fileName);
        }

        /// <summary>
        ///     Make the List of author names match the FileNames.
        /// </summary>
        private static bool GetAuthorFileNamesAddToAuthorsNamesList()
        {
            var clsAuthor = new AuthorsFileNamesCollection();
            var coll = new AuthorsFileNamesCollection();

            coll.ClearCollection();
            for (var index = 0; index < clsAuthor.ItemsCount(); index++)
                coll.AddItem(clsAuthor.GetItemAt(index));

            return coll.ItemsCount() != 0;
        }

        /// <summary>
        ///     The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        private static bool GetAuthorFileNamesFromAuthorsList()
        {
            var clsAuthor = new AuthorsFileNamesCollection();
            var fileInput = new FileInputClass();
            var validate = new ValidationClass();

            clsAuthor.ClearCollection();

            if (!validate.ValidateFileExists(BookListPaths.PathAuthorsNamesListFile, true)) return false;

            fileInput.ReadAuthorsNamesFromFile(BookListPaths.PathAuthorsNamesListFile);

            clsAuthor.SortCollection();
            return clsAuthor.ItemsCount() != 0;
        }
    }
}