using OOPSDemo236Batch.Inhertance;
using OOPSDemo236Batch.Polymorphism;

namespace OOPSDemo236Batch
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\t\tPlease Choose a option below List\n");
            Console.WriteLine("1. Inheritance \n2. Polymorphism\n");
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
                    
                default:
                    Console.WriteLine("Please enter Valid Option");
                    break;

            }
            Console.ReadLine();
        }
    }
}
