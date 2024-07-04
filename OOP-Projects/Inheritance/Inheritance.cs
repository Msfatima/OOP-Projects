using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects.Inheritance
{    public class Fruits // Base class (parent) - Default constructor
    {
        //propreties 
        public string Country = "Australia";

        //method 
        public void eat() 
        {
            Console.WriteLine("Australian fruits are delicious ");
        }
    }
    //Derived class (child)
    public class Appel : Fruits
    {
        public string Color = "red apple";
    }
}
