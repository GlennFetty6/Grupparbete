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

        private int totalPrice; //Kostnaden för alla varor. Används på kvittot. 
        private int totalAmount; // Det pris kunden kommer betala. 
        private int totalItems;

        List<Vara> customerCart = new List<Vara>();// Skapar en lista för kundvagn

        string paymentMethod;

        string input;

        public KassaForm()
        {
            InitializeComponent();
        }

        private void KassaForm_Load(object sender, EventArgs e)
        {
            NewItem();
        }

        private void buttonEnter_Click(object sender, EventArgs e)//knappen gör olika beroende på var i programmet man befinner sig. Programmet återkommer hit varje gång input krävs. 
        {
            txtboxCommand.Clear();
            ShowCartContent();

            input = textBox2.Text;

            if (active == false)
            {
                if (state == 1) // Frågar efter varaID
                {
                    CheckVaraId(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 2) // Om grönsak - fråga vikt
                {
                    VaraVikt(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 3) // Fråga antal
                {
                    VaraAntal(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 5) // Fråga om kupong
                {
                    Kupong(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 6) // Drar av värde av kupong från priset
                {
                    KupongMatte(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 7) // Betalning
                {
                    Betalning(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 8) // Kalkylerar växel
                {
                    CalcChange(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 9) // Köpet avslutat - Väntar på knapptryck
                {
                    input = null;
                    textBox2.Text = null;
                }
            }
        }

        private void NewItem() //Körs vid ny vara. 
        {
            state = 1;
            txtboxCommand.Text = "Id-number " + Environment.NewLine;
        }

        private void CheckVaraId(string inp) //Kollar så att id finns. 
        {
            active = true;

            int helTal;

            if (Int32.TryParse(inp, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                textBox2.Text = null;
                richTextBox2.Text += "Id-number is incorrect. Please try again!" + Environment.NewLine;
                txtboxCommand.Text = "Id-number " + Environment.NewLine;
                active = false;
            }

            else
            {
                richTextBox2.Text += "Selected item: " + valdVara.Namn + Environment.NewLine;
                VaraID(); // Metodanrop av VaraID
                helTal = 0;
            }
        }

        private void VaraID() //Kontrollerar kategori för att sen fråga om vikt eller antal. 
        {
            if (valdVara.Kategori == 1)
            {
                txtboxCommand.Text = "Weight in kg " + Environment.NewLine;
                state = 2;
                active = false;
            }

            if (valdVara.Kategori == 0)
            {
                state = 3;
                txtboxCommand.Text = "Quantity " + Environment.NewLine;
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
                    txtboxCommand.Text = "Quantity " + Environment.NewLine;
                    textBox2.Text = null;
                    richTextBox2.Text += "Number is not valid. Please try again!" + Environment.NewLine;
                    active = false;
                }

                else if (valdVara.LagerStatus == 0)
                {
                    textBox2.Text = null;
                    richTextBox2.Text += "The item is sold out." + Environment.NewLine;
                    active = false;
                    state = 1;
                }
                else if (antal > valdVara.LagerStatus)
                {
                    txtboxCommand.Text = "Quantity " + Environment.NewLine;
                    textBox2.Text = null;
                    richTextBox2.Text += "Sorry, there are only " + valdVara.LagerStatus + " " + valdVara.Namn + " left." + Environment.NewLine;
                    active = false;
                }
                else
                {
                    richTextBox2.Text += inp + " " + valdVara.Namn + " are added to the cart." + Environment.NewLine;
                    valdVara.LagerStatus -= antal;
                    valdVara.Antal = antal;
                    kostnad = antal * valdVara.Pris;
                    totalPrice += kostnad;
                    totalAmount += kostnad;
                    customerCart.Add(valdVara); // Lägger i vald vara i kundvagnen
                                                //  okInput = true;
                    active = false;
                    state = 1;
                    NewItem();

                    ShowCartContent();
                }
            }
        }

        private void VaraVikt(string inp) //Kollar så att antalet varor finns i lager etc. 
        {
            int vikt = 0;
            int kostnad = 0;


            if (Int32.TryParse(inp, out vikt) == false || vikt <= 0)
            {
                txtboxCommand.Text = "Weight in kg " + Environment.NewLine;
                textBox2.Text = null;
                richTextBox2.Text += "Number is not valid. Please try again." + Environment.NewLine;
                active = false;
            }

            else if (valdVara.LagerStatus == 0)
            {
                textBox2.Text = null;
                richTextBox2.Text += "The item is sold out." + Environment.NewLine;
                active = false;
                state = 1;
                NewItem();
            }

            else if (vikt > valdVara.LagerStatus)
            {
                txtboxCommand.Text = "Weight in kg " + Environment.NewLine;
                textBox2.Text = null;
                richTextBox2.Text += "Sorry, there are only " + valdVara.LagerStatus + " " + valdVara.Namn + " left." + Environment.NewLine;
                active = false;
            }

            else
            {
                valdVara.LagerStatus -= vikt;
                valdVara.Antal = vikt;
                kostnad = vikt * valdVara.Pris;
                totalPrice += kostnad;
                totalAmount += kostnad;
                richTextBox2.Text += vikt + "kg " + valdVara.Namn + " costs " + kostnad + "SEK" + Environment.NewLine;
                customerCart.Add(valdVara); // Lägger i vald vara i kundvagnen
                active = false;
                state = 1;
                NewItem();
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

        private void Kupong(string inp)
        {
            if (inp == "y")
            {
                richTextBox2.Text += "Amount to pay: " + totalAmount + Environment.NewLine;
                txtboxCommand.Text = "Coupon amount " + Environment.NewLine;
                state = 6;
            }

            else if (inp == "n")
            {
                richTextBox2.Text += "Amount to pay: " + totalAmount + Environment.NewLine;
                txtboxCommand.Text = "Cash or card";
                state = 7;
            }

            else
            {
                txtboxCommand.Text = "Coupon-Yes/No " + Environment.NewLine;
                richTextBox2.Text += "Invalid input. Press yes or no." + Environment.NewLine;
            }
        }

        private void KupongMatte(string inp)
        {
            int total;

            if (Int32.TryParse(inp, out total) == false || total <= 0)
            {
                textBox2.Text = null;
                txtboxCommand.Text = "Coupon amount ";
                active = false;
            }

            totalAmount -= total;

            if (totalAmount <= 0)
            {
                totalAmount = 0;
                richTextBox2.Text += "The coupon covered the costs." + Environment.NewLine;
                paymentMethod = "coupon";
                PrintReciept();
            }
            else
            {
                richTextBox2.Text += "Amount left to pay: " + totalAmount + Environment.NewLine;

                txtboxCommand.Text = "Cash or card ";
                state = 7;
            }
        }

        void Betalning(string inp)
        {
            paymentMethod = inp;

            if (inp == "cash")
            {
                txtboxCommand.Text = "Cash amount " + Environment.NewLine;
                state = 8;
            }
            else if (inp == "card")
            {
                txtboxCommand.Text = "Card amount " + Environment.NewLine;
                state = 8;
            }
            else
            {
                txtboxCommand.Text = "Cash or card ";
            }
        }

        void CalcChange(string inp)
        {
            int betalt;

            if (Int32.TryParse(inp, out betalt) == false || betalt <= 0 || betalt < totalAmount)
            {
                totalAmount -= betalt;
                richTextBox2.Text += "The amount was not enough. " + Environment.NewLine;
                richTextBox2.Text += "Amount left to pay: " + totalAmount + Environment.NewLine;
                txtboxCommand.Text = "Cash or card ";
                state = 7;
                return;
            }

            float växel = betalt - totalAmount;

            richTextBox2.Text += växel + " SEK in change." + Environment.NewLine;

            PrintReciept();
        }

        string KategoriTyp(int k)
        {
            if (k == 1)
            {
                return "vegetable";
            }
            else
            {
                return "general";
            }
        }

        void RapportVaror()
        {
            string rapport = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(rapport + "\\Rapport\\");

            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalPris.txt", true))
            {
                writer.WriteLine(totalPrice);
            }
            using (StreamWriter writer = new StreamWriter(rapport + "\\Rapport\\TotalaVaror.txt", true))
            {
                writer.WriteLine(totalItems);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Tar bort äldsta raden text så att nyaste raden text får plats i textboxen. 
        {
            if (richTextBox2.Lines.Length > 20)
            {
                richTextBox2.Lines = richTextBox2.Lines.Skip(1).ToArray();
            }
        }

        private void ShowCartContent()
        {
            int nr = 0;
            textBox3.Text = null;
            const string format = "{0,-10} {1,-12} {2,0}";
            textBox3.Text += (String.Format(format, "Name", "Quantity", "Price")) + Environment.NewLine;
            textBox3.Text += "----------------------------------" + Environment.NewLine;
            foreach (Vara v in customerCart)
            {
                textBox3.Text += (String.Format(format, v.Namn, v.Antal, v.Pris)) + Environment.NewLine;
                nr += v.Antal;
            }
            textBox3.Text += "----------------------------------" + Environment.NewLine;
            textBox3.Text += (String.Format(format, "Total:", nr, totalPrice));
        }

        private void recieptRichTextBox_MouseClick(object sender, MouseEventArgs e) // Nollställer och gömmer kvittot
        {
            richTextBox2.Clear();
            recieptRichTextBox.Clear();
            textBox3.Text = null;
            recieptRichTextBox.Hide();
        }

        private void txtboxCommand_TextChanged(object sender, EventArgs e) // Kommando textboxen
        {
            txtboxCommand.ReadOnly = true;
        }
        private void KassaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }
        void PrintReciept()
        {
            recieptRichTextBox.Show();
            const string format = "{0,-10} {1,-10} {2,-10} {3, 5} {4, 7}";
            recieptRichTextBox.Text += Environment.NewLine;
            recieptRichTextBox.Text += "\t" + (String.Format(format, "Quantity", "Name", "Category", "Price", "Total")) + Environment.NewLine;
            recieptRichTextBox.ForeColor = Color.MidnightBlue;
            foreach (Vara nr in customerCart)
            {
                int priceTotal = nr.Antal * nr.Pris;
                recieptRichTextBox.Text += "\t" + (String.Format(format, nr.Antal, nr.Namn, KategoriTyp(nr.Kategori), nr.Pris, priceTotal)) + Environment.NewLine;
                totalItems += nr.Antal;
            }
            recieptRichTextBox.Text += Environment.NewLine;
            float woutTax = totalPrice * Inloggning.moms;
            float tax = Inloggning.moms * 100;
            recieptRichTextBox.Text += "\t" + "Tax " + tax + "%: " + woutTax + Environment.NewLine;
            recieptRichTextBox.Text += "\t" + "Pay method: " + paymentMethod + Environment.NewLine;
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            recieptRichTextBox.Text += "\t" + "Receiptnumber: " + nr1 + Environment.NewLine;
            recieptRichTextBox.Text += "\t" + DateTime.Now + Environment.NewLine;

            RapportVaror();

            totalAmount = 0; //Måste nollställa värden för att inte få med föregående kunds varor på nästa kunds kvitto. 
            totalPrice = 0;
            totalItems = 0;

            customerCart.Clear();

            state = 9;
        }

        //###################################################### KNAPP KOD #######################################################
        private void button1_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus(); // Tabbar till Enter
            textBox2.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "0";
        }
        private void button00_Click(object sender, EventArgs e)
        {
            buttonEnter.Focus();
            textBox2.Text += "00";
        }


        private void buttonCard_Click(object sender, EventArgs e)
        {
            textBox2.Text = "card";
            buttonEnter_Click(sender, e);
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
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
        private void buttonClear_Click(object sender, EventArgs e) // Rensar input textboxen
        {
            textBox2.Clear();
        }
        private void btnPay_Click(object sender, EventArgs e) // Betalningsknapp
        {
            txtboxCommand.Text = "Coupon-Yes/No" + Environment.NewLine;
            state = 5;
        }

        private void btnNewCustomer_Click(object sender, EventArgs e) // Ny kund-knapp
        {
            if (totalPrice == 0)
            {
                richTextBox2.Clear();
                NewItem();
            }
            else
            {
                MessageBox.Show("Please complete the ongoing purchase...");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (totalPrice == 0)
            {
                richTextBox2.Text += "You will now return to login.";
                Hide();
                Inloggning.FormLogIn();
            }
            else
            {
                MessageBox.Show("Please complete the purchase before signing out.");
            }
        }
        //###################################################### KNAPP KOD SLUT #######################################################
    }
}
