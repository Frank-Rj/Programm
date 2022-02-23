using System;
using System.Collections.Generic;

namespace Pilas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definiendo Pila
            Stack<string> nombres = new Stack<string>();

            // Asignando valores a la Pila
            Console.WriteLine("Ingresando datos en la Stack: ");
            nombres.Push(Console.ReadLine());
            nombres.Push(Console.ReadLine());
            nombres.Push(Console.ReadLine());
            nombres.Push(Console.ReadLine());
            nombres.Push(Console.ReadLine());

            // Muestra los datos ingresados en la Pila
            Console.WriteLine("\nDatos que contiene la Stack: ");
            foreach (string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }

            // Procesando datos 
            Console.WriteLine("\nElemento a eliminar: {0} ", nombres.Peek());
            Console.WriteLine("Eliminando el elemento: {0}", nombres.Pop());
            Console.WriteLine("Siguiente elemento a eliminar: {0} ", nombres.Peek()); 
            Console.WriteLine("Eliminando el elemento: {0}", nombres.Pop());
            Console.WriteLine("Ultimo elemento a eliminar: {0} ", nombres.Peek());
            Console.WriteLine("Eliminando el elemento: {0}", nombres.Pop());

            // Definiendo segunda Pila a partir de la primera
            Stack<string> nombres2 = new Stack<string>(nombres.ToArray());

            // Muestra los datos de la segunda Pila
            Console.WriteLine("\nContenido de la Stack2 (primera copia): ");
            foreach (string nombre in nombres2)
            {
                Console.WriteLine(nombre);
            }

            // Definiendo array, contiene una copia de la segunda Pila
            string[] array = new string[nombres.Count * 2];
            nombres.CopyTo(array, nombres.Count);

            // Definiendo Pila tres
            Stack<string> nombres3 = new Stack<string>(array);

            Console.WriteLine("\nContenido de la Stack3 (segunda copia), con duplicados y nulos:");
            foreach (string numero in nombres3)
            {
                Console.WriteLine(numero);
            }

            Console.WriteLine("Ingresa el elemento a verificar en la Stack2: ");
            string name = Console.ReadLine();

            Console.WriteLine("\nVerificando si la Stack2 contiende el elemento: " + name);
            Console.WriteLine("nombres2.Contains/La Stack2 contiene (" + (name + ") = {0}"), nombres2.Contains(name));
            Console.WriteLine("nombres2.Clear()/Limpiando la Stack2"); nombres2.Clear();
            Console.WriteLine("nombres2.Count/Valores de la Stack2: {0}", nombres2.Count);  
        }
    }
}
