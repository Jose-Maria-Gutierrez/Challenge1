using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge1
{
    public class Class1
    {
        public void suma()
        {
            int i,suma,dato;
            do
            {
                Console.WriteLine("ingrese un numero positivo");
            } while (!int.TryParse(Console.ReadLine(), out dato) || dato<=0); //mientras no sea numero o sea negativo
            suma = 0;
            for (i=1;i<=100;i++)
            {
                suma += dato + i;
            }
            Console.WriteLine("valor de la suma: " + suma);
        }
    }
}
