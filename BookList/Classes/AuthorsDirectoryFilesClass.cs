using System.Linq;

namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Windows.Forms;
    using BookList.Collections;
    using BookList.PropertiesClasses;
    using JetBrains.Annotations;

    /// <summary>
    /// Defines the <see cref="AuthorsDirectoryFilesClass" />.
    /// </summary>
    public  class AuthorsDirectoryFilesClass
    {
        /// <summary>
        /// Gets the all author file paths contained in author directory.
        /// </summary>
        /// <param name="dirAuthorPath">The pat to the authors directory.</param>
        public  void GetAllAuthorFilePathsContainedInAuthorDirectory(string dirAuthorPath)
        {
            var validate = new ValidationClass();

            if (validate.ValidateStringIsNotNull(dirAuthorPath)) return;
            if (validate.ValidateStringHasLength(dirAuthorPath)) return;

            GetAllFileNamesContainedInAuthorsDirectory(dirAuthorPath);
        }

        /// <summary>
        /// The GetAllFileNamesContainedInAuthorsDirectory.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        private  void GetAllFileNamesContainedInAuthorsDirectory([NotNull] string dirPath)
        {
            var fileArray = Directory.GetFiles(dirPath, "*.dat");
            var fileNames = new List<string>(fileArray);

            GetAuthorFileNameFromPath(fileNames);
        }

        /// <summary>
        /// Make the List of author names match the FileNames.
        /// </summary>
        private  void GetAuthorFileNamesAddToAuthorsNamesList()
        {
            AuthorNamesListCollection.ClearCollection();
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
                AuthorNamesListCollection.AddItem(AuthorsFileNamesCollection.GetItemAt(index));
        }

        /// <summary>
        /// The GetAuthorFileNamesFromAuthorsList.
        /// </summary>
        private  void GetAuthorFileNamesFromAuthorsList()
        {
            var fileInput = new FileInputClass();

            fileInput.ReadAuthorsNamesFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);

            AuthorNamesListCollection.SortCollection();
        }


        /// <summary>
        /// The SetAllDirectoryPaths.
        /// </summary>
        private  void SetAllDirectoryPaths()
        {
            var dirFileOp = new DirectoryFileOperationsClass();
            
            dirFileOp.GetPathToSpecialDirectoryAppDataLocal();

            var dirTopPath = dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                BookListPropertiesClass
                    .PathToAppDataDirectory, BookListPropertiesClass.PathToTopLevelDirectory);

            BookListPropertiesClass.PathToAuthorsDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToTopLevelDirectory, BookListPropertiesClass.NameOfAuthorsDirectory);

            var dirAuthorListName = BookListPropertiesClass.NameOfAuthorsListDirectory;
            BookListPropertiesClass.PathToAuthorsListDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(
                    BookListPropertiesClass.PathToAuthorsDirectory, dirAuthorListName);

            var dirSeriesName = BookListPropertiesClass.NameOfSeriesDirectory;
            BookListPropertiesClass.PathToSeriesDirectory =
                dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath
                    (BookListPropertiesClass.PathToTopLevelDirectory, dirSeriesName);

            var dirTitlesName = BookListPropertiesClass.NameOfTitlesDirectory;
            BookListPropertiesClass.PathToTitlesDirectory = dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(BookListPropertiesClass.PathToTopLevelDirectory,
                    dirTitlesName);

            var dirAuthorTitlesName = BookListPropertiesClass.NameOfTitlesAuthorsDirectory;
            BookListPropertiesClass.PathToTitlesAuthorsDirectory = dirFileOp.CombineExistingDirectoryPathWithNewDirectoryPath(BookListPropertiesClass.PathToTopLevelDirectory,
                    dirAuthorTitlesName);
        }

        /// <summary>
        /// The SetAllFilePaths.
        /// </summary>
        private  void SetAllFilePaths()
        {
            var dirFileOp = new DirectoryFileOperationsClass();

            var fileAuthorNamesList = dirFileOp.CombineDirectoryPathWithFileName(
                BookListPropertiesClass
                    .PathToAuthorsListDirectory, BookListPropertiesClass.NameOfAuthorsListFile);
            BookListPropertiesClass.PathToAuthorsNamesListFile = fileAuthorNamesList;

            var fileSeriesList = dirFileOp.CombineDirectoryPathWithFileName(BookListPropertiesClass
                .PathToSeriesDirectory, BookListPropertiesClass.NameOfSeriesDirectory);
            BookListPropertiesClass.PathToSeriesNamesListFile = fileSeriesList;

            var fileTitlesList = dirFileOp.CombineDirectoryPathWithFileName(BookListPropertiesClass
                .PathToTitlesDirectory, BookListPropertiesClass.NameOfTitlesBookListFile);
            BookListPropertiesClass.PathToTitleNamesListFile = fileTitlesList;
        }

        /// <summary>
        /// The UpdateAuthorsNamesWithFileNames.
        /// </summary>
        public  void UpdateAuthorsNamesWithFileNames()
        {
            SetAllDirectoryPaths();
            SetAllFilePaths();
            GetAuthorFileNamesFromAuthorsList();
           // GetAllAuthorFilePathsContainedInAuthorDirectory(TODO);
            GetAuthorFileNamesAddToAuthorsNamesList();
        }


        /// <summary>
        /// The AddAuthorFileNamesToCollection.
        /// </summary>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        private  void AddAuthorFileNamesToCollection(string fileName)
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
        private  void GetAuthorFileNameFromPath(List<string> authorFilePaths)
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