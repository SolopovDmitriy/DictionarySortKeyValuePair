using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class CardFile
    {
        Dictionary<char, SortedList<Author, List<Book>>> _storage;

        public CardFile()
        {
            _storage = new Dictionary<char, SortedList<Author, List<Book>>>();
            
            //1040-1071
            for (int i = 1040; i < 1072; i++)
            {
                _storage.Add((char)i, new SortedList<Author, List<Book>>());
            }
            foreach (var item in _storage.Keys)
            {
                Console.WriteLine(item);
            }
        }

        public KeyValuePair<Author, List<Book>> getAuthorData(string name, string surname, string patronimic, DateTime birthDate)
        {
            throw new NotImplementedException();
        }

        public List<Book> getBooks(string name, string surname)
        {
            throw new NotImplementedException();
        }

        public List<Book> getBooks(string title)
        {
            List<Book> result = new List<Book>();

            foreach (var item in _storage.Values) //строки нашего словаря
            {
                foreach (List<Book> books in item.Values)
                {
                    foreach (Book oneBook in books)
                    {
                        if (oneBook.Title.Equals(title))
                        {
                            result.Add(oneBook);
                        }
                    }
                }
            }
            return result;
        }

        public bool AddAuthor(Author author)
        {
            char Letter = author.Surname.ToUpper()[0]; //первая буква фамилии автора
            if (_storage.ContainsKey(Letter))
            {
                //_storage[Letter] - доступ к значениям нужной строки (SortedList)
                //_storage[Letter].Keys - доступ ко всем авторам SortedLista
                foreach (Author item in _storage[Letter].Keys)
                {
                    if (item.Equals(author))
                    {
                        return false;
                    }
                }
                _storage[Letter].Add(author, new List<Book>());
                return true;
            }
            return false;
        }
        public void AddBook(Book book)
        {

        }
        public Book getBook(Author author, string title)
        {
            throw new NotImplementedException();
        }
        public List<Book> getBooks(Author author)
        {
            throw new NotImplementedException();
        }

    }
}


