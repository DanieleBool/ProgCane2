using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    internal class Topo : IAnimals
    {
        //VARIABILI MEMBRO
        private string nome;
        private int zampe;
        //COSTRUTTORE
        public Topo()
        {
            nome = "Gigio";
            zampe = 4;
        }
        //PROPERTIES
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Zampe { get; set; }
        public string GetVerso()
        {
            //Console.WriteLine("il topo squittisce");
            return "il topo squittisce";
        }
    }
}
