using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class GFG
    {

        private int value;

        public GFG(int value) { this.value = value; }

        public static GFG operator --(GFG obj)
        {
            obj.value = --obj.value;
            return obj;
        }

        public void Display()
        {
            Console.WriteLine("Values : " + value);
            Console.WriteLine();
        }
    }
}
