using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Classes
{
    public class AutomaticBookInfoFormat
    {
        public AutomaticBookInfoFormat()
        {
            
        }

        public List<string> FormatUnformattedBookInformation(List<string> unformatted)
        {
            var bookFormatted = new List<string>();

            CheckIfBookIsSeries(unformatted);

            return bookFormatted;
        }

        private void CheckIfBookIsSeries(List<string> unformatted)
        {
           
        }
    }
}
