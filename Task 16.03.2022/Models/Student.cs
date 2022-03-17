using System;
using System.Collections.Generic;
using System.Text;

namespace Task_16._03._2022.Models
{
    internal class Student:Person
    {
        //public int Point;
        public int Point = GetInputInt(0,);

        public Student(string Name, int Age,int Point):base(Name,Age)
        {
            this.Point = Point;
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Point:{Point}\nName:{Name}\nSurname:{Surname}\nAge:{Age}");
        }




        static int GetInputInt( int min, int max = int.MaxValue)
        {
            int input;
            do
            {
                //Console.WriteLine(name);
                input = Convert.ToInt32(Console.ReadLine());
            } while (input < min || input > max);

            return input;
        }

    }
}
