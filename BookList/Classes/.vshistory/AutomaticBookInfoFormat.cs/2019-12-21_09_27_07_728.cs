using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Classes
{
    using System.Windows.Forms;

    public class AutomaticBookInfoFormat
    {
        public AutomaticBookInfoFormat()
        {
            
        }

        public List<string> FormatUnformattedBookInformation(List<string> unformatted)
        {
            var bookFormatted = new List<string>();
            var retVal = false;

            foreach (var bookInfo in bookFormatted)
            {
               retVal = CheckIfBookIsSeries(bookInfo);
            }

            if (retVal)
            {
            }

          

            return bookFormatted;
        }

        private bool CheckIfBookIsSeries(string bookInfo)
        {
            var book = bookInfo.ToUpper();
            var find = "book";
            find = find.ToUpper();
            return book.Contains(find);

        }
    }
}
