﻿using System;

namespace Sconti
{
    class Program
    {
        static void Main(string[] args)
        {
            double importo = 0;
            double sconto = 0;
            double importo_scontato = 0;
            Console.WriteLine("Inserisci l'importo: ");
            importo = double.Parse(Console.ReadLine());
            if(importo<=500)
            {
                sconto = (importo / 100) * 10;
                importo_scontato = importo - sconto;
                Console.WriteLine("Lo sconto è di: "+sconto);
                Console.WriteLine("L'importo è di: "+importo_scontato);
            }else if (importo>500)
            {
                sconto = (importo / 100) * 20;
                importo_scontato = importo - sconto;
                Console.WriteLine("Lo sconto è di: " + sconto);
                Console.WriteLine("L'importo è di: "+importo_scontato);
            }
            Console.ReadLine();
        }
    }
}
