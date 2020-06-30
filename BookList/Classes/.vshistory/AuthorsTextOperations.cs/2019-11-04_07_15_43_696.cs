using System;
using System.Collections.Generic;

namespace BookList.Classes
{
    public class AuthorsTextOperations
    {
        public string GetAuthorNameFromFileName(string fileName)
        {
            var name = SplitFileNameFormFileExtension(fileName);

            // TODO: remove '-' from author first last name. check for more then one author.

            var author = ReplaceFirstLatNameSeperatorWithSpace(name);

            return author;
        }

        public static string SplitFileNameFormFileExtension(string fileName)
        {
            var temp = fileName.Split('.');

            return temp.Length < 1 ? fileName : temp[0];
        }

        public bool CheckForMultipleAuthors(string author)
        {
            return author.Contains("_");
        }

        public List<string> SplitMultipleAuthors(string authors)
        {
            var authorNames = new List<string>();

            var retVal = this.CheckForMultipleAuthors(authors);

            if (!retVal)
            {
                authorNames.Add(authors);
                return authorNames;
            }

            var index = GetTheIndexOfAuthorNamesSeperator(authors);

            authorNames = SplitAuthorsAtSeperator(index, authors);

            // TODO: this splits two authors names, Should check for third author?
            return authorNames;
        }

        public List<string> SplitAuthorsAtSeperator(int index, string names)
        {
            var authorsNames = new List<string>();

            var authors = names.Split('_');

            foreach (var name in authors)
            {
                authorsNames.Add(name);
            }

            return authorsNames;
        }

        public int GetTheIndexOfAuthorNamesSeperator(string name)
        {
            var index = name.IndexOf("_", StringComparison.Ordinal);

            return index;
        }

        public static string ReplaceFirstLatNameSeperatorWithSpace(string name)
        {
            var temp = new char();
            var author = string.Empty;

            foreach (var letter in name)
            {
                switch (letter)
                {
                    case '-':
                        temp = ' ';
                        break;
                    default:
                        temp = letter;
                        break;
                }

                author = string.Concat(author, temp.ToString());
            }

            return author;
        }

        public static void SplitStringAtStartOfBookTitle()
        {
        }
    }
}