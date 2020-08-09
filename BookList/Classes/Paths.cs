// BookListCurrent
//
// Paths.cs
//
// art2m
//
// art2m
//
// 07    20   2020
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
using System.Windows.Forms;
using BookListCurrent.ClassesProperties;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    ///     Class that contains code to create directories and files.
    /// </summary>
    public class Paths
    {
        /// <summary>
        /// The MSG box
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// deceleration of message object.
        /// </summary>
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        /// The validate
        /// </summary>
        private readonly Validation _validate = new Validation();

        /// <summary>
        ///     Initializes members of the <see cref="Paths" /> class.
        /// </summary>
        public Paths()
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
        public string CombineDirectoryPathFileNameCheckCreateFile([NotNull] string dirPath, string fileName, bool msg)
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
        public bool CreateNewDirectoryReturnPath(string dirNewPath)
        {
            if (!this._validate.ValidateStringIsNotNull(dirNewPath)) return false;
            if (!this._validate.ValidateStringHasLength(dirNewPath)) return false;

            if (Directory.Exists(dirNewPath)) return true;

            _ = Directory.CreateDirectory(dirNewPath);

            return this._validate.ValidateDirectoryExists(dirNewPath);
        }

        /// <summary>
        ///     The CreateNewFile.
        /// </summary>
        /// <param name="filePath">The filePath <see cref="string" /> .</param>
        /// <returns>
        ///     The <see cref="bool" /> .
        /// </returns>
        public bool CreateNewFile(string filePath)
        {
            if (!this._validate.ValidateStringIsNotNull(filePath)) return false;
            if (!this._validate.ValidateStringHasLength(filePath)) return false;
            if (File.Exists(filePath)) return true;

            _ = File.Create(filePath);

            if (!File.Exists(filePath)) return false;

            BookListPaths.PathOfCurrentWorkingFile = filePath;

            return true;
        }

        /// <summary>
        ///     Gets the application data directory path.
        /// </summary>
        /// <returns>
        /// </returns>
        public bool GetAppDataDirectoryPath()
        {
            var validate = new Validation();

            var cls = new Paths();
            // Saves the AppData directory path to BookListPaths.PathAppDataDirectory
            cls.GetPathToSpecialDirectoryAppDataLocal();

            if (validate.ValidateDirectoryExists(BookListPaths.PathAppDataDirectory)) return true;

            _msgBox.Msg = _myMsg.MsgUnableToFindTheAppDataDirectory;
            _msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// Gets the author file names list file path.
        /// </summary>
        /// <returns>True if file found else False.</returns>
        public bool GetAuthorFileNamesListFilePath()
        {
            var dirFileOp = new Paths();
            var validate = new Validation();

            var dirPath = BookListPaths.PathAuthorsListDirectory;

            var fileName = BookListPaths.NameAuthorsListFile;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(
                dirPath, fileName);

            var fileExists = validate.ValidateFileExists(filePath, true);

            if (!fileExists)
            {
                var dlgResult = this._msgBox.ShowQuestionMessageBox();

                // Create directory if it does not exist.
                if (dlgResult == DialogResult.Yes)
                {
                    dirFileOp.CreateNewFile(filePath);

                    if (validate.ValidateFileExists(filePath, true))
                    {
                        BookListPaths.PathAuthorsNamesListFile = filePath;
                        return true;
                    }
                    else
                    {
                        // return no directory created.
                        BookListPaths.PathAuthorsNamesListFile = String.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPaths.PathAuthorsNamesListFile = String.Empty;
                    return false;
                }
            }
            else
            {
                BookListPaths.PathAuthorsNamesListFile = filePath;
                return true;
            }
        }

        /// <summary>
        ///     Gets the authors directory path.
        /// </summary>
        /// <returns>
        ///     True if directory exists or was created else False.
        /// </returns>
        public bool GetAuthorsDirectoryPath()
        {
            var dirFileOp = new Paths();
            var validate = new Validation();

            var dirTop = BookListPaths.PathTopLevelDirectory;
            var dirName = BookListPaths.NameAuthorsDirectory;

            var dirPath = dirFileOp.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPaths.PathAuthorsDirectory = dirPath;
                return true;
            }

            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPaths.PathAuthorsDirectory = dirPath;
            return true;
        }

        /// <summary>
        ///     Gets the authors names list directory path.
        /// </summary>
        /// <returns>
        ///     True directory found or created else False.
        /// </returns>
        public bool GetAuthorsNamesListDirectoryPath()
        {
            var dirFileOp = new Paths();
            var validate = new Validation();

            var dirTop = BookListPaths.PathTopLevelDirectory;
            var dirName = BookListPaths.NameOfAuthorsListDirectory;

            var dirPath = dirFileOp.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPaths.PathAuthorsListDirectory = dirPath;
                return true;
            }

            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPaths.PathAuthorsListDirectory = dirPath;
            return true;
        }

        /// <summary>
        /// Gets the book list titles file path.
        /// </summary>
        /// <returns>True if path found else False.</returns>
        public bool GetBookListTitlesFilePath()
        {
            var dirFileOp = new Paths();
            var validate = new Validation();

            var dirPath = BookListPaths.PathTitlesDirectory;

            var fileName = BookListPaths.NameTitlesBookListFile;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(
                dirPath, fileName);

            var fileExists = validate.ValidateFileExists(filePath, true);

            if (!fileExists)
            {
                var dlgResult = this._msgBox.ShowQuestionMessageBox();

                // Create directory if it does not exist.
                if (dlgResult == DialogResult.Yes)
                {
                    dirFileOp.CreateNewFile(filePath);

                    if (validate.ValidateFileExists(filePath, true))
                    {
                        BookListPaths.PathTitleNamesListFile = filePath;
                        return true;
                    }
                    else
                    {
                        // return no directory created.
                        BookListPaths.PathTitleNamesListFile = String.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPaths.PathTitleNamesListFile = String.Empty;
                    return false;
                }
            }
            else
            {
                BookListPaths.PathTitleNamesListFile = filePath;
                return true;
            }
        }

        /// <summary>
        ///     The GetPathToSpecialDirectoryAppDataLocal.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMadeStatic.Global
        public bool GetPathToSpecialDirectoryAppDataLocal()
        {
            var validate = new Validation();
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (!validate.ValidateStringIsNotNull(dirPath))
            {
                return false;
            }

            BookListPaths.PathAppDataDirectory = dirPath;

            return true;
        }

        /// <summary>
        ///     Gets the permission to create new Author directory. This is a
        ///     required directory.
        /// </summary>
        /// <param name="dirPath">
        ///     The path of the directory to be created.
        /// </param>
        /// <returns>
        ///     False if user says no else returned value.
        /// </returns>
        public bool GetPermissionToCreateDirectory(string dirPath)
        {
            var dlgResult = _msgBox.ShowQuestionMessageBox();

            if (dlgResult == DialogResult.No) return false;

            return CreateNewAuthorDirectory(dirPath);
        }

        /// <summary>
        ///     Gets the titles directory path.
        /// </summary>
        /// <returns>
        ///     True if directory exists or was created else False.
        /// </returns>
        public bool GetTitlesDirectoryPath()
        {
            var dirFileOp = new Paths();
            var validate = new Validation();

            var dirTop = BookListPaths.PathTopLevelDirectory;
            var dirName = BookListPaths.NameTitlesDirectory;

            var dirPath = dirFileOp.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPaths.PathTitlesDirectory = dirPath;
                return true;
            }

            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPaths.PathTitlesDirectory = dirPath;
            return true;
        }

        /// <summary>
        ///     Gets the top level directory path.
        /// </summary>
        /// <returns>
        ///     True if directory exists or is created else False
        /// </returns>
        public bool GetTopLevelDirectoryPath()
        {
            var dirFileOp = new Paths();

            var validate = new Validation();

            var dirTop = BookListPaths.PathAppDataDirectory;
            var dirName = BookListPaths.NameTopLevelDirectory;

            var dirPath = dirFileOp.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPaths.PathTopLevelDirectory = dirPath;
                return true;
            }

            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPaths.PathTopLevelDirectory = dirPath;
            return true;
        }

        /// <summary>
        ///     Initialize all required directory paths.
        /// </summary>
        /// <returns>
        ///     True if all initialized else False.
        /// </returns>
        public bool InitializeDirectoryPath()

        {
            var dirFile = new Paths();

            var retVal = dirFile.GetAppDataDirectoryPath();

            if (retVal)
            {
                retVal = dirFile.GetTopLevelDirectoryPath();
            }

            if (retVal)
            {
                retVal = dirFile.GetAuthorsDirectoryPath();
            }


            if (retVal)
            {
                retVal = dirFile.GetAuthorsNamesListDirectoryPath();
            }

            if (retVal)
            {
                retVal = dirFile.GetTitlesDirectoryPath();
            }

            return retVal;
        }

        /// <summary>
        ///     Initialize all Required files.
        /// </summary>
        /// <returns>
        ///     True if all initialized else False.
        /// </returns>
        public bool InitializeFilePaths()
        {
            var retVal = GetBookListTitlesFilePath();

            return retVal && GetAuthorFileNamesListFilePath();
        }

        /// <summary>
        /// Creates the new author directory.
        /// </summary>
        /// <param name="dirPath">The dir path.</param>
        /// <returns>True if directory created else False.</returns>
        private bool CreateNewAuthorDirectory(string dirPath)
        {
            var dirFileOp = new Paths();

            dirFileOp.CreateNewDirectoryReturnPath(dirPath);

            return ValidateDirectoryCreated(dirPath);
        }

        /// <summary>
        ///     Validates the directory created.
        /// </summary>
        /// <param name="dirPath">The directory path.</param>
        /// <returns>
        ///     True if created else False
        /// </returns>
        private bool ValidateDirectoryCreated(string dirPath)
        {
            var validate = new Validation();

            return validate.ValidateStringHasLength(dirPath) && validate.ValidateDirectoryExists(dirPath);
        }
    }
}