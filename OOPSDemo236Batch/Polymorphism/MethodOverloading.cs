using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Method overloading is having same method name but different Parameter

namespace OOPSDemo236Batch.Polymorphism
{
    public class MethodOverloading
    {
        public int Add(int a,int b)
        {
            return a + b;
        }
        /*public int Add(int a,float b,long c) //type Casting is done conversion (small datatype to bigger is not possible)
        {
            float result = a + b + c;
            return result;
        }*/
        public float Add(float a, int b, long c)//type Casting is done conversion (bigger datatype to smaller is possible) 
        {
            float result = a + b + c;
            return result;
        }
    }
}
