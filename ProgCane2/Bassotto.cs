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

        //public void AbbaiaComeUnBassotto()
        //{
        //    Console.WriteLine("Il bassotto abbaia.");
        //    base.Abbaia();
        //}

        public override void Abbaia()
        {
            Console.WriteLine("Il bassotto abbaia.");
        }


    }
}
