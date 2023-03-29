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
                continue;
            }

            switch (scelta)
            {
                case 1:
                    faccia1 = new Cane();
                    break;
                case 2:
                    faccia1 = new Gatto();
                    break;
                case 3:
                    faccia1 = new Gallina();
                    break;
                case 4:
                    faccia1 = new Topo();
                    break;
                default:
                    Console.WriteLine("Scelta non valida");
                    continue;
            }
            Console.WriteLine(faccia1.GetVerso());

            if(faccia1.GetType()==new Cane().GetType())
            {
                Console.WriteLine(((Cane)faccia1).GetVerso2());
            }

        } while (scelta != 0);
    }
}

