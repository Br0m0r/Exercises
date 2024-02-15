using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    internal class helper
    {
        public class Person
        {
            public int age;

            public void Greet()
            {
                Console.WriteLine("Greetings!");

            }

            public void SetAge(int x)
            {
                age = x;

            }

        }




        public class Student : Person
        {
            public void study()
            {
                Console.WriteLine($"Im studying");
            }
            public void ShowAge()
            {
                Console.WriteLine($"My age is : {age}  years old");
            }

        }

        public class Teacher : Person
        {
            public void explain()
            {
                Console.WriteLine($"Im explaining");
            }

        }


    }
}
