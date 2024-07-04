using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects.Polymorphism
{
    public class Animals
    {
        public string Name = "Cat";
        public virtual void Eat()
        {
            Console.WriteLine("The animal name is "+ Name);
        }
    }
    public class Bird : Animals {     
        public override void Eat()
        {
            Console.WriteLine("The animal is not cat it is Bird");
        }
    }
}

