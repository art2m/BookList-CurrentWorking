using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;
using BookList.Collections;

namespace BookList.Classes
{
    using System.Collections.Generic;

    public static class FileOutputClass
    {
        private const string V7 = "You do not have access writes for this operation.";
        private const string V = V7;
        private const string V1 = "The path variable contains a null string. ";
        private const string V2 = "The file path value is a null string. ";
        private const string V3 = "Unable to locate the directory.";
        private const string V4 = "the file path is to long.";
        private const string V5 = "The operation has caused a security violation.";
        private const string V6 = "File path has invalid characters in it. ";

        /// ********************************************************************************
        /// <summary>
        ///     Write spelling words list to file.
        /// </summary>
        /// <param name="filePath">Path to write file to.</param>
        /// <returns>True if file is written else false.</returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool WriteArthurFileNamesToListFile(string filePath)
        {
            try
            {
                using (var streamWriter = new StreamWriter(filePath, false))
                {
                    for (var index = 0; index < AuthorNamesListCollection.ItemsCount(); index++)
                        streamWriter.WriteLine(AuthorNamesListCollection.GetItemAt(index));
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V1 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V2 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V3;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V4;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = V5;

                Debug.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = V6 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }

            return false;
        }

        /// ********************************************************************************
        /// <summary>
        ///     If adding new user  then write there name to the Art2MSpell user names file.
        /// </summary>
        /// <returns>True if write successful else false.</returns>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool WriteAuthorsTitlesToFile(string filePath, List<string> data)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                // Append line to the file.
                using (var writer = new StreamWriter(filePath, false))
                {
                    foreach (var item in data)
                    {
                        writer.WriteLine(item);
                    }

                    return true;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V7;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V1 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V2 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V3;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V4;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = V5;

                Debug.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = V6 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }

            return false;
        }

        /// <summary>
        ///  writes book info to the authors file.
        /// If Not book series then writes book title name.
        /// if Series writes book title, series name, volume number.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="bookInfo"></param>
        public static void WriteBookTitleSeriesVolumeNamesToAuthorsFile(string filePath, string bookInfo)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) return;
                if (string.IsNullOrEmpty(bookInfo)) return;
                if (!File.Exists(filePath)) return;

                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(bookInfo);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V7;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V1 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V2 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V3;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V4;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = V5;

                Debug.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = V6 + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }
    }
}