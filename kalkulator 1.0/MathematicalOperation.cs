using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kalkulator_1._0
{
    public static class MathematicalOperation
    {
        #region Opis działań matematycznych
        public static string informationAddition = "A + B = Wynik";
        public static string informationSubtraction = "A - B = Wynik";
        public static string informationMultiplication = "A * B = Wynik";
        public static string informationDivision = "A / B = Wynik";
        #endregion

        #region Działania matematyczne
        /// <summary>
        /// Metoda wykonująca odawanie
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>wynik działania</returns>
        public static float Addition(float A, float B)
        {
            var score = A + B;
            return score;
        }
        /// <summary>
        /// Metoda wykonująca odejmowanie
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>wynik działania</returns>
        public static float Subtraction(float A, float B)
        {
            var score = A - B;
            return score;
        }
        /// <summary>
        /// Metoda wykonująca mnożenie
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>wynik działania</returns>
        public static float Multiplication(float A, float B)
        {
            var score = A * B;
            return score;
        }
        /// <summary>
        /// Metoda wykonująca dzielenie
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>wynik działania</returns>
        public static float Division(float A, float B)
        {
            var score = A / B;
            return score;
        }
        #endregion

    }
}
