// BookList
// 
// BookAuthorAddingWin.cs
// 
// Arthur Melanson
// 
// art2m
// 
// 08    13   2020
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
using BookList.Classes;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>
    ///     Used to add new book authors and create there file.
    /// </summary>
    /// <seealso cref="T:System.Windows.Forms.Form" />
    public partial class BookAuthorAddingWin : Form
    {
        /// <summary>
        ///     Declaration of my message box class object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        ///     Declaration of validation class object.
        /// </summary>
        private readonly ValidationClass _valid = new ValidationClass();


        /// <summary>
        ///     Initializes a new instance of the <see cref="BookAuthorAddingWin" />
        ///     class.
        /// </summary>
        public BookAuthorAddingWin()
        {
            InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null) _msgBox.NameOfClass = declaringType.Name;

            SetInitialControlsState();
        }

        /// <summary>
        ///     The OnAddNewBookTitle_Clicked. Set the Text box Authors state.
        /// </summary>
        /// <param name="sender">
        ///     The source of the event. <see cref="Object" /> The source of the
        ///     event.
        /// </param>
        /// <param name="e">
        ///     The e <see cref="EventArgs" /> Instance containing the event data.
        /// </param>
        private void OnAddNewBookTitle_Clicked(object sender, EventArgs e)
        {
            txtAuthor.Enabled = true;
            txtAuthor.Text = string.Empty;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
            txtAuthor.Focus();
        }

        /// <summary>
        ///     The OnCancelOperationButton_Clicked.
        /// </summary>
        /// <param name="sender">
        ///     The source of the event. <see cref="Object" /> .
        /// </param>
        /// <param name="e">The e <see cref="EventArgs" /> .</param>
        private void OnCancelOperationButton_Clicked(object sender, EventArgs e)
        {
            btnAdd.PerformClick();
        }

        /// <summary>
        ///     The OnCloseAddingNewAuthorButton_Close.
        /// </summary>
        /// <param name="sender">
        ///     The source of the event. <see cref="Object" /> The source of the
        ///     event.
        /// </param>
        /// <param name="e">
        ///     The e <see cref="EventArgs" /> Instance containing the event data.
        /// </param>
        private void OnCloseAddingNewAuthorButton_Close(object sender, EventArgs e)
        {
            Close();
        }


        /// <summary>
        ///     The OnSaveRecordButton_Clicked.
        /// </summary>
        /// <param name="sender">
        ///     The source of the event. <see cref="Object" /> The source of the
        ///     event.
        /// </param>
        /// <param name="e">
        ///     The e <see cref="EventArgs" /> Instance containing the event data.
        /// </param>
        private void OnSaveRecordButton_Clicked(object sender, EventArgs e)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var dirFileOp = new FileClass();

            var dirAuthors = BookListPathsProperties.PathAuthorsDirectory;

            var authorOp = new AuthorOperationsClass();

            if (!_valid.ValidateStringIsNotNull(dirAuthors)) return;
            if (!_valid.ValidateStringHasLength(dirAuthors)) return;
            if (!_valid.ValidateStringHasLength(txtAuthor.Text.Trim())) return;
            if (!_valid.ValidateDirectoryExists(dirAuthors)) return;


            var fileName = authorOp.AddDashBetweenAuthorsFirstMiddleLastName(txtAuthor.Text);

            if (!_valid.ValidateStringHasLength(fileName)) return;

            var cls = new CombinePathsClass();
            var filePath = cls.CombineDirectoryPathWithFileName(dirAuthors, fileName);

            if (!_valid.ValidateStringHasLength(filePath)) return;

            if (_valid.ValidateFileExists(filePath, false))
            {
                _msgBox.Msg = "This file all ready exists.";
                _msgBox.ShowInformationMessageBox();
                return;
            }

            if (dirFileOp.CreateNewFile(filePath))
            {
                _msgBox.Msg = "Author file created successfully.";
                _msgBox.ShowInformationMessageBox();
                BookListPathsProperties.AuthorsNameCurrent = fileName;
                BookListPathsProperties.PathOfCurrentWorkingFile = filePath;

                AddNewAuthorFileNameToAuthorsList(fileName);

                return;
            }

            BookListPathsProperties.AuthorsNameCurrent = string.Empty;
            BookListPathsProperties.PathOfCurrentWorkingFile = string.Empty;

            _msgBox.Msg = "Failed to create the file for this author.";
            _msgBox.ShowErrorMessageBox();
        }

        /// <summary>
        ///     Adds the new author file name to authors list.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <exception cref="NotImplementedException" />
        private void AddNewAuthorFileNameToAuthorsList(string fileName)
        {
            _msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;

            var clsOutput = new OutputClass();

            if (clsOutput.WriteArthurFileNamesToListFile(fileName))
            {
                _msgBox.Msg = "The authors name has been added to the authors list.";
                _msgBox.ShowInformationMessageBox();
                return;
            }

            _msgBox.Msg = "Encountered error while adding author name to list. Operation failed.";
            _msgBox.ShowErrorMessageBox();
        }

        /// <summary>
        ///     Sets the initial state of the controls.
        /// </summary>
        private void SetInitialControlsState()
        {
            btnAdd.Enabled = true;
            btnSave.Enabled = false;
            btnCancel.Enabled = false;
            txtAuthor.Enabled = false;
            lblInfo.Text = "lblInfoAddAuthor";
        }
    }
}