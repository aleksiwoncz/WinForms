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
    public partial class Exercise7 : Form
    {
        public Exercise7()
        {
            InitializeComponent();
        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var valZ = textBox1.Text;
            var valx1 = textBox2.Text;
            var valx2 = textBox3.Text;
            SingleCount exercise7 = new SingleCount();

            double x1, x2;
            int Z;
            bool parseSuccess1 = double.TryParse(valx1, out x1);
            bool parseSuccess2 = double.TryParse(valx2, out x2);
            bool parseSuccess3 = int.TryParse(valZ, out Z);

            if (parseSuccess1 && parseSuccess2 && parseSuccess3)
            {
                Wynik.Items.Clear();
                if (x1 >= 0 && x1 <= 1000 && x2 >= 0 && x2 <= 1000 && x2 > x1 && Z > 0 && Z <= 1000)
                {
                    exercise7.X1 = x1;
                    exercise7.X2 = x2;

                    bool flag = false;
                    for(int i = 2; i < 25000; ++i)
                    {
                        exercise7.N = i;
                        var result_trap = exercise7.TrapezoidMethod(exercise7.FUNX2);

                        if (result_trap % Z == 0)
                        {
                            Wynik.Items.Add("Trapezoid method: " + result_trap);
                            Wynik.Items.Add("For n: " + exercise7.N);
                            flag = true;
                            break;
                        }
                    }
                    if (!flag) 
                    {
                         Wynik.Items.Add("No matches for Trapezoid method..");
                    }

                    flag = false;
                    for(int i = 2; i < 25000; ++i)
                    {
                        exercise7.N = i;
                        var result_rec = exercise7.RectangleMethod(exercise7.FUNX2);

                        if (result_rec % Z == 0)
                        {
                            Wynik.Items.Add("Rectangle method: " + result_rec);
                            Wynik.Items.Add("For n: " + exercise7.N);
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
                    Wynik.Items.Add("Please change value of X1 or X1 or Z");
                    Wynik.Items.Add("The valid values are:");
                    Wynik.Items.Add("X1 range 0 1000");
                    Wynik.Items.Add("X2 range 0 1000");
                    Wynik.Items.Add("Z range >0 1000");
                    Wynik.Items.Add("X2 > X1");
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
