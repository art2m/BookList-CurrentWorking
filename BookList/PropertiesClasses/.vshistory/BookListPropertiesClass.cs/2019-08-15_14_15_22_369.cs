namespace BookList.PropertiesClasses
{
    public static class BookListPropertiesClass
    {
        public static string NameOfAuthorsBookListFile { get; } = "BookListAuthors.dat";

        public static string NameOfTitlesBookListFile { get; } = "BookListTitles.dat";

        public static string NameOfAuthorsTitlesBookListFile { get; } = "BookListTitleAuthor.dat";

        public static string NameOfTopLevelDirectory { get; } = "BookList";

        public static string CurrentWorkingFileName { get; set; } = string.Empty;

        public static string CurrentAuthorName { get; set; } = string.Empty;


    }
}
