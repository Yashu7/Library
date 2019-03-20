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

            List<Student> studentlist = new List<Student>();
            int studentCount = 0;
            int userInput = 0;
            do
            {
                if (userInput == 1)
                {
                    
                    studentlist.Add(new Student());
                    Console.WriteLine("Insert Name:");
                    studentlist[studentCount].SetName(Console.ReadLine());
                    Console.WriteLine("Insert Surname:");
                    studentlist[studentCount].SetSurname(Console.ReadLine());
                    Console.WriteLine("Insert Age:");
                    studentlist[studentCount].SetAge(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("Insert Class:");
                    studentlist[studentCount].SetClass(Console.ReadLine());
                    studentCount = studentCount + 1;
                }

                userInput = DisplayLibraryMenu();
            } while (userInput != 5);
            
            



        }
    }
}
