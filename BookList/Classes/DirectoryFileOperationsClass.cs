// BookList
// 
// DirectoryFileOperationsClass.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 07    03   2020
// 
// 
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU Lesser General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// 
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU Lesser General Public License for more details.
// 
// You should have received a copy of the GNU Lesser General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>

using System;
using System.IO;
using System.Reflection;
using BookList.PropertiesClasses;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    ///     Class that contains code to create directories and files.
    /// </summary>
    public class DirectoryFileOperationsClass
    {
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Initializes  members of the <see cref="DirectoryFileOperationsClass" /> class.
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
        ///     Combine directory and file name. Check if file exists if not create it.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!_validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!_validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!_validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            if (!_validate.ValidateStringHasLength(fileName)) return string.Empty;
            if (!_validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = CombineDirectoryPathWithFileName(dirPath, fileName);

            if (_validate.ValidateDirectoryExists(filePath)) return string.Empty;

            File.Create(filePath).Dispose();

            return filePath;
        }


        /// <summary>
        ///     Combine directory name and file name.
        /// </summary>
        /// <param name="dirPath">The dirPath<see cref="string" />.</param>
        /// <param name="fileName">The fileName<see cref="string" />.</param>
        /// <returns>The <see cref="string" />.</returns>
        public string CombineDirectoryPathWithFileName([NotNull] string dirPath, [NotNull] string fileName)
        {
            if (!_validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!_validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!_validate.ValidateStringIsNotNull(fileName)) return string.Empty;
            if (!_validate.ValidateStringHasLength(fileName)) return string.Empty;
            if (!_validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var filePath = Path.Combine(dirPath, fileName);

            return filePath;
        }

        /// <summary>
        ///     Combine two strings to get complete path to directory
        /// </summary>
        /// <param name="dirPath">Directory name or path.</param>
        /// <param name="dirNewPath">Directory name, path or file name.</param>
        /// <returns>Path string to directories else empty string.</returns>
        public string CombineExistingDirectoryPathWithNewDirectoryPath([NotNull] string dirPath,
            string dirNewPath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!_validate.ValidateStringIsNotNull(dirPath)) return string.Empty;
            if (!_validate.ValidateStringHasLength(dirPath)) return string.Empty;
            if (!_validate.ValidateStringIsNotNull(dirNewPath)) return string.Empty;
            if (!_validate.ValidateStringHasLength(dirNewPath)) return string.Empty;
            if (!_validate.ValidateDirectoryExists(dirPath)) return string.Empty;

            var makePath = Path.Combine(dirPath, dirNewPath);

            return makePath;
        }

        /// <summary>
        ///     Create new directory.
        /// </summary>
        /// <param name="dirNewPath"></param>
        /// <returns></returns>
        public bool CreateNewDirectoryReturnPath(string dirNewPath)
        {
            if (!_validate.ValidateStringIsNotNull(dirNewPath)) return false;
            if (!_validate.ValidateStringHasLength(dirNewPath)) return false;

            _ = Directory.CreateDirectory(dirNewPath);

            return _validate.ValidateDirectoryExists(dirNewPath);
        }

        /// <summary>
        ///     The GetPathToSpecialDirectoryAppDataLocal.
        /// </summary>
        /// <returns>The <see cref="string" />.</returns>
        public void GetPathToSpecialDirectoryAppDataLocal()
        {
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);

            if (!_validate.ValidateStringIsNotNull(dirPath)) return;
            if (!_validate.ValidateStringHasLength(dirPath)) return;

            BookListPropertiesClass.PathToAppDataDirectory = dirPath;
        }

        /// <summary>
        ///     The CreateNewFile.
        /// </summary>
        /// <param name="filePath">The filePath<see cref="string" />.</param>
        /// <returns>The <see cref="bool" />.</returns>
        public bool CreateNewFile(string filePath)
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