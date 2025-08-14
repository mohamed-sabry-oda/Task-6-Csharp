using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6_C_
{
    internal class TypeA
    {
        private int F; // inside this Scope { }
        internal int G;// acc inside same project
        public int H;// acc in same project or out project

   

    public void print()
        {
            Console.WriteLine(F);
            Console.WriteLine(G);
            Console.WriteLine(H);
        }
    }
}
