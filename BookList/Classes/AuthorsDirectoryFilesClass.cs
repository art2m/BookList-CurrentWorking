using System.Linq;

namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using BookList.Collections;
    using BookList.PropertiesClasses;
    using JetBrains.Annotations;

    /// <summary>
    /// Defines the <see cref="AuthorsDirectoryFilesClass" />.
    /// </summary>
    public static class AuthorsDirectoryFilesClass
    {
        /// <summary>
        /// The GetAllAuthorFilePathsContainedInAuthorDirectory.
        /// </summary>
        public static void GetAllAuthorFilePathsContainedInAuthorDirectory()
        {
            var dirApp = BookListPropertiesClass.PathToAppDataDirectory;

            var dirAuthorPath = DirectoryFileOperationsClass.CombineExistingDirectoryPathWithNewDirectoryPath(dirApp,
                BookListPropertiesClass.PathToAuthorsDirectory);
            GetAllFileNamesContainedInAuthorsDirectory(dirAuthorPath);
        }

        /// <summary>
        /// The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        private static void GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");
            var fileNames = new List<string>(fileArray);

            GetAuthorFileNameFromPath(fileNames);
        }

        /// <summary>
        /// Make the List of author names match the FileNames.
        /// </summary>
        private static void GetAuthorFileNamesAddToAuthorsNamesList()
        {
            AuthorNamesListCollection.ClearCollection();
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
                AuthorNamesListCollection.AddItem(AuthorsFileNamesCollection.GetItemAt(index));
        }

        /// <summary>
        /// The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        private static void GetAuthorFileNamesFromAuthorsList()
        {
            FileInputClass.ReadAuthorsNamesFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            AuthorNamesListCollection.SortCollection();
        }


        /// <summary>
        /// The SetAllDirectoryPaths.
        /// </summary>
        private static void SetAllDirectoryPaths()
        {
            DirectoryFileOperationsClass.GetPathToSpecialDirectoryAppDataLocal();

            var dirTopPath = DirectoryFileOperationsClass.CombineExistingDirectoryPathWithNewDirectoryPath(BookListPropertiesClass
                .PathToAppDataDirectory, BookListPropertiesClass.PathToTopLevelDirectory);

            BookListPropertiesClass.PathToAuthorsDirectory =
                DirectoryFileOperationsClass.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory, BookListPropertiesClass.NameOfAuthorsDirectory);

            var dirAuthorListName = BookListPropertiesClass.NameOfAuthorsListDirectory;
            BookListPropertiesClass.PathToAuthorsListDirectory =
                DirectoryFileOperationsClass.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToAuthorsDirectory, dirAuthorListName);

            var dirSeriesName = BookListPropertiesClass.NameOfSeriesDirectory;
            BookListPropertiesClass.PathToSeriesDirectory = DirectoryFileOperationsClass.CombineExistingDirectoryPathWithNewDirectoryPath
                (BookListPropertiesClass.PathToTopLevelDirectory, dirSeriesName);

            var dirTitlesName = BookListPropertiesClass.NameOfTitlesDirectory;
            BookListPropertiesClass.PathToTitlesDirectory = DirectoryFileOperationsClass
                .CombineExistingDirectoryPathWithNewDirectoryPath(BookListPropertiesClass.PathToTopLevelDirectory, dirTitlesName);

            var dirAuthorTitlesName = BookListPropertiesClass.NameOfTitlesAuthorsDirectory;
            BookListPropertiesClass.PathToTitlesAuthorsDirectory = DirectoryFileOperationsClass
                .CombineExistingDirectoryPathWithNewDirectoryPath(BookListPropertiesClass.PathToTopLevelDirectory, dirAuthorTitlesName);
        }

        /// <summary>
        /// The SetAllFilePaths.
        /// </summary>
        private static void SetAllFilePaths()
        {
            var fileAuthorNamesList = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(
                BookListPropertiesClass
                    .PathToAuthorsListDirectory, BookListPropertiesClass.NameOfAuthorsListFile);
            BookListPropertiesClass.PathToAuthorsNamesListFile = fileAuthorNamesList;

            var fileSeriesList = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(BookListPropertiesClass
                .PathToSeriesDirectory, BookListPropertiesClass.NameOfSeriesDirectory);
            BookListPropertiesClass.PathToSeriesNamesListFile = fileSeriesList;

            var fileTitlesList = DirectoryFileOperationsClass.CombineDirectoryPathWithFileName(BookListPropertiesClass
                .PathToTitlesDirectory, BookListPropertiesClass.NameOfTitlesBookListFile);
            BookListPropertiesClass.PathToTitleNamesListFile = fileTitlesList;
        }

        /// <summary>
        /// The UpdateAuthorsNamesWithFileNames.
        /// </summary>
        public static void UpdateAuthorsNamesWithFileNames()
        {
            SetAllDirectoryPaths();
            SetAllFilePaths();
            GetAuthorFileNamesFromAuthorsList();
            GetAllAuthorFilePathsContainedInAuthorDirectory();
            GetAuthorFileNamesAddToAuthorsNamesList();
        }

        /// <summary>
        /// The AddAuthorFileNamesToCollection.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        private static void AddAuthorFileNamesToCollection(string fileName)
        {
            fileName = fileName.Trim();

            if (string.IsNullOrEmpty(fileName)) return;
            if (string.IsNullOrWhiteSpace(fileName)) return;

            if (AuthorsFileNamesCollection.ContainsItem(fileName)) return;
            AuthorsFileNamesCollection.AddItem(fileName);
        }

        /// <summary>
        /// The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The authorFilePaths<see cref="IEnumerable{string}" />.</param>
        private static void GetAuthorFileNameFromPath(List<string> authorFilePaths)
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