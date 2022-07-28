using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primer_proyecto_de_consola_en_Visual_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0; int num2 = 0;

            Console.WriteLine("Calculadora - Consola C#\r");
            Console.WriteLine("------------------------\n");

            Console.WriteLine("Digite el primer numero, y presione enter");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite el segundo numero, y presione enter");
            num2 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("¿Que quieres hacer?");
            Console.WriteLine("\ts - Sumar");
            Console.WriteLine("\tr - Restar");
            Console.WriteLine("\tm - Multiplicar");
            Console.WriteLine("\td - Dividir");
            Console.Write("Your option? ");



            switch (Console.ReadLine())
            {
                case "a":
                    Console.WriteLine($"El Resultado es:  {num1} + {num2} = " + (num1 + num2));
                    break;
                case "s":
                    Console.WriteLine($"El Resultado es: {num1} - {num2} = " + (num1 - num2));
                    break;
                case "m":
                    Console.WriteLine($"El Resultado es: {num1} * {num2} = " + (num1 * num2));
                    break;
                case "d":
                    Console.WriteLine($"El Resultado es: {num1} / {num2} = " + (num1 / num2));
                    break;
            }

            Console.Write("Presiona enter para cerrar la consola");
            Console.ReadKey();


        }
    }
}
