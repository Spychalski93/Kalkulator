using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_1._0
{
    public partial class Form1 : Form
    {
        public string instruction = "Najedż kursorem myszy na wybrane działanie" +
                " i przeczytaj szczegóły. Następnie wpisz dwie liczby i wybierz" +
                " działanie.";


        public Form1()
        {
            InitializeComponent();
        }

        private void sum_MouseEnter(object sender, EventArgs e)
        {
            textBoxInstruction.Text = MathematicalOperation.informationAddition;
        }

        private void difference_MouseEnter(object sender, EventArgs e)
        {
            textBoxInstruction.Text = "A - B = Wynik";
        }

        private void sum_MouseLeave(object sender, EventArgs e)
        {
            textBoxInstruction.Text = instruction;
        }

        private void difference_MouseLeave(object sender, EventArgs e)
        {
            textBoxInstruction.Text = instruction;
        }

        private void sum_Click(object sender, EventArgs e)

        {
            float A = float.Parse(textBoxNumberA.Text);
            float B = float.Parse(textBoxNumberB.Text);
            textBoxScore.Text = "" + MathematicalOperation.Addition(A,B);
        }

        private void difference_Click(object sender, EventArgs e)
        {

        }
    }
}
