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
    public partial class Exercise3 : Form
    {
        public Exercise3()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void CALCULATE_Click(object sender, EventArgs e)
        {
            var correct_result = 333333.333333;
            SingleCount exercise3 = new SingleCount();
            exercise3.X1 = 0;
            exercise3.X2 = 100;

            for (int i = 1; i < 7; ++i)
            {
                exercise3.N = (int)Math.Pow(10, i);
                Wynik.Items.Add("For n: " + exercise3.N);
                var result_trap = exercise3.TrapezoidMethod(exercise3.FUNX2);
                exercise3.MinSquareError = Math.Pow(correct_result - result_trap, 2);
                Wynik.Items.Add("Trapezoid method: " + exercise3.MinSquareError);

                var result_rec = exercise3.RectangleMethod(exercise3.FUNX2);
                exercise3.MinSquareError = Math.Pow(correct_result - result_rec, 2);
                Wynik.Items.Add("Rectangle method: " + exercise3.MinSquareError);

            }
        }
    }
}
