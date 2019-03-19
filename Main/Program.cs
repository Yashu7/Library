using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
        static public int DisplayLibraryMenu()
        {
            Console.WriteLine("Welcome to Library");
            Console.WriteLine();
            Console.WriteLine("1. Create a student account");
            Console.WriteLine("2. Add a book to the library");
            Console.WriteLine("3. Check for student");
            Console.WriteLine("4. Check for book");
            Console.WriteLine("5. Exit");
            var result = Console.ReadLine();
            return Convert.ToInt32(result);
        }



        static void Main(string[] args)
        {
            int userInput = 0;
            do
            {
                if (userInput == 1)
                {
                    Student student1 = new Student();
                    Console.WriteLine("Insert Name:");
                    student1.SetName(Console.ReadLine());
                    Console.WriteLine("Insert Surname:");
                    student1.SetSurname(Console.ReadLine());
                    Console.WriteLine("Insert Age:");
                    student1.SetAge(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Insert Class:");
                    student1.SetClass(Console.ReadLine());
                    student1.ShowStudent();
                }

                userInput = DisplayLibraryMenu();
            } while (userInput != 5);
        

            
            
           
        }
    }
}
