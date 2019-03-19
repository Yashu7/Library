using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Student
    {
        private string Name;
        private string Surname;
        private int Age;
        private string Class;

        public void SetName(string N)
        {
            Name = N;
        }
        public void SetSurname(string S)
        {
            Surname = S;
        }
        public void SetAge(int A)
        {
            Age = A;
        }
        public void SetClass(string C)
        {
            Class = C;
        }


            public void ShowStudent()
        {
            Console.WriteLine("Info about student:");
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Surname: " + Surname);
            Console.WriteLine("Age: " + Age);
            Console.WriteLine("Class: " + Class);
            
        }
    }
}
