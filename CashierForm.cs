using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;

namespace DigitCashier
{

    public partial class CashierForm : Form
    {
        private Vara selectedItem;
        List<Vara> customerCart = new List<Vara>();// Skapar en lista för kundvagn

        private bool active; //Används för att buttonEnter inte ska göra fel saker vid fel tillfälle. 
        int state; //Används för att buttonEnter inte ska göra fel saker vid fel tillfälle. 

        private int totalPrice; //Kostnaden för alla totalItems. Används på kvittot. 
        private int totalAmount; // Det pris kunden skall betala. 
        private int totalItems; // Totala köpta totalItems
        float change;
        string paymentMethod;
        string input; // Input för EnterButton
        int couponAmount = 0;

        public CashierForm()
        {
            InitializeComponent();
        }

        private void CashierForm_Load(object sender, EventArgs e)
        {
            panelCoupon.Location = new Point(394, 249);
            panelReceipt.Location = new Point(237, 28);
            NewItem();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) //Tar bort äldsta raden text så att nyaste raden text får plats i textboxen. 
        {
            if (richTextBox2.Lines.Length > 20)
            {
                richTextBox2.Lines = richTextBox2.Lines.Skip(1).ToArray();
            }
        }

        private void CashierForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide(); // AdminForm göms
            Inloggning.FormLogIn(); // FormLogIn öppnas
        }

        private void ShowCartContent()
        {
            int no = 0;
            textBox3.Text = null;
            const string format = "{0,-10} {1,-12} {2,0}";
            textBox3.Text += (String.Format(format, "Name", "Quantity", "Price")) + Environment.NewLine;
            textBox3.Text += "----------------------------------" + Environment.NewLine;
            foreach (Vara v in customerCart)
            {
                textBox3.Text += (String.Format(format, v.Namn, v.Antal, v.Pris)) + Environment.NewLine;
                no += v.Antal;
            }
            textBox3.Text += "----------------------------------" + Environment.NewLine;
            textBox3.Text += (String.Format(format, "Total:", no, totalPrice));
        }

        #region Purchase Process

        private void NewItem() //Körs vid ny vara. 
        {
            btnPay.Enabled = true;
            state = 1;
            txtboxCommand.Text = "Id-number " + Environment.NewLine;
        }

        private void CheckItemId(string inp) //Kollar så att id finns. 
        {
            btnPay.Enabled = false;
            active = true;

            int idNum;

            if (Int32.TryParse(inp, out idNum) == false || idNum.ToString().Length != 2 || CheckItemList(idNum) == false)
            {
                textBox2.Text = null;
                textBoxError.Text = "Id-number is incorrect. Please try again!" + Environment.NewLine;
                txtboxCommand.Text = "Id-number " + Environment.NewLine;
                active = false;
            }

            else
            {
                richTextBox2.Text += "Selected item: " + selectedItem.Namn + Environment.NewLine;
                ItemId(); // Metodanrop av ItemId
                idNum = 0;
            }
        }

        private void ItemId() //Kontrollerar kategori för att sen fråga om weight eller itemQuantity. 
        {
            if (selectedItem.Kategori == 1)
            {
                txtboxCommand.Text = "Weight in kg " + Environment.NewLine;
                state = 2;
                active = false;
            }

            if (selectedItem.Kategori == 0)
            {
                state = 3;
                txtboxCommand.Text = "Quantity " + Environment.NewLine;
                active = false;
            }
        }

