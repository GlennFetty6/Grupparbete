using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    public class Vara
    {
        private string namn;        //Namn på varan
        private int pris;           //Varans styckpris   
        private int kategori;       //0 Default. 1 Får de varor som ska vägas.
        private int id;             //Varans ID-nummer. Det nummer kassan slår in.
        private int lagerStatus;    //Antal varor på lager.
        private int antal;          //Variabeln används i Kassasystem för att hålla koll på hur många av varan som ligger i kundvagnen. 

        public Vara(string namn, int pris, int kategori, int id, int lagerStatus, int antal) //Constructor för att skapa varor. 
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


 
