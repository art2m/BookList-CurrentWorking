using System.Runtime.CompilerServices;

namespace BookList.Classes
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using BookList.PropertiesClasses;
    using JetBrains.Annotations;

    /// <summary>
    /// Class that contains code to create directories and files.
    /// </summary>
    public static class DirectoryFileOperationsClass
    {
        /// <summary>
        /// Defines the V.
        /// </summary>
        private const string V = "Encountered Error when combining directory paths or creating directory.";

        /// <summary>
        /// Defines the V1.
        /// </summary>
        private const string V1 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        /// Defines the V2.
        /// </summary>
        private const string V2 = "The directory path is to long.";

        /// <summary>
        /// Defines the V3.
        /// </summary>
        private const string V3 = "Unable to locate the directory.";

        /// <summary>
        /// Defines the V4.
        /// </summary>
        private const string V4 = "Not supported for this platform.";

        /// <summary>
        /// Defines the V5.
        /// </summary>
        private const string V5 = "Encountered error while creating directory.";

        /// <summary>
        /// Defines the V6.
        /// </summary>
        private const string V6 = "Encountered Error when combining directory paths or creating directory.";

        /// <summary>
        /// Defines the V7.
        /// </summary>
        private const string V7 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        /// Defines the V8.
        /// </summary>
        private const string V8 = "The directory path is to long.";

        /// <summary>
        /// Defines the V9.
        /// </summary>
        private const string V9 = "Unable to locate the directory.";

        /// <summary>
        /// Defines the V10.
        /// </summary>
        private const string V10 = "Not supported for this platform.";

        /// <summary>
        /// Defines the V11.
        /// </summary>
        private const string V11 = "Encountered error while creating directory.";

        /// <summary>
        /// Defines the V12.
        /// </summary>
        private const string V12 = "One or both of the path strings is null.";

        /// <summary>
        /// Defines the V13.
        /// </summary>
        private const string V13 = "Possible invalid characters in path string.";

        /// <summary>
        /// Defines the V14.
        /// </summary>
        private const string V14 = "Encountered Error when combining directory paths or creating directory.";

        /// <summary>
        /// Defines the V15.
        /// </summary>
        private const string V15 = "You do not have necessary security rating to perform this operation.";

        /// <summary>
        /// Defines the V16.
        /// </summary>
        private const string V16 = "The directory path is to long.";

        /// <summary>
        /// Defines the V17.
        /// </summary>
        private const string V17 = "Unable to locate the directory.";

        /// <summary>
        /// Defines the V18.
        /// </summary>
        private const string V18 = "Not supported for this platform.";

        /// <summary>
        /// Defines the V19.
        /// </summary>
        private const string V19 = "Encountered error while creating directory.";

        /// <summary>
        /// Initializes static members of the <see cref="DirectoryFileOperationsClass"/> class.
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
        /// Combine directory and file name. Check if file exists if not create it.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(dirPath)) return string.Empty;
            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(fileName)) return string.Empty;
            if (!ValidationClass.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = CombineDirectoryPathWithFileName(dirPath, fileName);
            if (ValidationClass.ValidateStringValueNotNullNotEmpty(filePath)) return string.Empty;

            if (ValidationClass.ValidateDirectoryExists(filePath)) return string.Empty;

            File.Create(filePath).Dispose();

            return filePath;
        }


        /// <summary>
        /// Combine directory name and file name.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public static string CombineDirectoryPathWithFileName([NotNull] string dirPath, [NotNull] string fileName)
        {
            try
            {
                if (!ValidationClass.ValidateStringValueNotNullNotEmpty(dirPath)) return string.Empty;
                if (!ValidationClass.ValidateStringValueNotNullNotEmpty(fileName)) return string.Empty;
                if (!ValidationClass.ValidateDirectoryExists(dirPath)) return string.Empty;

                var filePath = Path.Combine(dirPath, fileName);

                return filePath;
            }
            catch (PathTooLongException ex)
            {
                MyMessagesClass.ErrorMessage = V8;

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(ex.ToString());

                return string.Empty;
            }
        }

        /// <summary>
        /// Combine two strings to get complete path to directory
        /// </summary>
        /// <param name="dirPath">Directory name or path.</param>
        /// <param name="dirNewPath">Directory name, path or file name.</param>
        /// <returns>Path string to directories else empty string.</returns>
        public static string CombineExistingDirectoryPathWithNewDirectoryPath([NotNull] string dirPath,
            string dirNewPath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(dirPath)) return string.Empty;
            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(dirNewPath)) return string.Empty;
            if (!ValidationClass.ValidateDirectoryExists(dirPath)) return string.Empty;

            var makePath = Path.Combine(dirPath, dirNewPath);


            return makePath;
        }

        /// <summary>
        /// Create new directory.
        /// </summary>
        /// <param name="dirNewPath"></param>
        /// <returns></returns>
        public static bool CreateNewDirectoryReturnPath(string dirNewPath)
        {
            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(dirNewPath)) return false;

            Directory.CreateDirectory(dirNewPath);

            return ValidationClass.ValidateDirectoryExists(dirNewPath);
        }

        /// <summary>
        /// The GetPathToSpecialDirectoryAppDataLocal.
        /// </summary>
        /// <returns>The <see cref="string" />.</returns>
        public static void GetPathToSpecialDirectoryAppDataLocal()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!ValidationClass.ValidateStringValueNotNullNotEmpty(dirPath)) return;
            BookListPropertiesClass.PathToAppDataDirectory = dirPath;
        }

        /// <summary>
        /// The CreateNewFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
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