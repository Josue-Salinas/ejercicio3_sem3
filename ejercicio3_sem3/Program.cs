using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3_sem3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            double premio,monto_extra, monto_adivinanza,premio_total;
            int edad, adivinanzas_acertadas;
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de adivinanzas que acertó:");
            adivinanzas_acertadas = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                if (adivinanzas_acertadas >= 3)
                {
                    premio = 50;
                }
                else
                {
                    premio = 30;
                }
            }
            else
            {
                if (adivinanzas_acertadas >= 3)
                {
                    premio = 80;
                }
                else
                {
                    premio = 50;
                }
            }
            monto_extra = edad*5;
            monto_adivinanza = adivinanzas_acertadas*2;
            premio_total = premio + monto_extra + monto_adivinanza;
            Console.WriteLine("Usted gana un premio de S/." + premio_total);
            Console.ReadKey();
        }
    }
}
