// BookList
// 
// AutoFormatClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 06  28  2020
// 
// 06  28   2020
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using BookList.PropertiesClasses;

namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Collections;

    /// <summary>
    /// Try to find title name, series name and volume name and number. 
    /// </summary>
    public class AutoFormatClass
    {
        /// <summary>Initializes a new instance of the <see cref="AutoFormatClass" /> class.</summary>
        public AutoFormatClass()
        {
            FillListsWithSearchCriteria();
        }


        /// <summary>
        /// Checks to see if book information contains a book
        /// <paramref name="volume" /> and number. If found save to property.
        /// </summary>
        /// <param name="bookInfo">The book information.</param>
        /// <returns>
        /// The index where the <paramref name="volume" /> name or number
        /// begins.
        /// </returns>
        private static int CheckContainsBookVolume(string bookInfo)
        {
            var validate = new ValidationClass();
            var position = -1;

            for (var index = 0; index < VolumeBookNamesNumbers.GetItemsCount(); index++)
            {
                var name = VolumeBookNamesNumbers.GetItemAt(index);
                position = bookInfo.IndexOf(name, StringComparison.Ordinal);

                var len = bookInfo.Length;

                if (position <= 0 || position >= len) continue;

                var volNameNum = bookInfo.Substring(position);

                if (!validate.ValidateStringIsNotNull(volNameNum)) return -1;
                if (!validate.ValidateStringHasLength(volNameNum)) return -1;

                FormatBookDataProperties.BookSeriesVolumeNumber = volNameNum;

                if (position > -1) break;
            }

            return position;
        }

        /// <summary>Fills the lists with search criteria.</summary>
        /// <returns>true if success</returns>
        private void FillListsWithSearchCriteria()
        {
            FillListWithNumericValuesAsString();
            FillListWithNumericValues();
            FillWithPossibleVolumeNames();
        }

        /// <summary>Fills the list with numeric values.</summary>
        /// <returns>String with possible volume numbers.</returns>
        private static void FillListWithNumericValues()
        {
            var num = new List<string>(24)
            {
                "1",
                "2",
                "3",
                "3",
                "4",
                "5",
                "6",
                "7",
                "8",
                "9",
                "10",
                "11",
                "12",
                "13",
                "14",
                "15",
                "15",
                "16",
                "17",
                "18",
                "19",
                "20",
                "21",
                "22",
                "23",
                "24",
                "25"
            };

            foreach (var item in num)
            {
                NumericIntegersAsStringCollection.AddItem(item);
            }
        }

        /// <summary>Fills the list with number values as string.</summary>
        /// <returns>List of string values.</returns>
        private static void FillListWithNumericValuesAsString()
        {
            var alpha = new List<string>(24)
            {
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine",
                "ten",
                "eleven",
                "twelve",
                "thirteen",
                "fourteen",
                "fifteen",
                "sixteen",
                "seventeen",
                "eighteen",
                "nineteen",
                "twenty",
                "twenty One",
                "twenty two",
                "twenty three",
                "twenty four",
                "twenty five"
            };

            foreach (var item in alpha)
            {
                NumericWordsName.AddItem(item);
            }
        }

        /// <summary>Fills the with possible volume names.</summary>
        /// <returns>List containing possible volume names.</returns>
        private static void FillWithPossibleVolumeNames()
        {
            var volume = new List<string>
            {
                "vol",
                "volume",
                "book",
                "num",
                "number"
            };

            foreach (var item in volume)
            {
                VolumeBookNamesNumbers.AddItem(item);
            }
        }

        /// <summary>Finds the title series.</summary>
        /// <param name="formattedBookData">The formatted book data.</param>
        /// <returns>Title and series name.</returns>
        private List<string> FindTitleSeries(List<string> formattedBookData)
        {
            FindSeriesName(formattedBookData);


            return new List<string>();
        }

        /// <summary>Finds the name of the series.</summary>
        /// <param name="formattedBookData">The formatted book data.</param>
        private void FindSeriesName(List<string> formattedBookData)
        {
            for (var index = 0; index < UnformattedDataCollection.GetItemsCount(); index++)
            {
                foreach (var val in formattedBookData)
                {
                    var name = val.ToLower();
                    var temp = UnformattedDataBackUpCollection.GetItemAt(index).ToLower();
                    if (name.Equals(temp))
                    {
                        // TODO: Add code for locating words that match in series.
                    }
                }
            }
        }

        /// <summary>
        /// Locates the series part of book information. Then title and volume.
        /// </summary>
        /// <param name="filePath">The file path to <see langword="this"/> book.</param>
        /// <param name="bookInfo">The book information.</param>
        /// <returns>
        /// 
        /// </returns>
        public List<string> LocateSeriesPartOfBookInformation(string filePath, string bookInfo)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var fileInput = new FileInputClass();

            var validate = new ValidationClass();

            if (!validate.ValidateStringIsNotNull(filePath)) return new List<string>();
            if (!validate.CheckForInvalidPathCharacters(filePath)) return new List<string>();
            if (!validate.ValidateFileExists(filePath)) return new List<string>();

            var seriesInfo = fileInput.ReadAuthorNamesFromFile(filePath);

            // Not a book in a series.
            if (seriesInfo.Count < 2) return new List<string>();

            bookInfo = bookInfo.ToLower();

            this.FillListsWithSearchCriteria();

            var volIndex = CheckContainsBookVolume(bookInfo);

            var formattedBookData = this.SplitBookSectionsTitleSeries(bookInfo, volIndex);
            var TitleSeriesVol = this.FindTitleSeries(formattedBookData);

            return seriesInfo;
        }

        /// <summary>Splits the book sections title series.</summary>
        /// <param name="bookInfo">The book information.</param>
        /// <param name="volIndex">Index of where the volume name and or number begins.</param>
        /// <returns>The title and series names.</returns>
        private List<string> SplitBookSectionsTitleSeries(string bookInfo, int volIndex)
        {
            var temp = bookInfo.Substring(0, volIndex);
            var end = bookInfo.Length - 1;

            FormatBookDataProperties.BookSeriesVolumeNumber = bookInfo.Substring(volIndex);

            var val = temp.Split(' ');

            var titleSeriesList = new List<string>(val);

            for (var index = 0; index < titleSeriesList.Count; index++)
            {
                var validate = new ValidationClass();

                if (titleSeriesList[index].Length == 0)
                {
                    titleSeriesList.RemoveAt(index);
                }
            }

            return titleSeriesList;
        }
    }
}