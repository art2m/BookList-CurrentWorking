// BookListMainWin
//
// DirectoryClass.cs
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
using System.Reflection;
using System.Windows.Forms;

using BookList.PropertiesClasses;

namespace BookList.Classes
{
    /// <summary>
    ///     Directory operations.
    /// </summary>
    public class DirectoryClass
    {
        /// <summary>
        ///     Declaration of MyMessagesBox Object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declaration of ValidationClass Object.
        /// </summary>
        private readonly ValidationClass _validate = new ValidationClass();

        /// <summary>
        ///     Initializes members of the <see cref="DirectoryClass" /> class.
        /// </summary>
        public DirectoryClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Gets the application data directory path.
        /// </summary>
        /// <returns>
        /// </returns>
        public bool GetAppDataDirectoryPath()
        {
            var validate = new ValidationClass();

            var cls = new FileClass();
            // Saves the AppData directory path to BookListPathsProperties.PathAppDataDirectory
            GetPathToSpecialDirectoryAppDataLocal();

            if (validate.ValidateDirectoryExists(BookListPathsProperties.PathAppDataDirectory)) return true;

            _msgBox.Msg = "Unable to find the AppData directory unable to continue.";
            _msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Gets the authors directory path.
        /// </summary>
        /// <returns>
        ///     True if directory exists or was created else False.
        /// </returns>
        public bool GetAuthorsDirectoryPath()
        {
            var dirFileOp = new FileClass();
            var validate = new ValidationClass();

            var dirTop = BookListPathsProperties.PathTopLevelDirectory;
            var dirName = BookListPathsProperties.NameAuthorsDirectory;

            var cls = new CombinePathsClass();
            var dirPath = cls.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPathsProperties.PathAuthorsDirectory = dirPath;
                return true;
            }

            var clsPaths = new FileClass();
            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPathsProperties.PathAuthorsDirectory = dirPath;
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
            var dirFileOp = new FileClass();
            var validate = new ValidationClass();

            var dirTop = BookListPathsProperties.PathTopLevelDirectory;
            var dirName = BookListPathsProperties.NameOfAuthorsListDirectory;

            var cls = new CombinePathsClass();
            var dirPath = cls.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPathsProperties.PathAuthorsListDirectory = dirPath;
                return true;
            }

            var clsPath = new FileClass();
            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPathsProperties.PathAuthorsListDirectory = dirPath;
            return true;
        }

        /// <summary>
        ///     The GetPathToSpecialDirectoryAppDataLocal.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" /> .
        /// </returns>
        // ReSharper disable once MemberCanBeMade.Global
        public bool GetPathToSpecialDirectoryAppDataLocal()
        {
            var validate = new ValidationClass();
            var dirPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            if (!validate.ValidateStringIsNotNull(dirPath))
            {
                return false;
            }

            BookListPathsProperties.PathAppDataDirectory = dirPath;

            return true;
        }

        /// <summary>
        ///     Gets the titles directory path.
        /// </summary>
        /// <returns>
        ///     True if directory exists or was created else False.
        /// </returns>
        public bool GetTitlesDirectoryPath()
        {
            var dirFileOp = new FileClass();
            var validate = new ValidationClass();

            var dirTop = BookListPathsProperties.PathTopLevelDirectory;
            var dirName = BookListPathsProperties.NameTitlesDirectory;

            var cls = new CombinePathsClass();
            var dirPath = cls.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPathsProperties.PathTitlesDirectory = dirPath;
                return true;
            }

            var clsPaths = new FileClass();
            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPathsProperties.PathTitlesDirectory = dirPath;
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
            var dirFileOp = new FileClass();

            var validate = new ValidationClass();

            var dirTop = BookListPathsProperties.PathAppDataDirectory;
            var dirName = BookListPathsProperties.NameTopLevelDirectory;

            var cls = new CombinePathsClass();
            var dirPath = cls.CombineExistingDirectoryPathWithDirectoryName(
                dirTop, dirName);

            if (validate.ValidateDirectoryExists(dirPath))
            {
                BookListPathsProperties.PathTopLevelDirectory = dirPath;
                return true;
            }

            var clsPath = new FileClass();
            if (!GetPermissionToCreateDirectory(dirPath)) return false;

            BookListPathsProperties.PathTopLevelDirectory = dirPath;
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

            var retVal = GetAppDataDirectoryPath();

            if (retVal)

            {
                retVal = GetTopLevelDirectoryPath();
            }

            if (retVal)
            {
                retVal = GetAuthorsDirectoryPath();
            }


            if (retVal)
            {
                retVal = GetAuthorsNamesListDirectoryPath();
            }

            if (retVal)
            {
                retVal = GetTitlesDirectoryPath();
            }

            return retVal;
        }

        /// <summary>
        ///     Creates the new author directory.
        /// </summary>
        /// <param name="dirPath">The dir path.</param>
        /// <returns>True if directory created else False.</returns>
        public bool CreateNewAuthorDirectory(string dirPath)
        {
            var dirFileOp = new FileClass();

            var cls = new CombinePathsClass();
            cls.CreateNewDirectoryReturnPath(dirPath);

            return _validate.ValidateDirectoryExists(dirPath);
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
            var dlgResult = this._msgBox.ShowQuestionMessageBox();


            if (dlgResult == DialogResult.No) return false;

            var dirClass = new DirectoryClass();
            return dirClass.CreateNewAuthorDirectory(dirPath);
        }
    }
}