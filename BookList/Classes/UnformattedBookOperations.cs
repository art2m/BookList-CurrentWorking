using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using BookList.Collections;

namespace BookList.Classes
{
    public class UnformattedBookOperations
    {
        // TODO: remove this class if not used to find title, series and volume.
        public List<string> LocateSeriesPartOfBookInformation(string filePath, string bookInfo)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;


            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(filePath)) return new List<string>();
            if (!ValidationClass.CheckForInvalidPathCharacters(filePath)) return new List<string>();
            if (!ValidationClass.ValidateFileExits(filePath)) return new List<string>();

            var seriesInfo = FileInputClass.ReadAuthorNamesFromFile(filePath);

            if (seriesInfo.Count < 2) return new List<string>();

            bookInfo = bookInfo.ToLower();
            var volume = FillWithPossibleVolumeNames();
            var volNameNum = string.Empty;
            var volIndex = CheckContainsBookVolume(bookInfo, volume, volNameNum);
            var formattedBookData = this.SplitBookSectionsTitleSeriesVolumeNumber(bookInfo, volIndex);
            //List<string> TitleSeriesVol = FindTitleSeries(formattedBookData);

            //var retVal = this.CheckForBookSeries(seriesInfo, bookInfo);

            return seriesInfo;
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

        private bool CheckForBookSeries(List<string> seriesInfo, string bookInfo)
        {
            var alpha = FillListWithNumericValuesAsString();
            var numeric = FillListWithNumericValues();
            return true;
        }

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

        private List<string> SplitBookSectionsTitleSeriesVolumeNumber(string bookInfo, int volIndex)
        {
            var temp = bookInfo.Substring(0, volIndex);

            var val = temp.Split(' ');

            var titleSeriesList = new List<string>(val);
            return titleSeriesList;
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
                ("nineteen"),
                "twenty",
                "twenty One",
                "twenty two",
                "twenty three",
                "twenty four",
                "twenty five"
            };

            return alpha;
        }
    }
}