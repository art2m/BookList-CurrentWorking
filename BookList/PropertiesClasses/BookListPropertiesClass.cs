namespace BookList.PropertiesClasses
{
    /// <summary>
    /// Defines the <see cref="BookListPropertiesClass" />.
    /// </summary>
    public static class BookListPropertiesClass
    {
        /// <summary>
        /// Gets or sets the PathToAppDataDirectory
        /// Gets or sets the PathToAppDataDirectory.
        /// </summary>
        public static string PathToAppDataDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToAuthorsDirectory
        /// Gets or sets the PathToAuthorsDirectory.
        /// </summary>
        public static string PathToAuthorsDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToAuthorsListDirectory
        /// Gets or sets the PathToAuthorsListDirectory.
        /// </summary>
        public static string PathToAuthorsListDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToSeriesDirectory
        /// Gets or sets the PathToSeriesDirectory.
        /// </summary>
        public static string PathToSeriesDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToTitlesAuthorsDirectory
        /// Gets or sets the PathToTitlesAuthorsDirectory.
        /// </summary>
        public static string PathToTitlesAuthorsDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToTitlesDirectory
        /// Gets or sets the PathToTitlesDirectory.
        /// </summary>
        public static string PathToTitlesDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToTopLevelDirectory
        /// Gets or sets the PathToTopLevelDirectory.
        /// </summary>
        public static string PathToTopLevelDirectory { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToAuthorsNamesListFile
        /// Gets or sets the PathToAuthorsNamesListFile.
        /// </summary>
        public static string PathToAuthorsNamesListFile { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathOfCurrentWorkingFile
        /// Gets or sets the PathOfCurrentWorkingFile.
        /// </summary>
        public static string PathOfCurrentWorkingFile { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToSeriesNamesListFile
        /// Gets or sets the PathToSeriesNamesListFile.
        /// </summary>
        public static string PathToSeriesNamesListFile { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the PathToTitleNamesListFile
        /// Gets or sets the PathToTitleNamesListFile.
        /// </summary>
        public static string PathToTitleNamesListFile { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the CurrentWorkingFileName
        /// Gets or sets the CurrentWorkingFileName.
        /// </summary>
        public static string CurrentWorkingFileName { get; set; } = string.Empty;

        /// <summary>
        /// Gets the NameOfAuthorsListFile
        /// Gets the NameOfAuthorsListFile.
        /// </summary>
        public static string NameOfAuthorsListFile { get; } = "AuthorFileNames.dat";

        /// <summary>
        /// Gets the NameOfAuthorsTitlesBookListFile
        /// Gets the NameOfAuthorsTitlesBookListFile.
        /// </summary>
        public static string NameOfAuthorsTitlesBookListFile { get; } = "BookListTitleAuthor.dat";

        /// <summary>
        /// Gets the NameOfSeriesFile
        /// Gets the NameOfSeriesFile.
        /// </summary>
        public static string NameOfSeriesFile { get; } = "Series.dat";

        /// <summary>
        /// Gets the NameOfTitlesBookListFile
        /// Gets the NameOfTitlesBookListFile.
        /// </summary>
        public static string NameOfTitlesBookListFile { get; } = "BookListTitles.dat";

        /// <summary>
        /// Gets the NameOfAuthorsDirectory
        /// Gets the NameOfAuthorsDirectory.
        /// </summary>
        public static string NameOfAuthorsDirectory { get; } = "Authors";

        /// <summary>
        /// Gets the NameOfAuthorsListDirectory
        /// Gets the NameOfAuthorsListDirectory.
        /// </summary>
        public static string NameOfAuthorsListDirectory { get; } = "AuthorsNamesList";

        /// <summary>
        /// Gets the NameOfSeriesDirectory
        /// Gets the NameOfSeriesDirectory.
        /// </summary>
        public static string NameOfSeriesDirectory { get; } = "Series";

        /// <summary>
        /// Gets the NameOfTitlesAuthorsDirectory
        /// Gets the NameOfTitlesAuthorsDirectory.
        /// </summary>
        public static string NameOfTitlesAuthorsDirectory { get; } = "Titles-Authors";

        /// <summary>
        /// Gets the NameOfTitlesDirectory
        /// Gets the NameOfTitlesDirectory.
        /// </summary>
        public static string NameOfTitlesDirectory { get; } = "Titles";

        /// <summary>
        /// Gets the NameOfTopLevelDirectory
        /// Gets the NameOfTopLevelDirectory.
        /// </summary>
        public static string NameOfTopLevelDirectory { get; } = "BookList";

        /// <summary>
        /// Gets or sets the AuthorsNameCurrent
        /// Gets or sets the AuthorsNameCurrent.
        /// </summary>
        public static string AuthorsNameCurrent { get; set; } = string.Empty;
    }
}
