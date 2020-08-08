// BookListCurrent
//
// LocationFilePaths.cs
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
using BookList.PropertiesClasses;
using BookListCurrent.ClassesProperties;

namespace BookList.Classes
{
    /// <summary>
    ///     This class makes sure the files that are required exist. If they do not
    ///     exist will ask user If ok to create them. If Not existing and Not
    ///     created the program will be unable to continue.
    /// </summary>
    public class LocationFilePaths
    {
        /// <summary>
        /// The MSG box
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// My MSG
        /// </summary>
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        /// Gets the author file names list file path.
        /// </summary>
        /// <returns></returns>
        public bool GetAuthorFileNamesListFilePath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

            var dirPath = BookListPaths.PathAuthorsListDirectory;

            var fileName = BookListPaths.NameAuthorsListFile;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(
                dirPath, fileName);

            if (validate.ValidateFileExists(filePath, true))
            {
                BookListPaths.PathAuthorsNamesListFile = filePath;
                return true;
            }

            if (!GetPermissionToCreateFile(dirPath)) return false;

            BookListPaths.PathAuthorsNamesListFile = filePath;
            return true;

        }

        /// <summary>
        /// Get book list titles file path.
        /// </summary>
        /// <returns>True if path found else False.</returns>
        public bool GetBookListTitlesFilePath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

            var dirPath = BookListPaths.PathTitlesDirectory;

            var fileName = BookListPaths.NameTitlesBookListFile;

            var filePath = dirFileOp.CombineDirectoryPathWithFileName(
                dirPath, fileName);

            if (validate.ValidateFileExists(filePath, true))
            {
                BookListPaths.PathTitleNamesListFile = filePath;
                return true;
            }

            if (!GetPermissionToCreateFile(filePath)) return false;

            BookListPaths.PathTitleNamesListFile = filePath;
            return true;
        }

        /// <summary>
        /// Get permission to create the required file.
        /// </summary>
        /// <param name="filePath">The file path to the required file.</param>
        /// <returns>True if exists or is created else False.</returns>
        private bool GetPermissionToCreateFile(string filePath)
        {
            var dirFileOp = new DirectoryFileClass();

            var dlgResult = this._msgBox.ShowQuestionMessageBox();

            if (dlgResult == DialogResult.No) return false;

            if (dirFileOp.CreateNewFile(filePath))
            {
                BookListPaths.PathAuthorsNamesListFile = filePath;
                return true;
            }

            return false;
        }
    }
}