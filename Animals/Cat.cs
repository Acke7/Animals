using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    internal class Cat : Animal, ILegs,IFeline
    {
        public int NumbersOflegs { get; set; }


        public Cat()
        {
            NumbersOflegs = 4;
        }
        public string Meouw()
        {
            return "mewoooo"
;        }


    }
}
