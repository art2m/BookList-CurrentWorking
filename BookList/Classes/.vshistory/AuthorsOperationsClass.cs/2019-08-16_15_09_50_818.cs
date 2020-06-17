using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Classes
{
    using System.IO;

    public static class AuthorsClass
    {
        private static List<string> authorNames;

        public static List<string> GetAuthorsList()
        {
            return authorNames;
        }

        public static void GetAuthorsNameFromFileName(string fileName)
        {
            var name = Path.GetFileNameWithoutExtension(fileName);

            var authorName = name.Replace("-", " ");

            CheckForMultipleAuthors(authorName);


        }

        public static void CheckForMultipleAuthors(string authorName)
        {


            if (!authorName.Contains("_"))
            {
                var authors = authorName.Split('_');

                AuthorsClass.AddAuthorsToList(authors);
                return;
            }

            var author = new string[1];

            author[0] = authorName;

            AuthorsClass.AddAuthorsToList(author);




            //var authors = authorName.Replace("_", " ");


            //BookListPropertiesClass.CurrentAuthorName = authors;
        }
    }
}