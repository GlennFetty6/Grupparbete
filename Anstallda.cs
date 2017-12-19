﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DigitCashier
{
    class Anstallda
    {
        string malMapp = AppDomain.CurrentDomain.BaseDirectory; //Tar fram den mapp .exe körs ifrån. På det viset vi kör programmet är denna map debug.

        public void LaggTillExempelAnstallda() //Skapar filer åt våra anställda
        {
            Directory.CreateDirectory(malMapp + "\\Anstallda\\"); //Skapar mappen där våra filer lägger sig.             
            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\Sara.txt", false)) //Skapar en fil för Sara i Anstalla mappen. Innehåller info om namn, arbetade timmar, befattning och timlön. 
            {
                writer.WriteLine("Sara");
                writer.WriteLine("140");
                writer.WriteLine("Cashier");
                writer.WriteLine("119");
            }

            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\Arnold.txt", false)) //Skapar en fil för Arnold i Anstalla mappen. Innehåller info om namn, arbetade timmar, befattning och timlön. 
            {
                writer.WriteLine("Arnold");
                writer.WriteLine("168");
                writer.WriteLine("Admin");
                writer.WriteLine("170");
            }
        }

        public void VisaAnstalld(string namn) //Kallas från Administrator.cs. Skriver ut info från den fil med samma namn som variabeln "namn".
        {
            using (StreamReader reader = new StreamReader(malMapp + "\\Anstallda\\" + namn + ".txt")) // Läser upp informationen om den angivna anställda.
            {
                string anstalldNamn = reader.ReadLine();
                int arbTimmar = Int32.Parse(reader.ReadLine());
                string befattning = reader.ReadLine();
                int lon = Int32.Parse(reader.ReadLine());
                Console.WriteLine("Namn: {0}", anstalldNamn);
                Console.WriteLine("Arbetade timmar: {0}h", arbTimmar);
                Console.WriteLine("Befattning: {0}", befattning);
                Console.WriteLine("Lön: {0}kr", lon);
            }
        }

        public void ModifieraAnstalld(string namn, float arbTimmar, string befattning, float lon) //Anropas från Administrator.cs. Används för att både ändra på och lägga till anställda.
        {
            using (StreamWriter writer = new StreamWriter(malMapp + "\\Anstallda\\" + namn + ".txt", false)) //Sparar över/skapar .txt i mappen Anstallda. 
            {
                writer.WriteLine(namn);
                writer.WriteLine(arbTimmar);
                writer.WriteLine(befattning);
                writer.WriteLine(lon);
                Console.WriteLine("Uppdaterad information om den anställde:");
            }
        }

        public void TaBortAnstalld(string namn) //Tar bort den fil med samma namn som "namn" i mappen Anstallda. 
        {
            File.Delete(malMapp + "\\Anstallda\\" + namn + ".txt");
            Console.WriteLine("{0} är sparkad.", namn);
        }

        public string[] ListaAnstallda() //Skickar tillbaka en array med sökväg till samtliga anställdas filer. 
        {
            string[] anstalldLista;
            anstalldLista = Directory.GetFiles(malMapp + "\\Anstallda\\"); //Går in i mappen Anstallda för att sen spara samtliga filers sökväg i en array.
            return anstalldLista;
        }

        public void Items()
        {
            Inloggning.varuLista.Add(new Vara("milk", 12, 0, 22, 10, 0));
            Inloggning.varuLista.Add(new Vara("coffee", 40, 0, 33, 10, 0));
            Inloggning.varuLista.Add(new Vara("butter", 28, 0, 44, 10, 0));
            Inloggning.varuLista.Add(new Vara("eggs", 22, 0, 55, 10, 0));
            Inloggning.varuLista.Add(new Vara("onions", 9, 1, 66, 10, 0));
            Inloggning.varuLista.Add(new Vara("tomatoes", 19, 1, 77, 10, 0));
            Inloggning.varuLista.Add(new Vara("potatoes", 8, 1, 88, 10, 0));
        }
    }
}
