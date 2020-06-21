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

        /// <summary>
        /// Adds multiple book authors to list.
        /// </summary>
        /// <param name="authors">The authors.</param>
        public static void AddAuthorsToList(string[] authors)
        {
            var cnt = authors.Length;

           authorNames = new List<string>();

            foreach (var author in authors)
            {
                authorNames.Add(author);
            }
        }

        /// <summary>
        /// Adds single book author to list.
        /// </summary>
        /// <param name="author">The author.</param>
        public static void AddAuthorToList(string author)
        {
            authorNames = new List<string> {author};

        }

        public static List<string> GetAuthorsList()
        {
            return authorNames;
        }
    }
}