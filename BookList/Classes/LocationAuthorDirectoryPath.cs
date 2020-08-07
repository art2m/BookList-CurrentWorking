// BookListCurrent
//
// LocationAuthorDirectoryPath.cs
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

using System.Windows.Forms;
using BookListCurrent.ClassesProperties;

namespace BookList.Classes
{
    /// <summary>
    ///     Gets the path to the Authors directory if exists. If it does not exist
    ///     then the user will be asked to permit it being created. If allowed the
    ///     directory will then be created and its path saved.
    /// </summary>
    public class LocationAuthorDirectoryPath
    {
        /// <summary>
        ///     Declare messageBox class Object.
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        ///     Gets the application data directory path.
        /// </summary>
        /// <returns>
        /// </returns>
        public bool GetAppDataDirectoryPath()
        {
            var validate = new ValidationClass();

            var cls = new DirectoryFileClass();
            // Saves the AppData directory path to BookListPaths.PathAppDataDirectory
            cls.GetPathToSpecialDirectoryAppDataLocal();

             if(validate.ValidateDirectoryExists(BookListPaths.PathAppDataDirectory)) return true;

            _msgBox.Msg = _myMsg.MsgUnableToFindTheAppDataDirectory;
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
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

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
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

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
        ///     Gets the titles directory path.
        /// </summary>
        /// <returns>
        ///     True if directory exists or was created else False.
        /// </returns>
        public bool GetTitlesDirectoryPath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

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
            var dirFileOp = new DirectoryFileClass();

            var validate = new ValidationClass();

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

        private bool CreateNewAuthorDirectory(string dirPath)
        {
            var dirFileOp = new DirectoryFileClass();

            dirFileOp.CreateNewDirectoryReturnPath(dirPath);

            return ValidateDirectoryCreated(dirPath);
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
        private bool GetPermissionToCreateDirectory(string dirPath)
        {
            var dlgResult = _msgBox.ShowQuestionMessageBox();

            if (dlgResult == DialogResult.No) return false;

            return CreateNewAuthorDirectory(dirPath);
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
            var validate = new ValidationClass();

            if (validate.ValidateStringHasLength(dirPath))
            {
                if (validate.ValidateDirectoryExists(dirPath)) return true;
            }

            return false;
        }
    }
}