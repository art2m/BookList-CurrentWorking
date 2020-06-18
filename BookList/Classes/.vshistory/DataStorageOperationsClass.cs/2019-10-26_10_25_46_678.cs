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

        /// <summary>
        /// Adds to back up list.
        /// </summary>
        /// <param name="bkupList">The bkup list.</param>
        /// <returns></returns>
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