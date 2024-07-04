using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects.Polymorphism
{
    //Polymorphism allows you to invok a drevied class methods through base classe 
    public class Animals
    {
        public string Country = "Canada";

        //virtual keyword indicates the method can be overrideen in any drived class
        public virtual void Eat()
        {
            Console.WriteLine("This the base method Eat output");

        }
        //Drived class (child) 
        public class Cats : Animals
        {
            public string Color = "Whit";
            public override void Eat()
            {
                Console.WriteLine("This the overrideen method output Cats is " + Color);
            }
        }
    }

}
