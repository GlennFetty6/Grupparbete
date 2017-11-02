using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] koder = { 222, 333, 444, 555, 666 };
            int kod;

            Console.Write("Skriv in din tresiffriga kod: ");
            string input = Console.ReadLine();

            while (Int32.TryParse(input, out kod) == false || koder.Contains(kod) == false)
            {
                Console.Write("Kod ej giltig. Försök igen: ");
                input = Console.ReadLine();
            }
            int i = -1;

            foreach (int nr in koder)
            {
                i++;

                if (kod == koder[i])
                {

                    int firstNr = Math.Abs(kod);
                    while (firstNr >= 10)
                        firstNr /= 10;
                    if (firstNr == 2)
                    {
                        Console.WriteLine("Inloggad som kassör");
                        Kassasystem KasstSystem = new Kassasystem();
                        KasstSystem.Kassa();
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else if (firstNr == 3)
                    {
                        Console.WriteLine("Inloggad som 3");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else if (firstNr == 5)
                    {
                        Console.WriteLine("Inloggad som 5");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("Du är ej behörig");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                }
            }
        }
    }
}
