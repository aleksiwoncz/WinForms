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
    public partial class Exercise2 : Form
    {
        public Exercise2()
        {
            InitializeComponent();
        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var valZ = textBox1.Text;
            var correct_result = 25000000;
            SingleCount exercise2 = new SingleCount();
            exercise2.X1 = 0;
            exercise2.X2 = 100;
            double z;
            bool parseSuccess1 = double.TryParse(valZ, out z);                     // Percentage error from 0 to 100
       
            if (parseSuccess1)
            {
                if (z >= 0 && z <= 70)
                {
                    Wynik.Items.Clear();
                    double percentVal = z * correct_result / 100;               // Value of percentage error
                    double maxAccVal = correct_result + percentVal;             // Maximal accepted value  
                    double minAccVal = correct_result - percentVal;             // Minimal accepted value

                    bool flag = false;
                    for(int i = 1; i < 25000; ++i)
                    {
                        exercise2.N = i;
                        var result_trap = exercise2.TrapezoidMethod(exercise2.FUNX3);
                        if (result_trap >= minAccVal && result_trap <= maxAccVal)
                        {
                            Wynik.Items.Add("Trapezoid method: " + result_trap);
                            Wynik.Items.Add("For n: " + exercise2.N);
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
                        exercise2.N = i;
                        var result_rec = exercise2.RectangleMethod(exercise2.FUNX3);
                        if (result_rec >= minAccVal && result_rec <= maxAccVal)
                        {
                            Wynik.Items.Add("Rectangle method: " + result_rec);
                            Wynik.Items.Add("For n: " + exercise2.N);
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
                    Wynik.Items.Add("Please change value of Z");
                    Wynik.Items.Add("The valid value is:");
                    Wynik.Items.Add("Z range 0 70");
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Wynik_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
