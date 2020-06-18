using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using BookList.PropertiesClasses;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    ///     Class that contains code to create directories and files.
    /// </summary>
    public static class DirectoryFileOperationsClass
    {
        /// <summary>
        ///     Defines the V
        /// </summary>
        private const string V = "Encountered Error when combining directory paths or creating directory.";

        /// <summary>
        ///     Defines the V1
        /// </summary>
        private const string V1 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        ///     Defines the V2
        /// </summary>
        private const string V2 = "The directory path is to long.";

        /// <summary>
        ///     Defines the V3
        /// </summary>
        private const string V3 = "Unable to locate the directory.";

        /// <summary>
        ///     Defines the V4
        /// </summary>
        private const string V4 = "Not supported for this platform.";

        /// <summary>
        ///     Defines the V5
        /// </summary>
        private const string V5 = "Encountered error while creating directory.";

        /// <summary>
        ///     Defines the V6
        /// </summary>
        private const string V6 = "Encountered Error when combining directory paths or creating directory.";

        /// <summary>
        ///     Defines the V7
        /// </summary>
        private const string V7 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        ///     Defines the V8
        /// </summary>
        private const string V8 = "The directory path is to long.";

        /// <summary>
        ///     Defines the V9
        /// </summary>
        private const string V9 = "Unable to locate the directory.";

        /// <summary>
        ///     Defines the V10
        /// </summary>
        private const string V10 = "Not supported for this platform.";

        /// <summary>
        ///     Defines the V11
        /// </summary>
        private const string V11 = "Encountered error while creating directory.";

        /// <summary>
        ///     Defines the V12
        /// </summary>
        private const string V12 = "One or both of the path strings is null.";

        /// <summary>
        ///     Defines the V13
        /// </summary>
        private const string V13 = "Possible invalid characters in path string.";

        /// <summary>
        ///     Defines the V14
        /// </summary>
        private const string V14 = "Encountered Error when combining directory paths or creating directory.";

        /// <summary>
        ///     Defines the V15
        /// </summary>
        private const string V15 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        ///     Defines the V16
        /// </summary>
        private const string V16 = "The directory path is to long.";

        /// <summary>
        ///     Defines the V17
        /// </summary>
        private const string V17 = "Unable to locate the directory.";

        /// <summary>
        ///     Defines the V18
        /// </summary>
        private const string V18 = "Not supported for this platform.";

        /// <summary>
        ///     Defines the V19
        /// </summary>
        private const string V19 = "Encountered error while creating directory.";

        /// <summary>
        ///     Initializes static members of the <see cref="DirectoryFileOperationsClass" /> class.
        /// </summary>
        static DirectoryFileOperationsClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        ///     The CombineDirectoryPathFileNameCheckCreateFile
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" /></param>
        /// <param name="fileName">The fileName<see cref="string" /></param>
        /// <returns>The <see cref="string" /></returns>
        public static string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName)
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
                MyMessagesClass.ErrorMessage = V;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V1;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V2;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V3;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = V4;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V5;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
        }

        /// <summary>
        ///     The CombineDirectoryPathWithFileName
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" /></param>
        /// <param name="fileName">The fileName<see cref="string" /></param>
        /// <returns>The <see cref="string" /></returns>
        public static string CombineDirectoryPathWithFileName([NotNull] string dirPath, [NotNull] string fileName)
        {
            try
            {
                var filePath = Path.Combine(dirPath, fileName);

                return filePath;
            }
            catch (ArgumentNullException ex)
            {
                MyMessagesClass.ErrorMessage = V6;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V7;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V8;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V9;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = V10;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V11;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
        }

        /// <summary>
        ///     Combine two strings to get complete path to directory First Directory must
        ///     all ready exist.  Check to see if directory path exists if so return path string. else
        ///     create new directory.
        /// </summary>
        /// <param name="first">Directory name or path.</param>
        /// <param name="second">Directory name, path or file name.</param>
        /// <returns>Path string to directories else empty string.</returns>
        public static string CombineStringsMakeDirectoryPath([NotNull] string first, string second)
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
                MyMessagesClass.ErrorMessage = V12;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V13;

                Debug.WriteLine(ex.ToString());

                MyMessagesClass.ShowErrorMessageBox();

                return string.Empty;
            }
        }

        /// <summary>
        ///     The CheckDirectoryExistsCreateDirectory
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" /></param>
        /// <returns>The <see cref="string" /></returns>
        public static string CheckDirectoryExistsCreateDirectory([NotNull] string dirPath)
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
                MyMessagesClass.ErrorMessage = V14;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (UnauthorizedAccessException ex)
            {
                MyMessagesClass.ErrorMessage = V15;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V16;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (DirectoryNotFoundException ex)
            {
                MyMessagesClass.ErrorMessage = V17;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (NotSupportedException ex)
            {
                MyMessagesClass.ErrorMessage = V18;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
            catch (ArgumentException ex)
            {
                MyMessagesClass.ErrorMessage = V19;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());
                return string.Empty;
            }
        }

        /// <summary>
        ///     The GetPathToSpecialDirectoryAppDataLocal
        /// </summary>
        /// <returns>The <see cref="string" /></returns>
        public static string GetPathToSpecialDirectoryAppDataLocal()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!ValidationClass.ValidateStringValueNotNullNotWhiteSpace(dirPath)) return string.Empty;

            return !ValidationClass.ValidateDirectoryExists(dirPath) ? string.Empty : dirPath;
        }

        /// <summary>
        ///     The CreateNewFile
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" /></param>
        /// <returns>The <see cref="bool" /></returns>
        public static bool CreateNewFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath.Trim())) return false;
            if (File.Exists(filePath)) return true;

            using (File.Create(filePath))
            {
            }

            if (!File.Exists(filePath)) return false;

            BookListPropertiesClass.PathOfCurrentWorkingFile = filePath;

            return true;
        }
    }
}