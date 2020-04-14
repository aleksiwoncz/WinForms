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
    public partial class Exercise8 : Form
    {
        public Exercise8()
        {
            InitializeComponent();
        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var valZ = textBox1.Text;
            var correct_result = 1;
            SingleCount exercise8 = new SingleCount();
            exercise8.X1 = 0;
            exercise8.X2 = Math.PI / 2;
            double z;
            bool parseSuccess1 = double.TryParse(valZ, out z);                     // Percentage error from 0 to 100

            if (parseSuccess1)
            {
                Wynik.Items.Clear();
                if (z >= 0 && z <= 100)
                {
                    double percentVal = z * correct_result / 100;               // Value of percentage error
                    double maxAccVal = correct_result + percentVal;             // Maximal accepted value  
                    double minAccVal = correct_result - percentVal;             // Minimal accepted value

                    bool flag = false;
                    for(int i = 1; i < 25000; ++i)
                    {
                        exercise8.N = i;
                        var result_trap = exercise8.TrapezoidMethod(exercise8.FUNCOSX);
                        if (result_trap >= minAccVal && result_trap <= maxAccVal)
                        {
                            Wynik.Items.Add("Trapezoid method: " + result_trap);
                            Wynik.Items.Add("For n: " + exercise8.N);
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
                        exercise8.N = i;
                        var result_rec = exercise8.RectangleMethod(exercise8.FUNCOSX);
                        if (result_rec >= minAccVal && result_rec <= maxAccVal)
                        {
                            Wynik.Items.Add("Rectangle method: " + result_rec);
                            Wynik.Items.Add("For n: " + exercise8.N);
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
                    Wynik.Items.Add("The valid values are:");
                    Wynik.Items.Add("Z range 0 100");
                }

            }
        }
    }
}
