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

        public static List<string> AddToBackUpList(List<string> bkupList)
        {
            for (var index = 0; index < AuthorsFileNamesCollection.ItemsCount(); index++)
            {
                bkupList.Add(AuthorsFileNamesCollection.GetItemAt(index));
            }

            return bkupList;
        }
    }
}