using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    internal interface IAnimals
    {
        string Nome { get; set; }
        int Zampe { get; set; }
        void GetVerso();

    }
}