        private void CheckItemQuantity(string inpQuantity) //Kollar så att antalet totalItems finns i lager etc. 
        {
            int itemQuantity;
            int itemPrice = 0;

            if (Int32.TryParse(inpQuantity, out itemQuantity) == false || inpQuantity == "")
            {
                txtboxCommand.Text = "Quantity " + Environment.NewLine;
                textBox2.Text = null;
                textBoxError.Text = "Number is not valid. Please try again!" + Environment.NewLine;
                active = false;
            }

            else if (selectedItem.LagerStatus == 0)
            {
                btnPay.Enabled = true;
                textBox2.Text = null;
                textBoxError.Text = "The item is sold out." + Environment.NewLine;
                active = false;
                state = 1;

            }
            else if (itemQuantity > selectedItem.LagerStatus)
            {
                btnPay.Enabled = true;
                txtboxCommand.Text = "Quantity " + Environment.NewLine;
                textBox2.Text = null;
                textBoxError.Text = "Sorry, there are only " + selectedItem.LagerStatus + " " + selectedItem.Namn + " left." + Environment.NewLine;
                active = false;
            }
            else
            {
                btnPay.Enabled = true;
                richTextBox2.Text += inpQuantity + " " + selectedItem.Namn + " added to the cart." + Environment.NewLine;

                if (customerCart.Contains(selectedItem)) // Om vald vara finns höjs värderna på den valda varan
                {
                    selectedItem.LagerStatus -= itemQuantity;
                    selectedItem.Antal += itemQuantity;
                    itemPrice = itemQuantity * selectedItem.Pris;
                    totalPrice += itemPrice;
                    totalAmount += itemPrice;
                }
                else // Ny vara läggs till i korgen
                {
                    btnPay.Enabled = true;
                    selectedItem.LagerStatus -= itemQuantity;
                    selectedItem.Antal = itemQuantity;
                    itemPrice = itemQuantity * selectedItem.Pris;
                    totalPrice += itemPrice;
                    totalAmount += itemPrice;
                    customerCart.Add(selectedItem);
                }

                active = false;
                state = 1;
                ShowCartContent();
                NewItem();
            }
        }

        private void ItemWeight(string inpWeight) //Kollar så att antalet totalItems finns i lager etc. 
        {
            int weight;
            int price = 0;
            bool myloop = true;

            do
            {
                if (Int32.TryParse(inpWeight, out weight) == false)
                {
                    if (weight <= 0)
                    {
                        weight = 1;
                        inpWeight = "1";
                        myloop = true;
                        break;
                    }
                    txtboxCommand.Text = "Weight in kg " + Environment.NewLine;
                    textBox2.Text = null;
                    textBoxError.Text = "Number is not valid. Please try again." + Environment.NewLine;
                    active = false;
                    myloop = false;
                }

                else if (selectedItem.LagerStatus == 0)
                {
                    btnPay.Enabled = true;
                    textBox2.Text = null;
                    textBoxError.Text = "The " + selectedItem.Namn + " is/are sold out." + Environment.NewLine;
                    active = false;
                    myloop = false;
                    state = 1;
                    NewItem();
                }

                else if (weight > selectedItem.LagerStatus)
                {
                    btnPay.Enabled = true;
                    txtboxCommand.Text = "Weight in kg " + Environment.NewLine;
                    textBox2.Text = null;
                    textBoxError.Text = "Sorry, there are only " + selectedItem.LagerStatus + " kg " + selectedItem.Namn + " left." + Environment.NewLine;
                    active = false;
                    myloop = false;
                }
            } while (myloop == false);


            if (customerCart.Contains(selectedItem)) // Om vald vara finns höjs värderna på den valda varan
            {
                btnPay.Enabled = true;
                selectedItem.LagerStatus -= weight;
                selectedItem.Antal += weight;
                price = weight * selectedItem.Pris;
                richTextBox2.Text += weight + "kg " + selectedItem.Namn + " (" + price + "SEK)" + " added to the cart." + Environment.NewLine;
                totalPrice += price;
                totalAmount += price;
            }
            else // Ny vara läggs till i korgen
            {
                btnPay.Enabled = true;
                selectedItem.LagerStatus -= weight;
                selectedItem.Antal = weight;
                price = weight * selectedItem.Pris;
                totalPrice += price;
                totalAmount += price;
                richTextBox2.Text += weight + "kg " + selectedItem.Namn + " (" + price + "SEK)" + " added to the cart." + Environment.NewLine;
                customerCart.Add(selectedItem); // Lägger i vald vara i kundvagnen
                active = false;
                state = 1;
            }
            ShowCartContent();
            NewItem();
        }

        bool CheckItemList(int inpId) // Tittar så ID-numret finns med i varuListan.
        {
            for (var i = 0; i < Inloggning.varuLista.Count; i++)
            {
                if (Inloggning.varuLista[i].Id == inpId)
                {
                    selectedItem = Inloggning.varuLista[i];
                    return true;
                }
            }
            return false;
        }

