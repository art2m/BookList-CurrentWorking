namespace BookList.Classes
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;

    /// <summary>
    ///     Class that contains code to create directories and files.
    /// </summary>
    public static class DirectoryFileOperationsClass
    {
        /// ********************************************************************************
        /// <summary>
        ///     Constructor used to set class name for use with message boxes.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        static DirectoryFileOperationsClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }


        public string GetPathToSpecialDirectoryAppDataLocal()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!ValidationClass.ValidateStringValueNotEmptyNotWhiteSpace(dirPath)) return string.Empty;

            return !ValidationClass.ValidateDirectoryExists(dirPath) ? string.Empty : dirPath;
        }

        /// ********************************************************************************
        /// <summary>
        ///     Creates directories if they do not exist in supplied path;
        /// </summary>
        /// <param name="dirPath">The path to create directories from.</param>
        /// <returns>Directory path if they exist or were created else returns empty string.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CheckDirectoryExistsCreateDirectory(string dirPath)
        {
            try
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                if (Directory.Exists(dirPath))
                {
                    return dirPath;
                }

                Directory.CreateDirectory(dirPath);

                return dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage =
                    "Encountered Error when combining directory paths or creating directory.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have necessary security rating to perform this operation.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "The directory path is to long.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = "Not supported for this platform.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "Encountered error while creating directory.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Combine two strings to get complete path to directory First Directory must
        ///     all ready exist.  Check to see if directory path exists if so return path string. else
        ///     create new directory.
        /// </summary>
        /// <param name="first">Directory name or path.</param>
        /// <param name="second">Directory name, path or file name.</param>
        /// <returns>Path string to directories else empty string.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CombineStringsMakeDirectoryPath(string first, string second)
        {
            try
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var makePath = Path.Combine(first, second);

                var dirPath = CheckDirectoryExistsCreateDirectory(makePath);

                return dirPath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = "One or both of the path strings is null.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "Possible invalid characters in path string.";

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return string.Empty;
            }
        }

        /// ********************************************************************************
        /// <summary>
        ///     Combine directory name with file name. Check to see if file exists if it does
        ///     return file path else create file.
        /// </summary>
        /// <param name="dirPath">Directory path to join with file name.</param>
        /// <param name="fileName">The file name to create.</param>
        /// <returns>File path if exists or is created. else return empty string.</returns>
        /// <created>art2m,5/23/2019</created>
        /// <changed>art2m,5/23/2019</changed>
        /// ********************************************************************************
        public static string CombineDirectoryPathFileNameCheckCreateFile(string dirPath, string fileName)
        {
            try
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var filePath = Path.Combine(dirPath, fileName);

                if (!File.Exists(filePath))
                {
                    File.Create(filePath).Dispose();
                }

                return !File.Exists(filePath) ? string.Empty : filePath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage =
                    "Encountered Error when combining directory paths or creating directory.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = "You do not have necessary security rating to perform this operation.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = "The directory path is to long.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = "Unable to locate the directory.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = "Not supported for this platform.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = "Encountered error while creating directory.";

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
        }
    }
}
