using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    public class Vara
    {
        private string namn;
        private int pris;
        private int kategori;
        private int id;
        private int lagerStatus;
        private int antal;


        public Vara(string namn, int pris, int kategori, int id, int lagerStatus, int antal)
        {
            Namn = namn;
            Pris = pris;
            Kategori = kategori;
            Id = id;
            LagerStatus = lagerStatus;
            Antal = antal;
        }

        public int Antal
        {
            get;
            set;
        }

        public int Pris
        {
            get;
            set;
        }

        public string Namn
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


 
