using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork.Project
{
    /* class CRUDDemo
     {
         Book[] barr = new Book[3];

         class Author
         {
             public int aid;
             public string aname;
             public string acity;

             public Author(int aid,string aname,string acity)
             {
                 this.aid = aid;
                 this.aname = aname;
                 this.acity = acity;
             }
         }
         class Book
         {
             public int bid;
             public int bprice;
             public string bname;
             Author a;

             public Book(int bid,int bprice,string bname,Author a)
             {
                 this.bid = bid;
                 this.bprice = bprice;
                 this.bname = bname;
                 this.a = a;
             }

         }

         public createArray()
         {
             // add code to get values from user, create book object and add it to barr



         }

         public getBook(int id)
         {
             // iterate array and return book details for book with id 

         }


         static void Main(string[] args)
         {
             createArray()
           Enter bookid to fetch details
          int bid = sc.nextInt();
             Book b = getBook(bid);

         }
     }*/




    /* public class Book
     {
         public int BookId { get; set; }
         public string BookName { get; set; }
         public double BookPrice { get; set; }
         public string AuthorName { get; set; }

     }
     public create
     {

             //Create
             Book newBook = new Book { BookId = 4, BookName = "Book4", BookPrice = 12.99, AuthorName = "Author4" };
             Array.Resize(ref books, 4);
             books[3] = newBook;
     }

     public class Program
     {
         public static void Main()
         {
             Book[] books = new Book[] {
             new Book { BookId = 1, BookName = "Book1", BookPrice = 10.99, AuthorName = "Author1" },
             new Book { BookId = 2, BookName = "Book2", BookPrice = 8.99, AuthorName = "Author2" },
             new Book { BookId = 3, BookName = "Book3", BookPrice = 14.99, AuthorName = "Author3" }
         };


             //Read
             foreach (Book book in books)
             {
                 Console.WriteLine(book.BookName);
             }

             //Update
             for (int i = 0; i < books.Length; i++)
             {
                 if (books[i].BookId == 3)
                 {
                     books[i].BookName = "UpdatedBook3";
                     books[i].BookPrice = 17.99;
                     books[i].AuthorName = "UpdatedAuthor3";
                 }
             }

             //Delete
             Book[] newBooks = new Book[books.Length - 1];
             int j = 0;
             for (int i = 0; i < books.Length; i++)
             {
                 if (books[i].BookId != 2)
                 {
                     newBooks[j] = books[i];
                     j++;
                 }
             }
             books = newBooks;
         }
     }*/

    /*  class Author
      {
          public int authorId;
          public string authorName;

          public Author(int authorId, string authorName)
          {
              this.authorId = authorId;
              this.authorName = authorName;
          }
      }
      class Book
      {
          public int bookId;
          public string bookName;
          public int bookPrice;
          public Author bookAuthor;

          public Book(int bookId, string bookName, int bookPrice, Author bookAuthor)
          {
              this.bookId = bookId;
              this.bookName = bookName;
              this.bookPrice = bookPrice;
              this.bookAuthor = bookAuthor;
          }
      }
      class Operations
      {
          public Book[] books = new Book[10];
          //public int BookSize = -1;//To avoid unnecessary iterations
          public void InsertBook()//To insert the data
          {
              Console.Write("Enter how many book you want to insert : ");
              int No_ofBooks = int.Parse(Console.ReadLine());
              int bookId, bookPrice, authorId;
              string bookName, authorName;
              if (No_ofBooks <= books.Length)//To check enter size is less or more
              {
                  for (int i = 0; i < No_ofBooks; i++)
                  {
                      bool IsPresent = false;
                      Console.Write("Enter Book's Id : ");
                      bookId = int.Parse(Console.ReadLine());
                      for (int j = i - 1; j >= 0; j--) //To check book id is already present or not
                      {
                          if (books[j] != null && books[j].bookId.Equals(bookId))//To avoid null object reference
                          {
                              Console.WriteLine("Please Enter Unique Book Id !! " +
                                      bookId + " is already Present");
                              IsPresent = true;
                              No_ofBooks++;//To increase the user entered books size
                              break;
                          }
                      }
                      if (!IsPresent)
                      {
                          try//To avoid System.FormatException
                          {
                              Console.Write("Enter Book's Name : ");
                              bookName = Console.ReadLine();
                              Console.Write("Enter Book's Price : ");
                              bookPrice = int.Parse(Console.ReadLine());
                              Console.Write("Enter Book's AuthorId : ");
                              authorId = int.Parse(Console.ReadLine());
                              Console.Write("Enter Book's Author Name : ");
                              authorName = Console.ReadLine();
                              books[i] = new Book(bookId, bookName, bookPrice, new Author(authorId, authorName));
                          }
                          catch (Exception)
                          {
                              Console.WriteLine("Please Enter Proper Format...ReEnter..");
                              No_ofBooks++;
                          }
                      }
                  }
                  // BookSize = No_ofBooks;//To avoid unnecessary iterations
              }
              else
              {
                  Console.WriteLine("Error!! Number of books are more than " + books.Length);
              }
          }
          public void GetBookDetails(int bookId)//To Display Book Details
          {
              if (books.Length != 0)
              {
                  bool IsDisplay = false;
                  for (int i = 0; i < books.Length; i++)
                  {
                      if (books[i] != null && books[i].bookId.Equals(bookId))//To avoid null object reference
                      {
                          Console.WriteLine("Book Details : \nBook Id : " + books[i].bookId + "\nBook Name : " + books[i].bookName
                                 + "\nBook Price : " + books[i].bookPrice + "\nAuthor Id : " + books[i].bookAuthor.authorId +
                                   "\nAuthor Name : " + books[i].bookAuthor.authorName);
                          IsDisplay = true;
                          break;
                      }
                  }
                  if (!IsDisplay)//if book id is not present 
                  {
                      Console.WriteLine($"{bookId} is not present in current book list");
                  }
              }
              else
              {
                  Console.WriteLine("Current booklist is empty !!!");
                  Console.WriteLine("Please insert data first");
              }
          }
          public void UpdateBook(int bookId)
          {
              if (books.Length != 0)
              {
                  bool IsChanged = false;
                  for (int i = 0; i < books.Length; i++)
                  {
                      if (books[i] != null && books[i].bookId.Equals(bookId))//To avoid null object reference
                      {
                          Console.WriteLine("Enter New Price");
                          books[i].bookPrice = int.Parse(Console.ReadLine());
                          IsChanged = true;
                          break;
                      }
                  }
                  if (IsChanged)
                  {
                      Console.WriteLine("Price Changed Successfully");
                  }
                  else//if book id is not present 
                  {
                      Console.WriteLine($"{bookId} is not present in current book list");
                  }
              }
              else
              {
                  Console.WriteLine("Current booklist is empty !!!");
                  Console.WriteLine("Please insert data first");
              }
          }
          public void DeleteBook(int bookId)
          {
              if (books.Length != 0)
              {
                  bool IsDelete = false;
                  for (int i = 0; i < books.Length; i++)
                  {
                      if (books[i] != null && books[i].bookId.Equals(bookId))//To avoid null object reference 
                      {
                          books[i].bookId = 0;
                          books[i].bookName = "";
                          books[i].bookPrice = 0;
                          books[i].bookAuthor.authorId = 0;
                          books[i].bookAuthor.authorName = "";
                          IsDelete = true;
                          break;
                      }
                  }
                  if (IsDelete)
                  {
                      Console.WriteLine("Book's Details Deleted Successfully");
                  }
                  else//if book id is not present 
                  {
                      Console.WriteLine($"{bookId} is not present in current book list");
                  }
              }
              else
              {
                  Console.WriteLine("Current booklist is empty !!!");
                  Console.WriteLine("Please insert data first");
              }
          }
          static void Main(string[] args)
          {
              Operations op = new Operations();
              bool ToStop = false;
              do
              {
                  Console.WriteLine("\n\t\tWelcome To Crud Operations : \n\t\tPress 1 To Insert Data\n\t\tPress 2 To Display Data" +
                      $"\n\t\tPress 3 To Update Data\n\t\tPress 4 To Delete Data\n\t\tPress 5 To Exit");
                  int Key = int.Parse(Console.ReadLine());
                  switch (Key)
                  {
                      case 1:
                          op.InsertBook();
                          break;
                      case 2:
                          Console.Write("Enter Book's Id : ");
                          op.GetBookDetails(int.Parse(Console.ReadLine()));
                          break;
                      case 3:
                          Console.Write("Enter Book's Id : ");
                          op.UpdateBook(int.Parse(Console.ReadLine()));
                          break;
                      case 4:
                          Console.Write("Enter Book's Id : ");
                          op.DeleteBook(int.Parse(Console.ReadLine()));
                          break;
                      case 5:
                          ToStop = true;
                          break;
                      default:
                          Console.WriteLine("Invalid Key");
                          break;
                  }
              } while (!ToStop);
          }
      }*/

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
    }
}
