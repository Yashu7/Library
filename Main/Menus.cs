using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Menus
    {
        static public int DisplayLibraryMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Welcome to Library");
            Console.WriteLine();
            Console.WriteLine("1. Create a student account");
            Console.WriteLine("2. Add a book to the library");
            Console.WriteLine("3. Check for student");
            Console.WriteLine("4. Check for book");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            int result = 0;
            while (result == 0)
            {
                try
                {
                    result = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter number that corresponds with option.");
                }
            }

            return Convert.ToInt32(result);
        }
            static public int DisplayStudentsMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Students' List menu:");
            Console.WriteLine();
            Console.WriteLine("1. Show all records");
            Console.WriteLine("2. Find by ID");
            Console.WriteLine("3. Find by name");
            Console.WriteLine("4. Find by surname");
            Console.WriteLine("5. Find by age");
            Console.WriteLine("6. Find by class (eg. 1A or 3B)");
            Console.WriteLine("7. Exit");
            Console.WriteLine();
            int result3 = 0;
            while (result3 == 0)
            {
                try
                {
                    result3 = Convert.ToInt32(Console.ReadLine());

                }
                catch (FormatException)
                {
                    Console.WriteLine("Please enter number that corresponds with option.");
                }
            }

            return Convert.ToInt32(result3);
        }
    }
}
