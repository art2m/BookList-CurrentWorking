using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;

using BookList.Classes;
using BookList.PropertiesClasses;

namespace BookList.Source
{
    /// <summary>This class displays a list of books by the selected author.
    /// Then any unformatted book data can be formatted.</summary>
    public partial class FormatBookDataWin : Form
    {
        /// <summary>
        /// The result
        /// </summary>
        private DialogResult _result;

        /// <summary>
        /// decleration of message box object.
        /// </summary>
        private readonly MyMessageBoxClass _msgBox = new MyMessageBoxClass();

        /// <summary>
        /// The position in the record.
        /// </summary>
        private int position;

        /// <summary>
        /// The total count of records.
        /// </summary>
        private int totalCount;


        /// <summary>Initializes a new instance of the <see cref="FormatBookDataWin" /> class.</summary>
        public FormatBookDataWin()
        {
            this.InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                this._msgBox.NameOfClass = declaringType.Name;
            }

            this.mnuAuthors.PerformClick();
        }

        /// <summary>  Add all author names to the collection.</summary>
        private void GetAllAuthorsNames()
        {
            var fileInput = new InputClass();

            fileInput.ReadAuthorsNamesFromFile(BookListPathsProperties.PathAuthorsNamesListFile);
        }

        /// <summary>Displays the record count and selected record position.</summary>
        private void DisplayRecordCountAndPosition()
        {
            var sb = new StringBuilder();
            sb.Append(position.ToString());
            sb.Append(" of ");
            sb.Append(totalCount.ToString());

            this.lblPosition.Text = sb.ToString();
        }

        /// <summary>Gets the name of the authors name.</summary>
        /// <param name="fileName">Name of the file.</param>
        private void GetAuthorsName(string fileName)
        {
            var author = new AuthorOperationsClass();

            var clsFile = new FileClass();
            var authorName = clsFile.RemoveFileExtension(fileName);
        }


        /// <summary>  Get the selected authors path to the file.</summary>
        private void GetUnformattedDataFrom()
        {
            var dirFileOp = new FileClass();

            var dirPath = BookListPathsProperties.PathAuthorsDirectory;

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");

            var cls = new CombinePathsClass();
            BookListPathsProperties.PathToCurrentAuthorsFile = cls.CombineDirectoryPathWithFileName(dirPath,
                    BookListPathsProperties.AuthorsNameCurrent);

            this.GetAuthorsName(BookListPathsProperties.AuthorsNameCurrent);
        }


        /// <summary>Loads the book titles and info for the selected artist to a collection.</summary>
        private void LoadUnformattedData()
        {
            var fileInput = new InputClass();

            this.GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(BookListPathsProperties.PathToCurrentAuthorsFile)) return;

            fileInput.ReadTitlesFromFile(BookListPathsProperties.PathToCurrentAuthorsFile);

            var coll = new global::BookList.Collections.BookData();

