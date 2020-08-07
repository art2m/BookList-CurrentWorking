using System;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using BookList.Classes;
using BookList.Collections;
using BookList.PropertiesClasses;
using BookListCurrent.ClassesProperties;

namespace BookList.Source
{
    /// <summary>This class displays a list of books by the selected author.
    /// Then any unformatted book data can be formatted.</summary>
    public partial class FormatBookData : Form
    {
        private DialogResult _result;

        private MyMessageBox msgBox = new MyMessageBox();
        private MyMessages msg = new MyMessages();


        /// <summary>Initializes a new instance of the <see cref="FormatBookData" /> class.</summary>
        public FormatBookData()
        {
            InitializeComponent();

            var declaringType = MethodBase.GetCurrentMethod().DeclaringType;
            if (declaringType != null)
            {
                msgBox.NameOfClass = declaringType.Name;
            }

            mnuAuthors.PerformClick();

            SetAllControlsToolTips();
        }

        /// <summary>  Add all author names to the collection.</summary>
        private void GetAllAuthorsNames()
        {
            var fileInput = new FileInputClass();

            fileInput.ReadAuthorsNamesFromFile(BookListPropertiesClass.PathToAuthorsNamesListFile);
        }

        /// <summary>Displays the record count and selected record position.</summary>
        private void DisplayRecordCountAndPosition()
        {
            var sb = new StringBuilder();
            sb.Append(FormatBookDataProperties.CurrentPositionInTitlesRecords.ToString());
            sb.Append(" of ");
            sb.Append(FormatBookDataProperties.RecordsTotalCount.ToString());

            lblPosition.Text = sb.ToString();
        }

        /// <summary>Gets the name of the authors name.</summary>
        /// <param name="fileName">Name of the file.</param>
        private void GetAuthorsName(string fileName)
        {
            var author = new AuthorsTextOperations();

            var authorName = author.SplitFileNameFormFileExtension(fileName);


        }


        /// <summary>  Get the selected authors path to the file.</summary>
        private void GetUnformattedDataFrom()
        {
            var dirFileOp = new DirectoryFileClass();

            var dirPath = BookListPropertiesClass.PathToAuthorsDirectory;

            Debug.Assert(dirPath != null, nameof(dirPath) + " != null");
            FormatBookDataProperties.PathToCurrentAuthorsFile =
                dirFileOp.CombineDirectoryPathWithFileName(dirPath,
                    BookListPropertiesClass.AuthorsNameCurrent);

            GetAuthorsName(BookListPropertiesClass.AuthorsNameCurrent);
        }


        /// <summary>Loads the book titles and info for the selected artist to a collection.</summary>
        private void LoadUnformattedData()
        {
            var fileInput = new FileInputClass();

            GetUnformattedDataFrom();

            if (string.IsNullOrEmpty(FormatBookDataProperties.PathToCurrentAuthorsFile)) return;

            fileInput.ReadTitlesFromFile(FormatBookDataProperties.PathToCurrentAuthorsFile);

           // var collUn = new UnformattedDataBackUpCollection();
            //collUn.AddToBackUpList();

            var coll = new UnformattedDataCollection();

            FormatBookDataProperties.RecordsTotalCount = coll.GetItemsCount();
        }

        /// <summary>Moves to first record.</summary>
        private void MoveToFirstRecord()
        { 
            var coll = new UnformattedDataCollection();

            if (coll.GetItemsCount() <= 0) return;

            FormatBookDataProperties.BookTitleRecordsCount = 0;
            txtData.Text = coll.GetItemAt(FormatBookDataProperties.BookTitleRecordsCount);

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            DisplayRecordCountAndPosition();
        }

        /// <summary>Moves to last record.</summary>
        private void MoveToLastRecord()
        {
            var coll = new UnformattedDataCollection();

            if (coll.GetItemsCount() == 0) return;

            if (FormatBookDataProperties.BookTitleRecordsCount + 1 > coll.GetItemsCount()) return;

            FormatBookDataProperties.BookTitleRecordsCount = coll.GetItemsCount() - 1;

            txtData.Text = coll.GetItemAt(FormatBookDataProperties.BookTitleRecordsCount);

            FormatBookDataProperties.CurrentPositionInTitlesRecords = coll.GetItemsCount();

            DisplayRecordCountAndPosition();
        }

        /// <summary>Moves to next record.</summary>
        private void MoveToNextRecord()
        {
            var coll = new UnformattedDataCollection();

            if (coll.GetItemsCount() == 0) return;

            // pos zero based.
            if (FormatBookDataProperties.BookTitleRecordsCount + 1 >= coll.GetItemsCount()) return;

            FormatBookDataProperties.BookTitleRecordsCount++;

            txtData.Text = coll.GetItemAt(FormatBookDataProperties.BookTitleRecordsCount);

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            DisplayRecordCountAndPosition();
        }

