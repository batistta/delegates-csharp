using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Calcular somarDel = new Calcular(Somar);
            Calcular subtrDel = new Calcular(Subtrair);
            Calcular dividDel = new Calcular(Dividir);
            Calcular multiDel = new Calcular(Multiplicar);
            Console.WriteLine(somarDel(1,4));
            Console.WriteLine(subtrDel(1, 4));
            Console.WriteLine(dividDel(1, 4));
            Console.WriteLine(multiDel(1, 4));
            Console.ReadKey();

            int Somar(int x, int y)
            {
                return x + y;
            }
            int Subtrair(int x, int y)
            {
                return x - y;
            }
            int Dividir(int x, int y)
            {
                return x / y;
            }
            int Multiplicar(int x, int y)
            {
                return x * y;
            }
        }
        public delegate int Calcular(int x, int y);
        
    }

}
