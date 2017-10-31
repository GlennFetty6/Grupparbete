using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{

    class Inloggning
    {

        static void Main(string[] args)
        {
            int[] koder = new int[5] { 222, 333, 444, 555, 666 };

            Console.WriteLine("Skriv in din kod.");

            string input = Console.ReadLine();

            int kod;

            while(Int32.TryParse(input, out kod) == false){
                Console.WriteLine("Koden måste bestå av heltal");
                input = Console.ReadLine();
            }
                int i = -1;
                
                foreach (int nr in koder)
                {
                    i++;
                    Console.WriteLine(nr);

                    if (kod == koder[i] )
                    {

                        int firstNr = Math.Abs(kod);
                        while (firstNr >= 10)
                            firstNr /= 10;
                        if (firstNr == 2)
                        {
                            Console.WriteLine("Inloggad som 2");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }
                        if (firstNr == 3)
                        {
                            Console.WriteLine("Inloggad som 3");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }
                        if (firstNr == 5)
                        {
                            Console.WriteLine("Inloggad som 5");
                            Console.WriteLine("Press any key to exit.");
                            Console.ReadKey();
                        }

                    }

                    if(i == koder.Length)
                    {
                        Console.WriteLine("Du är ej behörig");
                        Console.WriteLine("Press any key to exit.");
                        Console.ReadKey();
                    }
                   
                }
           
            }
  
    }
}
