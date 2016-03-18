using System;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool Check(double a, double b, double c)
        {
            if ((a < b + c) && (b < a + c) && (c < a + b))
                return true;
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue, secondValue, thirdValue;

            firstValue  = (double)numericUpDown1.Value;
            secondValue = (double)numericUpDown2.Value;
            thirdValue  = (double)numericUpDown3.Value;

            if (Check(firstValue, secondValue, thirdValue))
                if (firstValue == secondValue && firstValue == thirdValue && secondValue == thirdValue)
                    label5.Text = "Треугольник равносторонний";
                else if (firstValue == secondValue || firstValue == thirdValue || secondValue == thirdValue)
                    label5.Text = "Треугольник равнобедренный";
                else
                    label5.Text = "Треугольник неравносторонний";
            else
                label5.Text = "Треугольник не существует";

            listBox1.Items.Add(numericUpDown1.Value + " " + numericUpDown2.Value + " " + numericUpDown3.Value + " " + label5.Text);  
        }
    }
}
