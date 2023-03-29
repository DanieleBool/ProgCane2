using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    public class Animale : IAnimals
    {
        protected string nome;
        protected int zampe;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public int Zampe { get; set; }

        public virtual string GetVerso()
        {
            return "L'animale fa un verso";
        }
    }
}
