using System;
using System.Collections.Generic;

namespace Training_Method_Calculator
{
    internal class Program
    {
        class classCalculatorku
        {
            public classCalculatorku(string merek)
            {
                Console.WriteLine("======OBJEK=======");
                Console.WriteLine("Buatan" + merek);
            }

            public int jumlah(int bil1, int bil2)
            {
                return bil1 + bil2;
            }

            public int kurang(int bil1, int bil2)
            {
                return bil1 - bil2;
            }

            public void tampilkanHasil(int hasil)
            {
                Console.WriteLine("hasil operasi = {0}", hasil);
            }
        }

        public static void Main(string[] args)
        {
            int hasilJumlah = 0, bil1 = 30, bil2 = 5;

            classCalculatorku casioclc = new classCalculatorku("casion");
            hasilJumlah = casioclc.jumlah(bil1, bil2);
            casioclc.tampilkanHasil(hasilJumlah);
            classCalculatorku enakiclc = new classCalculatorku("casion");
            hasilJumlah = enakiclc.kurang(bil1, bil2);
            casioclc.tampilkanHasil(hasilJumlah);
        }
    }
}