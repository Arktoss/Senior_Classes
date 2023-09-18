using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senior_Classes
{
    internal class Person_with_Constructor
    {
        //Fields
        private string name;
        private int age;
        private double height;

        //Properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return Age; }
            set { Age = value; }
        }

        public double Height
        {
            get { return height; }
            set { height = value; }
        }

        //Methods
        public void Introduce()
        {
            Console.WriteLine($"Hello my name is {name}and I am {age} years old. I am {height}feet tall. ")
        }

        // Constructor
        public Person_with_Constructor(string initialName, int initialage, double initialheight)
        {
            name = initialName;
            age = initialage;
            height = initialheight;
        }
    }
}
