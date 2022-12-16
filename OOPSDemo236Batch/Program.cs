using OOPSDemo236Batch.Inhertance;

namespace OOPSDemo236Batch
{
    class Program
    {
        public static void Main(String[]args)
        {
            Cars cars = new Cars(); //created a object of base class
            Console.WriteLine("\t\tAccessed CarDetails() method from base class");
            cars.CarDetails(); //calling method from base class
            Console.WriteLine("\t\tAccessed Details() method from Derived class");
            cars.Details();   //calling method from derived class
            Console.ReadLine();
        }
    }
}
