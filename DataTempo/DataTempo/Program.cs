using DataTempo.Entities;
using System;

namespace DataTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instanciando um DateTime
            DateTime data = DateTime.Now;
            Console.WriteLine(data);
            //-=-=-=-=-=-=-=-=--=-=-=

            Cliente cliente = new("Caio", 20);
            Console.WriteLine($"\n{cliente}");
        }
    }
}