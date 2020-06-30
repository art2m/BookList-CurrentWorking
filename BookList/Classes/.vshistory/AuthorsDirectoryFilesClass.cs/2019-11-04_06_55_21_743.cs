namespace BookList.Classes
{
    using System.Collections.Generic;
    using System.IO;
    using BookList.Collections;
    using BookList.PropertiesClasses;

    /// <summary>
    /// Defines the <see cref="AuthorsDirectoryFilesClass" />
    /// </summary>
    public static class AuthorsDirectoryFilesClass
    {
        /// <summary>
        /// The SetAllDirectoryPaths
        /// </summary>
        public static void SetAllDirectoryPaths()
        {
            var dirAppData = DirectoryFileOperationsClass.GetPathToSpecialDirectoryAppDataLocal();
            BookListPropertiesClass.PathToAppDataDirectory = dirAppData;

            var dirBookListName = BookListPropertiesClass.NameOfTopLevelDirectory;
            BookListPropertiesClass.PathToTopLevelDirectory =
                DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirAppData, dirBookListName);

            var dirAuthorName = BookListPropertiesClass.NameOfAuthorsDirectory;
            BookListPropertiesClass.PathToAuthorsDirectory =
                DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory, dirAuthorName);

            var dirAuthorListName = BookListPropertiesClass.NameOfAuthorsListDirectory;
            BookListPropertiesClass.PathToAuthorsListDirectory =
                DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory, dirAuthorListName);

            var dirSeriesName = BookListPropertiesClass.NameOfSeriesDirectory;
            BookListPropertiesClass.PathToSeriesDirectory = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath
                (BookListPropertiesClass.PathToTopLevelDirectory, dirSeriesName);

            var dirTitlesName = BookListPropertiesClass.NameOfTitlesDirectory;
            BookListPropertiesClass.PathToTitlesDirectory = DirectoryFileOperationsClass
                .CombineStringsMakeDirectoryPath(BookListPropertiesClass.PathToTopLevelDirectory, dirTitlesName);

            var dirAuthorTitlesName = BookListPropertiesClass.NameOfTitlesAuthorsDirectory;
            BookListPropertiesClass.PathToTitlesAuthorsDirectory = DirectoryFileOperationsClass
                .CombineStringsMakeDirectoryPath(BookListPropertiesClass.PathToTopLevelDirectory, dirAuthorTitlesName);
        }

        /// <summary>
        /// The SetAllFilePaths
        /// </summary>
        public static void SetAllFilePaths()
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
        /// The AddAuthorFileNamesToCollection
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string"/></param>
        private static void AddAuthorFileNamesToCollection(string fileName)
        {
            fileName = fileName.Trim();

            if (string.IsNullOrEmpty(fileName)) return;
            if (string.IsNullOrWhiteSpace(fileName)) return;

            if (AuthorsFileNamesCollection.ContainsItem(fileName)) return;
            AuthorsFileNamesCollection.AddItem(fileName);
        }

        /// <summary>
        /// Make the List of author names match the FileNames.
        /// </summary>
        public static void GetAuthorFileNamesAddToAuthorsNamesList()
        {
            AuthorNamesListCollection.ClearCollection();
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                AuthorNamesListCollection.AddItem(AuthorsFileNamesCollection.GetItemAt(index));
            }
        }

        /// <summary>
        /// The AddAuthorsListToCollection
        /// </summary>
        /// <param name="authors">The authors<see cref="IEnumerable{string}"/></param>
        private static void AddAuthorsListToCollection(IEnumerable<string> authors)
        {
            //var authorsList = FileInputClass.ReadTextDataFromFile(fileAuthorsPath);

            foreach (var author in authors)
            {
                if (!AuthorNamesListCollection.ContainsItem(author)) AuthorNamesListCollection.AddItem(author);
            }
        }

        /// <summary>
        /// The GetAllAuthorFilePathsContainedInAuthorDirectory
        /// </summary>
        public static void GetAllAuthorFilePathsContainedInAuthorDirectory()
        {
            var authorFilePaths = DirectoryFileOperationsClass.GetAllFileNamesContainedInAuthorsDirectory
                (BookListPropertiesClass.PathToAuthorsDirectory);

            GetAuthorFileNameFromPath(authorFilePaths);
        }

        /// <summary>
        /// The GetAuthorFileNamesFromAuthorsList
        /// </summary>
        public static void GetAuthorFileNamesFromAuthorsList()
        {
            var authorNames =
                FileInputClass.ReadTextDataFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            AddAuthorsListToCollection(authorNames);
        }

        /// <summary>
        /// The GetAuthorFileNameFromPath
        /// </summary>
        /// <param name="authorFilePaths">The authorFilePaths<see cref="IEnumerable{string}"/></param>
        private static void GetAuthorFileNameFromPath(IEnumerable<string> authorFilePaths)
        {
            AuthorsFileNamesCollection.ClearCollection();

            foreach (var authorPath in authorFilePaths)
            {
                var filePath = authorPath.Trim();

                var fileName = Path.GetFileName(filePath);

                AddAuthorFileNamesToCollection(fileName);
            }
        }

        /// <summary>
        /// The GetPathToAuthorsDirectory
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public static bool GetPathToAuthorsDirectory()
        {
            var dirAppData = DirectoryFileOperationsClass.GetPathToSpecialDirectoryAppDataLocal();

            var dirBookList = BookListPropertiesClass.NameOfTopLevelDirectory;

            var dirBooklistPath =
                DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirAppData, dirBookList);

            var dirAuthor = BookListPropertiesClass.NameOfAuthorsDirectory;

            var dirAuthorPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirBooklistPath,
                dirAuthor);

            BookListPropertiesClass.PathToAuthorsDirectory = dirAuthorPath;

            return Directory.Exists(dirAuthorPath);
        }

        /// <summary>
        /// The GetPathToAuthorsFileNamesList
        /// </summary>
        /// <returns>The <see cref="bool"/></returns>
        public static bool GetPathToAuthorsFileNamesList()
        {
            var dirBookListName = BookListPropertiesClass.NameOfTopLevelDirectory;
            var dirAuthorListNames = BookListPropertiesClass.NameOfAuthorsListDirectory;

            var dirAppData = DirectoryFileOperationsClass.GetPathToSpecialDirectoryAppDataLocal();
            var dirTopLevelPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirAppData,
                dirBookListName);
            var fileAuthorListPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirTopLevelPath,
                dirAuthorListNames);

            if (!File.Exists(fileAuthorListPath)) return false;

            BookListPropertiesClass.PathToAuthorsNamesListFile = fileAuthorListPath;

            return true;
        }

        /// <summary>
        /// The UpdateAuthorsNamesWithFileNames
        /// </summary>
        public static void UpdateAuthorsNamesWithFileNames()
        {
            SetAllDirectoryPaths();
            SetAllFilePaths();

            GetAuthorFileNamesFromAuthorsList();
            GetAllAuthorFilePathsContainedInAuthorDirectory();
            GetAuthorFileNamesAddToAuthorsNamesList();
        }
    }
}