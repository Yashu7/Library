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
            Console.WriteLine();
            Console.WriteLine("Welcome to Library");
            Console.WriteLine();
            Console.WriteLine("1. Create a student account");
            Console.WriteLine("2. Add a book to the library");
            Console.WriteLine("3. Check for student");
            Console.WriteLine("4. Check for book");
            Console.WriteLine("5. Exit");
            Console.WriteLine();
            var result = Console.ReadLine();
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
            var result3 = Console.ReadLine();
            return Convert.ToInt32(result3);
        }



        static void Main(string[] args)
        {

            List<Student> studentlist = new List<Student>();
            int studentCount = 0;
            int userInputLibraryMenu = 0;
            int userInputStudentsMenu = 0;
            do
            {
                if (userInputLibraryMenu == 1)
                {
                    
                    studentlist.Add(new Student());
                    studentlist[studentCount].SetID(studentCount);
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
                if (userInputLibraryMenu == 3)
                {
                    do
                    {
                        if(userInputStudentsMenu == 1)
                        {
                            
                            for (int i = 0; i < studentCount; i++)
                            {
                                studentlist[i].ShowStudent();
                            }
                            Console.ReadKey();
                        }
                        if(userInputStudentsMenu == 2)
                        {
                            Console.WriteLine("Insert ID number");
                            int i = Convert.ToInt32(Console.ReadLine());
                            studentlist[i].ShowStudent();
                            Console.ReadKey();

                        }
                        userInputStudentsMenu = DisplayStudentsMenu();
                    }
                    while (userInputStudentsMenu != 7);
                    
                    
                }

                userInputLibraryMenu = DisplayLibraryMenu();
                
            } while (userInputLibraryMenu != 5);
            
            



        }
    }
}
