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

        private static bool FillBackUpList()
        {
            
            {
                RawDataCollection.AddItem(value);
            }

            return RawDataCollection.GetItemsCount() > 0;
        }
    }
}