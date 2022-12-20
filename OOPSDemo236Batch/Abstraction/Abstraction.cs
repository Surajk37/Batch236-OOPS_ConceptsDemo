using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSDemo236Batch.Abstraction
{
    abstract class Animal
    {
        public abstract void AnimalSound();

        public void Sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

    class Pig : Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says : wee wee");
        }
    }
}
