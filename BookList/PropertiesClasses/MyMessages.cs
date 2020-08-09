// BookListCurrent
// 
// MyMessages.cs
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

namespace BookListCurrent.ClassesProperties
{
    /// <summary>
    /// Messages for various situations.
    /// </summary>
    public class MyMessages
    {
        /// <summary>
        ///     If the book series contains '()' around the series name then the
        ///     book is all ready formmated. Use this message.
        /// </summary>
        public string MsgBookSeriesIsAllReadyFormatted => "This book info is all ready formatted.";

        /// <summary>
        ///     If the Book Title being <see langword="checked" /> is all ready
        ///     formatted. Use this message.
        /// </summary>
        public string MsgBookTitleIsAllReadyFormatted => "This book title is all ready formatted.";

        /// <summary>
        ///     If the book title is not formatted.
        /// </summary>
        public string MSgBookTitleIsNotFormatted => "This book title is not formatted";

        /// <summary>
        ///     If string contains any thing but valid letters. Use this message.
        /// </summary>
        public string MsgCharacterNotValidLetter => "Fond character that is not a valid letter.";

        /// <summary>
        ///     If the string contains more then one word. Use this message.
        /// </summary>
        public string MsgContainsMoreThanOneWord =>
            "This string contains more than one word. must contain only one word.";

        /// <summary>
        ///     If the directory does not exist. Use this message.
        /// </summary>
        public string MsgDirectoryDoesNotExist => "This Directory path does not exist:  ";

        /// <summary>
        ///     Attempted to create one of the required directories and failed.
        /// </summary>
        public string MsgDirFailedCreate => "Unable to create this required directory. ";

        /// <summary>
        ///     If the file does not exist. Use this message.
        /// </summary>
        public string MsgFileDoesNotExist => "This file does not exist. ";

        /// <summary>
        ///     Attempted to create one of the required files and failed.
        /// </summary>
        public string MsgFileFailedCreate => "Unable to create this required file.";

        /// <summary>
        /// Gets the MSG index grater than collection count.
        /// </summary>
        /// <value>
        /// The MSG index grater than collection count.
        /// </value>
        public string MsgIndexGraterThanCollectionCount =>
            "The index can not be greater or equal to the number of items contained in the collection.";

        /// <summary>
        /// Gets the MSG index less than zero.
        /// </summary>
        /// <value>
        /// The MSG index less than zero.
        /// </value>
        public string MsgIndexLessThanZero => "The index is can not be less than zero.";
        /// <summary>
        ///     If File name check finds invalid character contained in the string
        ///     use this message.
        /// </summary>
        public string MsgInvalidFileNameCharFound => "There is an invalid character in the file name.";

        /// <summary>
        ///     If Path check finds invalid characters contained in path string use
        ///     this message.
        /// </summary>
        public string MsgInvalidPathCharFound => "The path name contains invalid characters. Exiting operation:";
        /// <summary>
        /// Gets the MSG required directory files missing.
        /// </summary>
        /// <value>
        /// The MSG required directory files missing.
        /// </value>
        public string MsgRequiredDirFilesMissing => "Exiting program! Required directories and files missing.";

        /// <summary>
        ///     Failed to successfully save changes.
        /// </summary>
        public string MsgSaveChangesFailed => "Changes save operation failed.";

        /// <summary>
        ///     Changes saved successfully.
        /// </summary>
        public string MsgSaveChangesSucceeded => "Changes have been saved.";

        /// <summary>
        ///     If the string is empty. Use this message.
        /// </summary>
        public string MsgStringIsEmpty => "This can not be an empty string.";

        /// <summary>
        ///     String <see langword="checked" /> is a <see langword="null" /> string.
        ///     Use this message.
        /// </summary>
        public string MsgStringIsNullString => "The string is not valid. It is a null string.";

        /// <summary>
        ///     If the book title matches the series name Not allowed. Use this
        ///     message.
        /// </summary>
        public string MsgTheTitleNameMatchesSeriesName =>
            "The title of the book can not be the same as the series name.";

