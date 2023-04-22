using System;
using System.IO;
using System.Windows.Forms;

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

        private bool saveFile()
        {

            if (label1.Text == "q")
            {
                for (int i = 0; i < 9; i++)
                {
                    string path = i + ".txt";
                    if (!File.Exists(path))
                    {
                        string text = richTextBox1.Text;
                        using (StreamWriter writer = new StreamWriter(path, false))
                        {
                            writer.WriteLineAsync(text);
                        }
                        return true;
                    }
                }
            }
            else
            {
                string path = label1.Text;
                string text = richTextBox1.Text;
                using (StreamWriter writer = new StreamWriter(path, false))
                {
                    writer.WriteLineAsync(text);
                }
                return true;
            }
            return true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = string.Empty;
        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }
    }
}
