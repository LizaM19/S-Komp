using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Extensions.FileSystemGlobbing;
using Microsoft.Extensions.FileSystemGlobbing.Abstractions;

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

            Matcher matcher = new Matcher();
            matcher.AddIncludePatterns(new[] { "-*.txt" });

            string searchDirectory = "C:/Users/Лиза/source/repos/S-Komp/S-Komp/bin/Debug/";

            PatternMatchingResult result = matcher.Execute(
                new DirectoryInfoWrapper(
                    new DirectoryInfo(searchDirectory)));

            //Directory.EnumerateFiles("", "/*-/?/?.txt", SearchOption.AllDirectories);
            /*int count = 0;
            string line;
            TextReader reader = new StreamReader("conf.txt");
            while ((line = reader.ReadLine()) != null)
            {
                Form3 form3 = new Form3();
                form3.Show();
                string lineS;
                TextReader readerS = new StreamReader("*"+line+".txt");
                while ((lineS = reader.ReadLine()) != null)
                {

                    form3.richTextBox1.Text = form3.richTextBox1.Text + lineS;
                }
                reader.Close();

            }
            reader.Close();
*/
        }
    }
}
