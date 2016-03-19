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

        private void AddToLog(double firstValue, double secondValue, double thirdValue, string result)
        {
            listBox1.Items.Add(firstValue + " " + secondValue + " " + thirdValue + " " + result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double firstValue, secondValue, thirdValue;

            firstValue  = (double)numericUpDown1.Value;
            secondValue = (double)numericUpDown2.Value;
            thirdValue  = (double)numericUpDown3.Value;

            try
            {
                var t = new Triangle(firstValue, secondValue, thirdValue);
                label5.Text = t.Type;
            }
            catch (TriangleException ex)
            {
                MessageBox.Show(ex.message);
                label5.Text = ex.message;
            }
            
            AddToLog(firstValue, secondValue, thirdValue, label5.Text);  
        }
    }
}
