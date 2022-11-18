using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructureBooks
{
   public struct book
    {
        public enum BookType { Magazine, Novel, ReferenceBook, Miscellaneous };

        public int bookId;
        public string title;
        public double price;
        public string bookType;
    }
   
    
    
    public class Program
    {
        
        static void Main(string[] args)
        {
            book b= new book();
            b.bookId = 2609;
            b.title = "Entry";
            b.price = 540.88; 

            Console.WriteLine("\nId of the book: " + b.bookId);
            Console.WriteLine("\nTitle of the book: " + b.title);
            Console.WriteLine("\nPrice of the book: " + b.price);
            Console.WriteLine("\nType of the book: " + book.BookType.Novel) ;
            
            Console.ReadLine();
        }
    }
}
