// //-----------------------------------------------------------------------------------------------------------------------------------
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
// //-----------------------------------------------------------------------------------------------------------------------------------

namespace BookList.Classes
{
    using JetBrains.Annotations;
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Reflection;
    using System.Security;
    using System.Text;
    using System.Windows.Forms.VisualStyles;


    /// <summary>
    ///     Validates data.
    /// </summary>
    public static class ValidationClass
    {
        /// <summary>
        /// Set class name for use with messages.
        /// </summary>
        /// <returns></returns>
        /// <created>art2m,5/22/2019</created>
        /// <changed>art2m,5/22/2019</changed>
        static ValidationClass()
        {
            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                MyMessagesClass.NameOfClass = declaringType.Name;
            }
        }

        /// ********************************************************************************
        /// <summary>
        /// Check that there are no invalid characters in the file name.
        /// </summary>
        /// <param name="fileName">The file name to check.</param>
        /// <created>art2m,6/6/2019</created>
        /// <changed>art2m,6/6/2019</changed>
        /// ********************************************************************************
        public static bool CheckForInvalidFileNameCharacters([NotNull] string fileName)
        {
            if (fileName == null) throw new ArgumentNullException(nameof(fileName));
            
            // Get a list of invalid file characters.
            var invalidFileChars = Path.GetInvalidFileNameChars();

            try
            {
                foreach (var item in invalidFileChars)
                {
                    var index = fileName.IndexOf(item);

                    if (index != -1)
                    {
                        throw new NotSupportedException();
                    }
                }

                return true;
            }
            catch (ArgumentNullException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine("The file name cannot be a null value.");
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (NotSupportedException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine("The file name contains invalid characters. Exiting operation:");
                sb.AppendLine(fileName);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }

            /// ********************************************************************************
            /// <summary>
            /// Check the path for any invalid characters.
            /// </summary>
            /// <param name="value">The string path to check.</param>
            /// <created>art2m,6/6/2019</created>
            /// <changed>art2m,6/6/2019</changed>
            /// ********************************************************************************
            public static bool CheckForInvalidPathCharacters([NotNull] string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                var invalidPathChars = Path.GetInvalidPathChars();

                try
                {
                    // var charValue = value.ToCharArray();
                    foreach (var item in invalidPathChars)
                    {
                        var index = value.IndexOf(item);

                        if (index != -1)
                        {
                            throw new NotSupportedException();
                        }
                    }

                    return true;
                }
                catch (ArgumentNullException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The string cannot be a null value.");
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (NotSupportedException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The path name contains invalid characters. Exiting operation:");
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    Debug.WriteLine(sb.ToString());

                    return false;
                }
            }

            /// ********************************************************************************
            /// <summary>
            /// If directory does not exist stop operation.
            /// </summary>
            /// <param name="dirPath">The path of the directory to check.</param>
            /// <created>art2m,6/6/2019</created>
            /// <changed>art2m,6/6/2019</changed>
            /// ********************************************************************************
            public static bool ValidateDirectoryExists([NotNull] string dirPath)
            {
                if (dirPath == null) throw new ArgumentNullException(nameof(dirPath));

                try
                {
                    if (!Directory.Exists(dirPath))
                    {
                        throw new DirectoryNotFoundException();
                    }

                    return true;
                }
                catch (ArgumentNullException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The directory path cannot be a null value.");
                    sb.AppendLine(dirPath);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (DirectoryNotFoundException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("Invalid directory path.");
                    sb.AppendLine(dirPath);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    Debug.WriteLine(sb.ToString());

                    return false;
                }
            }

            /// ********************************************************************************
            /// <summary>
            /// Check if file exists if not stop execution by thrown exception.
            /// </summary>
            /// <param name="filePath">The file path to validate exists.</param>
            /// <created>art2m,6/6/2019</created>
            /// <changed>art2m,6/6/2019</changed>
            /// ********************************************************************************
            public static bool ValidateFileExits([NotNull] string filePath)
            {
                if (filePath == null) throw new ArgumentNullException(nameof(filePath));

                try
                {
                    if (!File.Exists(filePath))
                    {
                        throw new FileNotFoundException();
                    }

                    return true;
                }
                catch (ArgumentNullException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The file path cannot be a null value.");
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (FileNotFoundException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("Unable to locate file for this path. Exiting operation: ");
                    sb.AppendLine(filePath);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    Debug.WriteLine(sb.ToString());
                    return false;
                }
            }

            /// ********************************************************************************
            /// <summary>
            /// Check that the path is not too long.
            /// </summary>
            /// <param name="value">The path to check for length.</param>
            /// <created>art2m,6/6/2019</created>
            /// <changed>art2m,6/6/2019</changed>
            /// ********************************************************************************
            public static bool ValidatePathToLong([NotNull] string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                try
                {
                    Path.GetFullPath(value);

                    return true;
                }
                catch (PathTooLongException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The path is too long. exiting operation.";
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    Debug.WriteLine(ex.ToString());

                    return false;
                }
                catch (SecurityException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("You do not have required permissions. ");
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (ArgumentNullException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The path cannot be null.");
                    sb.AppendLine(ex.ToString());
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (NotSupportedException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("Contains a colon that is not part of the path.");
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (ArgumentException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The specified path or filename exceeds Maximum Length.");
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
            }

            /// <summary>
            ///     Check that there are only letters in the spelling word.
            /// </summary>
            /// <param name="value">The spelling word to be checked.</param>
            /// <returns>True if only letters in the spelling word else false.</returns>
            /// <created>art2m,5/10/2019</created>
            /// <changed>art2m,5/10/2019</changed>
            public static bool ValidateSpellingWordHasLettersOnly(string value)
            {
                Contract.Requires(!string.IsNullOrEmpty(value));

                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                var val = string.Empty;

                try
                {
                    foreach (var letter in value)
                    {
                        if (char.IsLetter(letter))
                        {
                            continue;
                        }

                        MyMessagesClass.ErrorMessage = "Invalid character in string:  " + letter;
                        val = letter.ToString();

                        throw new NotSupportedException();
                    }

                    return true;
                }
                catch (NotSupportedException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("Invalid character in string:");
                    sb.AppendLine(val);
                    sb.AppendLine(ex.ToString());

                    Debug.WriteLine(sb.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
            }

            /// ********************************************************************************
            /// <summary>
            /// Check the string for length if zero then exit operation.
            /// </summary>
            /// <param name="value"></param>
            /// <created>art2m,6/6/2019</created>
            /// <changed>art2m,6/6/2019</changed>
            /// ********************************************************************************
            public static bool ValidateStringHasLength([NotNull] string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                try
                {
                    if (value.Length == 0)
                    {
                        throw new NotSupportedException();
                    }

                    return true;
                }
                catch (ArgumentNullException ex)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("The value cannot be null.");
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();
                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (NotSupportedException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("This value cannot be an empty string.");
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    Debug.WriteLine(sb.ToString());

                    return false;
                }
            }

            /// <summary>
            ///     Check for space in value this will means either space in word that does not belong or
            ///     two words instead of one spelling word.
            /// </summary>
            /// <param name="value">The spelling word to validate.</param>
            /// <returns>True if no space is found else false.</returns>
            /// <created>art2m,5/10/2019</created>
            /// <changed>art2m,5/10/2019</changed>
            public static bool ValidateStringOneWord([NotNull] string value)
            {
                if (value == null) throw new ArgumentNullException(nameof(value));

                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                try
                {
                    var index = value.IndexOf(' ');

                    if (index > -1)
                    {
                        throw new NotSupportedException();
                    }

                    return true;
                }
                catch (ArgumentNullException ex)
                {
                    var sb = new StringBuilder();

                    sb.AppendLine("The value cannot be null.");
                    sb.AppendLine(ex.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
                catch (NotSupportedException ex)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("Check to see if space in word or if two words are entered.");
                    sb.AppendLine("Spaces and double words are not allowed.");
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    Debug.WriteLine(sb.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
            }

            /// ********************************************************************************
            /// <summary>
            /// Check to see if string is null empty or length is 0. Throw exception
            /// to stop execution in these circumstances.
            /// </summary>
            /// <param name="value">The spelling word to be checked.</param>
            /// <returns>true if no problem is found with string else false.</returns>
            /// <created>art2m,5/10/2019</created>
            /// <changed>art2m,6/6/2019</changed>
            /// ********************************************************************************
            public static bool ValidateStringValueNotEmptyNotWhiteSpace([NotNull] string value)
            {
                MyMessagesClass.NameOfMethod = MethodBase.GetCurrentMethod().Name;

                value = value.Trim();

                try
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new NotSupportedException();
                    }

                    return true;
                }
                catch (NotSupportedException ex)
                {
                    var sb = new StringBuilder();
                    sb.AppendLine("The value is not valid. It is empty or null.");
                    sb.AppendLine(value);
                    sb.AppendLine(ex.ToString());

                    Debug.WriteLine(sb.ToString());

                    MyMessagesClass.ErrorMessage = sb.ToString();

                    MyMessagesClass.ShowErrorMessageBox();

                    return false;
                }
            }
        }
    }