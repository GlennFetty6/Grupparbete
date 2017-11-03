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
            int[] koder = { 222, 333, 444, 555, 666 };              //De koder som är möjliga att logga in med.
            int kod;                                            

            Console.Write("Skriv in din tresiffriga kod: ");    
            string input = Console.ReadLine();                      //Här skrivs koden in av användaren.

            while (Int32.TryParse(input, out kod) == false || koder.Contains(kod) == false) //Gör om strängen Input till en int om möjligt. Kollar om inskriven kod finns i Vektorn "koder". Om något misslyckas ber programmet om ny kod. 
            {
                Console.Write("Kod ej giltig. Försök igen: ");
                input = Console.ReadLine();
            }
            int i = 0;

            foreach (int nr in koder)
            {

                if (kod == koder[i])
                {

                    int firstNr = Math.Abs(kod);    //Tar fram första siffran i koden.
                    while (firstNr >= 10)
                        firstNr /= 10;
                    if (firstNr == 2)
                    {                      
                        Console.WriteLine("Inloggad som kassör");
                        Kassasystem KasstSystem = new Kassasystem();    //Om första siffran var 2 loggas användaren in som kassör och Kassa körs i klassen Kassasystem. 
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
                    i++;
                }
            }
        }
    }
}
