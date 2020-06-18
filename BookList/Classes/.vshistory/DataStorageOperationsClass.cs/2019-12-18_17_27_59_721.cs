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
        ///Backup AuthorsFileNamesCollection So if becomes corrupt while making changes to it.
        /// or the user changes there mind it can be restored.
        /// </summary>
        /// <param name="bkUpList">The backup list.</param>
        /// <returns>Empty backup list if AuthorsFileNamesCollection is empty.
        /// else returns copy of authorsFileNamesCollection.</returns>
        public static List<string> AddToBackUpList(List<string> bkUpList)
        {
            for (var index = 0; index < TitleNamesCollection.ItemsCount(); index++)
            {
                bkUpList.Add(TitleNamesCollection.GetItemAt(index));
            }

            return bkUpList;
        }
    }
}