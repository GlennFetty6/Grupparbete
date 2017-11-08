using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    public class Vara
    {
        private string namn, pris, kategori, id, lagerStatus, antal;
        /*
           # Namn på varan
           # Varans styckpris   
           # Varans kategori, 0 Default. 1 Får de varor som ska vägas.
           # Varans ID-nummer. Det nummer kassan slår in.
           # Antal varor på lager.
           # Variabeln används i Kassasystem för att hålla koll på hur många av varan som ligger i kundvagnen.
       

           # Konstruktor - En speciell typ av metod som har samma namn som klassen och har inget return värde utan har synlighet (public). 
           # En speciell metod som utförs varje gång en skapar ett nytt objekt av klassen.
           # Alla klasser har en konstruktor Implicity och Explicity */
        public Vara(string namn, int pris, int kategori, int id, int lagerStatus, int antal) //Explicity-Constructor för att skapa varor. 
        {
            Namn = namn;
            Pris = pris;
            Antal = antal;
            Kategori = kategori;
            Id = id;
            LagerStatus = lagerStatus;

        }
        public string Namn
        {
            get;
            set;
        }
        public int Pris
        {
            get;
            set;
        }
        public int Antal
        {
            get;
            set;
        }
        public int Kategori
        {
            get;
            set;
        }
        public int Id
        {
            get;
            set;
        }
        public int LagerStatus
        {
            get;
            set;
        }
    }
}



