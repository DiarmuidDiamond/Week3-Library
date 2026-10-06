using System;
using System.Collections.Generic;
using System.Text;

namespace Week3_Library
{

     class Book
    {
       public string Title;
       public string Author;
       public string ISBN;

        public Book(string bookTitle, string bookAuthor, string bookISBN)
        {
            this.Title = bookTitle;
            this.Author = bookAuthor; 
            this.ISBN = bookISBN;
        }
   
        public void DisplayInfo()
        {
            Console.WriteLine($"Book title: {Title}");
            Console.WriteLine($"Book Author: {Author}");
            Console.WriteLine($"Book ISBN: {ISBN}");
            Console.WriteLine();
        }
    }
}
