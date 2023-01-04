using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.FirstAssignment
{
    class Occurance
    {
        static void Main(string[] args)
        {
            string str = "Umar";
            char ch = 'a';
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ch)
                {
                    count++;
                    Console.WriteLine("Char is present");
                }
            }
            Console.WriteLine(count);

        }
    }

    class NoWords
    {
        static void Main(string[] args)
        {
            string str = "India iS My Country";
            Console.WriteLine(str);
            int cnt = 1;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ' ')
                {
                    cnt++;
                }
            }
            Console.WriteLine("No of words Are =" + " " + cnt);
        }
    }

    class Anagram
    {
        static void Main(string[] args)
        {
            int cnt = 0;
            Console.WriteLine("Enter String 1");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter String 2");
            string str2 = Console.ReadLine();
            char[] ch1 = str1.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();
            Array.Sort(ch1);
            Array.Sort(ch2);
            string val1 = new string(ch1);
            string val2 = new string(ch2);
            if (val1 == val2)
            {
                Console.WriteLine("Anagram");
            }
            else
            {
                Console.WriteLine("Not");
            }


        }
    }

    class Email
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Email Id: ");
            string emailId = Console.ReadLine();

            if (emailId.Contains("@") && emailId.Contains("."))
            {
                Console.WriteLine("Valid Email Id");
            }
            else
            {
                Console.WriteLine("Invalid Email Id");
            }

        }
    }

    /*  public class Book
      {
          public int bookId;
          public string bookName;
          public double price;
          public string authorName;

          public Book(int _bookId, string _bookName, double _price, string _authorName)
          {
              bookId = _bookId;
              bookName = _bookName;
              price = _price;
              authorName = _authorName;
          }
      }

      class Library
      {
          public static void Main(string[] args)
          {
              Book[] books = new Book[3] {
              new Book(1, "Data Structures", 250.20, "John Smith"),
              new Book(2, "Database Management", 300.50, "Mary Jones"),
              new Book(3, "Software Engineering", 150.50, "Paul Anderson")
          };

              // Create
              Book newBook = new Book(4, "Computer Networks", 200.00, "Robert Johnson");
              Array.Resize(ref books, books.Length + 1);
              books[books.Length - 1] = newBook;

              // Read
              foreach (Book book in books)
              {
                  Console.WriteLine("Book ID: {0}, Book Name: {1}, Price: {2}, Author Name: {3}", book.bookId, book.bookName, book.price, book.authorName);
              }

              // Update
              books[2].price = 200.00;
              Console.WriteLine("\nBook 3 has been updated with new price.");

              // Delete
              Array.Clear(books, 0, 1);
              Console.WriteLine("\nBook 1 has been deleted.");
          }
      }*/

    /*public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public double Price { get; set; }
        public string AuthorName { get; set; }

        public Book(int bookId, string bookName, double price, string authorName)
        {
            BookId = bookId;
            BookName = bookName;
            Price = price;
            AuthorName = authorName;
        }

        public Book[] CreateBookArray()
        {
            Book[] books = new Book[3]
            {
            new Book(1, "Book1", 10.0, "Author1"),
            new Book(2, "Book2", 20.0, "Author2"),
            new Book(3, "Book3", 30.0, "Author3")
            };
            return books;
        }

        public void InsertBook(Book book)
        {
            Book[] books = CreateBookArray();

            Book[] newBooks = new Book[books.Length + 1];
            for (int i = 0; i < books.Length; i++)
            {
                newBooks[i] = books[i];
            }
            newBooks[newBooks.Length - 1] = book;
            books = newBooks;
        }

        public  void UpdateBook(Book book)
        {
            Book[] books = CreateBookArray();

            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].BookId == book.BookId)
                {
                    books[i] = book;
                }
            }
        }

        public void DeleteBook(int bookId)
        {
            Book[] books = CreateBookArray();

            int index = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].BookId == bookId)
                {
                    index = i;
                }
            }

            Book[] newBooks = new Book[books.Length - 1];
            for (int i = 0; i < books.Length; i++)
            {
                if (i < index)
                {
                    newBooks[i] = books[i];
                }
                if (i > index)
                {
                    newBooks[i - 1] = books[i];
                }
            }
            books = newBooks;
        }

        
    }*/

    /*class Author
    {
        int authorid;
        string authorname;
        public int AuthorId
        {
            get { return authorid; }
            set { authorid = value; }
        }
        public string Authorname
        {
            get { return authorname; }
            set { authorname = value; }
        }
    }
    class Book
    {
        int bookid;
        string bookname;
        int price;
        Author a;
        public int BookId
        {
            get { return bookid; }
            set { bookid = value; }
        }
        public string BookName
        {
            get { return bookname; }
            set { bookname = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        public Author A
        {
            get { return a; }
            set { a = value; }
        }


    }
    class CrudeOperations
    {
        Book[] bk = new Book[20];

        public void Insert()
        {
            Console.WriteLine("Enter how namy books details you want to enter");
            int n = int.Parse(Console.ReadLine());
            int bookid, price, authorid;
            string bookname, authorname;
            if (n < bk.Length)
            {
                for (int i = 0; i < n; i++)
                {
                    bk[i] = new Book();
                    bool ispresent = false;
                    Console.WriteLine("Enter Book id: ");
                    bookid = int.Parse(Console.ReadLine());
                    for (int k = i - 1; k >= 0; k--)
                    {
                        if (bk[k].BookId.Equals(bookid))
                        {
                            Console.WriteLine("Id already exists");
                            ispresent = true;
                        }
                    }
                    try
                    {
                        if (ispresent == false)
                        {
                            Console.WriteLine("Enter Book name: ");
                            bookname = Console.ReadLine();
                            Console.WriteLine("Enter book price: ");
                            price = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author id: ");
                            authorid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter author name: ");
                            authorname = Console.ReadLine();
                            bk[i].BookId = bookid;
                            bk[i].BookName = bookname;
                            bk[i].Price = price;
                            bk[i].A = new Author();
                            bk[i].A.AuthorId = authorid;
                            bk[i].A.Authorname = authorname;
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Exception Handelled");
                    }
                }
            }
            else
            {
                Console.WriteLine("Please enter number of books again your books size is larger");
            }
        }
        public void GetBooksDetails(int bkid)
        {
            bool ispresent = false;
            for (int i = 0; i < bk.Length; i++)
            {
                ispresent = false;
                if (bk[i].BookId.Equals(bkid))
                {
                    Console.WriteLine("Book Details:\n Book Id:" + bk[i].BookId + "\nBook Name: " + bk[i].BookName + "\nBook Price: " + bk[i].Price + "\nAuthor Id: " + bk[i].A.AuthorId + "\nAuthor Name:" + bk[i].A.Authorname);
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == false)
            {
                Console.WriteLine("Book id doese not present please enter right book id");
            }
        }
        public void UpdateBookDetails(int bkid)
        {
            bool ispresent = false;
            Console.WriteLine("Enter Book new price: ");
            int newprice = int.Parse(Console.ReadLine());
            for (int i = 0; i < bk.Length; i++)
            {
                ispresent = false;
                if (bk[i].BookId.Equals(bkid))
                {
                    bk[i].Price = newprice;
                    ispresent = true;
                    break;
                }
            }
            if (ispresent == false)
            {
                Console.WriteLine("Book Id not found");
            }
            else
            {
                Console.WriteLine("Book updated");
            }
        }
        public void DeleteBookDetails(int bkid)
        {
            bool ispresent = false;
            for (int i = 0; i < bk.Length; i++)
            {
                ispresent = false;
                try
                {
                    if (bk[i].BookId.Equals(bkid))
                    {
                        bk[i].BookId = 0;
                        bk[i].BookName = "";
                        bk[i].Price = 0;
                        bk[i].A.AuthorId = 0;
                        bk[i].A.Authorname = "";
                        ispresent = true;
                        break;
                    }
                }
                catch
                {
                    Console.WriteLine("Id not found:");
                }
            }
            if (ispresent == true)
            {
                Console.WriteLine("Book Details Deleted Successfully");
            }
        }
    }
    class BookDetails
    {
        static void Main(string[] args)
        {
            CrudeOperations op = new CrudeOperations();
            bool stop = false;
            do
            {

                Console.WriteLine("Enter option: \n1.Insert\n2.Display\n3.Update\n4.Delete\n5.Exit ");
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        op.Insert();
                        break;
                    case 2:
                        Console.WriteLine("Enter Book's id whose detailed to be viewed:");
                        op.GetBooksDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 3:
                        Console.WriteLine("Enter Book's id whose detailed to be updated:");
                        op.UpdateBookDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 4:
                        Console.WriteLine("Enter Book's id whose detailed to be deleted:");
                        op.DeleteBookDetails(int.Parse(Console.ReadLine()));
                        break;
                    case 5:
                        stop = true;
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            } while (!stop);
        }
    }*/

    /////////////////////////////////////////////////////////////////////////////////////

    /* class Author
     {
         public int AuthorId { get; set; }
         public string Authorname { get; set; }
     }

     class Book
     {
         public int BookId { get; set; }
         public string BookName { get; set; }
         public int Price { get; set; }
         public Author A { get; set; }
     }

     class CrudeOperations
     {
         Book[] bk = new Book[20];

         public void Insert()
         {

             Console.WriteLine("Enter how namy books details you want to enter");
             int n = int.Parse(Console.ReadLine());
             int bookid, price, authorid;
             string bookname, authorname;
             if (n < bk.Length)
             {
                 for (int i = 0; i < n; i++)
                 {
                     bk[i] = new Book();
                     bool ispresent = false;
                     Console.WriteLine("Enter Book id: ");
                     bookid = int.Parse(Console.ReadLine());
                     for (int k = i - 1; k >= 0; k--)
                     {
                         if (bk[k] != null && bk[k].BookId.Equals(bookid))
                         {
                             Console.WriteLine("Id already exists");
                             ispresent = true;
                         }
                     }
                     try
                     {
                         if (ispresent == false)
                         {
                             Console.WriteLine("Enter Book name: ");
                             bookname = Console.ReadLine();
                             Console.WriteLine("Enter book price: ");
                             price = int.Parse(Console.ReadLine());
                             Console.WriteLine("Enter author id: ");
                             authorid = int.Parse(Console.ReadLine());
                             Console.WriteLine("Enter author name: ");
                             authorname = Console.ReadLine();
                             bk[i].BookId = bookid;
                             bk[i].BookName = bookname;
                             bk[i].Price = price;
                             bk[i].A = new Author();
                             bk[i].A.AuthorId = authorid;
                             bk[i].A.Authorname = authorname;
                         }
                     }
                     catch (Exception)
                     {
                         Console.WriteLine("Exception Handelled");
                     }
                 }
             }
             else
             {
                 Console.WriteLine("Please enter number of books again your books size is larger");
             }
         }

         public void GetBooksDetails(int bkid)
         {
             bool isDisplay = false;
             for (int i = 0; i < bk.Length; i++)
             {
                 isDisplay = false;
                 if (bk[i] != null && bk[i].BookId.Equals(bkid))
                 {
                     Console.WriteLine("Book Details:\n Book Id:" + bk[i].BookId + "\nBook Name: " + bk[i].BookName + "\nBook Price: " + bk[i].Price + "\nAuthor Id: " + bk[i].A.AuthorId + "\nAuthor Name:" + bk[i].A.Authorname);
                     isDisplay = true;
                     break;
                 }
             }
             if (isDisplay == false)
             {
                 Console.WriteLine("Book id doese not present please enter right book id");
             }
         }

         public void UpdateBookDetails(int bkid)
         {
             bool isUpdate = false;
             Console.WriteLine("Enter Book new price: ");
             int newprice = int.Parse(Console.ReadLine());
             Console.WriteLine("Do you want to update book name(Y/N)");
             string response = Console.ReadLine();
             string bookname = "";
             if (response.ToUpper() == "Y")
             {
                 Console.WriteLine("Enter Book new name: ");
                 bookname = Console.ReadLine();
             }
             Console.WriteLine("Do you want to update author name(Y/N)");
             string response1 = Console.ReadLine();
             string authorname = "";
             if (response1.ToUpper() == "Y")
             {
                 Console.WriteLine("Enter Author new name: ");
                 authorname = Console.ReadLine();
             }
             Console.WriteLine("Do you want to update author id(Y/N)");
             string response2 = Console.ReadLine();
             int authorid = 0;
             if (response2.ToUpper() == "Y")
             {
                 Console.WriteLine("Enter Author new id: ");
                 authorid = int.Parse(Console.ReadLine());
             }

             for (int i = 0; i < bk.Length; i++)
             {
                 isUpdate = false;
                 if (bk[i] != null && bk[i].BookId.Equals(bkid))
                 {
                     Console.WriteLine("Enter New Price");
                     bk[i].Price = newprice;
                     bk[i].BookName = bookname;
                     bk[i].A.Authorname = authorname;
                     bk[i].A.AuthorId = authorid;
                     isUpdate = true;
                     break;
                 }
             }
             if (isUpdate == false)
             {
                 Console.WriteLine("Book Id not found");
             }
             else
             {
                 Console.WriteLine("Book updated");
             }
         }

         public void DeleteBookDetails(int bkid)
         {
             bool ispresent = false;
             for (int i = 0; i < bk.Length; i++)
             {
                 ispresent = false;
                 try
                 {
                     if (bk[i].BookId.Equals(bkid))
                     {
                         bk[i].BookId = 0;
                         bk[i].BookName = "";
                         bk[i].Price = 0;
                         bk[i].A.AuthorId = 0;
                         bk[i].A.Authorname = "";
                         ispresent = true;
                         break;
                     }
                 }
                 catch
                 {
                     Console.WriteLine("Id not found:");
                 }
             }
             if (ispresent == true)
             {
                 Console.WriteLine("Book Details Deleted Successfully");
             }
         }

         public void ShowAllData()
         {
             bool isData = false;
             Console.WriteLine("Book Details are: ");
             for (int i = 0; i < bk.Length; i++)
             {
                 isData = false;
                 if (bk[i] != null && bk[i].BookId != 0)
                 {
                     Console.WriteLine("Book Details:\n Book Id:" + bk[i].BookId + "\nBook Name: " + bk[i].BookName + "\nBook Price: " + bk[i].Price + "\nAuthor Id: " + bk[i].A.AuthorId + "\nAuthor Name:" + bk[i].A.Authorname + "\n...........................");

                 }
             }
             if (isData == false)
             {
                 Console.WriteLine("No Record Available Till Now");
             }
         }
     }

         class BookDetails
         {
             static void Main(string[] args)
             {
                 CrudeOperations op = new CrudeOperations();
                 bool stop = false;
                 do
                 {
                     Console.WriteLine("\nWelocme to Library Management Application");
                     Console.WriteLine("\nEnter option: \n1.Insert\n2.Display\n3.Update\n4.Delete\n5.ShowAllData\n6.Exit ");
                     int n = int.Parse(Console.ReadLine());
                     switch (n)
                     {
                         case 1:
                             op.Insert();
                             break;
                         case 2:
                             Console.WriteLine("Enter Book's id whose detailed to be viewed:");
                             op.GetBooksDetails(int.Parse(Console.ReadLine()));
                             break;
                         case 3:
                             Console.WriteLine("Enter Book's id whose detailed to be updated:");
                             op.UpdateBookDetails(int.Parse(Console.ReadLine()));
                             break;
                         case 4:
                             Console.WriteLine("Enter Book's id whose detailed to be deleted:");
                             op.DeleteBookDetails(int.Parse(Console.ReadLine()));
                             break;
                         case 5:
                             op.ShowAllData();
                             break;
                         case 6:
                             stop = true;
                             break;
                         default:
                             Console.WriteLine("Invalid operation");
                             break;
                     }
                 } while (!stop);
             }
         }*/

    ///////////////////////////////////////////////////////////
    ///
    class Author
    {
        public int AuthorId { get; set; }
        public string Authorname { get; set; }
    }

    class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public int Price { get; set; }
        public Author A { get; set; }
    }

    class CrudeOperations
    {
        LinkedList<Book> bk = new LinkedList<Book>();

        public void Insert()
        {
            Console.WriteLine("Enter how many books details you want to enter");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int bookid, price, authorid;
                string bookname, authorname;
                bool ispresent = false;

                Console.WriteLine("Enter Book id: ");
                bookid = int.Parse(Console.ReadLine());

                foreach (Book b in bk)
                {
                    if (b.BookId.Equals(bookid))
                    {
                        Console.WriteLine("Id already exists");
                        ispresent = true;
                        break;
                    }
                }

                if (!ispresent)
                {
                    Console.WriteLine("Enter Book name: ");
                    bookname = Console.ReadLine();
                    Console.WriteLine("Enter book price: ");
                    price = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter author id: ");
                    authorid = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter author name: ");
                    authorname = Console.ReadLine();

                    bk.AddLast(new Book()
                    {
                        BookId = bookid,
                        BookName = bookname,
                        Price = price,
                        A = new Author()
                        {
                            AuthorId = authorid,
                            Authorname = authorname
                        }
                    });
                }
            }
        }

        public void GetBooksDetails(int bkid)
        {
            bool isDisplay = false;
            foreach (Book b in bk)
            {
                if (b.BookId.Equals(bkid))
                {
                    Console.WriteLine("Book Details:\n Book Id:" + b.BookId + "\nBook Name: " + b.BookName + "\nBook Price: " + b.Price + "\nAuthor Id: " + b.A.AuthorId + "\nAuthor Name:" + b.A.Authorname);
                    isDisplay = true;
                    break;
                }
            }
            if (!isDisplay)
            {
                Console.WriteLine("Book id does not present, please enter the right book id");
            }
        }

        public void UpdateBookDetails(int bkid)
        {
            bool isUpdate = false;
            Console.WriteLine("Enter Book new price: ");
            int newprice = int.Parse(Console.ReadLine());
            Console.WriteLine("Do you want to update book name(Y/N)");
            string response = Console.ReadLine();
            string bookname = "";
            if (response.ToUpper() == "Y")
            {
                Console.WriteLine("Enter Book new name: ");
                bookname = Console.ReadLine();
            }
            Console.WriteLine("Do you want to update author name(Y/N)");
            string response1 = Console.ReadLine();
            string authorname = "";
            if (response1.ToUpper() == "Y")
            {
                Console.WriteLine("Enter author new name: ");
                authorname = Console.ReadLine();
            }
            foreach (Book b in bk)
            {
                if (b.BookId.Equals(bkid))
                {
                    b.Price = newprice;
                    if (response.ToUpper() == "Y")
                    {
                        b.BookName = bookname;
                    }
                    if (response1.ToUpper() == "Y")
                    {
                        b.A.Authorname = authorname;
                    }
                    isUpdate = true;
                    break;
                }
            }
            if (!isUpdate)
            {
                Console.WriteLine("Book id does not exist, please enter the right book id");
            }
            else
            {
                Console.WriteLine("Updated..");
            }
        }

        public void ShowAllData()
        {
            Console.WriteLine("Book Details are: ");
            foreach (Book b in bk)
            {
                Console.WriteLine("Book Details:\n Book Id:" + b.BookId + "\nBook Name: " + b.BookName+ "\nBook Price: " + b.Price + "\nAuthor Id: " + b.A.AuthorId + "\nAuthor Name:" + b.A.Authorname + "\n...........................");
            }
            if (bk.Count == 0)
            {
                Console.WriteLine("No Record Available Till Now");
            }
        }
    }
}



