using System;
using System.Collections;

namespace Colas
{
    class Program
    {
        static void Main(string[] args)
        {
            // Definiendo una Queue.
            Queue numeros = new Queue();

            Console.WriteLine("Ingresando elementos a la Cola: ");
            numeros.Enqueue(Console.ReadLine());
            numeros.Enqueue(Console.ReadLine());
            numeros.Enqueue(Console.ReadLine());
            numeros.Enqueue(Console.ReadLine());
            numeros.Enqueue(Console.ReadLine());

            //Mostrando las propiedades y valores de Queue.
            Console.WriteLine("\nCantidad de elementos en la cola: {0}", numeros.Count);
            Console.Write("\nValores dentro de la Queue: ");
            
            PrintValues(numeros);

            // Eliminar  un elemento
            Console.WriteLine("\nElemento a eliminar: {0}", numeros.Peek());
            Console.WriteLine("Eliminando el elemento: {0}", numeros.Dequeue());

            // Mostrar valores de la Queue.
            Console.Write("\nValores de la Queue:");
            PrintValues(numeros);

            // Eliminar otros elementos
            Console.WriteLine("\nSiguiente elemento a eliminar: {0}", numeros.Peek());
            Console.WriteLine("Eliminando el elemento: {0}", numeros.Dequeue());

            Console.WriteLine("\nUltimo elemento a eliminar: {0}", numeros.Peek());
            Console.WriteLine("Eliminando el elemento: {0}", numeros.Dequeue());

            // Mostrar valores de la Queue.
            Console.Write("\nValores de la Queue: ");
            PrintValues(numeros);

            // Mostrar el primer valor la Queue
            Console.WriteLine("\nPrimer elemento de la Queue: {0}", numeros.Peek());

            Console.Write("\nValores de la Queue: ");
            PrintValues(numeros);

            numeros.Clear();

            Console.WriteLine("\nValores de la Queue después de limpiar: {0}", numeros.Count);
            PrintValues(numeros);

            void PrintValues(IEnumerable myCollection)
            {
                foreach (Object obj in myCollection)

                Console.Write("\t {0}", obj);
                Console.WriteLine();        
            }
        }
    }
}
