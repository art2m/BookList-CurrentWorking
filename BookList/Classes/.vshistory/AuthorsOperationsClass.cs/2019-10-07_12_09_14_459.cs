using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookList.Classes
{
    using System.IO;

    public static class AuthorsOperationsClass
    {
        private static List<string> authorNames = new List<string>();

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
            authorNames.Clear();

            if (!authorName.Contains("_"))
            {
                authorNames.Add(authorName);
                return;
            }

            authorNames = authorName.Split('_').ToList();
        }

        public static void AddOrRemoveAuthorNamesFromAuthorsList(List<string>authorsList)
        {
            foreach (var author in authorsList)
            {
                if (Auth)
            }
        }
    }
}