using System.Windows.Forms;
using System.Text;
using static System.Net.Mime.MediaTypeNames;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Intrinsics.Arm;
using System;
using System.IO;


namespace po_lab1
{
    public partial class Form1 : Form
    {

        private string number;

        public Form1()
        {
            InitializeComponent();
        }

        public string GetTextBoxValue()
        {
            return textBox1.PlaceholderText;
        }

        public async Task WriteTextToFileAsync(string number, int fromBase, int toBase, string result)
        {
            string text = number + "\n" + fromBase + "\n" + toBase + "\n" + result + "\n";
            string path = "history.txt";

            using (FileStream fstream = new FileStream(path, FileMode.OpenOrCreate))
            {
                byte[] buffer = Encoding.Default.GetBytes(text);
                await fstream.WriteAsync(buffer, 0, buffer.Length);
                Console.WriteLine("Text has been written to the file");
            }
        }

        public void SetTextBox2Value(string value)
        {
            number = value;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                MessageBox.Show("Введите число для перевода");
            }
            else
            {
                string number = textBox1.Text;
                int fromBase = trackBar1.Value;
                int toBase = trackBar2.Value;
                string result = NumberConverter.ConvertNumber(number, fromBase, toBase);

                using (FileStream fstream = new FileStream(@"C:\Users\konaz\OneDrive\Рабочий стол\history.txt", FileMode.Append, FileAccess.Write))
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes("Исходная система счисления: " + fromBase + "\r\n");
                    fstream.Write(array, 0, array.Length);

                    byte[] array2 = System.Text.Encoding.Default.GetBytes("Конечная система счисления: " + toBase + "\r\n");
                    fstream.Write(array2, 0, array2.Length);

                    byte[] array3 = System.Text.Encoding.Default.GetBytes("Число: " + number + "\r\n");
                    fstream.Write(array3, 0, array3.Length);

                    byte[] array4 = System.Text.Encoding.Default.GetBytes("Результат: " + result + "\r\n");
                    fstream.Write(array4, 0, array4.Length);

                    byte[] array5 = System.Text.Encoding.Default.GetBytes("-------------------------" + "\r\n");
                    fstream.Write(array5, 0, array5.Length);
                }


                button21.Enabled = true;
                textBox2.Text = result;
            }
        }



        private void button2_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 3)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text.Length == 1) && (textBox1.Text == "0"))
            {
                MessageBox.Show("не допустимо вводить больше значащих нулей");
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "1";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 4)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 9)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 5)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 6)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 7)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 8)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 10)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 11)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "A";
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 12)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "B";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 13)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "C";
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 14)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "D";
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 15)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "E";
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (trackBar1.Value < 16)
            {
                MessageBox.Show("Данный символ в выбранной системе счисления не доступен");
            }
            else
            {
                textBox1.Text = textBox1.Text + "F";
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ".";
            button21.Enabled = false;

        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);

        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = trackBar1.Value;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            numericUpDown2.Value = trackBar2.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            history his = new history();
            his.Show();
        }
    }
}