        private void CouponMath(int inp)
        {
            richTextBox2.Text += "Coupon amount payed: " + inp + Environment.NewLine;

            totalAmount -= inp;

            if (totalAmount <= 0)
            {
                totalAmount = 0;
                richTextBox2.Text += "The coupon covered the costs." + Environment.NewLine;
                paymentMethod = "Coupon";
                totalAmount = 0;
                PrintReceipt();

            }
            else
            {
                buttonCard.Enabled = true;
                buttonCash.Enabled = true;
                richTextBox2.Text += "Amount left to pay: " + totalAmount + Environment.NewLine;
                txtboxCommand.Text = "Cash or card ";
                state = 7;
            }
        }

        void Payment(string inpPay)
        {
            paymentMethod = inpPay;

            if (inpPay == "Cash")
            {
                richTextBox2.Text += "Selected payment method: Cash " + Environment.NewLine;
                txtboxCommand.Text = "Cash amount " + Environment.NewLine;
                state = 8;

            }
            else if (inpPay == "Card") // Kund skickas direkt till kvitto då en betalar exakta summan med kort.
            {
                richTextBox2.Text += "Selected payment method: Cash " + Environment.NewLine;
                totalAmount = 0;
                PrintReceipt();
            }
            else
            {
                txtboxCommand.Text = "Cash or card ";
            }
        }

        void CalcChange(string inp)
        {
            int payed;

            if (Int32.TryParse(inp, out payed) == false || payed <= 0 || payed < totalAmount)
            {
                totalAmount -= payed;
                textBoxError.Text = "The amount was not enough. " + totalAmount + " SEK left to pay." + Environment.NewLine;
                richTextBox2.Text += "Amount left to pay: " + totalAmount + Environment.NewLine;
                txtboxCommand.Text = "Cash or card ";
                state = 7;
                return;
            }

            change = payed - totalAmount;

            PrintReceipt();
        }

        string CategoryType(int c)
        {
            if (c == 1)
            {
                return "Vegetable";
            }
            else
            {
                return "General";
            }
        }
        #endregion

        #region Report Items

        void ReportItems()
        {
            string report = AppDomain.CurrentDomain.BaseDirectory;
            Directory.CreateDirectory(report + "\\Rapport\\");

            int month = DateTime.Now.Month;
            int year = DateTime.Now.Year;

            if (Directory.Exists(report + "\\Rapport\\" + year + "\\\\" + month + "\\") == false)
            {
                Directory.CreateDirectory(report + "\\Rapport\\" + year + "\\\\" + month + "\\");
            }

            using (StreamWriter writer = new StreamWriter(report + "\\Rapport\\" + year + "\\\\" + month + "\\TotalPris.txt", true))
            {
                writer.WriteLine(totalPrice);
            }
            using (StreamWriter writer = new StreamWriter(report + "\\Rapport\\" + year + "\\\\" + month + "\\TotalaVaror.txt", true))
            {
                writer.WriteLine(totalItems);
            }

            foreach (Vara a in customerCart)
            {
                if (a.Antal > 0)
                {
                    using (StreamWriter writer = new StreamWriter(report + "\\Rapport\\" + year + "\\\\" + month + "\\" + a.Namn + ".txt", true))
                    {
                        writer.WriteLine(a.Antal);
                    }
                }
            }
        }
        #endregion

        #region Reciept

