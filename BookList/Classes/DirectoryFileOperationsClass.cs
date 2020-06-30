using System.Runtime.CompilerServices;

namespace BookList.Classes
{
    using System;
    using System.Diagnostics;
    using System.IO;
    using System.Reflection;
    using PropertiesClasses;
    using JetBrains.Annotations;

    /// <summary>
    /// Class that contains code to create directories and files.
    /// </summary>
    public  class DirectoryFileOperationsClass
    {
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        /// Initializes  members of the <see cref="DirectoryFileOperationsClass"/> class.
        /// </summary>
        public DirectoryFileOperationsClass()
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
        public  string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(fileName)) return string.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = this.CombineDirectoryPathWithFileName(dirPath, fileName);

            if (this._validate.ValidateDirectoryExists(filePath)) return string.Empty;

            File.Create(filePath).Dispose();

            return filePath;
        }


        /// <summary>
        /// Combine directory name and file name.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public  string CombineDirectoryPathWithFileName([NotNull] string dirPath, [NotNull] string fileName)
        {
            if (!this._validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(fileName)) return string.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = Path.Combine(dirPath, fileName);

            return filePath;
        }

        /// <summary>
        /// Combine two strings to get complete path to directory
        /// </summary>
        /// <param name="dirPath">Directory name or path.</param>
        /// <param name="dirNewPath">Directory name, path or file name.</param>
        /// <returns>Path string to directories else empty string.</returns>
        public  string CombineExistingDirectoryPathWithNewDirectoryPath([NotNull] string dirPath,
            string dirNewPath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!this._validate.ValidateStringIsNotNull(dirNewPath)) return string.Empty;
            if (!this._validate.ValidateStringHasLength(dirNewPath)) return string.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var makePath = Path.Combine(dirPath, dirNewPath);

            return makePath;
        }

        /// <summary>
        /// Create new directory.
        /// </summary>
        /// <param name="dirNewPath"></param>
        /// <returns></returns>
        public  bool CreateNewDirectoryReturnPath(string dirNewPath)
        {
            if (!this._validate.ValidateStringIsNotNull(dirNewPath)) return false;
            if (!this._validate.ValidateStringHasLength(dirNewPath)) return false;

            _ = Directory.CreateDirectory(dirNewPath);

            return this._validate.ValidateDirectoryExists(dirNewPath);
        }

        /// <summary>
        /// The GetPathToSpecialDirectoryAppDataLocal.
        /// </summary>
        /// <returns>The <see cref="string" />.</returns>
        public  void GetPathToSpecialDirectoryAppDataLocal()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return;
            if (!this._validate.ValidateStringHasLength(dirPath)) return;

            BookListPropertiesClass.PathToAppDataDirectory = dirPath;
        }

        /// <summary>
        /// The CreateNewFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public  bool CreateNewFile(string filePath)
        {
            if (string.IsNullOrEmpty(filePath.Trim())) return false;
            if (File.Exists(filePath)) return true;

            _ = File.Create(filePath);

            if (!File.Exists(filePath)) return false;

            BookListPropertiesClass.PathOfCurrentWorkingFile = filePath;

            return true;
        }
    }
}