using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{

    internal class Cane : IAnimals
    {
        //VARIABILI MEMBRO
        private string nome;
        private int zampe;
        //COSTRUTTORE
        public Cane()
        {
            nome = "Ciccio";
            zampe = 4;
        }
        //PROPERTIES
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Zampe { get; set; }
        //METODO EREDITATO DA IIoward
        public void GetVerso()
        {
            Console.WriteLine("il cane dice 'Bau'");
        }

        


















        //METODO
        //public void Toward()
        //{
        //    Console.WriteLine($"L'animale dice 'Bau'");
        //}

        //public bool Equals(Cane cane)
        //{

        //}

        //private string nome;
        //private int zampe;

        //public void setNome(string nome)
        //{ 
        //    this.nome = nome;
        //}
        //public string GetNome()
        //{ 
        //    return this.nome; 
        //}

        //public void Nome
        //{
        //    get => this.nome;
        //    set => this.nome = value;
        //}

        //public string Nome { get; set; }
        //public int Zampe { get; set; }
    }


}