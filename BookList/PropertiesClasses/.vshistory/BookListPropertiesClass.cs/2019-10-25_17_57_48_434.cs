using System.Dynamic;

namespace BookList.PropertiesClasses
{
    public static class BookListPropertiesClass
    {
        #region Directory Paths

        public static string PathToAppDataDirectory { get; set; } = string.Empty;
        public static string PathToAuthorsDirectory { get; set; } = string.Empty;
        public static string PathToAuthorsListDirectory { get; set; } = string.Empty;
        public static string PathToSeriesDirectory { get; set; } = string.Empty;

        public static string PathToTitlesAuthorsDirectory { get; set; } = string.Empty;

        public static string PathToTitlesDirectory { get; set; } = string.Empty;
        public static string PathToTopLevelDirectory { get; set; } = string.Empty;

        #endregion

        #region File Paths

        public static string PathToAuthorsNamesListFile { get; set; } = string.Empty;


        public static string PathToCurrentWorkingFile { get; set; } = string.Empty;
        public static string PathToSeriesNamesListFile { get; set; } = string.Empty;

        public static string PathToTitleNamesListFile { get; set; } = string.Empty;

        #endregion

        #region File Names

        public static string CurrentWorkingFileName { get; set; } = string.Empty;
        public static string NameOfAuthorsListFile { get; } = "AuthorFileNames.dat";
        public static string NameOfAuthorsTitlesBookListFile { get; } = "BookListTitleAuthor.dat";
        public static string NameOfSeriesFile { get; } = "Series.dat";
        public static string NameOfTitlesBookListFile { get; } = "BookListTitles.dat";

        #endregion

        #region Directory Names

        public static string NameOfAuthorsDirectory { get; } = "Authors";
        public static string NameOfAuthorsListDirectory { get; } = "AuthorsNamesList";

        public static string NameOfSeriesDirectory { get; } = "Series";
        public static string NameOfTitlesAuthorsDirectory { get; } = "Titles-Authors";
        public static string NameOfTitlesDirectory { get; } = "Titles";
        public static string NameOfTopLevelDirectory { get; } = "BookList";

        #endregion
    }
}