        /// <summary>Moves to previous record.</summary>
        private void MoveToPreviousRecord()
        {
            var coll = new UnformattedDataCollection();

            if (coll.GetItemsCount() == 0) return;

            if (FormatBookDataProperties.BookTitleRecordsCount == 0) return;

            FormatBookDataProperties.BookTitleRecordsCount--;

            txtData.Text = coll.GetItemAt(FormatBookDataProperties.BookTitleRecordsCount);

            FormatBookDataProperties.CurrentPositionInTitlesRecords =
                FormatBookDataProperties.BookTitleRecordsCount + 1;

            DisplayRecordCountAndPosition();
        }

        /// <summary>Called when [book is not series RadioButton clicked].
        /// Sets property value to false.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnBookIsNotSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            FormatBookDataProperties.BookIsSeries = false;
        }

        /// <summary>Called when [book is series RadioButton clicked].
        ///  Sets the property value to true.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnBookIsSeriesRadioButton_Clicked(object sender, EventArgs e)
        {
            FormatBookDataProperties.BookIsSeries = true;
        }

        /// <summary>Called when [close button clicked].
        /// Exit Format Book Data Window form</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseButton_Clicked(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>Called when [close menu item clicked].
        /// Exit Format Book Data Windows form. </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnCloseMenuItem_Clicked(object sender, EventArgs e)
        {
            btnClose.PerformClick();
        }

        /// <summary>Called when [display all authors menu item clicked]. Displays the Author list form.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnDisplayAllAuthorsMenuItem_Clicked(object sender, EventArgs e)
        {
            GetAllAuthorsNames();


            using (var dlg = new AuthorsListing())
            {
                _result = dlg.ShowDialog();
            }

            if (_result == DialogResult.Cancel) return;

            LoadUnformattedData();

            if (string.IsNullOrEmpty(BookListPropertiesClass.AuthorsNameCurrent)) return;


            MoveToFirstRecord();
        }

        /// <summary>Called when [format book information button click].</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnFormatBookInformationButton_Click(object sender, EventArgs e)
        {

            msgBox.NameOfMethod = MethodBase.GetCurrentMethod().Name;
            var validate = new ValidationClass();

            if (!rbtnIsSeries.Checked && !rbtnNotSeries.Checked)
            {
                msgBox.Msg = "You must select if book is series or not series.";
               msgBox.ShowErrorMessageBox();
                return;
            }

            var temp = txtData.Text.Trim();

            if (string.IsNullOrEmpty(temp)) return;

            if (FormatBookDataProperties.BookIsSeries)
            {
                if (validate.ValidateBookSeriesIsFormatted(txtData.Text)) return;
            }
            else if (!FormatBookDataProperties.BookIsSeries &&
                     validate.ValidateBookNotSeriesIsFormatted(txtData.Text)) return;

            FormatBookDataProperties.UnformattedBookInformation = temp;

            using (var dlg = new FormatUnformattedBookData())
            {
                _result = dlg.ShowDialog();
            }

            if (_result == DialogResult.OK) ReloadBookTitles();
            btnFirst.PerformClick();
        }


        /// <summary>Called when [move first button clicked].
        /// Move to the first book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMoveFirstButton_Clicked(object sender, EventArgs e)
        {
            MoveToFirstRecord();
        }


        /// <summary>Called when [move last button clicked].
        /// Move to the last book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMoveLastButton_Clicked(object sender, EventArgs e)
        {
            MoveToLastRecord();
        }

        /// <summary>Called when [move next button clicked].
        /// Move to the next book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMoveNextButton_Clicked(object sender, EventArgs e)
        {
            MoveToNextRecord();
        }

        /// <summary>Called when [move previous button clicked].
        /// Move to the previous book title record.</summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void OnMovePreviousButton_Clicked(object sender, EventArgs e)
        {
            MoveToPreviousRecord();
        }

        /// <summary>Reloads the book titles.
        /// redisplay authors list so user can make a diffrent selection. </summary>
        private void ReloadBookTitles()
        {
            mnuAuthors.PerformClick();
        }

        /// <summary>Sets all controls tool tips.</summary>
        private void SetAllControlsToolTips()
        {
            /*tipTool.SetToolTip(btnFirst, FormatBookDataProperties.TipBtnFirst);
            tipTool.SetToolTip(btnNext, FormatBookDataProperties.TipBtnNext);
            tipTool.SetToolTip(btnPrevious, FormatBookDataProperties.TipBtnPrevious);
            tipTool.SetToolTip(btnLast, FormatBookDataProperties.TipBtnLast);*/
        }
    }

}