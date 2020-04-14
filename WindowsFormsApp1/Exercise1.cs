using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student1_csharp.Model;


namespace WindowsFormsApp1
{
    public partial class Exercise1 : Form
    {
        public Exercise1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {}

        private void button1_Click(object sender, EventArgs e)
        {
            var valM = textBox1.Text;
            var valZ = textBox2.Text;
            var correct_result = 333333.333333;
            SingleCount exercise1 = new SingleCount();
            Random random = new Random();
            exercise1.X1 = 0;
            exercise1.X2 = 100;
            int m; double z;
            bool parseSuccess1 = int.TryParse(valM, out m);
            bool parseSuccess2 = double.TryParse(valZ, out z);                     // Percentage error from 0 to 100 

            if (parseSuccess1 && parseSuccess2)
            {
                Wynik.Items.Clear();
                if (z >= 0 && z <= 100 && m >= 1 && m <= 1000)
                {
                    exercise1.CalculationNumber = m;
                    double percentVal = z * correct_result / 100;               // Value of percentage error
                    double maxAccVal = correct_result + percentVal;             // Maximal accepted value  
                    double minAccVal = correct_result - percentVal;             // Minimal accepted value

                    for (int i = 0; i < exercise1.CalculationNumber; ++i)
                    {
                        exercise1.N = random.Next(10, 100000);
                        var result_trap = exercise1.TrapezoidMethod(exercise1.FUNX2);
                        var result_rec = exercise1.RectangleMethod(exercise1.FUNX2);
                        if (result_trap >= minAccVal && result_trap <= maxAccVal)
                            Wynik.Items.Add("Trapezoid method: " + result_trap);
                        if (result_rec >= minAccVal && result_rec <= maxAccVal)
                            Wynik.Items.Add("Rectangle method: " + result_rec);
                    }
                    Wynik.Items.Add("END OF CALCULATION");
                }
                else
                {
                    Wynik.Items.Add("Please change value of Z or M");
                    Wynik.Items.Add("The valid values are:");
                    Wynik.Items.Add("M range 1 1000");
                    Wynik.Items.Add("Z range 0 100");
                }
            }
            else
            {
                Wynik.Items.Add("The given data was invalid");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void label1_Click(object sender, EventArgs e) {}

        private void Wynik_SelectedIndexChanged(object sender, EventArgs e) {}

        private void label2_Click(object sender, EventArgs e) {}
    }
}
