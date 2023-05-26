using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S_Komp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            List<String> listPurchase = new List<String>(10);
            List<int> listPurchaseNew = new List<int>(10);

            List<String> listSale = new List<String>(10);
            List<int> listSaleNew = new List<int>(10);

            listPurchase.Add(textBox1.Text);
            listPurchase.Add(textBox9.Text);
            listPurchase.Add(textBox19.Text);
            listPurchase.Add(textBox3.Text);
            listPurchase.Add(textBox5.Text);
            listPurchase.Add(textBox6.Text);
            listPurchase.Add(textBox4.Text);
            listPurchase.Add(textBox11.Text);
            listPurchase.Add(textBox14.Text);
            listPurchase.Add(textBox18.Text);

            listSale.Add(textBox16.Text);
            listSale.Add(textBox8.Text);
            listSale.Add(textBox20.Text);
            listSale.Add(textBox7.Text);
            listSale.Add(textBox15.Text);
            listSale.Add(textBox2.Text);
            listSale.Add(textBox12.Text);
            listSale.Add(textBox10.Text);
            listSale.Add(textBox13.Text);
            listSale.Add(textBox17.Text);

            for (int i = 0; i < 10; i++)
            {
                if (listPurchase[i] == "")
                {
                    listPurchase[i] = "0";
                }
                if (listSale[i] == "")
                {
                    listSale[i] = "0";
                }
                listPurchaseNew.Add(Convert.ToInt32(listPurchase[i]));
                listSaleNew.Add(Convert.ToInt32(listSale[i]));

            }

            int sumPurchase = listPurchaseNew.Sum();
            label14.Text = Convert.ToString(sumPurchase);

            int sumSale = listSaleNew.Sum();
            label13.Text = Convert.ToString(sumSale);

            label12.Text = "Чистая прибыль: " + (sumSale - sumPurchase);
        }

        private void textBox18_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && e.KeyChar != 8)
                e.Handled = true;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(GroupBox))
                    foreach (Control d in c.Controls)
                        if (d.GetType() == typeof(TextBox))
                            d.Text = string.Empty;

                if (c.GetType() == typeof(TextBox))
                    c.Text = string.Empty;
            }

            label14.Text = "";
            label13.Text = "";
            label12.Text = "Чистая прибыль: ";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                   "Много чего хочешь",
                   "Мне лень",
                   MessageBoxButtons.YesNoCancel,
                   MessageBoxIcon.Information);
        }
    }
}
