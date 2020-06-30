// //------------------------------------------------------------------------------------------------------------------
// <copyright file="None">
//
// Company copyright tag.
//
//  </copyright>
//
// Art2MSpell
//
// ValidationClass.cs
//
// art2m
//
// art2m@live.com
//
// 05  10  2019
//
// 05  08   2019
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.
// //------------------------------------------------------------------------------------------------------------------

using System.Diagnostics.Contracts;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using BookList.PropertiesClasses;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    /// Validates data.
    /// </summary>
    public static class ValidationClass
    {
        /// <summary>
        /// Initializes static members of the <see cref="ValidationClass"/> class.
        /// </summary>
        static ValidationClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// <summary>
        /// Check for invalid file name characters.
        /// </summary>
        /// <param name="fileName">File name to check.</param>
        /// <returns>True if no invalid characters in file name else false.</returns>
        public static bool CheckForInvalidFileNameCharacters([NotNull] string fileName)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!ValidateStringValueNotNullNotEmpty(fileName)) return false;

            // Get a list of invalid file characters.
            var invalidFileChars = Path.GetInvalidFileNameChars();


            if (invalidFileChars.Select(item => fileName.IndexOf(item)).All(index => index == -1)) return true;
            MyMessagesClass.ErrorMessage = "There is an invalid character in the file name.";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// Check for invalid path characters.
        /// </summary>
        /// <param name="pathString">The path string to check for invalid path characters.</param>
        /// <returns>If no invalid path characters return true else false.</returns>
        public static bool CheckForInvalidPathCharacters([NotNull] string pathString)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!ValidateStringValueNotNullNotEmpty(pathString)) return false;

            var invalidPathChars = Path.GetInvalidPathChars();

            // var charValue = pathString.ToCharArray();
            if (invalidPathChars.Select(item => pathString.IndexOf(item)).All(index => index == -1)) return true;
            MyMessagesClass.ErrorMessage = "The path name contains invalid characters. Exiting operation:";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }


        /// <summary>
        /// Validate if book is formatted all ready.
        /// So user can pick another book to be formatted.
        /// </summary>
        /// <param name="bookInfo">The string containing book title to be formatted.</param>
        /// <returns>True if book is formatted else false.</returns>
        public static bool ValidateBookNotSeriesIsFormatted(string bookInfo)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (bookInfo.Contains("*")) return true;
            MyMessagesClass.ErrorMessage = "This book title is all ready formatted.";
            MyMessagesClass.ShowInformationMessageBox();
            return false;
        }

        /// <summary>
        /// Check for parentheses around the book series name. If founc
        /// the book is formated correctly.
        /// </summary>
        /// <param name="bookInfo">Contains the series name to check for formatted.</param>
        /// <returns>True if formatted else false.</returns>
        public static bool ValidateBookSeriesIsFormatted(string bookInfo)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (bookInfo.Contains("(") || bookInfo.Contains(")")) return true;
            MyMessagesClass.ErrorMessage = "This book info is all ready formatted.";
            MyMessagesClass.ShowInformationMessageBox();
            return false;
        }

        /// <summary>
        /// Validate that dirPath contains a valid directory path.
        /// </summary>
        /// <param name="dirPath">The directory path.</param>
        /// <returns>If directory exists then true else false.</returns>
        public static bool ValidateDirectoryExists([NotNull] string dirPath)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (ValidateStringValueNotNullNotEmpty(dirPath)) return false;

            if (Directory.Exists(dirPath)) return true;
            MyMessagesClass.ErrorMessage = "This Directory path does not exist:  " + dirPath;
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// Validates the file exits.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns>.</returns>
        public static bool ValidateFileExits([NotNull] string filePath)
        {
            return ValidateStringValueNotNullNotEmpty(filePath) && File.Exists(filePath);
        }

        /// <summary>
        /// Validates series name does not match volume number. User could have selected same name
        /// for volume or series.
        /// </summary>
        /// <returns>True if the series name does not match volume info. else false.</returns>
        public static bool ValidateSeriesVolumeTextDoesNotMatch()
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!FormatBookDataProperties.BookSeriesVolumeNumber.Equals(FormatBookDataProperties.NameOfBookSeries))
            {
                return true;
            }

            MyMessagesClass.ErrorMessage =
                "The book series number is not valid. It is the same as the name of the book series.";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// Check that there are only letters in the spelling word.
        /// </summary>
        /// <param name="value">The spelling word to be checked.</param>
        /// <returns>True if only letters in the spelling word else false.</returns>
        public static bool ValidatestringHasLettersOnly(string value)
        {
            Contract.Requires(!string.IsNullOrEmpty(value));

            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;


            if (!(from letter in value
                where !char.IsLetter(letter)
                select letter.ToString()
                into val
                select "Invalid character in string:  " + val).Any())
            {
                return true;
            }

            MyMessagesClass.ErrorMessage = "Fond character that is not a valid letter.";
            MyMessagesClass.ShowErrorMessageBox();

            return false;
        }


        /// <summary>
        /// Check for space in pathString this will means either space in word that does not belong or
        ///     two words instead of one spelling word.
        /// </summary>
        /// <param name="value">The spelling word to validate.</param>
        /// <returns>True if no space is found else false.</returns>
        public static bool ValidateStringOneWord([NotNull] string value)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!ValidateStringValueNotNullNotEmpty(value)) return false;


            var index = value.IndexOf(' ');

            if (index <= -1) return true;
            MyMessagesClass.ErrorMessage = "This string contains more than one word. must contain only one word.";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// The ValidateStringValueNotNullNotEmpty.
        /// </summary>
        /// <param name="value">The string to be checked.</param>
        /// <returns>True if string is not empty and has length.</returns>
        public static bool ValidateStringValueNotNullNotEmpty([NotNull] string value)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            value = value.Trim();

            if (!string.IsNullOrEmpty(value)) return true;
            MyMessagesClass.ErrorMessage = "The pathString is not valid. It is a null or empty string.";
            MyMessagesClass.ShowErrorMessageBox();

            return false;
        }

        public static bool ValidateStringHasLength(string value)
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (value == null)
            {
                MyMessagesClass.ErrorMessage = "The pathString is not valid. It is a null string.";
                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }

            value = value.Trim();

            if (value.Length != 0) return true;

            MyMessagesClass.ErrorMessage = "The pathString is not valid. It is a null string.";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        /// This checks to be sure the title name does not match the series name.
        /// </summary>
        /// <returns>True if the title name does not match the series name else false. </returns>
        public static bool ValidateTitleSeriesTextDoesNotMatch()
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!FormatBookDataProperties.ContainsBookTitle.Equals(FormatBookDataProperties.NameOfBookSeries))
            {
                return true;
            }

            MyMessagesClass.ErrorMessage = "The title of the book can not be the same as the series name.";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }

        public static bool ValidateTitleVolumeTextDoesNotMatch()
        {
            MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!FormatBookDataProperties.BookSeriesVolumeNumber.Equals(
                FormatBookDataProperties.ContainsBookTitle))
            {
                return true;
            }

            MyMessagesClass.ErrorMessage = "The title cannot match the volume number text.";
            MyMessagesClass.ShowErrorMessageBox();
            return false;
        }
    }
}