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
       
        public void AddToBackUpList()
        {
            for (var index = 0; index < UnformattedDataCollection.GetItemsCount(); index++)
            {
                UnformattedDataBackUpCollection.AddItem(UnformattedDataCollection.GetItemAt(index));
                Debug.WriteLine(UnformattedDataCollection.GetItemAt(index));
            }
        }
    }
}