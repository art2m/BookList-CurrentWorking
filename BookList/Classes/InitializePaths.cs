// BookListCurrent
//
// LocationDirectoryFilePaths.cs
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

using System.Reflection;

namespace BookList.Classes
{
    /// <summary>
    ///     This class makes sure the directories and files that are required exist. If they
    ///     do not exist will ask user If ok to create them. If Not existing and Not
    ///     created the program will be unable to continue.
    /// </summary>
    public class InitializePaths
    {
        /// <summary>
        ///     declare message box Object.
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        ///     Initializes a new instance of the
        ///     <see cref="InitializePaths" /> class.
        /// </summary>
        public InitializePaths()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;
        }

        /// <summary>
        ///     Initialize all required directory paths.
        /// </summary>
        /// <returns>
        ///     True if all initialized else False.
        /// </returns>
        public bool InitializeDirectoryPath()

        {
            var initAuthorDir = new LocationAuthorDirectoryPath();

            var retVal = initAuthorDir.GetAppDataDirectoryPath();

            if (retVal)
            {
                retVal = initAuthorDir.GetTopLevelDirectoryPath();
            }

            if (retVal)
            {
                retVal = initAuthorDir.GetAuthorsDirectoryPath();
            }


            if (retVal)
            {
                retVal = initAuthorDir.GetAuthorsNamesListDirectoryPath();
            }

            if (retVal)
            {
                retVal = initAuthorDir.GetTitlesDirectoryPath();
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
            var cls = new LocationFilePaths();

            var retVal = cls.GetBookListTitlesFilePath();

            return retVal && cls.GetAuthorFileNamesListFilePath();
        }
    }
}