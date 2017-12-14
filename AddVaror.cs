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
