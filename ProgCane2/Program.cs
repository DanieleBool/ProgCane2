// See https://aka.ms/new-console-template for more information
using ProgCane2;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        IAnimals faccia1 = null;
        Bassotto bassotto = new Bassotto();

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
                Console.WriteLine("Non hai selezionato un numero");
                //faccia1 = null;
                continue;
            }
            //else if (faccia1 != null) 
            //{ Console.WriteLine(faccia1.GetVerso()); }

            switch (scelta)
            {
                case 1:
                    faccia1 = new Cane();
                    Cane cane = (Cane)faccia1;
                    Console.WriteLine(cane.GetVerso());
                    Console.WriteLine(cane.GetVerso2());
                    break;
                case 2:
                    faccia1 = new Gatto();
                    Console.WriteLine(faccia1.GetVerso());
                    break;
                case 3:
                    faccia1 = new Gallina();
                    Console.WriteLine(faccia1.GetVerso());
                    break;
                case 4:
                    faccia1 = new Topo();
                    Console.WriteLine(faccia1.GetVerso());
                    break;
                case 5:
                    bassotto.Abbaia();
                    //faccia1 = null;
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    //faccia1 = null;
                    break;


            }
                    //if (faccia1 != null)
                    //{
                    //    Console.WriteLine(faccia1.GetVerso());
                    //}


            //if (faccia1 is Cane cane)
            //{
            //    Console.WriteLine(cane.GetVerso());
            //    Console.WriteLine(cane.GetVerso2());
            //}
            //else if (faccia1 != null)
            //{
            //    Console.WriteLine(faccia1.GetVerso());
            //}


            //if (faccia1 != null)
            //{
            //    Console.WriteLine(faccia1.GetVerso());

            //    //if (faccia1.Equals(new Cane()))
            //    //{
            //    //    Console.WriteLine(((Cane)faccia1).GetVerso2());
            //    //    //non Cane.faccia1, per convertire faccia in un oggetto Cane
            //    //}

            //    if (faccia1.GetType() == new Cane().GetType())
            //    {
            //        Cane cane = (Cane)faccia1;
            //        Console.WriteLine(cane.GetVerso2());
            //    }

            //    //if (faccia1 is Cane cane)
            //    //{
            //    //    Console.WriteLine(((Cane)faccia1).GetVerso2());
            //    //    //non Cane.faccia1, per convertire faccia in un oggetto Cane
            //    //}

            //}

        } while (scelta != 0);

       
        Terrier terrier = new Terrier();
        Rottweiler rottweiler = new Rottweiler();
        bassotto.Corri();
        terrier.Corri();
        terrier.Abbaia();
        rottweiler.Corri();

    }
}



/// <summary>
//ISTANZIA CLASSI
//Cane cane = new Cane();
//Gatto gatto = new Gatto();
//Gallina gallina = new Gallina();
//Topo topo = new Topo();
/// </summary>
//    IAnimals faccia1;

//    Console.WriteLine("Scegli un'azione:");
//    Console.WriteLine("1. Cane");
//    Console.WriteLine("2. Gatto");
//    Console.WriteLine("3. Gallina");
//    Console.WriteLine("4. Topo");
//    Console.WriteLine("0. Esci");

//    int scelta;
//    do
//    {
//        Console.Write("Scelta: ");
//        if (!int.TryParse(Console.ReadLine(), out scelta))
//        {
//            Console.WriteLine("Scelta non valida");
//        }


//        switch (scelta)
//        {
//            case 1:
//                faccia1 = new Cane();
//                faccia1.GetVerso();
//                break;
//            case 2:
//                faccia1 = new Gatto();
//                faccia1.GetVerso();
//                break;
//            case 3:
//                faccia1 = new Gallina();
//                faccia1.GetVerso();
//                break;
//            case 4:
//                faccia1 = new Topo();
//                faccia1.GetVerso();
//                break;
//            case 0:
//                Console.WriteLine("Hai scelto di uscire dal programma");
//                break;
//            default:
//                Console.WriteLine("Scelta non valida");
//                break;
//        }
//    } while (scelta != 0);


//enum SceltaAnimale
//{
//    Cane = 1,
//    Gatto = 2,
//    Gallina = 3,
//    Topo = 4,
//}

//const string MessaggioScelta = "Che animale vuoi far rumoreggiare?";
//const string MessaggioSceltaNonValida = "Scelta non valida. Riprova.";
//const string MessaggioErrore = "Si è verificato un errore: {0}";

//static void Main(string[] args)
//{
//    IAnimals faccia1 = null;

//    while (true)
//    {
//        Console.WriteLine(MessaggioScelta);
//        Console.WriteLine($"{(int)SceltaAnimale.Cane}. Cane");
//        Console.WriteLine($"{(int)SceltaAnimale.Gatto}. Gatto");
//        Console.WriteLine($"{(int)SceltaAnimale.Gallina}. Gallina");
//        Console.WriteLine($"{(int)SceltaAnimale.Topo}. Topo");

//        string scelta = Console.ReadLine();
//        if (!Enum.TryParse(scelta, out SceltaAnimale animaleScelto))
//        {
//            Console.WriteLine(MessaggioSceltaNonValida);
//            continue;
//        }

//        switch (animaleScelto)
//        {
//            case SceltaAnimale.Cane:
//                faccia1 = new Cane();
//                break;
//            case SceltaAnimale.Gatto:
//                faccia1 = new Gatto();
//                break;
//            case SceltaAnimale.Gallina:
//                faccia1 = new Gallina();
//                break;
//            case SceltaAnimale.Topo:
//                faccia1 = new Topo();
//                break;
//        }

//        if (faccia1 == null)
//        {
//            Console.WriteLine(string.Format(MessaggioErrore, "Impossibile istanziare l'animale."));
//            continue;
//        }

//        Console.WriteLine(faccia1.GetVerso());
//        Console.WriteLine("Premi un tasto per continuare o X per uscire.");

//        if (Console.ReadKey().Key == ConsoleKey.X)
//        {
//            break;
//        }

//        Console.Clear();
//    }
//}















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




