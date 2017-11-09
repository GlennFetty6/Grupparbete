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
                Inloggning.varuLista.Add(new Vara("mjölk", 12, 0, 22, 10, 0));
                Inloggning.varuLista.Add(new Vara("kaffe", 40, 0, 33, 10, 0));
                Inloggning.varuLista.Add(new Vara("korv", 30, 0, 44, 10, 0));
                Inloggning.varuLista.Add(new Vara("ägg", 22, 0, 55, 10, 0));
                Inloggning.varuLista.Add(new Vara("tomater", 23, 1, 66, 10, 0));
        }
    }
}
