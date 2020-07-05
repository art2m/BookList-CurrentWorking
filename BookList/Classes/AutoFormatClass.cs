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

using System.Windows.Forms;
using BookList.PropertiesClasses;

namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using Collections;

    public class AutoFormatClass
    {
        /// <summary>
        /// Checks to see if book information contains a book
        /// <paramref name="volume"/> and number. If found save to property.
        /// </summary>
        /// <param name="bookInfo">The book information.</param>
        /// <param name="volume">The volume.</param>
        /// <returns>
        /// The index where the <paramref name="volume"/> name or number begins.
        /// </returns>
        private static int CheckContainsBookVolume(string bookInfo, List<string> volume)
        {
            var validate = new ValidationClass();

            var index = -1;
            foreach (var name in volume.Where(bookInfo.Contains))
            {
                index = bookInfo.IndexOf(name, StringComparison.Ordinal);

                var len = bookInfo.Length;

                if (index <= 0 || index >= len) continue;

                var volNameNum = bookInfo.Substring(index);

                if (!validate.ValidateStringIsNotNull(volNameNum)) return -1;
                if (!validate.ValidateStringHasLength(volNameNum)) return -1;

                FormatBookDataProperties.BookSeriesVolumeNumber = volNameNum;

                break;
            }

            return index;
        }

        private bool CheckForBookSeries(List<string> seriesInfo, string bookInfo)
        {
            var alpha = FillListWithNumericValuesAsString();
            var numeric = FillListWithNumericValues();
            var volume = FillWithPossibleVolumeNames();
            return true;
        }

        private static IEnumerable<string> FillListWithNumericValues()
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

            return num;
        }

        private static IEnumerable<string> FillListWithNumericValuesAsString()
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
                "tem",
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

            return alpha;
        }

        private static List<string> FillWithPossibleVolumeNames()
        {
            var volume = new List<string>
            {
                "vol",
                "volume",
                "book",
                "num",
                "number"
            };
            return volume;
        }

        private List<string> FindTitleSeries(List<string> formattedBookData)
        {
            FindSeriesName(formattedBookData);


            return new List<string>();
        }

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

            if (seriesInfo.Count < 2) return new List<string>();

            bookInfo = bookInfo.ToLower();
            var retVal = this.CheckForBookSeries(seriesInfo, bookInfo);
            var volume = FillWithPossibleVolumeNames();

            var volIndex = CheckContainsBookVolume(bookInfo, volume);

            var formattedBookData = this.SplitBookSectionsTitleSeries(bookInfo, volIndex);
            var TitleSeriesVol = this.FindTitleSeries(formattedBookData);

            return seriesInfo;
        }

        private List<string> SplitBookSectionsTitleSeries(string bookInfo, int volIndex)
        {
            var temp = bookInfo.Substring(0, volIndex);

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