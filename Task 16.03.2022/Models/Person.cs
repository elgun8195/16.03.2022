using System;
using System.Collections.Generic;
using System.Text;

namespace Task_16._03._2022.Models
{
    internal class Person
    {
        public string Name;
        public string Surname;
        public int Age;


        public Person(string Name,string Surname)
        {
            this.Name = Name;
            this.Surname = Surname; 
        }
  


        public string name { get { return Name; }
            set 
            {
                char result = Name[0];
                if (Char.IsLower(result))
                {
                    Console.WriteLine("Ilk herfi kicik ola bilmez");
                }
                
            }
        }


        public string surname
        {
            get { return Surname; }
            set
            {
                char result = Surname[0];
                if (Char.IsLower(result))
                {
                    Console.WriteLine("Ilk herfi kicik ola bilmez");
                }

            }
        }

        public int age 
        { 
            get
            { 
                return Age; 
            }
            set 
            {
                if (value<0)
                {
                    Console.WriteLine("Girilien yas menfi ola bilmez");
                }
                this.Age = value;
            } 
        }
    }
}
