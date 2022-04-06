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
            //Crear hilo          expresión blanda
            Thread t = new Thread(()=>go("Programación con hilos","Es facil!!!"));
            t.Start();
            Console.WriteLine("Hilo finalizado");
            Console.Read();
        }

        static void go(string str1, string str2)
        {
            Console.WriteLine(str1);
            Console.WriteLine(str2);
        }

        static void metodo(object o)
        {
            //Imprimir objeto
            Console.WriteLine(o.ToString());
            //Escribir mil veces el caracter y
            for(int i = 0; i < 1000; i++)
                Console.WriteLine("y");
        }
    }
}


