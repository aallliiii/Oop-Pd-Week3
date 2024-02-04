using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Book.BL;

namespace Book
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<attributes> MyData = new List<attributes>();
            while (true)
            {
                Console.Clear();
                int option;
                Console.WriteLine("Press 1 to add a book record");
                Console.WriteLine("Press 2 to add stock");
                Console.WriteLine("Press 3 to sell stock");
                Console.WriteLine("Press 4 to view all book data");
                option = int.Parse(Console.ReadLine());
                attributes a = new attributes();
                if (option == 1)
                {


                    Console.WriteLine("Enter Book Title");
                    a.Title = Console.ReadLine();
                    Console.WriteLine("Enter Book Author");
                    a.Author = Console.ReadLine();
                    Console.WriteLine("Enter Book Publication Year: ");
                    a.PublicationYear = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Price: ");
                    a.Price = float.Parse(Console.ReadLine());
                    Console.WriteLine("Enter Quantity: ");
                    a.Quantity = int.Parse(Console.ReadLine());
                    MyData.Add(a);
                }
                else if (option == 2)
                {
                    string change;
                    Console.WriteLine("Enter the title of the book");
                    change = Console.ReadLine();
                    foreach (attributes ToChange in MyData)
                    {
                        if (ToChange.Title == change)
                        {
                            Console.WriteLine("Enter the number of copy of the books to add: ");
                            int copies = int.Parse(Console.ReadLine());
                            Console.WriteLine(ToChange.Restock(copies));
                            Console.ReadLine();
                        }
                    }

                }
                else if (option == 3)
                {
                    string change;
                    Console.WriteLine("Enter the title of the book");
                    change = Console.ReadLine();
                    foreach (attributes ToChange in MyData)
                    {
                        if (ToChange.Title == change)
                        {
                            Console.WriteLine("Enter the number of copy of the books to sell: ");
                            int copies = int.Parse(Console.ReadLine());
                            Console.WriteLine(ToChange.Sell(copies));
                            Console.ReadLine();
                        }
                    }
                }
                else if (option == 4)
                {
                    foreach (attributes ToView in MyData)
                    {
                        Console.WriteLine(ToView.BookDetail());
                    }
                    Console.ReadLine();
                }
            }
        }
    }
}
