using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siem
{
    public partial class Form1 : Form
    {


        float a,b;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out a) == false)
            {
                errorProvider1.SetError(textBox1, "So khong hop le");
            }
            else
                errorProvider1.Clear();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (float.TryParse(textBox1.Text, out b) == false)
            {
                errorProvider1.SetError(textBox1, "So khong hop le");
            }
            else
                errorProvider1.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = " la : ";
            float a = float.Parse(textBox1.Text);
            float b = float.Parse(textBox2.Text);
            TinhToan cal = new TinhToan(a, b);
            if (radioButton1.Checked)
            {
                textBox3.Text = s + cal.Cong();
            }
            else if (radioButton2.Checked)
            {
                textBox3.Text = s + cal.Tru();
            }
            else if (radioButton3.Checked)
            {
                textBox3.Text = s + cal.Nhan();
            }
            else if (b != 0)
            {
                textBox3.Text = s + cal.Chia();
            }
            else
            {
                textBox3.Text = "Phep tinh bi loi";
            }
        }
    }
}
