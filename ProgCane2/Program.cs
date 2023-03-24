// See https://aka.ms/new-console-template for more information
using ProgCane2;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("scegli un numero: ");
        //string num;
        //num = Console.ReadLine();
        //switch (num)
        //{
        //    case "1":
        //        Cane.GetVerso();
        //        break;
        //    case "2":
        //        scelta = Cane.GetVerso();
        //        break;
        //    case "3":
        //        scelta = Cane.GetVerso();
        //        break;
        //    case "4":
        //        scelta = Cane.GetVerso();
        //        break;
        //    default:
        //        Console.WriteLine("non hai inserito nessun input");
        //        break;
        //}

        //ISTANZiA CLASSi
        Cane cane = new Cane();
        Gatto gatto = new Gatto();
        Gallina gallina = new Gallina();
        Topo topo = new Topo();

        Console.WriteLine("Scegli un'azione:");
        Console.WriteLine("1. Cane");
        Console.WriteLine("2. Gatto");
        Console.WriteLine("3. Gallina");
        Console.WriteLine("4. Topo");
        Console.WriteLine("0. Esci");

        int scelta;
        do
        {
            Console.Write("Scelta: ");
            if (!int.TryParse(Console.ReadLine(), out scelta))
            {
                Console.WriteLine("Scelta non valida");
            }


            switch (scelta)
            {
                case 1:
                    cane.GetVerso();
                    break;
                case 2:
                    gatto.GetVerso();
                    break;
                case 3:
                    gallina.GetVerso();
                    break;
                case 4:
                    topo.GetVerso();
                    break;
                case 0:
                    Console.WriteLine("Hai scelto di uscire dal programma");
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    break;
            }
        } while (scelta != 0);
    }
}












//public interface IToward
//{
//    void Toward(string name, int zampe)
//    {
//        Console.WriteLine($"L'animale dice 'Bau'");
//    }
//}

        //Console.WriteLine("inserisci cane ");
        //string cane1;
        //cane1 = Console.ReadLine();

        //Console.WriteLine("inserisci razza ");
        //string razza1;
        //razza1 = Console.ReadLine();


        //cani.Add(new Cane(cane1, razza1));
        //Console.WriteLine($"L'animale {cane1} dice 'Bau'");

    


