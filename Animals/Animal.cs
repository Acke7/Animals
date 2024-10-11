using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    abstract class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eat eat");
        }
        public void Sleep()
        {
            Console.WriteLine("sleep sleep");
        }
    }
}
