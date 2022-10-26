using System;

internal class Program
{
    static void Main(string[] args)
    {
        Double Cwhats, Pxwats, costo;
        Console.WriteLine("introduce el costo por whats ");
        Cwhats = double.Parse(Console.ReadLine());
        Console.WriteLine("introduce los whats consumidos");
        Pxwats = double.Parse(Console.ReadLine());
        costo = (Cwhats * Pxwats);
        Console.WriteLine("Consumo de energia"+costo);
        Console.ReadKey();
    }
}
