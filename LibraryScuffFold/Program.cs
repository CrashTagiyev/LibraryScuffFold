
using LibraryScuffFold.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Microsoft.VisualBasic;
using New.Namespace;
using System.Threading.Channels;
using static System.Reflection.Metadata.BlobBuilder;
using static System.Runtime.InteropServices.JavaScript.JSType;

internal class Program
{
    static void Main(string[] args)
    {
        using (var context = new LibraryDB())
        {
            ////1.Display books with the minimum number of pages issued by a particular publishing house.

            //foreach (var Press in context.Presses.Include(x => x.Books))
            //{
            //    Console.WriteLine(Press.Name);
            //    var book = Press.Books.ToList().OrderBy(x => x.Pages).FirstOrDefault();
            //    if (book != null)
            //    {
            //        Console.WriteLine(book.Name + " " + book.Pages);
            //    }
            //    else
            //    {
            //        Console.WriteLine("This press not have any books yet");
            //    }
            //    Console.WriteLine("\n\n");
            //}


            ////2.Display the names of publishers who have issued 
            //books with an average number of pages larger than 100.
            //foreach (var press in context.Presses.Include(x => x.Books))
            //{
            //    int PagesSum = press.Books.ToList().Sum(x => x.Pages);
            //    int BooksCount = press.Books.ToList().Count();
            //    if (BooksCount > 0)
            //    {
            //        if (PagesSum / BooksCount > 333)
            //        {
            //            Console.WriteLine("Publisher:"+press.Name+$"\nPages average:{PagesSum/BooksCount}");
            //        }
            //    }
            //    else
            //    {
            //        continue;
            //    }
            //    Console.WriteLine("\n");
            //}

            ////3.Output the total amount of pages of
            ////all the books in the library issued by the publishing houses BHV and BINOM.

            //int pagesSum = 0;

            //foreach (var press in context.Presses.Include(x=>x.Books).Where(x=>x.Name=="BHV" || x.Name=="Binom"))
            //{
            //        pagesSum+=press.Books.Sum(b=>b.Pages);
            //}
            //Console.WriteLine("Total amount of pages of publishers BHV and BINOM:"+pagesSum);


            ////4.Select the names of all students who took books between 
            ////    January 1, 2001 and the current date.

            //foreach (var student in context.Students.Include(s => s.SCards))
            //{
            //    foreach (var sc in student.SCards)
            //    {
            //        if (sc.DateOut > new DateTime(2001, 1, 1) && sc.DateOut < DateTime.Now)
            //        {
            //            Console.WriteLine("Id:" + student.Id + " " + student.FirstName + " " + student.LastName);
            //            break;
            //        }

            //    }
            //}

            ////5.Find all students who are currently working with the 
            ////    book "Windows 2000 registry" by Olga Kokoreva.

            //foreach (var student in context.Students.Include(s => s.SCards).ThenInclude(sc=>sc.IdBookNavigation))
            //{
            //    foreach (var sc in student.SCards)
            //    {
            //        if (sc.IdBookNavigation.Name == "Windows 2000 registry")
            //        {
            //            Console.WriteLine(student.FirstName + " " + student.LastName);
            //            break;
            //        }
            //    }
            //}


            //6.Display information about authors whose average 
            //volume of books(in pages) is more than 600 pages.

            //foreach (var author in context.Authors.Include(a=>a.Books))
            //{
            //    int BookCount,PagesSum;
            //    foreach (var book in author.Books)
            //    {
            //        PagesSum = author.Books.Sum(b => b.Pages);
            //        BookCount=author.Books.Count;
            //        if (PagesSum/BookCount>600)
            //        {
            //            Console.WriteLine(author.ToString());
            //            break;
            //        }
            //    }
            //}

            ////7.Display information about publishers, 
            ////    whose total number of pages of books published by them is more than 700.

            //foreach (var press in context.Presses.Include(a => a.Books))
            //{
            //    int  PagesSum;
            //    foreach (var book in press.Books)
            //    {
            //        PagesSum = press.Books.Sum(b => b.Pages);
            //        if (PagesSum  > 700)
            //        {
            //            Console.WriteLine("Id:"+press.Id+" "+press.Name);
            //            break;
            //        }
            //    }
            //}
        }
    }
}