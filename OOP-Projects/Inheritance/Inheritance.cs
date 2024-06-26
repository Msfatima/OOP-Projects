using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Projects.Inheritance
{
   
    //Inheritance It’s a mechanism that allows a class to inherit properties and behaviors from another class. 
    //First: Defind base class (parent) 
    public class Fruits 
    {
        //Second: assign propreties 
        public string Country = "Austraila";
        //Third: Add method 
        public void eat() //method 
        {
            Console.WriteLine("Eating fruits is healthy all the time");
        }
    }
    //Fourth :Defind derived class (child)
    public class Appel : Fruits
    {

        public string Color = "red";
    }
    public class Orang : Fruits 
    { 
        public string Weight { get; set; }
       
    }

   



}
