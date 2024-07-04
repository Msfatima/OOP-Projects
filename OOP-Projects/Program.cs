using OOP_Projects.Inheritance;
using OOP_Projects.Polymorphism;
using static OOP_Projects.Polymorphism.Animals;

//Inheritance example
Appel appel = new Appel();//call the child class
Console.WriteLine(appel.Color + " " + appel.Country);
appel.eat(); // child class return the value of the parent class 
/*****************************************************************/


//Program.cs
Animals animals = new Animals();
animals.Eat();
Animals cat = new Cats();
cat.Eat();


