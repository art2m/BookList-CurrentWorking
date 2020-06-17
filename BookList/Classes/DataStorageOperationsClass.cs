using System.Collections.Generic;
using BookList.Collections;

namespace BookList.Classes
{
    /// <summary>
    ///     Defines the <see cref="DataStorageOperationsClass" />
    /// </summary>
    public class DataStorageOperationsClass
    {
        /// <summary>
        ///     Backup AuthorsFileNamesCollection So if becomes corrupt while making changes to it.
        ///     or the user changes there mind it can be restored.
        /// </summary>
        /// <param name="bkUpList">The backup list.</param>
        /// <returns>The <see cref="List{string}" /></returns>
        public static List<string> AddToBackUpList(List<string> bkUpList)
        {
            for (var index = 0; index < BookInfoCollection.ItemsCount(); index++)
                bkUpList.Add(BookInfoCollection.GetItemAt(index));

            return bkUpList;
        }
    }
}