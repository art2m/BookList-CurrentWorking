using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Classes
{
    public static class AuthorsClass
    {
        private static List<string> authorNames;

        public static void AddAuthorsToList(string[] authors)
        {
            var cnt = authors.Length;

            var authorNames = new List<string>();

            foreach (var author in authors)
            {
                authorNames.Add(author);
            }
        }

        public static List<string> GetAuthorsList()
        {
            return authorNames;
        }
    }
}