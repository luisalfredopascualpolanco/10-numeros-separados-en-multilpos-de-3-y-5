using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyecto10._4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int posicion, numero;
                int multiplo5 = 0;
                int multiplo3 = 0;
                int multiploAmbos = 0;
                int ninguno = 0;

                for (int i = 0; i < 10; i++)
                {
                    posicion = i + 1;
                    Console.Write("Dame el que va en la posicion #" + posicion + ": ");
                    numero = int.Parse(Console.ReadLine());

                    if (numero % 5 == 0 && numero % 3 == 0)
                    {
                        multiploAmbos = multiploAmbos + 1;
                    }
                    else if (numero % 3 == 0)
                    {
                        multiplo3 = multiplo3 + 1;
                    }
                    else if(numero % 5 ==0)
                    {
                        multiplo5 = multiplo5 + 1;
                    }
                    else
                    {
                        ninguno = ninguno + 1;
                    }
                }
                Console.WriteLine("Hemos encontrado " + multiplo3 + " numeros multiplos de 3.");
                Console.WriteLine("Hemos encontrado " + multiplo5 + " numeros multiplos de 5.");
                Console.WriteLine("Hemos encontrado " + multiploAmbos + " numeros multiplos de ambos.");
                Console.WriteLine("Hemos encontrado " + ninguno + " numeros que no son multiplos de ninguno.");
            }
            catch (Exception)
            {
                Console.WriteLine("Ha introducido un valor invalido");               
            }
            Console.ReadKey();
        }
    }
}
