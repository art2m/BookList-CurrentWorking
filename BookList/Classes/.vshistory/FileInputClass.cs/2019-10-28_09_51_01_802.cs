// BookList
//
// FileInputClass.cs
//
// Art2M
//
// art2m@live.com
//
// 10  07  2019
//
// 08  15   2019
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
    using System.Security;
    using Collections;

    /// ********************************************************************************
    /// <summary>
    ///     used to read write spelling list user list and read header from spelling list files.
    /// </summary>
    /// ********************************************************************************
    public static class FileInputClass
    {
        /// ********************************************************************************
        /// <summary>
        ///     Used to get class name. For user with error messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
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
                    while ((line = sr.ReadLine()) != null)
                    {
                        data.Add(line);
                    }
                }

                return data;
            }
            catch (OutOfMemoryException ex)
            {
                MyMessagesClass.ErrorMessage = "Not enough memory to continue. Try closing other windows.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return new List<string>(Array.Empty<string>());
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return new List<string>(Array.Empty<string>());
            }
        }

        public static void ReadUnformattedDataFromFile(string filePath)
        {
            if (!File.Exists(filePath)) return;

            using (var sr = new StreamReader(filePath))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    UnformattedDataCollection.AddItem(line);
                }
            }

        }



        /// ********************************************************************************
        /// <summary>
        ///     Reads file that contains all of the paths To users spelling List file.
        /// </summary>
        /// <returns>True if file read is successful.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static void ReadTitlesFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath)) return;

                using (var sr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = sr.ReadLine()) != null)
                    {
                        TitleNamesCollection.AddItem(line);
                    }
                }
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

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