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
        private Vara valdVara; //Variabel som används i AdminVaror och ModifieraVara

        public void Administration()
        {

            int input = 0;
            do
            {
                Console.WriteLine("\n----------   Välj ett alternativ  ---------");
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
                    continue; //En får upp menyn igen och får ett nytt försök.
                }

                switch (input)
                {
                    case 1:
                        AdminAnstallda();
                        break;
                    case 2:
                        AdminVaror();
                        break;
                    case 3:
                        ModifieraMomssats();
                        break;
                    case 0:
                        Console.WriteLine("Du loggas nu ut som Admin och återvänder till inloggingen.\n");
                        Inloggning.FormLogIn();
                        break;
                    default: // Meddelande kommer upp om input är ett nummer utanför det tillåtna 0-4.
                        Console.WriteLine("Inkorrekt nummer. Välj ett nummer i menyn.");
                        break;
                }
            } while (huvudMeny || input != 0);
        }

        public void FormAdmin() /*******************************************************************************************************/
        {
            AdminForm af = new AdminForm();
            af.ShowDialog();
        }

        void AdminAnstallda()
        {
            int input = 0;
            do
            {
                Console.WriteLine("\n----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Lägg till ny anställd            -");
                Console.WriteLine("-       2 Ändra anställd info              -");
                Console.WriteLine("-       3 Se info om anställd              -");
                Console.WriteLine("-       4 Ta bort anställd                 -");
                Console.WriteLine("-       0 Tillbaka till huvudmenyn         -");
                Console.WriteLine("-------------------------------------------\n");

                try //Kontrollerar att inmatning är av typen interger.
                {
                    input = int.Parse(Console.ReadLine());
                    huvudMeny = false;
                }
                catch
                {
                    Console.WriteLine("Välj ett nummer i menyn.");
                    continue;
                }

                switch (input)
                {
                    case 1:
                        NyAnstalld();
                        break;
                    case 2:
                        ModifieraAnstalld();
                        break;
                    case 3:
                        SeAnstalld();
                        break;
                    case 4:
                        SparkaAnstalld();
                        break;
                    case 0:
                        Console.WriteLine("Tillbaka till huvudmenyn.");
                        break;
                    default: // Meddelande kommer upp om input är ett nummer utanför det tillåtna 0-4.
                        Console.WriteLine("Inkorrekt nummer. Välj ett nummer i menyn.");
                        break;
                }
            } while (huvudMeny || input != 0);

        }

        void ModifieraAnstalld()
        {
            Anstallda anst = new Anstallda();

            Console.Write("Ange namn på den nuvarande anställde: ");
            string namn = Console.ReadLine();

            while (OmNamnFinns(namn) == false)
            {
                Console.Write("Namnet finns ej med i databasen. Försök igen: ");
                namn = Console.ReadLine();
            }

            anst.VisaAnstalld(namn);

            Console.Write("Ändra antalet arbetade timmar för månaden: ");
            string input = Console.ReadLine();
            int arbetadeTim;

            while (Int32.TryParse(input, out arbetadeTim) == false || arbetadeTim < 0)
            {
                Console.Write("Antalet måste vara 0 eller mer. Försök igen: ");
                input = Console.ReadLine();
            }

            bool okInput;
            string arbRoll;

            do
            {
                Console.Write("Ange vilken befattning {0} har, Administratör eller Kassör: ", namn);
                arbRoll = Console.ReadLine();

                if (arbRoll == "Administratör")
                {
                    okInput = true;
                }
                else if (arbRoll == "Kassör")
                {
                    okInput = true;
                }
                else
                {
                    okInput = false;
                    Console.WriteLine("Du måste svara antingen Administratör eller Kassör.");
                }
            } while (okInput == false);

            Console.Write("Ange ny timlön: ");
            string input2 = Console.ReadLine();
            int inkomst;

            while (Int32.TryParse(input2, out inkomst) == false || inkomst < 0)
            {
                Console.Write("Antalet måste vara 0 eller mer: ");
                input2 = Console.ReadLine();
            }

            anst.ModifieraAnstalld(namn, arbetadeTim, arbRoll, inkomst);
            anst.VisaAnstalld(namn);// Visar anställd

        }

        void NyAnstalld() //Ger admin möjlighet att lägga till ny anställd. Ber först användaren om den info som krävs. Skapar sen en ny anställd mha SetAnstalld i Anställda.cs
        {
            Anstallda anst = new Anstallda(); //Skapar ett objekt av klassen Anställda

            Console.Write("Ange namn på den nya anställde: ");
            string namn = Console.ReadLine();

            Console.Write("Ange hur många timmar {0} har arbetat denna månaden: ", namn);
            string input = Console.ReadLine();

            int arbetadeTim;

            while (Int32.TryParse(input, out arbetadeTim) == false || arbetadeTim < 0)
            {
                Console.Write("Antalet måste vara 0 eller mer. Försök igen: ");
                input = Console.ReadLine();
            }

            bool okInput;
            string arbRoll;

            do
            {
                Console.Write("Vilken befattning har {0}, Administratör eller Kassör: ", namn);
                arbRoll = Console.ReadLine();

                if (arbRoll == "Administratör")
                {
                    okInput = true;
                }
                else if (arbRoll == "Kassör")
                {
                    okInput = true;
                }
                else
                {
                    Console.WriteLine("Du måste välja på antingen Administratör eller Kassör.");
                    okInput = false;
                }
            } while (okInput == false);

            Console.Write("Vad har {0} för timlön: ", namn);
            string input2 = Console.ReadLine();

            int inkomst;

            while (Int32.TryParse(input2, out inkomst) == false || inkomst < 0)
            {
                Console.Write("Antalet måste vara 0 eller mer. Försök igen: ");
                input2 = Console.ReadLine();
            }
            anst.ModifieraAnstalld(namn, arbetadeTim, arbRoll, inkomst);
            anst.VisaAnstalld(namn);// Visar anställd
        }

        void SeAnstalld() //Läser in ett namn för att sen mha metoden SeAnstalld i Anstallda.cs visa information om den anställde.
        {
            Anstallda anst = new Anstallda();

            Console.Write("Ange namn på den anställde: ");
            string namn = Console.ReadLine();

            while (OmNamnFinns(namn) == false)
            {
                Console.Write("Namnet finns ej med i databasen. Försök igen: ");
                namn = Console.ReadLine();
            }

            anst.VisaAnstalld(namn);
        }

        void SparkaAnstalld() //Läser in ett namn för att sen anropa metoden TaBortAnstalld i Anställda.cs
        {
            Anstallda anst = new Anstallda();
            Console.Write("Ange namn på den anställde du vill göra dig av med: ");
            string namn = Console.ReadLine();

            while (OmNamnFinns(namn) == false)
            {
                Console.Write("Namnet finns ej med i databasen. Försök igen: ");
                namn = Console.ReadLine();
            }

            anst.TaBortAnstalld(namn);
        }

        bool OmNamnFinns(string inNamn) //Jämför om det namn som skickas in i metoden finns i en array med de anställda som kommer från Anställda.cs Returnar true om namnet existerar i arrayen.
        {
            Anstallda anst = new Anstallda();

            foreach (string fil in anst.ListaAnstallda())
            {
                if ((inNamn + ".txt") == Path.GetFileName(fil)) //ans.listaAnstallda innehåller info om path till filerna. Denna metod hittar namnet på filen så att vi kan jämföra det med inNamn.
                {
                    return true;
                }
            }

            return false;
        }

        void AdminVaror() //Menymetod för hantering av varor när man är inloggad som admin. 
        {
            int input = 0;
            do
            {
                Console.WriteLine("\n----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Lägg till vara                    -");
                Console.WriteLine("-       2 Ändra vara                        -");
                Console.WriteLine("-       3 Skriv ut prislapp                 -");
                Console.WriteLine("-       0 Tillbaka till huvudmenyn          -");
                Console.WriteLine("-------------------------------------------\n");

                try //Kontrollerar att inmatning är av typen integer.
                {
                    input = int.Parse(Console.ReadLine());
                    huvudMeny = false;
                }
                catch
                {
                    Console.WriteLine("Välj ett nummer i menyn.");
                    continue;
                }

                switch (input)
                {
                    case 1:
                        LaggTillVara();
                        break;
                    case 2:
                        ModifieraVara();
                        break;
                    case 3:
                        SkrivUtPrisLapp();
                        break;
                    case 0:
                        Console.WriteLine("Tillbaka till huvudmenyn.");
                        break;
                    default: // Meddelande kommer upp om input är ett nummer utanför det tillåtna 0-4.
                        Console.WriteLine("Inkorrekt nummer. Välj ett nummer i menyn.");
                        break;
                }
            } while (huvudMeny || input != 0);
        }

        void LaggTillVara() //Används för att lägga till varor i varuListan. 
        {                   //Samlar först den data som behövs för att därefter köra konstruktorn i Vara.cs och lägga till objektet som skapas i varulistan.
            Console.Write("Ange namnet på den vara du vill lägga till: ");
            string namn = Console.ReadLine();

            Console.Write("Ange pris: ");
            string input = Console.ReadLine();

            int pris;

            while (Int32.TryParse(input, out pris) == false || pris <= 0)
            {
                Console.Write("Priset måste bestå av ett positivt heltal. Försök igen: ");
                input = Console.ReadLine();
            }

            Console.Write("Ange kategori 0 för Matvara, 1 för Grönsak):");
            string input2 = Console.ReadLine();

            int kategori;

            while (Int32.TryParse(input2, out kategori) == false || (kategori != 0 && kategori != 1))
            {
                Console.Write("Den nya kategorin måste vara 0 eller 1. Försök igen: ");
                input2 = Console.ReadLine();//Skriver över förra försökets input
            }

            Console.Write("Ange ID-nummer: ");
            string input3 = Console.ReadLine();

            int idNr;

            while (Int32.TryParse(input3, out idNr) == false || CheckList(idNr) == true || idNr < 10 || idNr > 99)
            {
                Console.Write("Det nya ID-numret måste vara ett heltal mellan 9 och 100 och får inte vara i bruk. Försök igen: ");
                input3 = Console.ReadLine();
            }

            Console.Write("Ange lagerstatus på varan: ");
            string input4 = Console.ReadLine();

            int lagerAntal;

            while (Int32.TryParse(input4, out lagerAntal) == false || lagerAntal < 0)
            {
                Console.Write("Antalet på lager måste vara 0 eller mer. Försök igen: ");
                input4 = Console.ReadLine();
            }

            Inloggning.varuLista.Add(new Vara(namn, pris, kategori, idNr, lagerAntal, 0));// Ny vara läggs till i varuLista
            Console.WriteLine("Varan {0} är nu tillagd i systemet.", namn);
        }

        void ModifieraVara()
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

            Console.Write("Vilken förändring vill du göra på vald vara? ");

            int input2 = 0;

            do
            {
                Console.WriteLine("\n----------   Välj ett alternativ  ---------");
                Console.WriteLine("-       1 Namn                            -");
                Console.WriteLine("-       2 Pris                            -");
                Console.WriteLine("-       3 Kategori                        -");
                Console.WriteLine("-       4 Id                              -");
                Console.WriteLine("-       0 Tillbaka till huvudmenyn        -");
                Console.WriteLine("-------------------------------------------\n");

                try //Kontrollerar att inmatning är av typen interger.
                {
                    input2 = int.Parse(Console.ReadLine());
                    varuMeny = false;
                }
                catch
                {
                    Console.WriteLine("Välj ett nummer i menyn.");
                    continue;
                }

                switch (input2)
                {
                    case 1:
                        ModifieraValdVara(input2);
                        break;
                    case 2:
                        ModifieraValdVara(input2);
                        break;
                    case 3:
                        ModifieraValdVara(input2);
                        break;
                    case 4:
                        ModifieraValdVara(input2);
                        break;
                    case 0:
                        Console.WriteLine("Du loggas nu ut.");
                        Administration();
                        break;
                    default: // Meddelande kommer upp om input är ett nummer utanför det tillåtna 0-4.
                        Console.WriteLine("Inkorrekt nummer. Välj ett nummer i menyn.");
                        break;
                }
            } while (varuMeny || input2 != 0);

            Console.ReadKey();
        }

        void ModifieraValdVara(int nr) //Orienterar sig mha av inkommande int och ger sen användaren möjlighet att ändra vald variabel. 
        {
            switch (nr)
            {
                case 1:
                    Console.Write("Skriv in det nya namnet på {0}: ", valdVara.Namn);
                    valdVara.Namn = Console.ReadLine();
                    Console.WriteLine("Namnet ändrat till {0}", valdVara.Namn);
                    break;
                case 2:
                    Console.Write("Skriv in det nya priset för {0}: ", valdVara.Namn);
                    string input = Console.ReadLine();

                    int helTal;

                    while (Int32.TryParse(input, out helTal) == false || helTal <= 0)
                    {
                        Console.Write("Det nya priset måste bestå av ett positivt heltal. Försök igen: ");
                        input = Console.ReadLine();
                    }

                    valdVara.Pris = helTal;
                    Console.WriteLine("Priset ändrat till {0}kr", valdVara.Pris);
                    break;
                case 3:
                    Console.Write("Skriv in den nya kategorin för {0}, 0 för Matvara och 1 för Grönsak: ", valdVara.Namn);
                    string input2 = Console.ReadLine();

                    int helTal2;

                    while (Int32.TryParse(input2, out helTal2) == false || (helTal2 != 0 && helTal2 != 1))
                    {
                        Console.Write("Den nya kategorin måste vara 0 eller 1. Försök igen: ");
                        input2 = Console.ReadLine();
                    }
                    valdVara.Kategori = helTal2;
                    Console.WriteLine("Kategorin ändrad till {0}", valdVara.Kategori);
                    break;
                case 4:
                    Console.Write("Skriv in det nya ID-numret på {0}: ", valdVara.Namn);
                    string input3 = Console.ReadLine();

                    int helTal3;

                    while (Int32.TryParse(input3, out helTal3) == false || CheckList(helTal3) == true || helTal3 < 10 || helTal3 > 99)
                    {
                        Console.Write("Det nya ID-numret måste vara ett heltal mellan 9 och 100 och får inte vara i bruk. Försök igen: ");
                        input3 = Console.ReadLine();
                    }
                    valdVara.Id = helTal3;// ID på valdVara ändras till värdet av helTal3
                    Console.WriteLine("ID-nummer ändrat till {0}", valdVara.Id);
                    break;
                default:
                    break;
            }
        }

        bool CheckList(int tal) // Loopar igenom listan i Inloggning.varuLista för att kontrollera att ID-numret inte redan är taget.
        {                       //Kollar om ett ID existerar i varulistan. Returnar i so fall true annars false. 
            for (var i = 0; i < Inloggning.varuLista.Count; i++)
            {
                if (Inloggning.varuLista[i].Id == tal)
                {
                    valdVara = Inloggning.varuLista[i];
                    return true;
                }
            }
            return false;
        }

        void SkrivUtPrisLapp()
        {
            Console.Write("Skriv in varans Id-nummer: ");
            string input = Console.ReadLine();
            int helTal;

            while (Int32.TryParse(input, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                Console.Write("Koden måste bestå av ett giltigt tvåsiffrigt heltal. Försök igen: ");
                input = Console.ReadLine();
            }
            helTal = 0;

            if (valdVara.Kategori == 0)
            {
                Console.WriteLine("\n {0}: {1}kr/paket ", valdVara.Namn, valdVara.Pris);
            }
            else
            {
                Console.WriteLine("\n {0}: {1}kr/kg ", valdVara.Namn, valdVara.Pris);
            }

        }

        void ModifieraMomssats()  //Körs när admin väljer att ändra momsen. Ändrar momsen till ett värde mellan 0-1.
        {
            Console.Write("Momssatsen är {0}. Ange önskad momssatsen: ", Inloggning.moms);//Hämtar momssatsen från Inloggning.moms.

            string input = Console.ReadLine();
            float tal;

            while (float.TryParse(input, out tal) == false || 0.0f > tal || tal > 1.0f)// Kontrollerar så input är korrekt
            {
                Console.Write("Koden måste bestå av ett tal mellan 0.0-1.0: ");
                input = Console.ReadLine();
            }
            Inloggning.moms = tal;//Momsen får ett nytt värde

            Console.WriteLine("Momssatsen ändrad till {0}", Inloggning.moms);
        }
    }
}
