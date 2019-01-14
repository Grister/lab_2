using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace calculate_kon
{
    public partial class Form2 : Form
    {
        public double a, b, k, p, q, r, s, t;
        public int n;
        public Form2()
        {
            InitializeComponent();
        }

        public double f1(double x)
        {
            return k / x;
        }

        public double df1(double x)
        {
            return k * Math.Log(x);
        }

        public double f2(double x)
        {
            return p * x * x + q * x + r;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }


        public double df2(double x)
        {
            return p * x * x * x / 3 + q * x * x / 2 + r * x;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public double f3(double x)
        {
            return s * Math.Pow(x, t);
        }

        public double df3(double x)
        {
            if (t != -1) return s * Math.Pow(x, t + 1) / (t + 1);
            else return s * Math.Log(x);
        }

        public delegate double Func(double X);

        public double sqr(Func f)
        {
            double h = (b - a) / n;
            double res = 0;
            for (int i = 0; i < n; i++)
            {
                res += f(a + i * h + h / 2);
            }
            return h * res;
        }


        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                a = Double.Parse(textBox1.Text);
                b = Double.Parse(textBox2.Text);
                n = Int32.Parse(textBox9.Text);
                if (radioButton1.Checked)
                {
                    k = Double.Parse(textBox3.Text);
                    textBox7.Text = sqr(f1).ToString();
                    textBox8.Text = (df1(b) - df1(a)).ToString();
                }
                if (radioButton2.Checked)
                {
                    p = Double.Parse(textBox4.Text);
                    q = Double.Parse(textBox5.Text);
                    textBox7.Text = sqr(f2).ToString();
                    textBox8.Text = (df2(b) - df2(a)).ToString();
                }
                if (radioButton3.Checked)
                {
                    s = Double.Parse(textBox10.Text);
                    t = Double.Parse(textBox11.Text);
                    textBox7.Text = sqr(f3).ToString();
                    textBox8.Text = (df3(b) - df3(a)).ToString();

                }
            }
            catch
            {
                MessageBox.Show("Введите правильные данные.");
            }
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Калькулятор f2 = new Калькулятор();
            f2.ShowDialog();
            this.Close();
        }
        private void матрицыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form3 f2 = new Form3();
            f2.ShowDialog();
            this.Close();
        }
    }
}

