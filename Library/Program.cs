using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Program
    {
        static void TestList()
        {
            List<int> list1;
            list1 = new List<int>(1000);

            // list1[5] = 123; // error



            list1.Add(2);
            list1.Add(21);
            list1.Add(25);
            list1.Add(7);

            // list1[3] = 2000;

            // list1.Remove(21);
            // list1.RemoveAt(0);
            // list1.RemoveAll(item => item > 10);

            //Console.WriteLine(list1.Capacity);
            //Console.WriteLine(list1.Count);
            //Console.WriteLine();
            //for (int i = 0; i < list1.Count; i++) // i = 0, 1, 2, 3
            //{
            //    Console.WriteLine(list1[i]);       
            //}


            foreach (int item in list1)
            {
                Console.WriteLine(item);
            }



            List<string> list2 = new List<string>();
            list2.Add("Hello");
        }

        static void TestBook1()
        {
            Book book1 = new Book();
            book1.Authors.Add(new Author("Александр", "Пушкин", "Сергеевич", new DateTime(1799, 6, 26)));
            book1.Authors.Add(new Author("Николя", "Гоголь", "Васильевич", new DateTime(1809, 4, 1)));

            foreach (Author item in book1.Authors)
            {
                Console.WriteLine(item.Surname);
            }

        }


        static void TestBook2()
        {
            Book book2 = new Book("Mертвые души", "интерессная книга", Genre.Drama, new DateTime(2010, 6, 26), Publisher.Piter);
            book2.Authors.Add(new Author("Александр", "Пушкин", "Сергеевич", new DateTime(1799, 6, 26)));
            book2.Authors.Add(new Author("Николя", "Гоголь", "Васильевич", new DateTime(1809, 4, 1)));


            List<Author> list3 = book2.Authors;

            foreach (Author item in book2.Authors)// foreach (Author item in list3)
            {
                Console.WriteLine(item);
            }

        }

        static void TestSimpleDictionary()
        {
            // php 
            // $array1 = ["name" => "Peter", "surname" => "Petrov"]
            // echo $array1["name"];  // Peter

            Dictionary<string, string> dict1 = new Dictionary<string, string>();
            dict1["name"] = "Peter";
            dict1["surname"] = "Ivanov";
            //dict1["age"] = 23;// error
            Console.WriteLine(dict1["name"]);
        }


        static void TestSimpleDictionary2()
        {
            // php 
            // $array1 = ["name" => "Peter", "surname" => "Petrov"]
            // echo $array1["name"];  // Peter

            Dictionary<string, int> dict1 = new Dictionary<string, int>();
            //dict1["name"] = "Peter"; // error
            //dict1["surname"] = "Ivanov";// error
            dict1["age"] = 23;
            dict1["height"] = 190;

            dict1["height"] = 200;

            dict1.Remove("age");
            //string key = "sdf";
            //if (dict1.ContainsKey(key))
            //{
            //    Console.WriteLine(dict1[key]);
            //}
            //else
            //{
            //    Console.WriteLine("The dictionary doesnt have this key");
            //}


            foreach(KeyValuePair<string, int> item in dict1)
            {
                Console.WriteLine(item.Value);
            }
           
        }


        static void TestDictionary3()
        {
            Author author1 = new Author("Александр", "Пушкин", "Сергеевич", new DateTime(1799, 6, 26));
            Author author2 = new Author("Николя", "Гоголь", "Васильевич", new DateTime(1809, 4, 1));
            Author author3 = new Author("Иван", "Тургенев", "Сергеевич", new DateTime(1883, 9, 3));
            Dictionary<Author, double> dict1 = new Dictionary<Author, double>();

            dict1[author1] = 3.5;
            dict1[author1] = 3.6;
            dict1[author3] = 3.7;
            Console.WriteLine(dict1[author1]);
            foreach(KeyValuePair<Author, double> item in dict1)
            {
                Console.WriteLine(item);
            }           
        }


        static void TestSimpleSortedList()
        {
            // SortedList<Author, List<Book>>
            SortedList<string, int> dict1 = new SortedList<string, int>();
            dict1["weight"] = 90;
            dict1["age"] = 230;
            dict1["height"] = 190;
                

            foreach (KeyValuePair<string, int> item in dict1)
            {
                Console.WriteLine(item);
            }

        }

        static void TestSortedListDifficult ()
        {
            // SortedList<Author, List<Book>>
           
            SortedList<Author, List<Book>> dict1 = new SortedList<Author, List<Book>>(new AuthorComparerByName());
            // key - Author
            // value  - List<Book>
           
           
            Author author3 = new Author("Иван", "Тургенев", "Сергеевич", new DateTime(1883, 9, 3));
            
            
            
            Author author2 = new Author("Николя", "Гоголь", "Васильевич", new DateTime(1809, 4, 1));
            Book book1 = new Book();
            Book book2 = new Book("Mертвые души", "интерессная книга", Genre.Drama, new DateTime(2010, 6, 26), Publisher.Piter);
            List<Book> GogolBooks = new List<Book>();
            GogolBooks.Add(book2);
            GogolBooks.Add(book1);            
            dict1[author2] = GogolBooks;



            Author author1 = new Author("Александр", "Пушкин", "Сергеевич", new DateTime(1799, 6, 26));
            Book book3 = new Book("Евгений Онегин", "интерессная книга", Genre.Drama, new DateTime(2010, 6, 26), Publisher.Piter);
            List<Book> PushkinBooks = new List<Book>();
            PushkinBooks.Add(book3);           
            dict1[author1] = PushkinBooks;

            foreach (KeyValuePair<Author, List<Book>> item in dict1)
            {
                Console.WriteLine(item.Key);
            }

        }


        static void Main(string[] args)
        {
            //CardFile cardFile = new CardFile();
            //cardFile.AddAuthor(new Author("Александр", "Пушкин", "Сергеевич", new DateTime(1799, 6, 26)));
            //cardFile.AddAuthor(new Author("Николя", "Гоголь", "Васильевич", new DateTime(1809, 4, 1)));
            //cardFile.AddAuthor(new Author("Иван", "Тургенев", "Сергеевич", new DateTime(1883, 9, 3)));

            //Console.WriteLine(cardFile);



            // TestBook2();
            // TestDictionary3();
            // TestSimpleSortedList();
            TestSortedListDifficult();

            Console.ReadKey();

        }
    }
}
