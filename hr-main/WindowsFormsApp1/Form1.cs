using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(textBox1.Text);
            string a = " ";
            string b = " ";
            if (radioButton1.Checked)
            {
                a = radioButton1.Text;
            }
            else if (radioButton2.Checked)
            {
                a = radioButton2.Text;
            }
            if (radioButton3.Checked)
            {
                b = radioButton3.Text;
            }
            else if (radioButton4.Checked)
            {
                b = radioButton4.Text;
            }
            if (num > 20)
            {
                MessageBox.Show("Nqma tolkova mesta");
                textBox1.Text = "";
            }
            else if (num < 0)
            {
                MessageBox.Show("Invalid amount");
                textBox1.Text = "";
            }
            else
            {

                MessageBox.Show("Вие избрахте маса за " + textBox1.Text + ", " + a + " ,Плащане с: " + b);
                Form3 thirdForm = new Form3();
                thirdForm.Show();
            }
            
            
        }
    }
}
