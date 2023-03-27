using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{

    internal class Bassotto : Cane
    {
        public Bassotto() : base()
        {

        }

        public override void Abbaia()
        {
            Console.WriteLine("Il bassotto abbaia.");
        }

        public override void Corri()
        {
            Console.WriteLine("Il bassotto corre.");
        }

    }
}
