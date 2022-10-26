using System;



namespace costodeviaje
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double kilomecosto, kilometroreco, cos;
            Console.WriteLine("introduce el costo por kilometro  ");
            kilomecosto = double.Parse(Console.ReadLine());
            Console.WriteLine("introduce los kilometros recorridos");
            kilometroreco = double.Parse(Console.ReadLine());
            cos = (kilomecosto * kilometroreco);

            Console.WriteLine("muestra el costo de viaje  " + cos);

            Console.ReadKey();






        }
    }
}
