using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class Administrator
    {
        bool huvudMeny = true;

        public void Administration()
        {
            int input = 0;
            do
            {
                Console.WriteLine("----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Anställda                       -");
                Console.WriteLine("-       2 Varor                           -");
                Console.WriteLine("-       3 Uppdatera momssats              -");
                Console.WriteLine("-       0 Logga ut                        -");
                Console.WriteLine("-------------------------------------------\n");

                try //Kontrollerar att inmatning är av typen interger.
                {
                    input = int.Parse(Console.ReadLine());
                    huvudMeny = false;
                }
                catch
                {
                    Console.WriteLine("Välj ett nummer i menyn.");
                    Console.WriteLine("\n");
                }

                switch (input)
                {
                    case 1:
                        AdminAnställda();
                        break;
                    case 2:
                        AdminVaror();
                        break;
                    case 3:
                        AdminMomssats();
                        break;
                    case 0:
                        Console.WriteLine("Du loggas nu ut. Tryck på valfri tangent.");
                        Console.ReadKey();                       
                        break;
                    default: // Meddelande kommer upp om input är ett nummer utanför det tillåtna 0-4.
                        Console.WriteLine("Inkorrekt nummer. Välj ett nummer i menyn.");
                        break;
                }
            } while (huvudMeny || input != 0);
        }

        void AdminAnställda()
        {
            // Lägg till ny/ta bort/uppdatera en anställd information
            // Visa anställd information och antal arbetade timmar
            do
            {
                int input1;
                Console.WriteLine("Du är inne i AdminAnställda");

                // Detta är bara strunt  
                Console.Write("Skriv ett tal eller '0' för att återgå till huvud menyn: ");
                input1 = int.Parse(Console.ReadLine());
                if (input1 == 0)
                {
                    Console.WriteLine("Tillbaka till huvud menyn");
                    huvudMeny = false;
                }
                else
                {
                    Console.WriteLine("Ditt nummer var {0}", input1);
                    huvudMeny = true;
                }

            } while (huvudMeny);
        }

        void AdminVaror()
        {
            // Lägg till ny/ta bort/uppdatera en vara information
            // Lägg till ny/ta bort/uppdatera en varugrupper
            // Ändra pris på en vara
            // Göra utskrift av prisetiketter till varje vara
            Console.WriteLine("Du är inne i AdminVaror");
            Console.ReadKey();
        }
        void AdminMomssats()
        {
            // Lägg till ny/ta bort/uppdatera en momssatser
            Console.WriteLine("Du är inne i AdminVaror");
            Console.ReadKey();
        }
    }
}
