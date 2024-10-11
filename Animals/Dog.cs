using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Dog :Animal ,ILegs,ICanine
    {
        public int NumbersOflegs { get; set; }
        public Dog()
        {
            NumbersOflegs = 4;
        }

        public string Bark()
        {
            return "Hoooof";
        }

    }
}
