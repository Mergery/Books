using System;
namespace Defining
{
    class Program
    {
        static void Main(string[]args)
        {
            Book b1 = new Book("War and Peace", "Leo", 825);
            Book b2 = new Book("Heaven", "Calumn Scott", 123);
            Book b3 = new Book("Maiden", "Orlando", 675);

            Console.WriteLine(b1.GetDescription());
            Console.WriteLine(b2.GetDescription());
            Console.WriteLine(b3.GetDescription());
        }

    }
    
}