using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    internal class Terrier : Cane
    {
        public Terrier() : base()
        {
        }

        public override void Abbaia()
        {
            Console.WriteLine("Il Terrier abbaia squillante.");
            //base.Corri();  chiamo il metodo Corri della classe base Cane
        }
    }
}
