// BookListMainWin
//
// CombinePathsClass.cs
//
// art2m
//
// 08    12   2020
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

using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    /// Combine directory and file paths.
    /// </summary>
    public class CombinePathsClass
    {
        /// <summary>
        /// The MSG box
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        /// The validate
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Initializes members of the <see cref="CombinePathsClass" /> class.
        /// </summary>
        public CombinePathsClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Combine directory and file name. Check if file exists if not create
        ///     it.
        /// </summary>
        /// <param name="dirPath">The dirPath <see cref="string" /> .</param>
        /// <param name="fileName">The fileName <see cref="string" /> .</param>
        /// <param name="msg"> True if you want to display message not found else false to skip.</param>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        public string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName, bool
            msg)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return String.Empty;
            if (!this._validate.ValidateStringIsNotNull(fileName)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(fileName)) return String.Empty;

            if (!this._validate.ValidateDirectoryExists(dirPath)) return String.Empty;

            var filePath = this.CombineDirectoryPathWithFileName(dirPath, fileName);

            if (this._validate.ValidateFileExists(filePath, false)) return filePath;

            File.Create(filePath).Dispose();

            return File.Exists(filePath) ? filePath : String.Empty;
        }

        /// <summary>
        ///     Combine directory name and file name.
        /// </summary>
        /// <param name="dirPath">The dirPath <see cref="string" /> .</param>
        /// <param name="fileName">The fileName <see cref="string" /> .</param>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        public string CombineDirectoryPathWithFileName([NotNull] string dirPath, [NotNull] string fileName)
        {
            if (!this._validate.ValidateStringIsNotNull(dirPath)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return String.Empty;
            if (!this._validate.ValidateStringIsNotNull(fileName)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(fileName)) return String.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return String.Empty;

            var filePath = Path.Combine(dirPath, fileName);

            return filePath;
        }

        /// <summary>
        ///     Combine two strings to get complete path to directory
        /// </summary>
        /// <param name="dirPath"><see cref="Directory" /> name or path.</param>
        /// <param name="dirName">
        ///     <see cref="Directory" /> name, path or file name.
        /// </param>
        /// <returns>
        ///     <see cref="Path" /> string to directories else empty string.
        /// </returns>
        public string CombineExistingDirectoryPathWithDirectoryName([NotNull] string dirPath, string dirName)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this._validate.ValidateStringIsNotNull(dirPath)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(dirPath)) return String.Empty;
            if (!this._validate.ValidateStringIsNotNull(dirName)) return String.Empty;
            if (!this._validate.ValidateStringHasLength(dirName)) return String.Empty;
            if (!this._validate.ValidateDirectoryExists(dirPath)) return String.Empty;

            var makePath = Path.Combine(dirPath, dirName);

            return makePath;
        }

        /// <summary>
        ///     Create new directory.
        /// </summary>
        /// <param name="dirNewPath"></param>
        /// <returns>
        /// </returns>
        public  bool CreateNewDirectoryReturnPath(string dirNewPath)
        {
            if (!this._validate.ValidateStringIsNotNull(dirNewPath)) return false;
            if (!this._validate.ValidateStringHasLength(dirNewPath)) return false;

            if (Directory.Exists(dirNewPath)) return true;

            _ = Directory.CreateDirectory(dirNewPath);

            return this._validate.ValidateDirectoryExists(dirNewPath);
        }
    }
}