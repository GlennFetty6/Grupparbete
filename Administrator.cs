using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitCashier
{
    class Administrator
    {
        bool huvudMeny = true;
        bool varuMeny = true;

        public void Administration()
        {
            int input = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Anställda                       -");
                Console.WriteLine("-       2 Ändra på vara                   -");
                Console.WriteLine("-       3 Uppdatera momssats              -");
                Console.WriteLine("-       4 Lägg till vara                  -");
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
                    case 4:
                        LäggTillVara();
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

            int input = 0;
            do
            {
                Console.WriteLine("");
                Console.WriteLine("----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Läggtill/ändra anställd         -");
                Console.WriteLine("-       2 Se info om anställd             -");
                Console.WriteLine("-       3 Ta bort anställd                -");
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
                        LaggTillAnstalld();
                        break;
                    case 2:
                        SeAnstalld();
                        break;
                    case 3:
                        SparkaAnstalld();
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

            // Lägg till ny/ta bort/uppdatera en anställd information
            //// Visa anställd information och antal arbetade timmar
            //do
            //{
            //    int input1;
            //    Console.WriteLine("Du är inne i AdminAnställda");

            //    // Detta är bara strunt  
            //    Console.Write("Skriv ett tal eller '0' för att återgå till huvud menyn: ");
            //    input1 = int.Parse(Console.ReadLine());
            //    if (input1 == 0)
            //    {
            //        Console.WriteLine("Tillbaka till huvud menyn");
            //        huvudMeny = false;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ditt nummer var {0}", input1);
            //        huvudMeny = true;
            //    }

            //} while (huvudMeny);
        }

        void LäggTillVara() //Används för att lägga till varor i varuListan. 
        {                   //Samlar först den data som behövs för att därefter köra constructorn i Vara.cs och lägga till objektet som skapas i varulistan.
            Console.WriteLine("Ange namnet på den vara du vill lägga till");
            string namn = Console.ReadLine();

            Console.WriteLine("Ange priset på {0}", namn);

            string input = Console.ReadLine();

            int pris;

            while (Int32.TryParse(input, out pris) == false || pris <= 0)
            {
                Console.Write("Priset måste bestå av ett positivt heltal. Försök igen: ");
                input = Console.ReadLine();
            }

            Console.WriteLine("Ange vilken kategori {0} ska ha", namn);

            string input2 = Console.ReadLine();

            int kategori;

            while (Int32.TryParse(input2, out kategori) == false || (kategori != 0 && kategori != 1))
            {
                Console.Write("Den nya kategorin måste vara 0 eller 1. Försök igen: ");
                input2 = Console.ReadLine();
            }

            Console.WriteLine("Ange vilket ID-nummer {0} ska ha.", namn);

            string input3 = Console.ReadLine();

            int idNr;

            while (Int32.TryParse(input3, out idNr) == false || CheckList(idNr) == true || idNr < 10 || idNr > 99)
            {
                Console.Write("Det nya ID-numret måste vara ett heltal mellan 9 och 100 och får inte vara i bruk. Försök igen: ");
                input3 = Console.ReadLine();
            }

            Console.WriteLine("Ange hur många {0} som finns på lager.", namn);

            string input4 = Console.ReadLine();

            int lagerAntal;

            while (Int32.TryParse(input4, out lagerAntal) == false|| lagerAntal < 0)
            {
                Console.Write("Antalet på lager måste vara 0 eller mer ");
                input4 = Console.ReadLine();
            }


            Program.varuLista.Add(new Vara(namn, pris, kategori, idNr, lagerAntal, 0));

            Console.WriteLine("Varan {0} är nu tillagd i systemet.", namn);
            Console.ReadKey();
        }

        private Vara valdVara; //Variabel som används i AdminVaror och AndraVara

        void AdminVaror() //Menymetod för hantering av varor när man är inloggad som admin. 
        {
            Console.Write("Skriv in varans Id-nummer: ");
            string input = Console.ReadLine();
            int helTal;

            while (Int32.TryParse(input, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                Console.Write("Koden måste bestå av ett giltigt tvåsiffrigt heltal. Försök igen: ");
                input = Console.ReadLine();
            }
            Console.WriteLine("Vald vara är {0}", valdVara.Namn);
            helTal = 0;

            Console.Write("Vilken förändring vill du göra på vald vara?");

            int input2 = 0;

            do
            {
                Console.WriteLine("");
                Console.WriteLine("----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Namn                            -");
                Console.WriteLine("-       2 Pris                            -");
                Console.WriteLine("-       3 Kategori                        -");
                Console.WriteLine("-       4 Id                              -");
                Console.WriteLine("-       0 Logga ut                        -");
                Console.WriteLine("-------------------------------------------\n");

                try //Kontrollerar att inmatning är av typen interger.
                {
                    input2 = int.Parse(Console.ReadLine());
                    varuMeny = false;
                }
                catch
                {
                    Console.WriteLine("Välj ett nummer i menyn.");
                    Console.WriteLine("\n");
                }

                switch (input2)
                {
                    case 1:
                        AndraVara(input2);
                        break;
                    case 2:
                        AndraVara(input2);
                        break;
                    case 3:
                        AndraVara(input2);
                        break;
                    case 4:
                        AndraVara(input2);
                        break;
                    case 0:
                        Console.WriteLine("Du loggas nu ut. Tryck på valfri tangent.");
                        Console.ReadKey();
                        Administration();
                        break;
                    default: // Meddelande kommer upp om input är ett nummer utanför det tillåtna 0-4.
                        Console.WriteLine("Inkorrekt nummer. Välj ett nummer i menyn.");
                        break;
                }
            } while (varuMeny || input2 != 0);

            // Lägg till ny/ta bort/uppdatera en vara information
            // Lägg till ny/ta bort/uppdatera en varugrupper
            // Ändra pris på en vara
            // Göra utskrift av prisetiketter till varje vara
            Console.WriteLine("Du är inne i AdminVaror");
            Console.ReadKey();
        }

        void AndraVara(int nr)  //Orienterar sig mha av inkommande int och ger sen användaren möjlighet att ändra vald variabel. 
        {
            switch (nr)
            {
                case 1:
                    Console.WriteLine("Skriv in det nya namnet på {0}", valdVara.Namn);
                    valdVara.Namn = Console.ReadLine();
                    Console.WriteLine("Namnet ändrat till {0}", valdVara.Namn);
                    Console.ReadKey();
                    break;
                case 2:
                    Console.WriteLine("Skriv in det nya priset för {0}", valdVara.Namn);
                    string input = Console.ReadLine();

                    int helTal;

                    while (Int32.TryParse(input, out helTal) == false || helTal <= 0)
                    {
                        Console.Write("Det nya priset måste bestå av ett positivt heltal. Försök igen: ");
                        input = Console.ReadLine();
                    }

                    valdVara.Pris = helTal;
                    Console.WriteLine("Priset ändrat till {0}", valdVara.Pris);
                    Console.ReadKey();
                    break;
                case 3:
                    Console.WriteLine("Skriv in den nya kategorin för {0}", valdVara.Namn);
                    string input2 = Console.ReadLine();

                    int helTal2;

                    while (Int32.TryParse(input2, out helTal2) == false || (helTal2 != 0 &&  helTal2 != 1))
                    {
                        Console.Write("Den nya kategorin måste vara 0 eller 1. Försök igen: ");
                        input2 = Console.ReadLine();
                    }
                    valdVara.Kategori = helTal2;
                    Console.WriteLine("Kategorin ändrad till {0}", valdVara.Kategori);
                    Console.ReadKey();
                    break;
                case 4:
                    Console.WriteLine("Skriv in det nya ID-numret på {0}", valdVara.Namn);
                    string input3 = Console.ReadLine();

                    int helTal3;

                    while (Int32.TryParse(input3, out helTal3) == false || CheckList(helTal3) == true || helTal3 < 10 || helTal3 > 99)
                    {
                        Console.Write("Det nya ID-numret måste vara ett heltal mellan 9 och 100 och får inte vara i bruk. Försök igen: ");
                        input3 = Console.ReadLine();
                    }

                    valdVara.Id = helTal3;
                    Console.WriteLine("ID-nummer ändrat till {0}", valdVara.Id);
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }

        bool CheckList(int tal) //Kollar om ett ID existerar i varulistan. Returnar i so fall true annars false. 
        {
            for (var i = 0; i < Program.varuLista.Count; i++)
            {
                if (Program.varuLista[i].Id == tal)
                {
                    valdVara = Program.varuLista[i];
                    return true;
                }
            }
            return false;
        }

        void AdminMomssats() //Körs när admin väljer att ändra momsen. Ändrar momsen till ett värde mellan 0-1.
        {
            Console.WriteLine("Den gamla momssatsen är {0}. Skriv in den nya ", Program.moms);

            string input = Console.ReadLine();
            float tal;

            while (float.TryParse(input, out tal) == false || 0.0f > tal || tal > 1.0f)
            {
                Console.Write("Koden måste bestå av ett tal mellan 0.0-1.0: ");
                input = Console.ReadLine();
            }
            Program.moms = tal;

            Console.WriteLine("Momssatsen ändrad till {0}", Program.moms);
            Console.ReadKey();
        }

        void LaggTillAnstalld() //Ger admin möjlighet att lägga till ny anställd. Ber först användaren om den info som krävs. Skapar sen en ny anställd mha SetAnstalld i Anställda.cs
        {
            Anställda ans = new Anställda();

            Console.WriteLine("Ange namn på den anställde ");
            string name = Console.ReadLine();

            Console.WriteLine("Ange hur många timmar {0} har arbetat denna månaden.", name);

            string input = Console.ReadLine();

            int workedHours;

            while (Int32.TryParse(input, out workedHours) == false || workedHours < 0)
            {
                Console.Write("Antalet måste vara 0 eller mer");
                input = Console.ReadLine();
            }

            Console.WriteLine("Arbetar {0} som Administratör eller Kassör?", name);

            bool okInput;

            string role;

            do
            {
                Console.WriteLine("Arbetar {0} som Administratör eller Kassör?", name);
                role = Console.ReadLine();

                if (role == "Administratör")
                {
                    okInput = true;
                }
                else if (role == "Kassör")
                {
                    okInput = true;
                }
                else
                {
                    okInput = false;
                    Console.WriteLine("Du måste svara antingen Administratör eller Kassör");
                }
            } while (okInput == false);

            Console.WriteLine("Vad har {0} för timlön ", name);

            string input2 = Console.ReadLine();

            int wage;

            while (Int32.TryParse(input2, out wage) == false || wage < 0)
            {
                Console.Write("Antalet måste vara 0 eller mer");
                input2 = Console.ReadLine();
            }

            ans.SetAnstalld(name, workedHours, role, wage);
        }

        void SeAnstalld() //Läser in ett namn för att sen mha metoden GetAnstalld i Anställda.cs visa information om den anställde.
        {
            Anställda ans = new Anställda();

            Console.WriteLine("Ange namn på den anställde ");
            string name = Console.ReadLine();

            while (OmNamnFinns(name) == false) //Kör metoden OmNamnFinns som returnar en bool.
            {
                Console.Write("Namnet finns ej med i databasen. Försök igen: ");
                name = Console.ReadLine();
            }

            ans.GetAnstalld(name);
        }
         
        void SparkaAnstalld() //Läser in ett namn för att sen kalla pp metoden TaBortAnstalld i Anställda.cs
        {
            Anställda ans = new Anställda();
            Console.WriteLine("Ange namn på den anställde du vill göra dig av med");
            string name = Console.ReadLine();

            while (OmNamnFinns(name) == false)
            {
                Console.Write("Namnet finns ej med i databasen. Försök igen: ");
                name = Console.ReadLine();
            }

            ans.TaBortAnstalld(name);
        }

        bool OmNamnFinns(string inNamn) //Jämför om det namn som skickas in i metoden finns i en array med de anställda som kommer från Anställda.cs Returnar true om namnet redan existerar i arrayen.
        {
            Anställda ans = new Anställda();

            foreach (string file in ans.ListaAnstallda())
            {
                if ((inNamn + ".txt") == Path.GetFileName(file)) //ans.listaAnstallda innehåller info om path till filerna. Denna metod tar bort .txt på filnamnen och jämför dom sen med inNamn.
                {
                    return true;
                }
            }

            return false;
        }
    }
}
