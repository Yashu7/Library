using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    class Program
    {
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
                    bool tryAgain = true;
                    studentlist.Add(new Student());
                    studentlist[studentCount].SetID(studentCount);
                    Console.WriteLine("Insert Name:");
                    studentlist[studentCount].SetName(Console.ReadLine());
                    Console.WriteLine("Insert Surname:");
                    studentlist[studentCount].SetSurname(Console.ReadLine());
                    Console.WriteLine("Insert Age:");
                    tryAgain = true;
                    while (tryAgain)
                    {
                        try
                        {
                            studentlist[studentCount].SetAge(Convert.ToInt32(Console.ReadLine()));
                            tryAgain = false;
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Age was in incorrect format, please write just numbers.");
                            Console.WriteLine("Insert Age:");
                        }
                    }
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
                        
                        if(userInputStudentsMenu == 3)
                        {
                            Console.WriteLine("Insert name");
                            string name = Console.ReadLine();
                            for (int i = 0; i < studentCount; i++)
                            {
                               
                                if (studentlist[i].ByName(name))
                                {
                                    studentlist[i].ShowStudent();
                                }
                                
                            }
                            Console.ReadKey();
                        }
                        if (userInputStudentsMenu == 4)
                        {
                            Console.WriteLine("Insert surname");
                            string surname = Console.ReadLine();
                            for (int i = 0; i < studentCount; i++)
                            {

                                if (studentlist[i].BySurname(surname))
                                {
                                    studentlist[i].ShowStudent();
                                }

                            }
                            Console.ReadKey();
                        }
                        userInputStudentsMenu = Menus.DisplayStudentsMenu();
                    } 
                    while (userInputStudentsMenu != 7);
                    
                    
                }

                userInputLibraryMenu = Menus.DisplayLibraryMenu();
                
            } while (userInputLibraryMenu != 5);
            
            



        }
    }
}
