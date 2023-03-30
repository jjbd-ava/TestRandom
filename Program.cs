using System;

namespace TestRandom
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int objetivo = rnd.Next(0, 101);
            Console.WriteLine("Adivina el número (0-100) en 4 intentos.");
            string pistas = "";
            int intento = 1;
            bool acierto = false;
            int introducido;
            while(intento<5 && !acierto)
            {
                Console.WriteLine($"==================\n¿Qué número crees que es? Intento {intento}/4");
                if (intento > 1)
                {
                    Console.WriteLine($"Pistas:\n{pistas}");
                }
                while (!int.TryParse(Console.ReadLine(), out introducido) || introducido<0 || introducido>100)
                {
                    Console.WriteLine($"No has introducido un número válido.");
                    Console.WriteLine($"¿Qué número crees que es? Intento {intento}/4");
                }
                if (introducido == objetivo)
                {
                    Console.WriteLine($"¡Has acertado en el intento {intento}/4!");
                    acierto = true;
                }
                else
                {
                    if (introducido > objetivo)
                    {
                        pistas += $"El número secreto es menor que {introducido}\n";
                        Console.WriteLine("Parece que el número es menor.");
                    }
                    else
                    {
                        pistas += $"El número secreto es mayor que {introducido}\n";
                        Console.WriteLine("Parece que el número es mayor.");
                    }
                    intento++;
                }
            }
            if (!acierto) Console.WriteLine($"Vaya, mala suerte. El número secreto era {objetivo}");
        }
    }
}
