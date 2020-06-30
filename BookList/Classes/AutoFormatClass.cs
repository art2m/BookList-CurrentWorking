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

        private static int CheckContainsBookVolume(string bookInfo, List<string> volume, string volNameNum)
        {
            var index = -1;
            foreach (var name in volume.Where(bookInfo.Contains))
            {
                index = bookInfo.IndexOf(name, StringComparison.Ordinal);

                var len = bookInfo.Length;
                if (index < len)
                {
                    volNameNum = bookInfo.Substring(index, len);
                    break;
                }
            }

            if (!string.IsNullOrEmpty(volNameNum))
            {
                volNameNum = volNameNum.Trim();
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
            foreach (var val in formattedBookData)
            {
                for (var index = 0; index < UnformattedDataCollection.GetItemsCount(); index++)
                {
                }
            }

            return new List<string>();
        }

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
            var volNameNum = string.Empty;
            var volIndex = CheckContainsBookVolume(bookInfo, volume, volNameNum);
            var formattedBookData = this.SplitBookSectionsTitleSeriesVolumeNumber(bookInfo, volIndex);
            var TitleSeriesVol = this.FindTitleSeries(formattedBookData);

            return seriesInfo;
        }

        private List<string> SplitBookSectionsTitleSeriesVolumeNumber(string bookInfo, int volIndex)
        {
            var temp = bookInfo.Substring(0, volIndex);

            var val = temp.Split(' ');

            var titleSeriesList = new List<string>(val);
            return titleSeriesList;
        }
    }
}