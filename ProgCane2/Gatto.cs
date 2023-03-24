using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    internal class Gatto : IAnimals
    {
        //VARIABILI MEMBRO
        private string nome;
        private int zampe;
        //COSTRUTTORE
        public Gatto()
        {
            nome = "Nero";
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
            //Console.WriteLine("il gatto miagola");
            return "il gatto miagola";
        }
    }
}
