using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Security;
using BookList.Collections;

namespace BookList.Classes
{
    using System.Collections.Generic;

    public class FileOutputClass
    {
        /// ********************************************************************************
        /// <summary>
        ///     Write spelling words list to file.
        /// </summary>
        /// <param name="filePath">Path to write file to.</param>
        /// <param name="words"></param>
        /// <returns>True if file is written else false.</returns>
        /// <created>art2m,5/20/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static void WriteArthurFileNamesToListFile(string filePath)
        {
            try
            {
                using (var streamWriter = new StreamWriter(filePath, false))
                {
                    for (var index = 0; index < AuthorNamesListCollection.ItemsCount(); index++)
                        streamWriter.WriteLine(AuthorNamesListCollection.GetItemAt(index));
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     If adding new user  then write there name to the Art2MSpell user names file.
        /// </summary>
        /// <returns>True if write successful else false.</returns>
        /// <created>art2m,5/17/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static void WriteAuthorsTitlesToFile(string filePath, List<string> data)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                // Append line to the file.
                using (var writer = new StreamWriter(filePath, false))
                {
                    foreach (var value in data)
                    {
                        writer.WriteLine(value);
                    }
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
        }
    }
}