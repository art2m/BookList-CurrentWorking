namespace BookList.Classes
{
    using System.Collections.Generic;
    using System.Diagnostics;
    using BookList.Collections;

    /// <summary>
    /// Defines the <see cref="DataStorageOperationsClass" />.
    /// </summary>
    public class DataStorageOperationsClass
    {
        /// <summary>
        /// Create a backup of all unformatted data. This will allow the user to roll back
        /// changes.
        /// </summary>
        public static void AddToBackUpList()
        {
            for (var index = 0; index < UnformattedDataCollection.GetItemsCount(); index++)
            {
                UnformattedDataBackUpCollection.AddItem(UnformattedDataCollection.GetItemAt(index));
                Debug.WriteLine(UnformattedDataCollection.GetItemAt(index));
            }
        }
    }
}