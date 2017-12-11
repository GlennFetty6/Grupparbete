using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;

namespace DigitCashier
{
  
    public partial class KassaForm : Form
    {
        private Vara valdVara;

        private bool active; //Används för att buttonEnter inte ska göra fel saker vid fel tillfälle. 
        int state; //Används för att buttonEnter inte ska göra fel saker vid fel tillfälle. 

        private int totalPris; //Kostnaden för alla varor. Används på kvittot. 
        private int totaltBelopp; // Det pris kunden kommer betala. 
        private int totalAntalVaror;

        List<Vara> kundVagn = new List<Vara>();// Skapar en lista för kundvagn

        string betalningsTyp;

        string input;

        public KassaForm()
        {
            InitializeComponent();
        }

        private void KassaForm_Load(object sender, EventArgs e)
        {
            NewVara();
        }

        private void EnterBtn_KeyDown(object sender, KeyEventArgs e) // Fungerar ej
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonEnter_Click(input, e);
            }
        }

        private void buttonEnter_Click(object sender, EventArgs e)//knappen gör olika beroende på var i programmet man befinner sig. Programmet återkommer hit varje gång input krävs. 
        {
            ShowCartContent();

            input = textBox2.Text;

            if (active == false)
            {
                if (state == 1)
                {
                    CheckVaraId(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 2)
                {
                    VaraVikt(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 3)
                {
                    VaraAntal(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 4)
                {
                    FlerVaror(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 5)
                {
                    Kupong(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 6)
                {
                    KupongMatte(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 7)
                {
                    Betalning(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 8)
                {
                    CalcChange(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 9)
                {
                    FlerKunder(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 10)
                {
                    Hide(); // AdminForm göms
                    Inloggning.FormLogIn(); // FormLogIn öppnas
                }
            }
        }

        private void NewVara() //Körs vid ny vara. 
        {
            state = 1;
            textBox1.Text += "Id-number: " + Environment.NewLine;
        }

        private void CheckVaraId(string inp) //Kollar så att id finns. 
        {
            active = true;

            int helTal;

            if (Int32.TryParse(inp, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                textBox2.Text = null;
                textBox1.Text += "Id-number is incorrect. Please try again:" + Environment.NewLine;
                active = false;
            }

            else
            {
                textBox1.Text += "Selected item: " + valdVara.Namn + Environment.NewLine;
                VaraID(); // Metodanrop av VaraID
                helTal = 0;
            }
        }

        private void VaraID() //Kontrollerar kategori för att sen fråga om vikt eller antal. 
        {
            if (valdVara.Kategori == 1)
            {
                textBox1.Text += "Weight in kg: " + Environment.NewLine;
                state = 2;
                active = false;
            }

            if (valdVara.Kategori == 0)
            {
                state = 3;
                textBox1.Text += "Quantity: " + Environment.NewLine;
                active = false;
            }
        }

        private void VaraAntal(string inp) //Kollar så att antalet varor finns i lager etc. 
        {
            int antal = 0;
            int kostnad = 0;

            {
                if (Int32.TryParse(inp, out antal) == false)
                {
                    textBox2.Text = null;
                    textBox1.Text += "Number is not valid. Please try again." + Environment.NewLine;
                    active = false;
                }

                else if (valdVara.LagerStatus == 0)
                {
                    textBox2.Text = null;
                    textBox1.Text += "The item is sold out." + Environment.NewLine;
                    active = false;
                    state = 4;

                    textBox1.Text += "More items?" + Environment.NewLine;
                }
                else if (antal > valdVara.LagerStatus)
                {
                    textBox2.Text = null;
                    textBox1.Text += "Sorry, there are only " + valdVara.LagerStatus + " " + valdVara.Namn + " left." + Environment.NewLine;
                    active = false;
                }
                else
                {
                    textBox1.Text += inp + " " + valdVara.Namn + " are added to the cart." + Environment.NewLine;
                    valdVara.LagerStatus -= antal;
                    valdVara.Antal = antal;
                    kostnad = antal * valdVara.Pris;
                    totalPris += kostnad;
                    totaltBelopp += kostnad;
                    kundVagn.Add(valdVara); // Lägger i vald vara i kundvagnen
                                            //  okInput = true;
                    active = false;
                    state = 4;

                    ShowCartContent();

                    textBox1.Text += "More items?" + Environment.NewLine;
                }
            }
        }

        private void VaraVikt(string inp) //Kollar så att antalet varor finns i lager etc. 
        {
            int vikt = 0;
            int kostnad = 0;


            if (Int32.TryParse(inp, out vikt) == false || vikt <= 0)
            {
                textBox2.Text = null;
                textBox1.Text += "Number is not valid. Please try again." + Environment.NewLine;
                active = false;
            }

            else if (valdVara.LagerStatus == 0)
            {
                textBox2.Text = null;
                textBox1.Text += "The item is sold out." + Environment.NewLine;
                active = false;
                state = 4;

                textBox1.Text += "More items?" + Environment.NewLine;
            }

            else if (vikt > valdVara.LagerStatus)
            {
                textBox2.Text = null;
                textBox1.Text += "Sorry, there are only " + valdVara.LagerStatus + " " + valdVara.Namn + " left." + Environment.NewLine;
                active = false;
            }


            else
            {
                valdVara.LagerStatus -= vikt;
                valdVara.Antal = vikt;
                kostnad = vikt * valdVara.Pris;
                totalPris += kostnad;
                totaltBelopp += kostnad;
                textBox1.Text += vikt + "kg " + valdVara.Namn + " = " + kostnad + "SEK" + Environment.NewLine;
                kundVagn.Add(valdVara); // Lägger i vald vara i kundvagnen
                active = false;
                state = 4;

                textBox1.Text += "More items?" + Environment.NewLine;
            }
        }

        bool CheckList(int tal) // Tittar så ID-numret finns med i varuListan.
        {
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

        private void FlerVaror(string inp) //Kontrollerar input för att se om kunden vill ha fler varor eller ej. 
        {
            if (inp == "y")
            {
                NewVara();
            }
            else if (inp == "n")
            {
                textBox1.Text += "Coupon?" + Environment.NewLine;
                state = 5;
            }

            else
            {
                textBox1.Text += "Incorrect input." + Environment.NewLine;
            }
        }

        private void Kupong(string inp)
        {
            if (inp == "y")
            {
                textBox1.Text += "Amount to pay: " + totaltBelopp + Environment.NewLine;
                textBox1.Text += "How much is the coupon worth? " + Environment.NewLine;
                state = 6;
            }

            else if (inp == "n")
            {
                textBox1.Text += "Amount to pay: " + totaltBelopp + Environment.NewLine;

                textBox1.Text += "Cash or card: " + Environment.NewLine;
                state = 7;
            }

            else
            {
                textBox1.Text += "Invalid input. Press yes or no." + Environment.NewLine;
            }
        }

        private void KupongMatte(string inp)
        {
            int total;

            if (Int32.TryParse(inp, out total) == false || total <= 0)
            {
                textBox2.Text = null;
                textBox1.Text += "How much is the coupon worth? " + Environment.NewLine;
                active = false;
            }

            totaltBelopp -= total;

            if (totaltBelopp <= 0)
            {
                totaltBelopp = 0;
                textBox1.Text += "The coupon covered the costs." + Environment.NewLine;
                PrintReciept();
            }
            else
            {
                textBox1.Text += "Amount left to pay: " + totaltBelopp + Environment.NewLine;

                textBox1.Text += "Cash or card: " + Environment.NewLine;
                state = 7;
            }
        }

        void Betalning(string inp)
        {
            betalningsTyp = inp;

            if (inp == "cash")
            {
                textBox1.Text += "How much did the customer pay: " + Environment.NewLine;
                state = 8;
            }
            else if (inp == "card")
            {
                textBox1.Text += "How much did the customer pay: " + Environment.NewLine;
                state = 8;
            }
            else
            {
                textBox1.Text += "Cash or card: " + Environment.NewLine;
            }
        }

        void CalcChange(string inp)
        {
            int betalt;

            if (Int32.TryParse(inp, out betalt) == false || betalt <= 0 || betalt < totaltBelopp)
            {
                totaltBelopp -= betalt;
                textBox1.Text += "The amount was not enough. " + Environment.NewLine;
                textBox1.Text += "Amount left to pay: " + totaltBelopp + Environment.NewLine;
                textBox1.Text += "Cash or card: " + Environment.NewLine;
                state = 7;
                return;
            }

            int växel = betalt - totaltBelopp;

            textBox1.Text += växel + " SEK in change." + Environment.NewLine;

            PrintReciept();
        }

        void PrintReciept()
        {
            recieptRichTextBox.Show();
            recieptRichTextBox.Text += "Reciept" + Environment.NewLine;
            recieptRichTextBox.SelectionFont = new Font("Verdana", 12);
            recieptRichTextBox.Text += Environment.NewLine + "SEWK's livs" + Environment.NewLine;
            recieptRichTextBox.Text += "Kungsgatan 37, 441 50 Alingsås" + Environment.NewLine;
            recieptRichTextBox.Text += "Org Nr: 556033-5696" + Environment.NewLine;
            recieptRichTextBox.Text += Environment.NewLine;
            recieptRichTextBox.Text += "Quantity" + "\t" + "Name" + "\t" + "Category"+ "\t" + "Price" + "\t" + "Total" + Environment.NewLine;

            foreach (Vara nr in kundVagn)
            {   
                int priceTotal = nr.Antal * nr.Pris;
                recieptRichTextBox.Text += nr.Antal + "\t" + "\t" + nr.Namn + "\t"  + KategoriTyp(nr.Kategori) + "\t" + nr.Pris + "\t" + priceTotal + Environment.NewLine;
                totalAntalVaror += nr.Antal;
            }
            recieptRichTextBox.Text += Environment.NewLine;
            float woutTax = totalPris * Inloggning.moms;
            float tax = Inloggning.moms * 100;
            recieptRichTextBox.Text += "Tax " + tax + "%: "+ woutTax + Environment.NewLine;
            recieptRichTextBox.Text += "Pay method: "+ betalningsTyp + Environment.NewLine;
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            recieptRichTextBox.Text += "Receiptnumber: " + nr1 + Environment.NewLine;
            recieptRichTextBox.Text += DateTime.Now + Environment.NewLine;

            RapportVaror();

            totaltBelopp = 0; //Måste nollställa värden för att inte få med föregående kunds varor på nästa kunds kvitto. 
            totalPris = 0;
            totalAntalVaror = 0;

            kundVagn.Clear();

            textBox1.Text += Environment.NewLine + "More customers?" + Environment.NewLine;

            state = 9;
        }

        string KategoriTyp(int k)
        {
            if (k == 1)
            {
                return "Vegetable";
            }
            else
            {
                return "General";
            }
        }

        void RapportVaror()
        {
            string rapport = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(rapport + "\\Report\\");

            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalPris.txt", true))
            {
                writer.WriteLine(totalPris);
            }
            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalaVaror.txt", true))
            {
                writer.WriteLine(totalAntalVaror);
            }
        }

        void FlerKunder(string inp)
        {
            if (inp == "y")
            {
                NewVara();
                recieptRichTextBox.Clear();
            }
            else if (inp == "n")
            {
                textBox1.Text += "You will now return to login.";
                Hide();
                Inloggning.FormLogIn();
                state = 10;
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Tar bort äldsta raden text så att nyaste raden text får plats i textboxen. 
        {

            if (textBox1.Lines.Length > 38)
            {
                textBox1.Lines = textBox1.Lines.Skip(1).ToArray();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox2.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Card" + Environment.NewLine;
            textBox2.Text = "card";
            buttonEnter_Click(sender, e);
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Cash" + Environment.NewLine;
            textBox2.Text = "cash";
            buttonEnter_Click(sender, e);
        }
        private void buttonYes_Click(object sender, EventArgs e)
        {
            textBox2.Text = "y";
            buttonEnter_Click(sender, e);
        }
        private void buttonNo_Click(object sender, EventArgs e)
        {
            textBox2.Text = "n";
            buttonEnter_Click(sender, e);
        }

        private void ShowCartContent()
        {
            int nr = 0;
            textBox3.Text = null;
            textBox3.Text += "Name" + "\t" + "\t" + "Amount" + "\t" + "Price" + Environment.NewLine;
            foreach (Vara v in kundVagn)
            {
                textBox3.Text += v.Namn + "\t" + "\t" + v.Antal + "\t" + v.Pris + Environment.NewLine;
                nr += v.Antal;
            }
            textBox3.Text += "Total amount" + "\t" + nr + "\t" + totalPris;
        }

        private void KassaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
        }
        
        private void textboxReciept_MouseClick(object sender, MouseEventArgs e)
        {
           // textboxReciept.Hide();
        }

        private void textboxReciept_KeyDown(object sender, KeyEventArgs e)
        {
           // textboxReciept.Hide();
        }

        private void recieptRichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            recieptRichTextBox.Hide();
        }
    }
}
