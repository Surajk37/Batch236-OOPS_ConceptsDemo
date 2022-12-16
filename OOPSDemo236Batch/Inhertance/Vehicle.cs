using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo236Batch.Inhertance
{
    public class Vehicle //base class
    {
        public string Name = "BMW";
        public int Price = 5000000;
        public string FuelType = "Petrol";
        public string Color = "Blue";
         
        public void CarDetails()
        {
            Console.WriteLine("Name : {0}",Name);
            Console.WriteLine("Price : {0}",Price);
            Console.WriteLine("FuelType : {0}", FuelType);
            Console.WriteLine("Color : {0}\n", Color);

        }
    }
    
}
