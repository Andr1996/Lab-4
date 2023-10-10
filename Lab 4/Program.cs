using System;

namespace Lab_4
{
   //  Ex 1. Un dulap are trei caracteristici : lungime , latime , inaltime.Dulapul va avea o metoda care va calcula volumul acestuia.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti lungimea: ");
            int L = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti latimea: ");
            int l = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduceti inaltimea: ");
            int h = int.Parse(Console.ReadLine());

            Volum volum = new Volum (L, l, h);

            volum.CalculVolum();


        }
    }
}
