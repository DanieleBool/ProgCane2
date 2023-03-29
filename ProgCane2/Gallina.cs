using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgCane2
{
    public class Gallina : Animale
    {
        //COSTRUTTORE
        public Gallina()
        {
            nome = "Rosita";
            zampe = 2;
        }

        public override string GetVerso()
        {
            return "La gallina svolazza";
        }
    }
}



    //internal class Gallina : IAnimals
    //{
    //    //VARIABILI MEMBRO
    //    private string nome;
    //    private int zampe;
    //    //COSTRUTTORE
    //    public Gallina()
    //    {
    //        nome = "Rosita";
    //        zampe = 2;
    //    }
    //    //PROPERTIES
    //    public string Nome
    //    {
    //        get { return nome; }
    //        set { nome = value; }
    //    }

    //    public int Zampe { get; set; }

    //    public override string GetVerso()
    //    {
    //        //Console.WriteLine("La gallina");
    //        return "La gallina svolazza";
    //    }
    //}