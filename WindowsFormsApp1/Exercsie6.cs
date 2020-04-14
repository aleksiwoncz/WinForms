using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Student1_csharp.Model;


namespace WindowsFormsApp1
{
    public partial class Exercsie6 : Form
    {
        public Exercsie6()
        {
            InitializeComponent();
        }

        private void Exercsie6_Load(object sender, EventArgs e) {}

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var valK = textBox3.Text;
            var valM = textBox1.Text;
            SingleCount exercise6 = new SingleCount();
            Random random = new Random();

            int m; int k;
            bool parseSuccess1 = int.TryParse(valM, out m);
            bool parseSuccess2 = int.TryParse(valK, out k);

            if (parseSuccess1 && parseSuccess2)
            {
                Wynik.Items.Clear();
                if (k >= 0 && k <= 4 && m >= 1 && m <= 1000)
                {
                    exercise6.N = (int)Math.Pow(10, k);

                    double result_x2 = 0, result_x3 = 0, diff = double.MaxValue;
                    double local_x2, local_x3, local_diff;
                    // Trapezoid method
                    for (int i = 0; i < m; ++i)
                    {
                        exercise6.X1 = random.Next(0, 100);
                        exercise6.X2 = random.Next(100, 300);

                        local_x2 = exercise6.TrapezoidMethod(exercise6.FUNX2);
                        local_x3 = exercise6.TrapezoidMethod(exercise6.FUNX3);
                        local_diff = local_x2 - local_x3;
                        if (local_diff < 0) local_diff *= -1;
                        if (local_diff < diff)
                        {
                            diff = local_diff;
                            result_x2 = local_x2;
                            result_x3 = local_x3;
                        }
                    }
                    Wynik.Items.Add("Trapezoid method");
                    Wynik.Items.Add("X^2 function: " + result_x2);
                    Wynik.Items.Add("X^3 function: " + result_x3);
                    Wynik.Items.Add("Lowest difference: " + diff);


                    result_x2 = 0; result_x3 = 0; diff = double.MaxValue;
                    // Rectangle method
                    for (int i = 0; i < m; ++i)
                    {
                        exercise6.X1 = random.Next(0, 100);
                        exercise6.X2 = random.Next(100, 300);

                        local_x2 = exercise6.RectangleMethod(exercise6.FUNX2);
                        local_x3 = exercise6.RectangleMethod(exercise6.FUNX3);
                        local_diff = local_x2 - local_x3;
                        if (local_diff < 0) local_diff *= -1;
                        if (local_diff < diff)
                        {
                            diff = local_diff;
                            result_x2 = local_x2;
                            result_x3 = local_x3;
                        }
                    }
                    Wynik.Items.Add("Rectangle method");
                    Wynik.Items.Add("X^2 function: " + result_x2);
                    Wynik.Items.Add("X^3 function: " + result_x3);
                    Wynik.Items.Add("Lowest difference: " + diff);
                }
                else
                {
                    Wynik.Items.Add("Please change value of Z or M");
                    Wynik.Items.Add("The valid values are:");
                    Wynik.Items.Add("M range 1 1000");
                    Wynik.Items.Add("K range 0 4");
                }
            }
            else
            {
                Wynik.Items.Add("The given data was invalid");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
