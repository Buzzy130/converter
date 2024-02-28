using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace po_lab1
{
    public partial class history : Form
    {
        public history()
        {
            InitializeComponent();
        }

        public void GetComponent(string number, int fromBase, int toBase, string result)
        {
            label1.Text = label1.Text + "Исходная система счисления: " + fromBase + "\n";
            label1.Text = label1.Text + "Конечная система счисления: " + toBase + "\n";
            label1.Text = label1.Text + "Число: " + number + "\n";
            label1.Text = label1.Text + "Результат: " + result + "\n";
            label1.Text = "-------------------------------- \n";
        }

        public void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\konaz\OneDrive\Рабочий стол\history.txt";

            string text = File.ReadAllText(path);
            label1.Text = text;
        }
    }
}
