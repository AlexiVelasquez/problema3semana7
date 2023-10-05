using System;

namespace problema3semana7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Años bisiestos desde 1900:");

            for (int año = 1900; año <= 2023; año++)
            {
                // Verificar si el año es bisiesto
                if ((año % 4 == 0 && año % 100 != 0) || (año % 400 == 0))
                {
                    Console.Write("Es un año bisiesto:\t"); Console.WriteLine(año);
                }
            }Console.ReadKey();
        }
    }
}
