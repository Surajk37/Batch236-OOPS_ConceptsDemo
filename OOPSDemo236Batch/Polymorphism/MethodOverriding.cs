using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo236Batch.Polymorphism
{
    internal class Animals
    {
        public virtual void Run()
        {
            Console.WriteLine("Running");
        }
    }
    class Dog : Animals
    {
        public override void Run()
        {
            Console.WriteLine("Running");
        }
    }
    class Cat : Dog
    {
        public void Run()
        {
            Console.WriteLine("Sleeping");
        }
    }
}
