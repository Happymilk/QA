using System;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void numericUpDown1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numericUpDown1.Value = 1000000000;
        }
        private void numericUpDown2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numericUpDown2.Value = 1000000000;
        }
        private void numericUpDown3_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            numericUpDown3.Value = 1000000000;
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
                MessageBox.Show(t.Type, "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Text = t.Type;
            }
            catch (TriangleException ex)
            {
                MessageBox.Show(ex.message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);              
                label5.Text = ex.message;
            }
            
            AddToLog(firstValue, secondValue, thirdValue, label5.Text);  
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var reader = new StreamReader("test.txt");
            var writer = new StreamWriter("result.txt");

            while (!reader.EndOfStream)
            {
                var s = reader.ReadLine();
                var col = s.Split(' ');

                try
                {
                    var t = new Triangle(col[0], col[1], col[2]);
                    writer.WriteLine(col[0] + " " + col[1] + " " + col[2] + " " + t.Type);
                }
                catch (TriangleException ex)
                {
                    writer.WriteLine(col[0] + " " + col[1] + " " + col[2] + " " + ex.message);
                }
            }
            reader.Dispose();
            writer.Dispose();
            MessageBox.Show("Готово", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