        void PrintReceipt()
        {
            panelReceipt.Show();

            richTextBoxReceipt.Text += "\t" + "\t" + "\t" + "  Shop Receipt" + Environment.NewLine;
            richTextBoxReceipt.Text += "\t" + "\t" + "     SEWK's Supermarket" + Environment.NewLine;
            richTextBoxReceipt.Text += "\t" + "Address: Rasberrylane 46, 6025 Hillary " + Environment.NewLine;
            richTextBoxReceipt.Text += "\t" + "\t" + "   Org No: 556033 - 5696" + Environment.NewLine;
            richTextBoxReceipt.Text += "\t" + "\t" + "    " + DateTime.Now + Environment.NewLine;
            richTextBoxReceipt.Text += "--------------------------------------------------" + Environment.NewLine;

            const string format2 = "{0,-10} {1,-10} {2,-10} {3, 6} {4, 8}";
            richTextBoxReceipt.Text += Environment.NewLine;
            richTextBoxReceipt.Text += (String.Format(format2, "Quantity", "Name", "Category", "Price", "Total")) + Environment.NewLine;
            foreach (Vara nr in customerCart)
            {
                int priceTotal = nr.Antal * nr.Pris;
                richTextBoxReceipt.Text += (String.Format(format2, nr.Antal, nr.Namn, CategoryType(nr.Kategori), nr.Pris, priceTotal)) + Environment.NewLine;
                totalItems += nr.Antal;
            }
            richTextBoxReceipt.Text += Environment.NewLine;
            richTextBoxReceipt.Text += "--------------------------------------------------" + Environment.NewLine;
            richTextBoxReceipt.Text += "TOTAL" + "\t" + "\t" + "\t" + "\t" + totalPrice + " SEK" + Environment.NewLine;
            richTextBoxReceipt.Text += Environment.NewLine;

            float tax = Inloggning.moms * 100;
            float totalTax = totalPrice * Inloggning.moms;
            float subTotal = totalPrice - Inloggning.moms;

            richTextBoxReceipt.Text += "Subtotal " + "\t" + "\t" + "\t" + subTotal + " SEK" + Environment.NewLine;
            richTextBoxReceipt.Text += "Tax " + tax + "%:" + "\t" + "\t" + "\t" + totalTax + " SEK" + Environment.NewLine;
            richTextBoxReceipt.Text += "Pay method" + "\t" + "\t" + "\t" + paymentMethod + Environment.NewLine;
            richTextBoxReceipt.Text += "Change" + "\t" + "\t" + "\t" + change + " SEK" + Environment.NewLine;
            richTextBoxReceipt.Text += "Coupon" + "\t" + "\t" + "\t" + couponAmount + " SEK" + Environment.NewLine;

            Random verfNo = new Random();
            int no1 = verfNo.Next(100000000, 999999999);
            textboxReceiptNo.Text += "6025 - " + no1;


            ReportItems();

            totalAmount = 0; //Måste nollställa värden för att inte få med föregående kunds totalItems på nästa kunds kvitto. 
            totalPrice = 0;
            totalItems = 0;

            customerCart.Clear();

            state = 9;
        }

        private void richTextBoxReceipt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            richTextBox2.Clear();
            richTextBoxReceipt.Clear();
            textBox3.Text = null;
            panelReceipt.Hide();
        }

        private void textboxCoupon_Click(object sender, EventArgs e)
        {
            textboxCoupon.Clear();
        }
        #endregion

        //###################################################### KNAPP KOD #######################################################
        #region Buttons

        #region EnterButton
        private void buttonEnter_Click(object sender, EventArgs e)//knappen gör olika beroende på var i programmet man befinner sig. Programmet återkommer hit varje gång input krävs. 
        {
            txtboxCommand.Clear();
            textBoxError.Clear();
            ShowCartContent();

            input = textBox2.Text;

            if (active == false)
            {
                if (state == 1) // Frågar efter varaID
                {
                    CheckItemId(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 2) // Om grönsak - fråga weight
                {
                    ItemWeight(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 3) // Fråga itemQuantity
                {
                    CheckItemQuantity(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 7) // Payment
                {
                    buttonCard.Enabled = true;
                    buttonCash.Enabled = true;
                    Payment(input);
                    input = null;
                    textBox2.Text = null;
                }

                else if (state == 8) // Kalkylerar change
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
        #endregion
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

        private void textboxCoupon_TextChanged(object sender, EventArgs e)
        {
            int total;
            if (Int32.TryParse(textboxCoupon.Text, out total) == false)
            {
                buttonAdd.Enabled = false;
            }
            else
            {
                buttonAdd.Enabled = true;
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Int32.TryParse(textboxCoupon.Text, out couponAmount) == true)
            {
                CouponMath(couponAmount);
                active = false;
            }
            else
            {
                textboxCoupon.Text = null;
            }
            panelCoupon.Hide();
            btnPay.Enabled = false;
            state = 7;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            string inp = null;
            Payment(inp);
            panelCoupon.Hide();
            btnPay.Enabled = false;
            state = 7;
        }

        private void buttonCard_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Card";
            buttonEnter_Click(sender, e);
        }

        private void buttonCash_Click(object sender, EventArgs e)
        {
            textBox2.Text = "Cash";
            buttonEnter_Click(sender, e);
        }

        private void buttonClear_Click(object sender, EventArgs e) // Rensar input textboxen
        {
            textBox2.Clear();
        }

        private void btnPay_Click(object sender, EventArgs e) // Betalningsknapp
        {
            panelCoupon.Show();
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
                MessageBox.Show("Please complete the purchase before signing out...");
            }
        }
        #endregion

    }
}
