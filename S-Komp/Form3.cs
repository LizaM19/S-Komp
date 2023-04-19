using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace S_Komp
{
    
    public partial class Form3 : Form
    {

        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "Редактировать")
            {
                button2.Text = "Сохранить";
                richTextBox1.Enabled = true;
            }
            else
            {
                button2.Text = "Редактировать";
                richTextBox1.Enabled = false;
                saveFile();

            }
        }

        private void saveFile() {
            DateTime now = DateTime.Now;
            Random rnd = new Random();
            int value = rnd.Next(10, 99);
            string path = now.ToString("-" + value) + ".txt";
            //string pathConf = "conf.txt";
            string text = richTextBox1.Text;

            using (StreamWriter writer = new StreamWriter(path, false))
            {
                writer.WriteLineAsync(text);
            }
/*            using (StreamWriter writer = new StreamWriter(pathConf, true))
            {
                writer.WriteLineAsync("-"+value);
            }*/
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }
    }
}
