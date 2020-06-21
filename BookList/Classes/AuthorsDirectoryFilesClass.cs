﻿namespace BookList.Classes
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
        /// Defines the Str0.
        /// </summary>
        private const string Str0 = "This Author file all ready exists. ";

        /// <summary>
        /// Defines the Str01.
        /// </summary>
        private const string Str01 = "Unable to locate this file. ";

        /// <summary>
        /// Defines the V.
        /// </summary>
        private const string V = "Encountered Error when creating new author file.";

        /// <summary>
        /// Defines the V1.
        /// </summary>
        private const string V1 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        /// Defines the V2.
        /// </summary>
        private const string V2 = "The file path is to long.";

        /// <summary>
        /// Defines the V3.
        /// </summary>
        private const string V3 = "Not supported for this platform.";

        /// <summary>
        /// Defines the V4.
        /// </summary>
        private const string V4 = "Encountered file path error while creating this file";

        /// <summary>
        /// The CheckIfAuthorsFileAllReadyExists.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool CheckIfAuthorsFileAllReadyExists(string filePath)
        {
            if (!File.Exists(filePath)) return false;

            MyMessagesClass.InformationMessage = string.Concat(Str0, filePath);
            MyMessagesClass.ShowInformationMessageBox();

            return true;
        }

        /// <summary>
        /// The CheckNewEmptyAuthorsFileWasCreated.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool CheckNewEmptyAuthorsFileWasCreated(string filePath)
        {
            if (File.Exists(filePath)) return true;

            MyMessagesClass.ErrorMessage = string.Concat(Str01, filePath);
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// The CreateEmptyAuthorNameFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public static bool CreateEmptyAuthorNameFile(string filePath)
        {
            try
            {
                File.Create(filePath).Dispose();

                return true;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V1;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V2;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = Str01;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = V3;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V4;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return false;
            }
        }

        /// <summary>
        /// The GetAllAuthorFilePathsContainedInAuthorDirectory.
        /// </summary>
        public static void GetAllAuthorFilePathsContainedInAuthorDirectory()
        {
            var authorFilePaths = GetAllFileNamesContainedInAuthorsDirectory
                (BookListPropertiesClass.PathToAuthorsDirectory);

            GetAuthorFileNameFromPath(authorFilePaths);
        }

        /// <summary>
        /// The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        /// <returns>The <see cref="List{string}" />.</returns>
        public static List<string> GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");
            var fileNames = new List<string>(fileArray);

            return fileNames;
        }

        /// <summary>
        /// Make the List of author names match the FileNames.
        /// </summary>
        public static void GetAuthorFileNamesAddToAuthorsNamesList()
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
            var authorNames =
                FileInputClass.ReadAuthorNamesFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            AddAuthorsListToCollection(authorNames);
        }

        /// <summary>
        /// The GetPathToAuthorsDirectory.
        /// </summary>
        /// <returns>The <see cref="string" />returns path to authors directory.</returns>
        public static string GetPathToAuthorsDirectory()
        {
            var dirAppData = DirectoryFileOperationsClass.GetPathToSpecialDirectoryAppDataLocal();

            var dirBookList = BookListPropertiesClass.NameOfTopLevelDirectory;

            var dirBookListPath =
                DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirAppData, dirBookList);

            var dirAuthor = BookListPropertiesClass.NameOfAuthorsDirectory;

            var dirAuthorPath = DirectoryFileOperationsClass.CombineStringsMakeDirectoryPath(dirBookListPath,
                dirAuthor);

            BookListPropertiesClass.PathToAuthorsDirectory = dirAuthorPath;

            return dirAuthorPath;
        }

        /// <summary>
        /// The GetPathToAuthorsFileNamesList.
        /// </summary>
        /// <returns>The <see cref="bool" />.</returns>
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
        /// The SetAllDirectoryPaths.
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
        /// The SetAllFilePaths.
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
        /// The AddAuthorsListToCollection.
        /// </summary>
        /// <param name="authors">The authors<see cref="IEnumerable{string}" />.</param>
        private static void AddAuthorsListToCollection(IEnumerable<string> authors)
        {
            //var authorsList = FileInputClass.ReadAuthorNamesFromFile(fileAuthorsPath);

            foreach (var author in authors)
                if (!AuthorNamesListCollection.ContainsItem(author))
                    AuthorNamesListCollection.AddItem(author);
        }

        /// <summary>
        /// The GetAuthorFileNameFromPath.
        /// </summary>
        /// <param name="authorFilePaths">The authorFilePaths<see cref="IEnumerable{string}" />.</param>
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
    }
}
