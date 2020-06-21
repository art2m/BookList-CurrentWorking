// BookList
// 
// BookListOperationsClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 08  14  2019
// 
// 08  14   2019
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Drawing.Text;
    using System.IO;
    using System.Linq;
    using System.Runtime.Remoting.Messaging;
    using Collections;
    using PropertiesClasses;

    public class BookListOperationsClass
    {
        public bool CheckBookListStringIsFileName(string value)
        {
            if (value.Contains("***")) return false;

            var fileName = this.GetFileNameFromString(value);
            return true;
        }


        private string GetFileNameFromString(string value)
        {
            var fileName = string.Empty;

            fileName = value.Replace("*", "");

            if (!ValidationClass.ValidateStringValueNotEmptyNotWhiteSpace(fileName)) return fileName;

            BookListPropertiesClass.CurrentWorkingFileName = fileName;
            return fileName;
        }


        /// <summary>
        /// Updates the authors list of names with any author file names not
        /// not previously added. This is list of names is used to tell if this author has been
        /// previously read. It is then used to add books read to this author or check if a book has been read.
        /// </summary>
        /// <returns></returns>
        public bool UpdateAuthorNamesFileList()
        {
            var bookListPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            var dir = new DirectoryInfo(bookListPath);
            var files = dir.GetFiles("*.dat");
            var authors = files.Select(file => file.ToString()).ToList();

            this.ReadCurrentAuthorsListFile(authors);

            return true;
        }

        public bool ReadCurrentAuthorsListFile(List<string> authors)
        {


            return true;
        }
    }
    }
}