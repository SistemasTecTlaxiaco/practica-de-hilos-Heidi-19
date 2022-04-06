using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace practica6
{
    class Program
    {
        public static int CalculoComplejo(int n)
        {
            // sumo uno y espero 5 segundos
            n = n + 1;
            Thread.Sleep(5000);
            return n;
        }

    }

    public class HiloParaMates
    {
        protected int n;
        protected MatesCallback callback = null;
        public HiloParaMates(int n, MatesCallback callback)
        {
            this.n = n;
            this.callback = callback;
        }
        public void CalculoComplejo()
        {
            int result = Program.CalculoComplejo(n);
            if (callback != null)
                callback(result);
        }
    }

    // creo un delegado con la firma necesaria para capturar
    // el valor devuelto por el método CalculoComplejo
    public delegate void MatesCallback(int n);

    public class Ejemplo
    {

        public static void Main()
        {
            HiloParaMates hpm = new HiloParaMates(1000, new MatesCallback(ResultCallback));

            Thread th = new Thread(new ThreadStart(hpm.CalculoComplejo));

            th.Start();
            th.Join();

        }
        public static void ResultCallback(int n)
        {
            Console.WriteLine("Resultado de la operación: " + n);
        }
    }
}


