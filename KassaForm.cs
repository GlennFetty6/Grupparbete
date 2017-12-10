using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;

namespace DigitCashier
{
    public partial class KassaForm : Form
    {
        private Vara valdVara;

        private bool active; //Används för att button15 inte ska göra fel saker vid fel tillfälle. 
        int state; //Används för att button15 inte ska göra fel saker vid fel tillfälle. 

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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void EnterBtn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button15_Click(sender, e);
            }
        }

        private void button15_Click(object sender, EventArgs e) //knappen gör olika beroende på var i programmet man befinner sig. Programmet återkommer hit varje gång input krävs. 
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
                    Inloggning.FormLogIn();
                }
            }
        }

        private void NewVara() //Körs vid ny vara. 
        {
            state = 1;
            textBox1.Text += "Skriv in varans ID-nummer: " + Environment.NewLine;
        }

        private void CheckVaraId(string inp) //Kollar så att id finns. 
        {
            active = true;

            int helTal;

            if (Int32.TryParse(inp, out helTal) == false || helTal.ToString().Length != 2 || CheckList(helTal) == false)
            {
                textBox2.Text = null;
                textBox1.Text += "Koden måste bestå av ett giltigt tvåsiffrigt heltal. Försök igen: " + Environment.NewLine;
                active = false;
            }

            else
            {
                textBox1.Text += "Vald vara är " + valdVara.Namn + Environment.NewLine;
                VaraID(); // Metodanrop av VaraID
                helTal = 0;
            }

   
        }

        private void VaraID() //Kontrollerar kategori för att sen fråga om vikt eller antal. 
        {

            if (valdVara.Kategori == 1)
            {
            textBox1.Text += "Ange varans vikt i kilogram: " + Environment.NewLine;
            state = 2;
            active = false;
            }

            if (valdVara.Kategori == 0)
            {
            state = 3;
            textBox1.Text += "Ange antal av varan " + Environment.NewLine;
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
                    textBox1.Text += "Koden måste bestå av ett giltigt heltal." + Environment.NewLine;
                    active = false;
                }

                else if (valdVara.LagerStatus == 0)
                {
                    textBox2.Text = null;
                    textBox1.Text += "Varan är tyvärr slut." + Environment.NewLine;
                    active = false;
                    state = 4;

                    textBox1.Text += "Fler varor? j/n " + Environment.NewLine;
                }
                else if (antal > valdVara.LagerStatus)
                {
                    textBox2.Text = null;
                    textBox1.Text += "För stort antal. Det finns bara" + valdVara.LagerStatus + "st " + valdVara.Namn + "kvar" + Environment.NewLine;
                    active = false;
                }
                else
                {
                    textBox1.Text += inp + "paket" + valdVara.Namn + "är tillagd i kundvagnen" + Environment.NewLine;
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

                    textBox1.Text += "Fler varor? j/n " + Environment.NewLine;
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
                    textBox1.Text += "Koden måste bestå av ett giltigt heltal." + Environment.NewLine;
                active = false;
                }

                else if (valdVara.LagerStatus == 0)
                {
                    textBox2.Text = null;
                    textBox1.Text += "Varan är tyvärr slut." + Environment.NewLine;
                active = false;
                state = 4;

                textBox1.Text += "Fler varor? j/n " + Environment.NewLine;
            }

                else if (vikt > valdVara.LagerStatus)
                {
                    textBox2.Text = null;
                    textBox1.Text += "För stort antal. Det finns bara" + valdVara.LagerStatus + "kg " + valdVara.Namn + "kvar" + Environment.NewLine;
                active = false;
            }


                else
                {
                    valdVara.LagerStatus -= vikt;
                    valdVara.Antal = vikt;
                    kostnad = vikt * valdVara.Pris;
                    totalPris += kostnad;
                    totaltBelopp += kostnad;
                    textBox1.Text += vikt + "kg " + valdVara.Namn + " " + kostnad + "kr" + Environment.NewLine;
                    kundVagn.Add(valdVara); // Lägger i vald vara i kundvagnen
                active = false;
                state = 4;

                textBox1.Text += "Fler varor? j/n " + Environment.NewLine;
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
            if(inp == "j")
            {
                NewVara();
            }
            else if (inp == "n")
            {
                textBox1.Text += "Har kunden någon kupong? j/n: " + Environment.NewLine;
                state = 5;
            }

            else
            {
                textBox1.Text += "Du kan endast svara j eller n " + Environment.NewLine;
            }
        }

        private void Kupong(string inp)
        {
            if (inp == "j")
            {
                textBox1.Text += "Hur mycket är kupongen värd? " + Environment.NewLine;
                state = 6;
            }

            else if (inp == "n")
            {
                textBox1.Text += "Belopp att betala: " + totaltBelopp + Environment.NewLine;

                textBox1.Text += "Betala med kort eller kontant: " + Environment.NewLine;
                state = 7;
            }

            else
            {
                textBox1.Text += "Du kan endast svara j eller n " + Environment.NewLine;
            }
        }

        private void KupongMatte(string inp)
        {
            int total;

            if(Int32.TryParse(inp, out total) == false || total <= 0)
            {
                textBox2.Text = null;
                textBox1.Text += "Hur mycket är kupongen värd? " + Environment.NewLine;
                active = false;
            }

            totaltBelopp -= total;

            if (totaltBelopp <= 0)
            {
                totaltBelopp = 0;
                textBox1.Text += "Kupongen täckte hela kostnaden. Kunden behöver inte betala något mer." + Environment.NewLine;
                SkrivUtKvitto();
            }
            else
            {
                textBox1.Text += "Belopp att betala: " + totaltBelopp + Environment.NewLine;

                textBox1.Text += "Betala med kort eller kontant: " + Environment.NewLine;
                state = 7;
            }
        }

        void Betalning(string inp)
        {
            betalningsTyp = inp;

            if (inp == "kontant")
            {
                textBox1.Text += "Hur mycket betalade kunden: " + Environment.NewLine;
                state = 8;
            }
            else if (inp == "kort")
            {
                textBox1.Text += "Hur mycket betalade kunden: " + Environment.NewLine;
                state = 8;
            }
            else
            {
                textBox1.Text += "Betala med kort eller kontant: " + Environment.NewLine;
            }
        }

        void CalcChange(string inp)
        {
            int betalt;

            if (Int32.TryParse(inp, out betalt) == false || betalt <= 0 || betalt < totaltBelopp)
            {
                totaltBelopp -= betalt;
                textBox1.Text += "Summan räcker inte till. " + Environment.NewLine;
                textBox1.Text += "Betala med kort eller kontant: " + Environment.NewLine;
                state = 7;
                return;
            }

            int växel = betalt - totaltBelopp;

            textBox1.Text += växel + "kr i växel." + Environment.NewLine;
            Console.WriteLine("{0}kr i växel.", växel);

            SkrivUtKvitto();
        }

        void SkrivUtKvitto()
        {
            textBox1.Text += "SEWK's livs" + Environment.NewLine;
            textBox1.Text += "Kungsgatan 37, 441 50 Alingsås" + Environment.NewLine;
            textBox1.Text += "Org Nr: 556033-5696" + Environment.NewLine;

            foreach (Vara nr in kundVagn) {
                int siffra = nr.Antal * nr.Pris;
                textBox1.Text += nr.Antal + " " + nr.Namn + " " + KategoriTyp(nr.Kategori) + " " + nr.Pris + " " + siffra + Environment.NewLine;
                totalAntalVaror += nr.Antal;
            }
            float m = totalPris * Inloggning.moms;
            float n = Inloggning.moms * 100;
            textBox1.Text += "Moms" + n + "%" + "       " + m + Environment.NewLine;
            textBox1.Text += betalningsTyp + Environment.NewLine;
            Random verfNr = new Random();
            int nr1 = verfNr.Next(100000, 999999);
            textBox1.Text += "Kvittonummer: " + nr1 + Environment.NewLine;
            textBox1.Text += DateTime.Now + Environment.NewLine;

            RapportVaror();

            totaltBelopp = 0; //Måste nollställa värden för att inte få med föregående kunds varor på nästa kunds kvitto. 
            totalPris = 0;
            totalAntalVaror = 0;

            kundVagn.Clear();

            textBox1.Text += "Fler kunder? j/n" + Environment.NewLine;

            state = 9;

        }

        string KategoriTyp(int k)
        {
            if (k == 1)
            {
                return "Grönsak";
            }
            else
            {
                return "Matvara";
            }
        }

        void RapportVaror()
        {
            string rapport = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(rapport + "\\Rapport\\");

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
            if (inp == "j")
            {
                NewVara();
            }
            else if (inp == "n")
            {
                textBox1.Text += "Du loggas nu ut som kassör och återvänder till inloggningen.";
                Inloggning.FormLogIn();
                state = 10;
            }
            else
            {
                Console.WriteLine("Inkorrekt svar. skriv endast 'j' eller 'n' ");
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

        private void button10_Click(object sender, EventArgs e)
        {
            textBox2.Text += "0";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Betalningen görs med kort" + Environment.NewLine;
            textBox2.Text = "kort";
            button15_Click(sender, e);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Betalningen görs kontant" + Environment.NewLine;
            textBox2.Text = "kontant";
            button15_Click(sender, e);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Ja" + Environment.NewLine;
            textBox2.Text = "j";
            button15_Click(sender, e);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text += "Nej" + Environment.NewLine;
            textBox2.Text = "n";
            button15_Click(sender, e);
        }

        private void ShowCartContent()
        {
            int nr = 0;
            textBox3.Text = null;
            textBox3.Text += "Name" + "\t" + "\t" + "Amount" + "\t" + "Pris" + Environment.NewLine;
            foreach(Vara v in kundVagn)
            {
                textBox3.Text += v.Namn + "\t" + "\t" + v.Antal + "\t" + v.Pris + Environment.NewLine;
                nr += v.Antal;
            }
            textBox3.Text += "Total price" + "\t" + nr + "\t" + totalPris;
        }

        private void KassaForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }
    }
}
