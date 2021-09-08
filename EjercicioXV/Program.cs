using System;

namespace EjercicioXV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número: ");

            string prueba = Console.ReadLine();


            if (Int64.TryParse(prueba, out Int64 CC7))
            {
                Console.WriteLine("Es un valor númerico");
            }
            else
            {
                if (Decimal.TryParse(prueba, out decimal CC8))
                {
                    Console.WriteLine("Es un valor númerico");
                }
                else
                {
                    if (long.TryParse(prueba, out long CC9))
                    {
                        Console.WriteLine("Es un valor númerico");
                    }
                    else
                    {
                        if (double.TryParse(prueba, out double CC10))
                        {
                            Console.WriteLine("Es un valor númerico");
                        }

                        else
                        {
                            Console.WriteLine("No es un valor númerico");
                        }
                    }
                }
            }
        }

    }
}