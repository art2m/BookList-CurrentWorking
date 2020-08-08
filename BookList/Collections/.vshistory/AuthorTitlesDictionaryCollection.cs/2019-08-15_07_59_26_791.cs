using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Collections
{
    public static class AuthorTitlesDictionaryCollection
    {
        private static readonly Dictionary<string, List<string>> DicData = new Dictionary<string, List<string>>();

        // private static readonly List<string> LstTitles = new List<string>();

        public static void AddItems(string author, List<string> titles)
        {
            DicData.Add(author, titles);

        }


    }
}
