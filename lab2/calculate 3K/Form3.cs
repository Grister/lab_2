using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace calculate_kon
{
    public partial class Form3 : Form
    {
        [DllImport("dwmapi.dll")]
        static extern int DwmExtendFrameIntoClientArea(IntPtr hwnd, ref matrica margins);
        [StructLayout(LayoutKind.Sequential)]

        public struct matrica
        {
            public int leftWidth;
            public int rightWidth;
            public int topHeight;
            public int bottomHeight;
        }
        public Form3()
        {
            InitializeComponent();
            AeroGlass(true);
        }

        void AeroGlass(bool enabled)
        {
            matrica pole = new matrica();
            pole.bottomHeight = 23;
            if (enabled)
            {
                DwmExtendFrameIntoClientArea(this.Handle, ref pole);
            }
        }

            private void MatricesM_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = $"Ответ ({umn.Text}):";
                matrixAB1.Text = ((int.Parse(matrixA1.Text) * int.Parse(matrixB1.Text)) + (int.Parse(matrixA4.Text) * int.Parse(matrixB2.Text)) + (int.Parse(matrixA7.Text) * int.Parse(matrixB3.Text))).ToString();
                matrixAB4.Text = ((int.Parse(matrixA1.Text) * int.Parse(matrixB4.Text)) + (int.Parse(matrixA4.Text) * int.Parse(matrixB5.Text)) + (int.Parse(matrixA7.Text) * int.Parse(matrixB6.Text))).ToString();
                matrixAB7.Text = ((int.Parse(matrixA1.Text) * int.Parse(matrixB7.Text)) + (int.Parse(matrixA4.Text) * int.Parse(matrixB8.Text)) + (int.Parse(matrixA7.Text) * int.Parse(matrixB9.Text))).ToString();
                matrixAB2.Text = ((int.Parse(matrixA2.Text) * int.Parse(matrixB1.Text)) + (int.Parse(matrixA5.Text) * int.Parse(matrixB2.Text)) + (int.Parse(matrixA8.Text) * int.Parse(matrixB3.Text))).ToString();
                matrixAB5.Text = ((int.Parse(matrixA2.Text) * int.Parse(matrixB4.Text)) + (int.Parse(matrixA5.Text) * int.Parse(matrixB5.Text)) + (int.Parse(matrixA8.Text) * int.Parse(matrixB6.Text))).ToString();
                matrixAB8.Text = ((int.Parse(matrixA2.Text) * int.Parse(matrixB7.Text)) + (int.Parse(matrixA5.Text) * int.Parse(matrixB8.Text)) + (int.Parse(matrixA8.Text) * int.Parse(matrixB9.Text))).ToString();
                matrixAB3.Text = ((int.Parse(matrixA3.Text) * int.Parse(matrixB1.Text)) + (int.Parse(matrixA6.Text) * int.Parse(matrixB2.Text)) + (int.Parse(matrixA9.Text) * int.Parse(matrixB3.Text))).ToString();
                matrixAB6.Text = ((int.Parse(matrixA3.Text) * int.Parse(matrixB4.Text)) + (int.Parse(matrixA6.Text) * int.Parse(matrixB5.Text)) + (int.Parse(matrixA9.Text) * int.Parse(matrixB6.Text))).ToString();
                matrixAB9.Text = ((int.Parse(matrixA3.Text) * int.Parse(matrixB7.Text)) + (int.Parse(matrixA6.Text) * int.Parse(matrixB8.Text)) + (int.Parse(matrixA9.Text) * int.Parse(matrixB9.Text))).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void clclicl_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = $"Ответ ({clozh.Text}):";
                matrixAB1.Text = (int.Parse(matrixA1.Text) + int.Parse(matrixB1.Text)).ToString();
                matrixAB2.Text = (int.Parse(matrixA2.Text) + int.Parse(matrixB2.Text)).ToString();
                matrixAB3.Text = (int.Parse(matrixA3.Text) + int.Parse(matrixB3.Text)).ToString();
                matrixAB4.Text = (int.Parse(matrixA4.Text) + int.Parse(matrixB4.Text)).ToString();
                matrixAB5.Text = (int.Parse(matrixA5.Text) + int.Parse(matrixB5.Text)).ToString();
                matrixAB6.Text = (int.Parse(matrixA6.Text) + int.Parse(matrixB6.Text)).ToString();
                matrixAB7.Text = (int.Parse(matrixA7.Text) + int.Parse(matrixB7.Text)).ToString();
                matrixAB8.Text = (int.Parse(matrixA8.Text) + int.Parse(matrixB8.Text)).ToString();
                matrixAB9.Text = (int.Parse(matrixA9.Text) + int.Parse(matrixB9.Text)).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void otn_Click(object sender, EventArgs e)
        {
            try
            {
                label3.Text = $"Ответ ({otn.Text}):";
                matrixAB1.Text = (int.Parse(matrixA1.Text) - int.Parse(matrixB1.Text)).ToString();
                matrixAB2.Text = (int.Parse(matrixA2.Text) - int.Parse(matrixB2.Text)).ToString();
                matrixAB3.Text = (int.Parse(matrixA3.Text) - int.Parse(matrixB3.Text)).ToString();
                matrixAB4.Text = (int.Parse(matrixA4.Text) - int.Parse(matrixB4.Text)).ToString();
                matrixAB5.Text = (int.Parse(matrixA5.Text) - int.Parse(matrixB5.Text)).ToString();
                matrixAB6.Text = (int.Parse(matrixA6.Text) - int.Parse(matrixB6.Text)).ToString();
                matrixAB7.Text = (int.Parse(matrixA7.Text) - int.Parse(matrixB7.Text)).ToString();
                matrixAB8.Text = (int.Parse(matrixA8.Text) - int.Parse(matrixB8.Text)).ToString();
                matrixAB9.Text = (int.Parse(matrixA9.Text) - int.Parse(matrixB9.Text)).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextBox[] AllMatricesTextBox = { matrixA1, matrixA2, matrixA3, matrixA4, matrixA5, matrixA6, matrixA7, matrixA8, matrixA9, matrixB1, matrixB2, matrixB3, matrixB4, matrixB5, matrixB6, matrixB7, matrixB8, matrixB9, matrixAB1, matrixAB2, matrixAB3, matrixAB4, matrixAB5, matrixAB6, matrixAB7, matrixAB8, matrixAB9 };
            foreach (var AllMatrices in AllMatricesTextBox)
                AllMatrices.Clear();
        }

        private void Change_Click(object sender, EventArgs e)
        {
            try
            {
                string stack = String.Empty;
                stack = matrixA1.Text;
                matrixA1.Text = matrixB1.Text;
                matrixB1.Text = stack;
                stack = matrixA4.Text;
                matrixA4.Text = matrixB4.Text;
                matrixB4.Text = stack;
                stack = matrixA7.Text;
                matrixA7.Text = matrixB7.Text;
                matrixB7.Text = stack;
                stack = matrixA2.Text;
                matrixA2.Text = matrixB2.Text;
                matrixB2.Text = stack;
                stack = matrixA5.Text;
                matrixA5.Text = matrixB5.Text;
                matrixB5.Text = stack;
                stack = matrixA8.Text;
                matrixA8.Text = matrixB8.Text;
                matrixB8.Text = stack;
                stack = matrixA3.Text;
                matrixA3.Text = matrixB3.Text;
                matrixB3.Text = stack;
                stack = matrixA6.Text;
                matrixA6.Text = matrixB6.Text;
                matrixB6.Text = stack;
                stack = matrixA9.Text;
                matrixA9.Text = matrixB9.Text;
                matrixB9.Text = stack;
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void umnA_Click(object sender, EventArgs e)
        {
            try
            {
                matrixA1.Text = (int.Parse(matrixA1.Text) * numericMatricesA.Value).ToString();
                matrixA4.Text = (int.Parse(matrixA4.Text) * numericMatricesA.Value).ToString();
                matrixA7.Text = (int.Parse(matrixA7.Text) * numericMatricesA.Value).ToString();
                matrixA2.Text = (int.Parse(matrixA2.Text) * numericMatricesA.Value).ToString();
                matrixA5.Text = (int.Parse(matrixA5.Text) * numericMatricesA.Value).ToString();
                matrixA8.Text = (int.Parse(matrixA8.Text) * numericMatricesA.Value).ToString();
                matrixA3.Text = (int.Parse(matrixA3.Text) * numericMatricesA.Value).ToString();
                matrixA6.Text = (int.Parse(matrixA6.Text) * numericMatricesA.Value).ToString();
                matrixA9.Text = (int.Parse(matrixA9.Text) * numericMatricesA.Value).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void umnB_Click(object sender, EventArgs e)
        {
            try
            {
                matrixB1.Text = (int.Parse(matrixB1.Text) * numericMatricesB.Value).ToString();
                matrixB4.Text = (int.Parse(matrixB4.Text) * numericMatricesB.Value).ToString();
                matrixB7.Text = (int.Parse(matrixB7.Text) * numericMatricesB.Value).ToString();
                matrixB2.Text = (int.Parse(matrixB2.Text) * numericMatricesB.Value).ToString();
                matrixB5.Text = (int.Parse(matrixB5.Text) * numericMatricesB.Value).ToString();
                matrixB8.Text = (int.Parse(matrixB8.Text) * numericMatricesB.Value).ToString();
                matrixB3.Text = (int.Parse(matrixB3.Text) * numericMatricesB.Value).ToString();
                matrixB6.Text = (int.Parse(matrixB6.Text) * numericMatricesB.Value).ToString();
                matrixB9.Text = (int.Parse(matrixB9.Text) * numericMatricesB.Value).ToString();
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void TransposeA_Click(object sender, EventArgs e)
        {
            try
            {
                string stackTransposeA = String.Empty;
                stackTransposeA = matrixA1.Text;
                matrixA1.Text = matrixA1.Text;
                matrixA1.Text = stackTransposeA;
                stackTransposeA = matrixA2.Text;
                matrixA2.Text = matrixA4.Text;
                matrixA4.Text = stackTransposeA;
                stackTransposeA = matrixA3.Text;
                matrixA3.Text = matrixA7.Text;
                matrixA7.Text = stackTransposeA;
                stackTransposeA = matrixA5.Text;
                matrixA5.Text = matrixA5.Text;
                matrixA5.Text = stackTransposeA;
                stackTransposeA = matrixA6.Text;
                matrixA6.Text = matrixA8.Text;
                matrixA8.Text = stackTransposeA;
                stackTransposeA = matrixA9.Text;
                matrixA9.Text = matrixA9.Text;
                matrixA9.Text = stackTransposeA;
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void TransposeB_Click(object sender, EventArgs e)
        {
            try
            {
                string stackTransposeB = String.Empty;
                stackTransposeB = matrixB1.Text;
                matrixB1.Text = matrixB1.Text;
                matrixB1.Text = stackTransposeB;
                stackTransposeB = matrixB2.Text;
                matrixB2.Text = matrixB4.Text;
                matrixB4.Text = stackTransposeB;
                stackTransposeB = matrixB3.Text;
                matrixB3.Text = matrixB7.Text;
                matrixB7.Text = stackTransposeB;
                stackTransposeB = matrixB5.Text;
                matrixB5.Text = matrixB5.Text;
                matrixB5.Text = stackTransposeB;
                stackTransposeB = matrixB6.Text;
                matrixB6.Text = matrixB8.Text;
                matrixB8.Text = stackTransposeB;
                stackTransposeB = matrixB9.Text;
                matrixB9.Text = matrixB9.Text;
                matrixB9.Text = stackTransposeB;
            }
            catch (FormatException exc)
            {
                label4.Text = "Статус: " + exc.Message;
            }
        }

        private void стандартныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Калькулятор f2 = new Калькулятор();
            f2.ShowDialog();
            this.Close();
        }

        private void интеграллыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
    }
}
