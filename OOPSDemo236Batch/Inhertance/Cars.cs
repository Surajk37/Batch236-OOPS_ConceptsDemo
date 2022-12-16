using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo236Batch.Inhertance
{
    public class Cars : Vehicle  //derived class
    {
        public string ChassisNumber = "SV30 - 0169266";
        public void Details()
        {
            Console.WriteLine("Chassis Number : {0}",ChassisNumber);
        }
    }
}
