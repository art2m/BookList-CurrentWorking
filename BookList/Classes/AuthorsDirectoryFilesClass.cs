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

using System.Collections.Generic;
using System.IO;
using System.Linq;
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
        ///     Gets the all author file paths contained in author directory.
        /// </summary>
        /// <param name="dirAuthorPath">The pat to the authors directory.</param>
        public void GetAllAuthorFilePathsContainedInAuthorDirectory(string dirAuthorPath)
        {
            var validate = new ValidationClass();

            if (validate.ValidateStringIsNotNull(dirAuthorPath)) return;
            if (validate.ValidateStringHasLength(dirAuthorPath)) return;

            GetAllFileNamesContainedInAuthorsDirectory(dirAuthorPath);
        }

        /// <summary>
        ///     The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        private void GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");
            var fileNames = new List<string>(fileArray);

            GetAuthorFileNameFromPath(fileNames);
        }

        /// <summary>
        ///     Make the List of author names match the FileNames.
        /// </summary>
        private void GetAuthorFileNamesAddToAuthorsNamesList()
        {
            AuthorNamesListCollection.ClearCollection();
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
                AuthorNamesListCollection.AddItem(AuthorsFileNamesCollection.GetItemAt(index));
        }

        /// <summary>
        ///     The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        private void GetAuthorFileNamesFromAuthorsList()
        {
            var fileInput = new FileInputClass();

            fileInput.ReadAuthorsNamesFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            AuthorNamesListCollection.SortCollection();
        }


        /// <summary>
        ///     The SetAllDirectoryPaths.
        /// </summary>
        private void SetAllDirectoryPaths()
        {
            var dirFileOp = new DirectoryFileOperationsClass();

            dirFileOp.GetPathToSpecialDirectoryAppDataLocal();

            BookListPropertiesClass.PathToTopLevelDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToAppDataDirectory, BookListPropertiesClass.NameOfTopLevelDirectory);

            BookListPropertiesClass.PathToAuthorsDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory, BookListPropertiesClass.NameOfAuthorsDirectory);

            BookListPropertiesClass.PathToAuthorsListDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory,
                    BookListPropertiesClass.NameOfAuthorsListDirectory);

            BookListPropertiesClass.PathToSeriesDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath
                    (BookListPropertiesClass.PathToTopLevelDirectory, BookListPropertiesClass.NameOfSeriesDirectory);

            BookListPropertiesClass.PathToTitlesDirectory = dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                BookListPropertiesClass.PathToTopLevelDirectory, BookListPropertiesClass.NameOfTitlesDirectory);

            BookListPropertiesClass.PathToTitlesAuthorsDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory,
                    BookListPropertiesClass.NameOfTitlesAuthorsDirectory);
        }

        /// <summary>
        ///     The SetAllFilePaths.
        /// </summary>
        private void SetAllFilePaths()
        {
            var dirFileOp = new DirectoryFileOperationsClass();

            BookListPropertiesClass.PathToAuthorsNamesListFile = dirFileOp.CombineDirectoryPathWithFileName(
                BookListPropertiesClass.PathToAuthorsListDirectory, BookListPropertiesClass.NameOfAuthorsListFile);

            BookListPropertiesClass.PathToSeriesNamesListFile = dirFileOp.CombineDirectoryPathWithFileName(
                BookListPropertiesClass
                    .PathToSeriesDirectory, BookListPropertiesClass.NameOfSeriesDirectory);

            BookListPropertiesClass.PathToTitleNamesListFile = dirFileOp.CombineDirectoryPathWithFileName(
                BookListPropertiesClass
                    .PathToTitlesDirectory, BookListPropertiesClass.NameOfTitlesBookListFile);
        }

        /// <summary>
        ///     The UpdateAuthorsNamesWithFileNames.
        /// </summary>
        public void UpdateAuthorsNamesWithFileNames()
        {
            SetAllDirectoryPaths();
            SetAllFilePaths();
            GetAuthorFileNamesFromAuthorsList();
            GetAuthorFileNamesAddToAuthorsNamesList();
        }


        /// <summary>
        ///     The AddAuthorFileNamesToCollection.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        private void AddAuthorFileNamesToCollection(string fileName)
        {
            fileName = fileName.Trim();

            if (string.IsNullOrEmpty(fileName)) return;
            if (string.IsNullOrWhiteSpace(fileName)) return;

            if (AuthorsFileNamesCollection.ContainsItem(fileName)) return;
            AuthorsFileNamesCollection.AddItem(fileName);
        }

        /// <summary>
        ///     The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The authorFilePaths<see cref="IEnumerable{string}" />.</param>
        private void GetAuthorFileNameFromPath(List<string> authorFilePaths)
        {
            if (authorFilePaths == null) return;
            if (!authorFilePaths.Any()) return;

            AuthorsFileNamesCollection.ClearCollection();

            foreach (var authorPath in authorFilePaths)
            {
                var filePath = authorPath.Trim();

                var fileName = Path.GetFileName(filePath);

                AddAuthorFileNamesToCollection(fileName);
            }
        }
    }
}