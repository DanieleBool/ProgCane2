using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    internal interface IAnimals
    {
        //NON POSSO ISTANZIARE NELL'INTERFACCIA
        //Cane cane = new Cane();
        //Gatto gatto = new Gatto();
        //Gallina gallina = new Gallina();
        //Topo topo = new Topo();

        string Nome { get; set; }
        int Zampe { get; set; }
        void GetVerso();

    }
}
