using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitCashier
{
    class AddVaror //Skapade klass där jag la AddVaror metoden. Den jävlades bara i Program.cs
    { 
        public void AddVaror2() //Fick ej heta samma som klass
        {
                Program.varuLista.Add(new Vara("Mjölk", 15, 0, 22, 10, 0));
                Program.varuLista.Add(new Vara("Kaffe", 45, 0, 33, 10, 0));
                Program.varuLista.Add(new Vara("Korv", 30, 0, 44, 10, 0));
                Program.varuLista.Add(new Vara("Ägg", 22, 0, 55, 10, 0));
                Program.varuLista.Add(new Vara("Tomater", 6, 1, 66, 10, 0));
        }
    }
}
