using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    internal class Rottweiler : Cane
    {
        public Rottweiler() : base()
        {

        }

        public override void Abbaia()
        {
            Console.WriteLine("Il rottweiler abbaia aggressivo.");
        }

    }
}
