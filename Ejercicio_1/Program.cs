using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Andy Ramiro Garzón Toaza

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1:	Imprimir los números pares que hay dentro de los 100 primeros números enteros.
            // No utilizar la estructura de control "if" para resolver este ejercicio.
            Console.WriteLine("Ejercicio 1: Cantidad de números pares en los 100 primeros números enteros");
            for (int i = 2; i <= 100; i += 2)
            {
                Console.WriteLine(i);
            }

            // Ejercicio 2: Imprimir los números pares que hay dentro de los 100 primeros números enteros utilizando "if" 
            Console.WriteLine("\nEjercicio 2: Números pares dentro de los 100 primeros números enteros");
            for (int i = 1; i <= 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            // Ejercicio 3: Imprimir los números del 1 al 50:
            //a.Para números divisibles por 3, imprima "Fizz".
            //b.Para números divisibles por 5, imprima "Buzz".
            //c.Para números divisibles por 3 y 5, imprime "FizzBuzz".
            //d.En cualquier otro caso, imprima el número.

            Console.WriteLine("\nEjercicio 3: Imprimir los número del 1 al 50");
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            // Ejercicio 4: Imprime los números del 1 al 10 utilizando un bucle " while ".
            Console.WriteLine("\nEjercicio 4: Números del 1 al 10");
            int num = 1;
            while (num <= 10)
            {
                Console.WriteLine(num);
                num++;
            }

            // Ejercicio 5:	Calcula la suma de los primeros 100 números enteros utilizando un bucle " while ".
            Console.WriteLine("\nEjercicio 5: Suma de los primeros 100 números enteros");
            int suma = 0;
            int contador = 1;
            while (contador <= 100)
            {
                suma += contador;
                contador++;
            }
            Console.WriteLine($"La suma de los primeros 100 números enteros es: {suma}");

            // Ejercicio 6: Imprimir los números pares que hay dentro de los 100 primeros números enteros utilizando un bucle " while ".
            Console.WriteLine("\nEjercicio 6: Cantidad de números pares dentro de los 100 primeros números enteros");
            int par = 2;
            while (par <= 100)
            {
                Console.WriteLine(par);
                par += 2;
            }

            // Pausa para mantener la consola abierta
            Console.WriteLine("\nPara cerrar presiona cualquier tecla");
            Console.ReadKey();
        }
    }
}