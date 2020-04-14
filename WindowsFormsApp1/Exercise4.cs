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
    public partial class Exercise4 : Form
    {
        public Exercise4()
        {
            InitializeComponent();
        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var valZ = textBox1.Text;
            var valK = textBox3.Text;
            SingleCount exercise4 = new SingleCount();
            exercise4.X1 = 0;
            int K; int Z;
            bool parseSuccess1 = int.TryParse(valK, out K);
            bool parseSuccess2 = int.TryParse(valZ, out Z);

            if (parseSuccess1 && parseSuccess2)
            {
                Wynik.Items.Clear();
                if (K >= 0 && K <= 4 && Z > 0 && Z <= 1000)
                {
                    exercise4.N = (int)Math.Pow(10, K);
                    int x2 = 1;

                    bool flag = false;
                    for(int i = 1; i < 25000; ++i)
                    {
                        exercise4.X2 = i;
                        var result = exercise4.TrapezoidMethod(exercise4.FUNX3);
                        if (result % Z == 0)
                        {
                            Wynik.Items.Add("Trapezoid Method");
                            Wynik.Items.Add("Result: " + result);
                            Wynik.Items.Add("For x1: " + exercise4.X1 + ", x2: " + exercise4.X2);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) 
                    {
                         Wynik.Items.Add("No matches for Trapezoid method..");
                    }

                    flag = false;
                    for(int i = 1; i < 25000; ++i)
                    {
                        exercise4.X2 = i;
                        var result = exercise4.RectangleMethod(exercise4.FUNX3);
                        if (result % Z == 0)
                        {
                            Wynik.Items.Add("Rectangle Method");
                            Wynik.Items.Add("Result: " + result);
                            Wynik.Items.Add("For x1: " + exercise4.X1 + ", x2: " + exercise4.X2);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) 
                    {
                         Wynik.Items.Add("No matches for Rectangle method..");
                    }
                }
                else
                {
                    Wynik.Items.Add("Please change value of Z or K");
                    Wynik.Items.Add("The valid values are:");
                    Wynik.Items.Add("K range 0 4");
                    Wynik.Items.Add("Z range >0 1000");
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
