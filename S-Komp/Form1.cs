using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace S_Komp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            readFile();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/Ебейший прайс.xlsx"))
            {
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + "/Ебейший прайс.xlsx");
            }
            else
            {
                MessageBox.Show(
                    "Капитан, наше сокровище проебано",
                    "Общая тревога!!!",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Information);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void readFile()
        {
            string searchDirectory = "C:/Users/Лиза/source/repos/S-Komp/S-Komp/bin/Debug/";
            string[] AllFiles = Directory.GetFiles(searchDirectory, "-*.txt", SearchOption.AllDirectories);
            int count = AllFiles.Length;

            for (; count != 0; count--)
            {
                Form3 form3 = new Form3();
                form3.Show();
                TextReader readerS = new StreamReader(AllFiles[count - 1]);
                string lineS = readerS.ReadToEnd();
                form3.richTextBox1.Text = form3.richTextBox1.Text + lineS;
            }
        }
    }
}
