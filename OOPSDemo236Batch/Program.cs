//using OOPSDemo236Batch.Abstraction;
using OOPSDemo236Batch.Abstraction;
using OOPSDemo236Batch.Encapsulation;
using OOPSDemo236Batch.Inhertance;
using OOPSDemo236Batch.Polymorphism;
using System;
using System.Net.NetworkInformation;

namespace OOPSDemo236Batch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tPlease Choose a option below List\n");
            Console.WriteLine("1. Inheritance \n2. Polymorphism \n3. Abstraction \n4. Encapsulation\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("Inhertance Concept");
                    Cars cars = new Cars(); //created a object of base class
                    Console.WriteLine("\t\tAccessed CarDetails() method from base class");
                    cars.CarDetails(); //calling method from base class
                    Console.WriteLine("\t\tAccessed Details() method from Derived class");
                    cars.Details();   //calling method from derived 
                    break;

                case 2:
                    Console.WriteLine("\t\tMethod Overloading\n");
                    MethodOverloading method = new MethodOverloading();
                    Console.WriteLine("Sum: " + method.Add(10, 20));
                    Console.WriteLine("Sum: " + method.Add(5, 35, 87));
                    Console.WriteLine("Sum: " + method.Add(10.3f, 40,23));
                    
                    Console.WriteLine("\t\tMethod Overridding");
                    Animals animal = new Animals();
                    animal.Run();
                    Dog dog = new Dog();
                    dog.Run();
                    Cat cat = new Cat();
                    cat.Run();
                    break;

                case 3:
                    Console.WriteLine("\tAbstraction Concept");
                    Pig pig = new Pig();
                    pig.AnimalSound();
                    pig.Sleep();
                    break;

                case 4:
                    Console.WriteLine("\tEncapsulation Concept");
                    Account account = new Account();
                    Console.WriteLine("before:\n" + account.Name);
                    account.Name = "abcd";
                    Console.WriteLine("after:\t" + account.Name);
                    break;

                default:
                    Console.WriteLine("Please enter Valid Option");
                    break;

            }
            Console.ReadLine();
        }
    }
}
