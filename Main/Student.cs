using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main
{
    public class Student
    {
        private int ID;
        private string Name;
        private string Surname;
        private int Age;
        private string Class;

        public void SetID(int I)
        {
            ID = I;
        }
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
            Console.WriteLine();
            Console.WriteLine("Info about student:");
            Console.WriteLine("ID: {0}. Name: {1}. Surname: {2}. Age: {3}. Class: {4}. ",ID, Name, Surname, Age, Class);
            Console.WriteLine();
        }
            public bool ByName(string FindName)
        {
           if (FindName == Name)
            {
                return true;
            }
           else
            {
                return false;
            }
        }
    }
}
