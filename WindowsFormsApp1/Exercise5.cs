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
    public partial class Exercise5 : Form
    {
        public Exercise5()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private double findX(Random random)
        {
            return random.Next(10, 100000);
        }

        private double integralX(SingleCount exercise5, bool method, Func<double, double> fun, Random random)
        {
            exercise5.X1 = 0;
            while (true)
            {
                exercise5.X2 = findX(random);
                if (exercise5.X2 > exercise5.X1)
                    break;
            }
            double local_x = 0;
            if (method)     // Trapezoid
                local_x = exercise5.TrapezoidMethod(fun);
            else
                local_x = exercise5.RectangleMethod(fun);

            return local_x;
        }


        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var valK = textBox3.Text;
            SingleCount exercise5 = new SingleCount();
            Random random = new Random();

            int K;
            bool parseSuccess1 = int.TryParse(valK, out K);

            if (parseSuccess1)
            {
                Wynik.Items.Clear();
                if (K >= 0 && K <= 4)
                {
                    exercise5.N = (int)Math.Pow(10, K);
                    double local_x2, local_x3;
                    bool flag = false;
                    for (int i = 1; i < 25000; ++i)
                    {
                        local_x2 = integralX(exercise5, true, exercise5.FUNX2, random);
                        local_x3 = integralX(exercise5, true, exercise5.FUNX3, random);
                        Wynik.Items.Add("Trapezoid method: " + local_x2);
                        Wynik.Items.Add("Trapezoid method: " + local_x3);

                        if (local_x2 == local_x3)
                        {
                            Wynik.Items.Add("Trapezoid method: " + local_x2);
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Wynik.Items.Add("No matches for Trapezoid method..");
                    }

                    flag = false;
                    for (int i = 1; i < 25000; ++i)
                    {

                        local_x2 = integralX(exercise5, false, exercise5.FUNX2, random);
                        local_x3 = integralX(exercise5, false, exercise5.FUNX3, random);

                        if (local_x2 == local_x3)
                        {
                            Wynik.Items.Add("Rectangle method: " + local_x2);
                            flag = true;
                        }
                    }
                    if (!flag)
                    {
                        Wynik.Items.Add("No matches for Rectangle method..");
                    }
                }
                else
                {
                    Wynik.Items.Add("Please change value of K");
                    Wynik.Items.Add("The valid values is:");
                    Wynik.Items.Add("K range 0 4");
                }
            }
            else
            {
                Wynik.Items.Add("The given data was invalid");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
