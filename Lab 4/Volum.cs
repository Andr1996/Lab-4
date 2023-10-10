using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_4
{
    class Volum
    {
        private int lungime;
        private int latime;
        private int inaltime;
        private int calcul;

        public Volum(int L, int l, int h)
        {
            lungime = L;
            latime = l;
            inaltime = h;
        }

        public void CalculVolum()
        {
            calcul = lungime * latime * inaltime;
            Console.WriteLine($"Volumul dulapului este: {calcul}");
        }

    }
}
