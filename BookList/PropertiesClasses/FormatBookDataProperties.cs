// BookListCurrent
//
// FormatBookDataProperties.cs
//
// art2m
//
// art2m
//
// 07    19   2020
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
    /// <summary>
    ///     Defines the <see cref="FormatBookDataProperties" /> .
    /// </summary>
    public static class FormatBookDataProperties
    {
        /// <summary>
        ///     True if this book is part of a series else false.
        /// </summary>
        public static bool BookIsSeries { get; set; }

        /// <summary>
        /// Gets or sets the book series volume number.
        /// </summary>
        /// <value>
        /// The book series volume number.
        /// </value>
        public static string BookSeriesVolumeNumber { get; set; }

        /// <summary>
        /// Gets or sets the book title records count.
        /// </summary>
        /// <value>
        /// The book title records count.
        /// </value>
        public static int BookTitleRecordsCount { get; set; }

        /// <summary>
        /// Gets or sets the contains book title.
        /// </summary>
        /// <value>
        /// The contains book title.
        /// </value>
        public static string ContainsBookTitle { get; set; }

        /// <summary>
        ///     Holds the series name that user selected from the book information
        ///     text box.
        /// </summary>
        public static string NameOfBookSeries { get; set; } = string.Empty;

        /// <summary>
        ///     Holds the title name that user selected from the book information
        ///     text box.
        /// </summary>
        public static string NameOfBookTitle { get; set; } = string.Empty;

        /// <summary>
        ///     Holds the volume number and possibly name such as volume or book
        ///     from the book information text box.
        /// </summary>
        public static string NameOfBookVolume { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the unformatted book information.
        /// </summary>
        /// <value>
        /// The unformatted book information.
        /// </value>
        public static string UnformattedBookInformation { get; set; } = string.Empty;
    }
}