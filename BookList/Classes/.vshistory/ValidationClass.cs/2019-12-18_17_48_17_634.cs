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
    using System;
    using System.Diagnostics;
    using System.Diagnostics.Contracts;
    using System.IO;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Security;
    using System.Text;

    using JetBrains.Annotations;

    /// <summary>
    ///     Validates data.
    /// </summary>
    public static class ValidationClass
    {
        private const string Value = "The file name cannot be a null value.";
        private const string Value1 = "The file name contains invalid characters. Exiting operation:";
        private const string Value2 = "The string cannot be a null value.";
        private const string Value3 = "The path name contains invalid characters. Exiting operation:";
        private const string Value4 = "The directory path cannot be a null value.";
        private const string Value5 = "Unable to locate file for this path. Exiting operation: ";
        private const string Value6 = "Invalid directory path.";
        private const string Value7 = "The file path cannot be a null value.";
        private const string Value8 = "The path is too long. exiting operation.";
        private const string Value9 = "You do not have required permissions. ";
        private const string Value10 = "The path cannot be null.";
        private const string Value11 = "Contains a colon that is not part of the path.";
        private const string Value12 = "The specified path or filename exceeds Maximum Length.";
        private const string V = "Invalid character in string:  ";
        private const string Value13 = "This value cannot be an empty string.";
        private const string Value14 = "Invalid character in string:";
        private const string Value16 = "The value cannot be null.";
        private const string Value15 = Value16;

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


        /// <summary>Checks for invalid file name characters.</summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>true if no invalid characters in file name else false.</returns>
        /// <exception cref="ArgumentNullException">This file name is a null value.</exception>
        /// <exception cref="NotSupportedException">This file name contains invalid characters.</exception>
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

                sb.AppendLine(Value);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (NotSupportedException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value1);
                sb.AppendLine(fileName);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }


        /// <summary>Checks for invalid path characters.</summary>
        /// <param name="value">The value.</param>
        /// <returns>If no invalid path characters return true else false.</returns>
        /// <exception cref="ArgumentNullException">The path is a null value.</exception>
        /// <exception cref="NotSupportedException">The path contains invalid characters.</exception>
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

                sb.AppendLine(Value2);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (NotSupportedException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value3);
                sb.AppendLine(value);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(sb.ToString());

                return false;
            }
        }


        /// <summary>Validates the directory exists.</summary>
        /// <param name="dirPath">The directory path.</param>
        /// <returns>If directory exists then true else false.</returns>
        /// <exception cref="ArgumentNullException">Directory path is a null value.</exception>
        /// <exception cref="DirectoryNotFoundException">This path is not valid for a directory.</exception>
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

                sb.AppendLine(Value4);
                sb.AppendLine(dirPath);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (DirectoryNotFoundException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value6);
                sb.AppendLine(dirPath);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();

                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(sb.ToString());

                return false;
            }
        }

        /// <summary>
        /// Validates the file exits.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException">filePath</exception>
        /// <exception cref="FileNotFoundException">return false</exception>
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

                sb.AppendLine(Value7);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (FileNotFoundException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value5);
                sb.AppendLine(filePath);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                Debug.WriteLine(sb.ToString());
                return false;
            }
        }


        /// <summary>Validates the path to long.</summary>
        /// <param name="value">The path to be checked.</param>
        /// <returns>true if path OK else false.</returns>
        /// <exception cref="ArgumentNullException">value</exception>
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

                sb.AppendLine(Value8);
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

                sb.AppendLine(Value9);
                sb.AppendLine(value);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentNullException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value10);
                sb.AppendLine(ex.ToString());
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (NotSupportedException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value11);
                sb.AppendLine(value);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (ArgumentException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value12);
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

                    MyMessagesClass.ErrorMessage = V + letter;
                    val = letter.ToString();

                    throw new NotSupportedException();
                }

                return true;
            }
            catch (NotSupportedException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value14);
                sb.AppendLine(val);
                sb.AppendLine(ex.ToString());

                Debug.WriteLine(sb.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();

                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
        }

       /// <summary>
       /// Validate string is not empty.
       /// </summary>
       /// <param name="value">The string to be checked.</param>
       /// <returns>True if string not empty string else false.</returns>
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
                sb.AppendLine(Value16);
                sb.AppendLine(ex.ToString());

                MyMessagesClass.ErrorMessage = sb.ToString();
                MyMessagesClass.ShowErrorMessageBox();

                return false;
            }
            catch (NotSupportedException ex)
            {
                var sb = new StringBuilder();

                sb.AppendLine(Value13);
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

                sb.AppendLine(Value16);
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


        /// <summary>Validates the string value not null or only white space.</summary>
        /// <param name="value">The string to be checked.</param>
        /// <returns>True if string is not empty and has length.</returns>
        /// <exception cref="NotSupportedException"></exception>
        public static bool ValidateStringValueNotNullNotWhiteSpace([NotNull] string value)
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

        public static bool ValidateStringValueIsNotNull(string value)
        {
            try
            {
                if (value == null) throw new ArgumentNullException();

                return true;
            }
            catch (Exception ex)
            {
                MyMessagesClass.ErrorMessage = "This value can not be null. " + ex.ToString();
                MyMessagesClass.ShowErrorMessageBox();
                return false;
            }
        }
    }
}