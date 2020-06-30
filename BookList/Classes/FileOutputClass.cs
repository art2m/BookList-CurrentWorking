namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using System.Security;
    using BookList.Collections;

    /// <summary>
    /// Defines the <see cref="FileOutputClass" />.
    /// </summary>
    public  class FileOutputClass
    {
         public FileOutputClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        /// Write arthur names to file.
        /// </summary>
        /// <param name="filePath">Path to write file to.</param>
        /// <returns>True if file is written else false.</returns>
        public  bool WriteArthurFileNamesToListFile(string filePath)
        {
            var validate = new ValidationClass();

            if (!validate.ValidateStringIsNotNull(filePath)) return false;
            if (!validate.ValidateStringHasLength(filePath)) return false;
            if (!validate.ValidateFileExists(filePath)) return false;
            if (!validate.CheckForInvalidPathCharacters(filePath)) return false;

            try
            {
                using (var streamWriter = new StreamWriter(filePath, false))
                {
                    for (var index = 0; index < AuthorNamesListCollection.ItemsCount(); index++)
                    {
                        streamWriter.WriteLine(AuthorNamesListCollection.GetItemAt(index));
                    }
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have access writes for this operation.";

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

            return false;
        }

        /// <summary>
        /// If adding new user  then write there name to the Art2MSpell user names file.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>True if write successful else false.</returns>
        public  bool WriteAuthorsTitlesToFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                // Append line to the file.
                using (var writer = new StreamWriter(filePath, false))
                {
                    for (var i = 0; i < UnformattedDataCollection.GetItemsCount(); i++)
                    {
                        writer.WriteLine(UnformattedDataCollection.GetItemAt(i));
                    }

                    return true;
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
                MyMessagesClass.ErrorMessage = $"The path variable contains a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = $"The file path value is a null string. {filePath}";

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
                MyMessagesClass.ErrorMessage = $"File path has invalid characters in it. {filePath}";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
            }

            return false;
        }

        /// <summary>
        /// writes book info to the authors file.
        ///     If Not book series then writes book title name.
        ///     if Series writes book title, series name, volume number.
        /// </summary>
        /// <param name="filePath">.</param>
        /// <param name="bookInfo">.</param>
        public  bool WriteBookTitleSeriesVolumeNamesToAuthorsFile(string filePath)
        {
            try
            {
                if (string.IsNullOrEmpty(filePath)) return false;
                if (!File.Exists(filePath)) return false;

                using (var writer = new StreamWriter(filePath, true))
                {
                    for (var i = 0; i < UnformattedDataCollection.GetItemsCount(); i++)
                    {
                        writer.WriteLine(UnformattedDataCollection.GetItemAt(i));
                    }
                }

                return true;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have access writes for this operation.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = $"The path variable contains a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = $"The file path value is a null string. {filePath}";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "the file path is to long.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
            catch (SecurityException ex)
            {
                MyMessagesClass.ErrorMessage = "The operation has caused a security violation.";

                Debug.WriteLine(ex.ToString());
                return false;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = $"File path has invalid characters in it. {filePath}";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
        }
    }
}