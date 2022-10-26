namespace a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FINAL, PRECIO, CANT;
            Console.WriteLine("Introduce el precio:  ");
            PRECIO = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la cantidad: ");
            CANT = double.Parse(Console.ReadLine());

            if (CANT >= 2)
            {
                FINAL = (PRECIO * CANT) + ((PRECIO * CANT) + ((PRECIO * CANT) * 0.05));
                Console.WriteLine("El precio más descuento es:  "+FINAL);
                Console.ReadKey();
            }
            else if (CANT <= 1)
            {
                FINAL = PRECIO * CANT;
                Console.WriteLine("El precio más descuento es:  " + FINAL);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("error");
            }


        }
    }
}
