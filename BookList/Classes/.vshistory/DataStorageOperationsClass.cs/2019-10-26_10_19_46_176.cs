using System.Collections.Generic;
using System.IO;
using System.Linq;
using BookList.Collections;
using JetBrains.Annotations;

namespace BookList.Classes
{
    public class DataStorageOperationsClass
    {
        public DataStorageOperationsClass()
        {
        }

        public static bool AddToBackUpList([NotNull] string filePath)
        {
            //if (!ValidationClass.ValidateStringValueNotEmptyNotWhiteSpace(filePath)) return false;

            //if (!ValidationClass.ValidateFileExits(filePath)) return false;

            //var data = FileInputClass.ReadTextDataFromFile(filePath);

            return FillBackUpList();
        }

        private static bool FillBackUpList(List<string> bkupList)
        {
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                bkupList.Add(AuthorsFileNamesCollection.GetItemAt(index));
            }

            return bkupList.Count > 0;
        }
    }
}