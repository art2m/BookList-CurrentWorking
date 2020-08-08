namespace BookList.Classes
{
    using System.Collections.Generic;

    using BookList.Collections;

    /// <summary>
    /// Defines the <see cref="DataStorageOperationsClass" />
    /// </summary>
    public class DataStorageOperationsClass
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataStorageOperationsClass"/> class.
        /// </summary>
        public DataStorageOperationsClass()
        {
        }

        /// <summary>
        /// Backup AuthorsFileNamesCollection So if becomes corrupt while making changes to it.
        /// or the user changes there mind it can be restored.
        /// </summary>
        /// <param name="bkUpList">The backup list.</param>
        /// <returns>The <see cref="List{string}"/></returns>
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
