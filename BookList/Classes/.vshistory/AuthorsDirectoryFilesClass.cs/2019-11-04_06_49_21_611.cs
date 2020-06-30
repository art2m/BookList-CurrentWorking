using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using BookList.Collections;
using BookList.PropertiesClasses;

namespace BookList.Classes
{
    public static class AuthorsDirectoryFilesClass
    {
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

        private static void AddAuthorsListToCollection(IEnumerable<string> authors)
        {
            //var authorsList = FileInputClass.ReadTextDataFromFile(fileAuthorsPath);

            foreach (var author in authors)
                if (!AuthorNamesListCollection.ContainsItem(author))
                {
                    AuthorNamesListCollection.AddItem(author);
                }
        }

        public static void GetAllAuthorFilePathsContainedInAuthorDirectory()
        {
            var authorFilePaths = DirectoryFileOperationsClass.GetAllFileNamesContainedInAuthorsDirectory
                (BookListPropertiesClass.PathToAuthorsDirectory);

            GetAuthorFileNameFromPath(authorFilePaths);
        }

        public static void GetAuthorFileNamesFromAuthorsList()
        {
            var authorNames =
                FileInputClass.ReadTextDataFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            AddAuthorsListToCollection(authorNames);
        }

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


        public static bool GetPathToAuthorsFileNamesList()
        {
            var dirBookListName = BookListPropertiesClass.NameOfTopLevelDirectory;
            var dirAuthorListNames = BookListPropertiesClass.NameOfAuthorsListDirectory;
            var authorListName = BookListPropertiesClass.NameOfAuthorsListFile;

            var dirAppData = DirectoryFileOperationsClass.GetPathToSpecialDirectoryAppDataLocal();
            var dirTopLevelPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirAppData,
                dirBookListName);
            var fileAuthorListPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirTopLevelPath,
                dirAuthorListNames);

            if (!File.Exists(fileAuthorListPath)) return false;

            BookListPropertiesClass.PathToAuthorsNamesListFile = fileAuthorListPath;

            return true;
        }

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