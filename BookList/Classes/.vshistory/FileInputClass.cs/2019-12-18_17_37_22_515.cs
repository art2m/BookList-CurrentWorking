// BookList
// 
// FileInputClass.cs
// 
// Art2M
// 
// art2m@live.com
// 
// 11  04  2019
// 
// 10  26   2019
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
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using Collections;

    public static class FileInputClass
    {
        private const string V = "Not enough memory to continue. Try closing other windows.";
        private const string V1 = "The file path value is a null string. ";
        private const string V2 = "The file path value is an empty string.";
        private const string V3 = "Unable to locate this file. ";
        private const string V4 = "Unable to locate the directory.";
        private const string V5 = "File path has invalid characters in it.";
        private const string V6 = "The file path value is a null string. ";
        private const string V7 = "The file path value is an empty string.";
        private const string V8 = "Unable to locate this file. ";
        private const string V9 = "Unable to locate the directory.";
        private const string V10 = "File path has invalid characters in it.";
        private const string V11 = "The file path value is a null string. ";

        /// <summary>
        /// Initializes static members of the <see cref="FileInputClass"/> class.
        /// </summary>
        static FileInputClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        
        public static List<string> ReadTextDataFromFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var data = new List<string>();
            try
            {
                var isFile = File.Exists(filePath);

                using (var sr = new StreamReader(filePath))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null) data.Add(line);
                }

                return data;
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = V;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V1 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V2;

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V3 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return new List<string>(Array.Empty<string>());
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V4;

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = V5;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
        }

       
        public static void ReadTitlesFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) TitleNamesCollection.AddItem(line);
                }
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V6 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V7;

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V8 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V9;

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = V10;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }
       
        public static void ReadUnformattedDataFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null) UnformattedDataCollection.AddItem(line);
                }
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V11 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }
    }
}