        /// <summary>
        ///     If the title name matches the volume name or number. Not allowed.
        ///     Use this message.
        /// </summary>
        public string MsgTheTitleNameMatchesTheVolumeNameNumber =>
            "The title cannot match the volume number text.";

        /// <summary>
        ///     If one of the required directories does not exist. Use this message.
        /// </summary>
        public string MsgThisIsARequiredDirectory =>
            "This directory is one that is required for the program. Should I create it?";

        /// <summary>
        ///     If cannot create authors file name. Use this message.
        /// </summary>
        public string MsgUnableToCreateAuthorFileName => "Unable to create the authors file name.";

        /// <summary>
        ///     If the AppDat directory can not be found. Use this message.
        /// </summary>
        public string MsgUnableToFindTheAppDataDirectory =>
            "Unable to find the AppData directory unable to continue.";

        /// <summary>
        /// Gets the MSG volume number and series name match.
        /// </summary>
        /// <value>
        /// The MSG volume number and series name match.
        /// </value>
        public string MsgVolumeNumberAndSeriesNameMatch =>
            "The book series number is not valid. It is the same as the name of the book series.";
        /// <summary>
        /// Gets the tip automatic format.
        /// </summary>
        /// <value>
        /// The tip automatic format.
        /// </value>
        public string TipAutoFormat { get; } = "Try to auto format book Information.";

        /// <summary>
        ///     Gets the TipBtnFirst.
        /// </summary>
        public string TipBtnFirst { get; } = "Move to first book record.";

        /// <summary>
        ///     Gets the TipBtnLast.
        /// </summary>
        public string TipBtnLast { get; } = "Move to last book record.";

        /// <summary>
        ///     Gets the TipBtnNext.
        /// </summary>
        public string TipBtnNext { get; } = "Move to next book record.";

        /// <summary>
        ///     Gets the TipBtnPrevious.
        /// </summary>
        public string TipBtnPrevious { get; } = "Move to previous book record.";

        /// <summary>
        ///     Gets the TipBtnReplace.
        /// </summary>
        public string TipBtnReplace { get; } = "Format the book title, series and book title.";

        /// <summary>
        ///     Gets the TipBtnSave.
        /// </summary>
        public string TipBtnSave { get; } = "Select to save all formatted book data";

        /// <summary>
        ///     Gets the TipBtnSeries.
        /// </summary>
        public string TipBtnSeries { get; } = "Get the user selected series name.";

        /// <summary>
        ///     Gets the TipBtnTitle.
        /// </summary>
        public string TipBtnTitle { get; } = "Get the user selected title name.";

        /// <summary>
        ///     Gets the TipBtnVolume.
        /// </summary>
        public string TipBtnVolume { get; } = "Get the user selected volume number.";

        /// <summary>
        ///     Gets the TipLblInfo.
        /// </summary>
        public string TipLblInfo { get; } = "Authors Name  ";

        /// <summary>
        ///     Gets the TipLblPosition.
        /// </summary>
        public string TipLblPosition { get; } = "Record position ";

        /// <summary>
        ///     Gets the TipNotSameTitleSeriesVolume.
        /// </summary>
        public string TipNotSameTitleSeriesVolume { get; } = "The book title and/or book series must not " +
                                                             "be the same as book volume. ";

        /// <summary>
        ///     Gets the TipTitleSeriesNotSame.
        /// </summary>
        public string TipTitleSeriesNotSame { get; } = "The title of the book and the book series " +
                                                       "must not be the same. ";

        /// <summary>
        ///     Gets the TipTxtData.
        /// </summary>
        public string TipTxtData { get; } = "Select Title name then select series name then volume number.";
        /// <summary>
        ///     Gets the TipTxtSeries.
        /// </summary>
        public string TipTxtSeries { get; } = "Book series name is displayed here after selecting.";

        /// <summary>
        ///     Gets the TipTxtTitle.
        /// </summary>
        public string TipTxtTitle { get; } = "The book title name is displayed here after selecting.";

        /// <summary>
        ///     Gets the TipTxtVolume.
        /// </summary>
        public string TipTxtVolume { get; } = "The book volume is displayed here after selecting.";
    }
}