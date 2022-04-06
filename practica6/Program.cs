using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace practica6
{
    class Program
    {
        static void Main(String[] args)
        {
            //Crear hilo
            Thread t = new Thread(metodo);

            //Escribir mil veces el caracter x
            for(int i = 0; i < 1000; i++)
                Console.WriteLine("x");
        }

        static void metodo()
        {
            //Escribir mil veces el caracter y
            for(int i = 0; i < 1000; i++)
                Console.WriteLine("y");
        }
    }
}