            totalCount = coll.GetItemsCount();
        }

        /// <summary>Moves to first record.</summary>
        private void MoveToFirstRecord()
        {
            var coll = new global::BookList.Collections.BookData();

            if (coll.GetItemsCount() <= 0) return;

            BookDataProperties.NumberOfItems = 0;
            this.txtData.Text = coll.GetItemAt(BookDataProperties.NumberOfItems);

            position = BookDataProperties.NumberOfItems + 1;

            this.DisplayRecordCountAndPosition();
        }

        /// <summary>Moves to last record.</summary>
        private void MoveToLastRecord()
        {
            var coll = new global::BookList.Collections.BookData();

            if (coll.GetItemsCount() == 0) return;

            if (BookDataProperties.NumberOfItems + 1 > coll.GetItemsCount()) return;

            BookDataProperties.NumberOfItems = coll.GetItemsCount() - 1;

            this.txtData.Text = coll.GetItemAt(BookDataProperties.NumberOfItems);

            position = coll.GetItemsCount();

            this.DisplayRecordCountAndPosition();
        }

        /// <summary>Moves to next record.</summary>
        private void MoveToNextRecord()
        {
            var coll = new global::BookList.Collections.BookData();

            if (coll.GetItemsCount() == 0) return;

            // pos zero based.
            if (BookDataProperties.NumberOfItems + 1 >= coll.GetItemsCount()) return;

            BookDataProperties.NumberOfItems++;

            this.txtData.Text = coll.GetItemAt(BookDataProperties.NumberOfItems);

            position = BookDataProperties.NumberOfItems + 1;

            this.DisplayRecordCountAndPosition();
        }

        /// <summary>Moves to previous record.</summary>
        private void MoveToPreviousRecord()
        {
            var coll = new global::BookList.Collections.BookData();

            if (coll.GetItemsCount() == 0) return;

            if (BookDataProperties.NumberOfItems == 0) return;

            BookDataProperties.NumberOfItems--;

            this.txtData.Text = coll.GetItemAt(BookDataProperties.NumberOfItems);

            position = BookDataProperties.NumberOfItems + 1;

            this.DisplayRecordCountAndPosition();
        }

        /// <summary>Called when [book is not series RadioButton clicked].
        /// Sets property value to false.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnBookIsNotSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            BookDataProperties.BookSeries = false;
        }

        /// <summary>Called when [book is series RadioButton clicked].
        ///  Sets the property value to true.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnBookIsSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            BookDataProperties.BookSeries = true;
        }

        /// <summary>Called when [close button clicked].
        /// Exit Format Book Data Window form</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>Called when [close menu item clicked].
        /// Exit Format Book Data Windows form. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseMenuItem_Clicked(object sender, EventArgs e)
        {
            this.btnClose.PerformClick();
        }

        /// <summary>Called when [display all authors menu item clicked]. Displays the Author list form.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnDisplayAllAuthorsMenuItem_Clicked(object sender, EventArgs e)
        {
            this.GetAllAuthorsNames();


            using (var dlg = new AuthorsListingWin())
            {
                this._result = dlg.ShowDialog();
            }

            if (this._result == DialogResult.Cancel) return;

            this.LoadUnformattedData();

            if (string.IsNullOrEmpty(BookListPathsProperties.AuthorsNameCurrent)) return;


            this.MoveToFirstRecord();
        }

        /// <summary>Called when [format book information button click].</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnFormatBookInformationButton_Click(object sender, EventArgs e)
        {
            this._msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var validate = new ValidationClass();

            if (!this.rbtnIsSeries.Checked && !this.rbtnNotSeries.Checked)
            {
                this._msgBox.Msg = "You must select if book is series or not series.";
                this._msgBox.ShowErrorMessageBox();
                return;
            }

            var temp = this.txtData.Text.Trim();

            if (string.IsNullOrEmpty(temp)) return;

            if (BookDataProperties.BookSeries)
            {
                if (validate.ValidateBookSeriesIsFormatted(this.txtData.Text)) return;
            }
            else if (!BookDataProperties.BookSeries &&
                     validate.ValidateBookNotSeriesIsFormatted(this.txtData.Text)) return;

            BookDataProperties.UnformattedBookInformation = temp;

            using (var dlg = new UnformattedBookDataWin())
            {
                this._result = dlg.ShowDialog();
            }

            if (this._result == DialogResult.OK) this.ReloadBookTitles();
            this.btnFirst.PerformClick();
        }


        /// <summary>Called when [move first button clicked].
        /// Move to the first book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMoveFirstButton_Clicked(object sender, EventArgs e)
        {
            this.MoveToFirstRecord();
        }


        /// <summary>Called when [move last button clicked].
        /// Move to the last book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            this.MoveToLastRecord();
        }

        /// <summary>Called when [move next button clicked].
        /// Move to the next book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            this.MoveToNextRecord();
        }

        /// <summary>Called when [move previous button clicked].
        /// Move to the previous book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            this.MoveToPreviousRecord();
        }

        /// <summary>Reloads the book titles.
        /// redisplay authors list so user can make a diffrent selection. </summary>
        private void ReloadBookTitles()
        {
            this.mnuAuthors.PerformClick();
        }
    }
}