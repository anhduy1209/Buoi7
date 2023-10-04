using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bttl
{
    public partial class Form1 : Form
    {
        float m,n,p;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out m) == false)
            {
                errorProvider1.SetError(textBox1, "So khong hop le");
            }
            else
                errorProvider1.Clear();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox3.Enabled = false;
                label4.Enabled = false;
            }
            else
            { 
                textBox3.Enabled = true;
                label4.Enabled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out p) == false)
            {
                errorProvider1.SetError(textBox3, "So khong hop le");
            }
            else
                errorProvider1.Clear();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                string s = "Phuong trinh co nghiem : ";
                float a, b;
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                PTB1 pt1 = new PTB1(a, b);
                if (a == 0)
                {
                    MessageBox.Show("Loi tinh toan (a phai khac 0)");
                }
                else
                    textBox4.Text = s + pt1.TinhNghiem();

            }
            else
            {
                float a, b,c;
                a = float.Parse(textBox1.Text);
                b = float.Parse(textBox2.Text);
                c = float.Parse(textBox3.Text);
                PTB2 pt2 = new PTB2(a, b, c);
                if (pt2.TinhNghiem() == 1)
                {
                    textBox4.Text = "Phuong trinh vo nghiem";
                }
                else if (pt2.TinhNghiem() == 2)
                {
                    float x = -b / 2 * a;
                    textBox4.Text = "Phuong trinh co 2 nghiem kep x = " + x;
                }
                else
                {
                    double delta = b * b - 4 * a * c;
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    textBox4.Text = "Phuong trinh co 2 nghiem phan biet" + " x1 = " + x1 + "   x2 = " + x2;
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out n) == false)
            {
                errorProvider1.SetError(textBox2, "So khong hop le");
            }
            else
                errorProvider1.Clear();
        }
    }
}
