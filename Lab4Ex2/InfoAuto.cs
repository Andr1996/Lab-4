using System;
using System.Collections.Generic;
using System.Text;

namespace Lab4Ex2
{
    class InfoAuto
    {
        private string marca;
        private string numarImatriculare;
        private int capacitateCilindrica;

        public InfoAuto(string marci, string numere, int capacitate)
        {
            marca = marci;
            numarImatriculare = numere;
            capacitateCilindrica = capacitate;

        }

        public void GetDescription()
        {
            Console.WriteLine($"Marca: {marca}, Numar de inmatriculare: {numarImatriculare}, Capacitate cilindrica: {capacitateCilindrica}");
        }

    }
}
