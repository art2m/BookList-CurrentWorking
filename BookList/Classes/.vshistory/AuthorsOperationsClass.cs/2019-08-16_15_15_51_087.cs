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
            authorNames = new List<string>();

            if (!authorName.Contains("_"))
            {
                authorNames = authorName.Split('_').ToList();
                
                return;

            }

            
        }
    }
}