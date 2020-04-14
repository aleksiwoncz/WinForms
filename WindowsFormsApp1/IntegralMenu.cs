using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class IntegralMenu : Form
    {
        public IntegralMenu()
        {
            InitializeComponent();
            
        }

        private void zadanie1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise1 ex1 = new Exercise1();
            ex1.ShowDialog();
        }


        private void zadanie2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise2 ex2 = new Exercise2();
            ex2.ShowDialog();
        }

        private void zadanie3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise3 ex3 = new Exercise3();
            ex3.ShowDialog();
        }

        private void zadanie4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise4 ex4 = new Exercise4();
            ex4.ShowDialog();
        }

        private void zadanie5ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise5 ex5 = new Exercise5();
            ex5.ShowDialog();
        }

        private void zadanie6ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercsie6 ex6 = new Exercsie6();
            ex6.ShowDialog();
        }

        private void zadanie7ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise7 ex7 = new Exercise7();
            ex7.ShowDialog();
        }

        private void zadanie8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exercise8 ex8 = new Exercise8();
            ex8.ShowDialog();
        }

        private void zadaniaToolStripMenuItem_Click(object sender, EventArgs e)
        { }
    }
}
