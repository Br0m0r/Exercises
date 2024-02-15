using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3
{
    internal class helper
    {



        public abstract class Animal
        {
            public string name;

            public void SetName(string Name)
            {
                name = Name;

            }
            public  string GetName()
            {

                return name;


            }
            public abstract void Eat();
        }

        public class Dog : Animal
        {
            public override void Eat()
            {
                Console.WriteLine($"{name} is eating");
            }

        }

    }
}
