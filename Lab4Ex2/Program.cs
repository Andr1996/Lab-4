using System;

namespace Lab4Ex2
{
   // Ex 2. Scrieti un program care va modela un autoturism. Un autoturism va avea o marca (string), un numar de inmatriculare (string), precum si o capacitate cilindrica (int).
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti marca: ");
            string marca = (Console.ReadLine());
            Console.WriteLine("Introduceti numarul de imatriculare: ");
            string numar = (Console.ReadLine());
            Console.WriteLine("Introduceti capacitatea cilindrica: ");
            int capacitate = int.Parse(Console.ReadLine());

            InfoAuto infAuto = new InfoAuto(marca, numar, capacitate);

            infAuto.GetDescription();   
        }
    }
}
