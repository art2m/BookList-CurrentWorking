namespace BookList.Classes
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Security;

    /// ********************************************************************************
    /// <summary>
    ///     used to read write spelling list user list and read header from spelling list files.
    /// </summary>
    /// ********************************************************************************
    public static class BookListReadWriteClass
    {
        /// ********************************************************************************
        /// <summary>
        ///     Used to get class name. For user with error messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/21/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        static BookListReadWriteClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Reads the spelling list from the file the user has opened.
        /// </summary>
        /// <param name="filePath">The file path to the spelling list user wishes to open.</param>
        /// <returns>True if the spelling list words are added to collection else false.</returns>
        /// <created>art2m,5/10/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static List<string> ReadAuthorsListFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                string[] spell;
                using (var fileRead = new StreamReader(filePath))
                {
                    spell = fileRead.ReadToEnd().Split(',');
                }

                return new List<string>(spell);
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


        /// <summary>
        /// Reads the authors titles from file.
        /// </summary>
        /// <param name="filePath">The file path to authors titles file.</param>
        /// <returns></returns>
        public static List<string> ReadAuthorsTitlesFromFile(string filePath)
        {
            var userNames = new List<string>();

            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                using (var reader = new StreamReader(filePath))
                {
                    string user;
                    while ((user = reader.ReadLine()) != null)
                    {
                        userNames.Add(user.Trim());
                    }
                }

                return userNames;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return userNames;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return userNames;
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return userNames;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return userNames;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return userNames;
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
        public static List<string> ReadTitlesFromFile(string filePath)
        {
            var userName = new List<string>();
            try
            {
                if (!File.Exists(filePath))
                {
                    return userName;
                }

                using (var reader = new StreamReader(filePath))
                {
                    string user;
                    while ((user = reader.ReadLine()) != null)
                    {
                        userName.Add(user.Trim());
                    }
                }

                return userName;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return userName;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is an empty string.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return userName;
            }
            catch (FileNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate this file. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();
                return userName;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                Debug.WriteLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return userName;
            }
            catch (IOException ex)
            {
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return userName;
            }
        }

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
        public static bool WriteArthurNamesToFile(string filePath, IEnumerable<string> words)
        {
            var wordsCsv = string.Join(",", words.ToArray());
            try
            {
                File.WriteAllText(filePath, wordsCsv);
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
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

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
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
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
        public static bool WriteAuthorsTitlesToFile(string filePath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            try
            {
                // Append line to the file.
                using (var writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(UserPropertiesClass.UserName);
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
                MyMessagesClass.ErrorMessage = "The path variable contains a null string. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "The file path value is a null string. " + filePath;

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
                MyMessagesClass.ErrorMessage = "File path has invalid characters in it. " + filePath;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Writes file that contains all of the paths to users spelling list file.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static bool WriteUsersSpellingListPathsFile()
        {
            return true;
        }
    }
}
