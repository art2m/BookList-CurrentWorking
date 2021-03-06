﻿// BookListCurrent
//
// BookListPathsProperties.cs
//
// art2m
//
// art2m
//
// 07    18   2020
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

namespace BookList.PropertiesClasses
{
    using System;

    /// <summary>
    ///     Defines the <see cref="BookListPathsProperties" /> .
    /// </summary>
    public static class BookListPathsProperties
    {
        /// <summary>
        ///     Gets or sets the AuthorsNameCurrent.
        /// </summary>
        public static string AuthorsNameCurrent { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the CurrentWorkingFileName.
        /// </summary>
        public static string CurrentWorkingFileName { get; set; } = String.Empty;

        /// <summary>
        ///     Gets the NameAuthorsDirectory.
        /// </summary>
        public static string NameAuthorsDirectory { get; } = "Authors";

        /// <summary>
        ///     Gets the NameAuthorsListFile.
        /// </summary>
        public static string NameAuthorsListFile { get; } = "AuthorFileNames.dat";

        /// <summary>
        ///     Gets the NameAuthorsTitlesBookListFile.
        /// </summary>
        public static string NameAuthorsTitlesBookListFile { get; } = "BookListTitleAuthor.dat";

        /// <summary>
        ///     Gets the NameOfAuthorsListDirectory.
        /// </summary>
        public static string NameOfAuthorsListDirectory { get; } = "AuthorsNamesList";

        /// <summary>
        ///     Gets the NameSeriesDirectory.
        /// </summary>
        public static string NameSeriesDirectory { get; } = "Series";

        /// <summary>
        ///     Gets the NameSeriesFile.
        /// </summary>
        public static string NameSeriesFile { get; } = "Series.dat";

        /// <summary>
        ///     Gets the NameTitlesAuthorsDirectory.
        /// </summary>
        public static string NameTitlesAuthorsDirectory { get; } = "Titles-Authors";

        /// <summary>
        ///     Gets the NameTitlesBookListFile.
        /// </summary>
        public static string NameTitlesBookListFile { get; } = "BookListTitles.dat";

        /// <summary>
        ///     Gets the NameTitlesDirectory.
        /// </summary>
        public static string NameTitlesDirectory { get; } = "Titles";

        /// <summary>
        ///     Gets the NameTopLevelDirectory.
        /// </summary>
        public static string NameTopLevelDirectory { get; } = "BookList";

        /// <summary>
        ///     Gets or sets the PathAppDataDirectory.
        /// </summary>
        public static string PathAppDataDirectory { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathAuthorsDirectory.
        /// </summary>
        public static string PathAuthorsDirectory { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathAuthorsListDirectory.
        /// </summary>
        public static string PathAuthorsListDirectory { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathAuthorsNamesListFile.
        /// </summary>
        public static string PathAuthorsNamesListFile { get; set; } = String.Empty;

        /// <summary>
        /// Gets or sets the path book list title author file.
        /// </summary>
        /// <value>
        /// The path book list title author file.
        /// </value>
        public static string PathBookListTitleAuthorFile { get; set; }

        /// <summary>
        ///     Gets or sets the PathOfCurrentWorkingFile.
        /// </summary>
        public static string PathOfCurrentWorkingFile { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathSeriesDirectory.
        /// </summary>
        public static string PathSeriesDirectory { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathSeriesNamesListFile.
        /// </summary>
        public static string PathSeriesNamesListFile { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathTitleNamesListFile.
        /// </summary>
        public static string PathTitleNamesListFile { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathTitlesAuthorsDirectory.
        /// </summary>
        public static string PathTitlesAuthorsDirectory { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathTitlesDirectory.
        /// </summary>
        public static string PathTitlesDirectory { get; set; } = String.Empty;

        /// <summary>
        ///     Gets or sets the PathTitleAuthorsNames List File.
        /// </summary>
        public static string PathToCurrentAuthorsFile { get; set; }

        /// <summary>
        ///     Gets or sets the PathTopLevelDirectory.
        /// </summary>
        public static string PathTopLevelDirectory { get; set; } = String.Empty;
    }
}