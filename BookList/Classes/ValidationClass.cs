// BookListCurrent
//
// ValidationClass.cs
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

using System.IO;
using System.Reflection;
using BookListCurrent.ClassesProperties;
using JetBrains.Annotations;

namespace BookList.Classes
{
    /// <summary>
    ///     Validates data.
    /// </summary>
    public class ValidationClass
    {
        /// <summary>
        /// MessageBox Object Deceleration.
        /// </summary>
        private readonly MyMessageBox _msgBox = new MyMessageBox();

        /// <summary>
        /// MYMessages Object Deceleration.
        /// </summary>
        private readonly MyMessages _myMsg = new MyMessages();

        /// <summary>
        ///     Initializes members of the <see cref="ValidationClass" /> class.
        /// </summary>
        public ValidationClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) this._msgBox.NameOfClass = this._myMsg.MsgInvalidFileNameCharFound;
        }

        /// <summary>
        /// Indexes the greater than zero less then collection Count.
        /// </summary>
        /// <param name="index">The Index Make sure it falls into the allowed collection Count.</param>
        /// <param name="count">The Count total number of items contained in collection.</param>
        /// <returns>True if Index OK else False.</returns>
        public bool IndexGreaterThanZeroLessThenCollectionCount(int index, int count)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (index < 0)
            {
                this._msgBox.Msg = this._myMsg.MsgIndexLessThanZero;
                this._msgBox.ShowErrorMessageBox();
                return false;
            }

            if (index < count) return true;

            this._msgBox.Msg = this._myMsg.MsgIndexGraterThanCollectionCount;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }


        /// <summary>
        ///     Validate if book is formatted all ready. So user can pick another
        ///     book to be formatted.
        /// </summary>
        /// <param name="bookInfo">
        ///     The string containing book title to be formatted.
        /// </param>
        /// <returns>
        ///     True if book is formatted else False.
        /// </returns>
        public bool ValidateBookNotSeriesIsFormatted(string bookInfo)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(bookInfo)) return false;
            if (!this.ValidateStringHasLength(bookInfo)) return false;

            // Formatted will contain '[*]'
            if (bookInfo.Contains("[*]"))
            {
                this._msgBox.Msg = this._myMsg.MsgBookTitleIsAllReadyFormatted;
                this._msgBox.ShowInformationMessageBox();
                return true;
            }

            this._msgBox.Msg = this._myMsg.MSgBookTitleIsNotFormatted;
            this._msgBox.ShowInformationMessageBox();
            return false;
        }

        /// <summary>
        ///     Check for parentheses around the book series name. If found the book
        ///     is formatted correctly.
        /// </summary>
        /// <param name="bookInfo">
        ///     Contains the series name to check for formatted.
        /// </param>
        /// <returns>
        ///     True if formatted else False.
        /// </returns>
        public bool ValidateBookSeriesIsFormatted(string bookInfo)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(bookInfo)) return false;
            if (!this.ValidateStringHasLength(bookInfo)) return false;

            // if string contains '()' around the series name then it has all ready been formatted.
            if (bookInfo.Contains("(") && bookInfo.Contains(")"))
            {
                this._msgBox.Msg = this._myMsg.MsgBookSeriesIsAllReadyFormatted;
                this._msgBox.ShowInformationMessageBox();
                return true;
            }

            this._msgBox.Msg = this._myMsg.MSgBookTitleIsNotFormatted;
            this._msgBox.ShowInformationMessageBox();
            return false;
        }

        /// <summary>
        ///     Validate that <paramref name="dirPath" /> contains a valid directory
        ///     path.
        /// </summary>
        /// <param name="dirPath">The directory path.</param>
        /// <returns>
        ///     If directory exists then <see langword="true" /> else false.
        /// </returns>
        public bool ValidateDirectoryExists([NotNull] string dirPath)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(dirPath)) return false;
            if (!this.ValidateStringHasLength(dirPath)) return false;

            if (Directory.Exists(dirPath)) return true;

            this._msgBox.Msg = this._myMsg.MsgDirectoryDoesNotExist + dirPath;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the file exists.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="msg">If True and file does not exist return message and False.
        ///  Else return just False and no message.</param>
        /// <returns>
        ///     True if exists else False.
        /// </returns>
        public bool ValidateFileExists(string filePath, bool msg)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(filePath)) return false;
            if (!this.ValidateStringHasLength(filePath)) return false;

            if (File.Exists(filePath)) return true;
            // used to decide if to return message below or not.
            if (!msg) return false;


            this._msgBox.Msg = this._myMsg.MsgFileDoesNotExist + filePath;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates series name does not match volume number. User could have
        ///     selected same name for volume or series.
        /// </summary>
        /// <returns>
        ///     True if the series name does not match volume info. else false.
        /// </returns>
        public bool ValidateSeriesVolumeTextDoesNotMatch()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(FormatBookDataProperties.NameOfBookSeries)) return false;
            if (!this.ValidateStringIsNotNull(FormatBookDataProperties.NameOfBookVolume)) return false;
            if (!this.ValidateStringHasLength(FormatBookDataProperties.NameOfBookSeries)) return false;
            if (!this.ValidateStringHasLength(FormatBookDataProperties.NameOfBookVolume)) return false;

            if (!FormatBookDataProperties.NameOfBookSeries.Equals(FormatBookDataProperties.NameOfBookVolume))
                return true;

            this._msgBox.Msg = this._myMsg.MsgVolumeNumberAndSeriesNameMatch;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the string has length not an empty string.
        /// </summary>
        /// <param name="value">The string to be Checked..</param>
        /// <returns>
        ///     If string has length <see langword="true" /> else false.
        /// </returns>
        public bool ValidateStringHasLength(string value)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(value)) return false;

            value = value.Trim();

            if (value.Length != 0) return true;

            this._msgBox.Msg = this._myMsg.MsgStringIsEmpty;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the string is not Null.
        /// </summary>
        /// <param name="value">
        ///     The string to be <see langword="checked" /> for
        ///     <see langword="null" /> value.
        /// </param>
        /// <returns>
        ///     True if not <see langword="null" /> else false.
        /// </returns>
        public bool ValidateStringIsNotNull(string value)
        {
            if (value != null) return true;

            this._msgBox.Msg = this._myMsg.MsgStringIsNullString;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }
        
        /// <summary>
        ///     This checks to be sure the title name does not match the series
        ///     name.
        /// </summary>
        /// <returns>
        ///     True if the title name does not match the series name else False.
        /// </returns>
        public bool ValidateTitleSeriesTextDoesNotMatch()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(FormatBookDataProperties.NameOfBookSeries)) return false;
            if (!this.ValidateStringHasLength(FormatBookDataProperties.NameOfBookSeries)) return false;
            if (!this.ValidateStringIsNotNull(FormatBookDataProperties.NameOfBookTitle)) return false;
            if (!this.ValidateStringHasLength(FormatBookDataProperties.NameOfBookTitle)) return false;

            if (!FormatBookDataProperties.NameOfBookTitle.Equals(FormatBookDataProperties.NameOfBookSeries))
                return true;

            this._msgBox.Msg = this._myMsg.MsgTheTitleNameMatchesSeriesName;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }

        /// <summary>
        ///     Validates the title volume text does not match.
        /// </summary>
        /// <returns>
        ///     True if text does not match else False.
        /// </returns>
        public bool ValidateTitleVolumeTextDoesNotMatch()
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            if (!this.ValidateStringIsNotNull(FormatBookDataProperties.NameOfBookVolume)) return false;
            if (!this.ValidateStringHasLength(FormatBookDataProperties.NameOfBookVolume)) return false;
            if (!this.ValidateStringIsNotNull(FormatBookDataProperties.NameOfBookTitle)) return false;
            if (!this.ValidateStringHasLength(FormatBookDataProperties.NameOfBookTitle)) return false;

            if (!FormatBookDataProperties.NameOfBookVolume.Equals(
                FormatBookDataProperties.NameOfBookTitle))
                return true;

            this._msgBox.Msg = this._myMsg.MsgTheTitleNameMatchesTheVolumeNameNumber;
            this._msgBox.ShowErrorMessageBox();
            return false;
        }
    }
}