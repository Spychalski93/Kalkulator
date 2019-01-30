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

        public Form1()
        {
            InitializeComponent();
        }

        #region Pola pomocnicze
        /// <summary>
        /// Treść instrukcji wyświetlanej domyślnie w <see cref="textBoxInstruction"/>
        /// </summary>
        public string instructionBegin = "Najedż kursorem myszy na wybrane działanie" +
                " i przeczytaj szczegóły. Następnie wpisz dwie liczby i wybierz" +
                " działanie.";
        #endregion

        #region Metody pomocnicze
        private static void CharacterRestrictions(KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9'
                                        || e.KeyChar == 8 || e.KeyChar == ',')
                e.Handled = false;
            else
                e.Handled = true;
        }
        #endregion  

        #region MauseEnter     
        private void sum_MouseEnter(object sender, EventArgs e)
        {
            textBoxInstruction.Text = MathematicalOperation.informationAddition;
        }

        private void difference_MouseEnter(object sender, EventArgs e)
        {
            textBoxInstruction.Text = "A - B = Wynik";
        }
        #endregion

        #region MauseLeave
        private void sum_MouseLeave(object sender, EventArgs e)
        {
            textBoxInstruction.Text = instructionBegin;
        }

        private void difference_MouseLeave(object sender, EventArgs e)
        {
            textBoxInstruction.Text = instructionBegin;
        }
        #endregion

        #region Click
        private void sum_Click(object sender, EventArgs e)

        {
            float A = float.Parse(textBoxNumberA.Text);
            float B = float.Parse(textBoxNumberB.Text);
            textBoxScore.Text = "" + MathematicalOperation.Addition(A, B);
        }

        private void difference_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region KeyPress
        private void textBoxNumberA_KeyPress(object sender, KeyPressEventArgs e)
        {
            CharacterRestrictions(e);
        }

        private void textBoxNumberB_KeyPress(object sender, KeyPressEventArgs e)
        {
            CharacterRestrictions(e);
        }
        #endregion
    }
}
