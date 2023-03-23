// See https://aka.ms/new-console-template for more information
using ProgCane2;
using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("scegli un numero: ");
        string num;
        cane1 = Console.ReadLine();
        switch (num)
        {
            case "1":
                scelta = ;
                break;
            case "2":
                scelta = new Oca(input, feed);
                break;
            case "3":
                scelta = new Gallina(input, feed);
                break;
            case "4":
                scelta = new Cavallo(input, feed);
                break;
            default:
                Console.WriteLine("non hai inserito nessun input");
                break;
        }
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

    


