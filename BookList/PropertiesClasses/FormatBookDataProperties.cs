namespace BookList.PropertiesClasses
{
    using System.Runtime.CompilerServices;
    using System.Windows.Forms;

    /// <summary>
    /// Defines the <see cref="FormatBookDataProperties" />.
    /// </summary>
    internal class FormatBookDataProperties
    {
        /// <summary>
        /// Gets the TipTxtData.
        /// </summary>
        public static string TipTxtData { get; } = "Select Title name then select series name then volume number.";

        /// <summary>
        /// Gets the TipBtnFirst.
        /// </summary>
        public static string TipBtnFirst { get; } = "Move to first book record.";

        /// <summary>
        /// Gets the TipBtnNext.
        /// </summary>
        public static string TipBtnNext { get; } = "Move to next book record.";

        /// <summary>
        /// Gets the TipBtnPrevious.
        /// </summary>
        public static string TipBtnPrevious { get; } = "Move to previous book record.";

        /// <summary>
        /// Gets the TipBtnLast.
        /// </summary>
        public static string TipBtnLast { get; } = "Move to last book record.";

        /// <summary>
        /// Gets the TipBtnReplace.
        /// </summary>
        public static string TipBtnReplace { get; } = "Format the book title, series and book title.";

        /// <summary>
        /// Gets the TipBtnSave.
        /// </summary>
        public static string TipBtnSave { get; } = "Select to save all formatted book data";

        /// <summary>
        /// Gets the TipBtnSeries.
        /// </summary>
        public static string TipBtnSeries { get; } = "Get the user selected series name.";

        /// <summary>
        /// Gets the TipBtnTitle.
        /// </summary>
        public static string TipBtnTitle { get; } = "Get the user selected title name.";

        /// <summary>
        /// Gets the TipBtnVolume.
        /// </summary>
        public static string TipBtnVolume { get; } = "Get the user selected volume number.";

        /// <summary>
        /// Gets the TipTxtSeries.
        /// </summary>
        public static string TipTxtSeries { get; } = "Book series name is displayed here after selecting.";

        /// <summary>
        /// Gets the TipTxtTitle.
        /// </summary>
        public static string TipTxtTitle { get; } = "The book title name is displayed here after selecting.";

        /// <summary>
        /// Gets the TipTxtVolume.
        /// </summary>
        public static string TipTxtVolume { get; } = "The book volume is displayed here after selecting.";

        public static string TipAutoFormat { get; } = "Try to auto format book Information.";

        /// <summary>
        /// Gets the TipLblInfo.
        /// </summary>
        public static string TipLblInfo { get; } = "Authors Name  ";

        /// <summary>
        /// Gets the TipNotSameTitleSeriesVolume.
        /// </summary>
        public static string TipNotSameTitleSeriesVolume { get; } = "The book title and/or book series must not " +
                                                                    "be the same as book volume. ";

        /// <summary>
        /// Gets the TipTitleSeriesNotSame.
        /// </summary>
        public static string TipTitleSeriesNotSame { get; } = "The title of the book and the book series " +
                                                              "must not be the same. ";

        /// <summary>
        /// Gets the TipLblPosition.
        /// </summary>
        public static string TipLblPosition { get; } = "Record position ";

        /// <summary>
        /// True if this book is part of a series else false.
        /// </summary>
        public static bool BookIsSeries { get; set; }

        public static int CurrentPositionInTitlesRecords { get; set; }

        public static string BookSeriesVolumeNumber { get; set; }

        public static int BookTitleRecordsCount { get; set; }

        public static bool CheckTitleSeriesVolumeAreNotTheSame { get; set; }

        public static string ContainsBookTitle { get; set; }

        public static string NameOfBookSeries { get; set; }

        public static string PathToCurrentAuthorsFile { get; set; }

        public static int RecordsTotalCount { get; set; }

        public static string UnformattedBookInformation { get; set; } = string.Empty;
    }
}
