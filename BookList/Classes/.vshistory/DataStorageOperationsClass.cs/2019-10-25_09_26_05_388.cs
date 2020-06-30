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

        public bool AddRawDataReadFromFileToRawDataCollection([NotNull] string filePath)
        {
            if (ValidationClass.ValidateStringValueNotEmptyNotWhiteSpace(filePath)) return false;

            if (!ValidationClass.ValidateFileExits(filePath)) return false;

            var data = FileInputClass.ReadTextDataFromFile(filePath);

            return FillRawDataCollection(data);
        }

        private static bool FillRawDataCollection(IEnumerable<string> data)
        {
            foreach (var value in data)
            {
                RawDataCollection.AddItem(value);
            }

            return RawDataCollection.GetItemsCount() > 0;
        }
    }
}