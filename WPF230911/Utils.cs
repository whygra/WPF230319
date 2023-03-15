using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WPF230319
{
    public static class Utils
    {
        // регулярное выражение для чисел
        public static readonly Regex _regexNumChars = new Regex("[^0-9.-]+");

        // проверка строки на соответствие регулярному выражению
        public static bool AreCharsAllowed(string text) =>
            _regexNumChars.IsMatch(text);

        public static double ArithmeticAvg(params double[] numbers) =>
            numbers.Average();

        public static double GeometicAvg(params double[] numbers) =>
            // корень степени <количество чисел> из произведения всех чисел
            Root(numbers.Aggregate((a, b) => a * b), numbers.Length);


        // извлекает корень степени y из числа x
        public static double Root(double x, double y) =>
            Math.Pow(x, 1d / y);


        // парсит вещественное число из текстбокса
        public static double ParseDouble(TextBox txb) =>
            Double.Parse(txb.Text);

        // дискриминант
        public static double CalcDiscriminant(double a, double b, double c) =>
            b * b - 4 * a * c;

        // вычислить корень, входные параметры: коэфициенты a, b и корень из дискриминанта
        public static double CalcEquationRoot(double a, double b, double sqrtD) =>
            (-b + sqrtD) / (2 * a);
    }
}
