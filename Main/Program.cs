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
            //Console.WriteLine("Insert student's name:");
            //
            //Console.ReadLine();
        }
    }
}
