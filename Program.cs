using System;
using System.Timers;

namespace ArbolNavidad
{
    internal class Program
    {
        static int segundos = 60; // Puedes ajustar el valor inicial según tus necesidades
        
        static void Main(string[] args)
        {
            while(!Console.KeyAvailable)
            {
                Arbol();
                ActualizarTemporizador();
            }
            
            Console.ReadKey();
        }
        static void Arbol()
        {
            int body, size;

            body = 1;
            size = 12;
            Random r = new Random();

            for (int i = 0; i < size; i++)
            {
                string space = "";

                for (int j = size - i; j > 0; j--)
                {
                    space += " ";
                }
                Console.Write(space);

                for (int k = 0; k < body; k++)
                {
                    int random = r.Next(1, 100);
                    if ((random % 2) == 0) Console.ForegroundColor = ConsoleColor.Cyan;
                    else Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("*");
                }
                Console.Write(space);
                Console.WriteLine();
                body += 2;
            }
            for (int t = 0; t < 3; t++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("          ||||");
            }
        }
        static void ActualizarTemporizador()
        {
            Thread.Sleep(800); // Se queda pausado en esta linea 800 milisegundos antes de continuar 

            Console.Clear(); // Limpiar la consola para que el temporizador no se acumule

            // Decrementa el contador
            segundos--;

            // Verifica si el contador llegó a cero
            if (segundos < 0)
            {
                Console.WriteLine("Tiempo agotado. Reiniciando contador.");
                segundos = 60; // Puedes ajustar el valor de reinicio según tus necesidades
            }
        }
    }
}