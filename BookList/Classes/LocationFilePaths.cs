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
        private readonly MyMessageBox _msgBox = new MyMessageBox();
        private readonly MyMessages _myMsg = new MyMessages();

        public bool GetAuthorFileNamesListFilePath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

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
                        BookListPaths.PathAuthorsNamesListFile = string.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPaths.PathAuthorsNamesListFile = string.Empty;
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
        ///     <para>
        ///         Get the path to the Series.dat file. It is contained in the Series
        ///         directory. If Exists Set DefaultDirectoryAndFilesExist.PathSeriesOk
        ///         = true. Set BookListPaths.Series = Path to Title directory.
        ///     </para>
        ///     <para>
        ///         If the directory does not exist ask user if ok to be created as it
        ///         is a required directory.
        ///     </para>
        ///     <para>
        ///         if Not exist and Not created set
        ///         DefaultDirectoryAndFilesExist.Series.dat = false. Set
        ///         BookListPaths.PathSeriesDirectory = string.Empty.
        ///     </para>
        /// </summary>
        public bool GetSeriesFilePath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

            var dirPath = BookListPaths.PathSeriesDirectory;

            var fileName = BookListPaths.NameSeriesFile;

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
                        BookListPaths.PathSeriesDirectory = filePath;
                        return true;
                    }
                    else
                    {
                        // return no directory created.
                        BookListPaths.PathSeriesDirectory = string.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPaths.PathSeriesDirectory = string.Empty;
                    return false;
                }
            }
            else
            {
                BookListPaths.PathSeriesDirectory = filePath;
                return true;
            }
        }

        /// <summary>
        ///     <para>
        ///         Get the path to the BookListTitles.dat file. It is contained in the
        ///         Titles-Author directory. If Exists Set
        ///         DefaultDirectoryAndFilesExist.PathBookListTitlesFilesOk = true. Set
        ///         BookListPaths.Titles = Path to Title directory.
        ///     </para>
        ///     <para>
        ///         If the directory does not exist ask user if ok to be created as it
        ///         is a required directory.
        ///     </para>
        ///     <para>
        ///         if Not exist and Not created set
        ///         DefaultDirectoryAndFilesExist.BookListTitleAuthor.dat = false. Set
        ///         BookListPaths.PathTitleNamesListFile = string.Empty.
        ///     </para>
        /// </summary>
        public bool GetBookListTitlesFilePath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

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
                        BookListPaths.PathTitleNamesListFile = string.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPaths.PathTitleNamesListFile = string.Empty;
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
        ///     <para>
        ///         Get the path to the BookListTitleAuthor.dat file. It is contained in
        ///         the AuthorsNamesList directory. If Exists Set
        ///         DefaultDirectoryAndFilesExist.PathBookListTitleAuthorFilesOk = true.
        ///         Set BookListPaths.TitlesAuthors = Path to TitleAuthors directory.
        ///     </para>
        ///     <para>
        ///         If the directory does not exist ask user if ok to be created as it
        ///         is a required directory.
        ///     </para>
        ///     <para>
        ///         if Not exist and Not created set
        ///         DefaultDirectoryAndFilesExist.BookListTitleAuthor.dat = false. Set
        ///         BookListPaths.PathBookListTitleAuthorFile = string.Empty.
        ///     </para>
        /// </summary>
        public bool GetBookListTitlesAuthorFilesPath()
        {
            var dirFileOp = new DirectoryFileClass();
            var validate = new ValidationClass();

            var dirPath = BookListPaths.PathTitlesAuthorsDirectory;

            var fileName = BookListPaths.NameAuthorsTitlesBookListFile;

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
                        BookListPaths.PathBookListTitleAuthorFile = filePath;
                        return true;
                    }
                    else
                    {
                        // return no directory created.
                        BookListPaths.PathBookListTitleAuthorFile = string.Empty;
                        return false;
                    }
                }
                else
                {
                    // return user does not want to create the directory.
                    BookListPaths.PathBookListTitleAuthorFile = string.Empty;
                    return false;
                }
            }
            else
            {
                BookListPaths.PathBookListTitleAuthorFile = filePath;
                return true;
            }
        }
    }
}