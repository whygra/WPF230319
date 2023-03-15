using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF230319
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        // вычислить и вывести среднее арифметическое
        private void CalcAvgArithmetic(object sender, RoutedEventArgs e)
        {
            if (!AreFieldsFilled()) return;
            double result = Utils.ArithmeticAvg(
                Utils.ParseDouble(txbNumA), Utils.ParseDouble(txbNumB), Utils.ParseDouble(txbNumC)
                );
            txbResult.Text = 
                $"Среднее арифметическое: {result:n2}";
        }

        // вычислить и вывести среднее геометрическое
        private void CalcAvgGeometric(object sender, RoutedEventArgs e)
        {
            // if (!AreFieldsFilled()) return;
            double result = Utils.GeometicAvg(
                Utils.ParseDouble(txbNumA), Utils.ParseDouble(txbNumB), Utils.ParseDouble(txbNumC)
                );
            txbResult.Text = 
                $"Среднее геометрическое: {result:n2}";
        }

        // вычислить корни уравнения
        private void CalcEquationRoots(object sender, RoutedEventArgs e)
        {
            if (!AreFieldsFilled()) return;

            (double a, double b, double c) =
                (Utils.ParseDouble(txbNumA), Utils.ParseDouble(txbNumB), Utils.ParseDouble(txbNumC));

            double d = Utils.CalcDiscriminant(a, b, c);
            // квадратный корень из дискриминанта - для упрощенного вычисления корней
            double sqrtD = Math.Sqrt(d);

            // варианты вычисления и вывода корней в зависимости от дискриминанта
            txbResult.Text = $"Уравнение ({a}x^2 + {b}x + {c} = 0)\n\n" + 
                d switch
            {
                < 0 => "У уравнения нет корней",
                > 0 => $"x1 = {Utils.CalcEquationRoot(a, b, sqrtD):n2}, x2 = {Utils.CalcEquationRoot(a, b, -sqrtD):n2}",
                0 => $"x = {Utils.CalcEquationRoot(a, b, sqrtD):n2}",
                _ => "",
            };
        }

        // проверка вводимых символов
        private void txbNum_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = Utils.AreCharsAllowed(e.Text);
        }

        // обработка изменения текста текстбокса для числа
        private void txbNum_TextChanged(object sender, TextChangedEventArgs e)
        {
            // сбросить блок вывода результата (уже не актуального)
            txbResult.Text = "";

            var txb = (TextBox)sender;
            // активировать кнопки при успешном парсинге
            bool isParsed = 
                btnCalcAvgArithmetic.IsEnabled = btnCalcAvgGeometric.IsEnabled = btnCalcEquationRoots.IsEnabled =
                Double.TryParse(txb.Text, out double num);

            // передать этому же текстбоксу полученное значение
            // исключаются возможные лишние символы
            if (isParsed)
                // обход пропадания точки
                txb.Text = Regex.IsMatch(txb.Text, @"\d*\.$") ?
                    $"{num}." :
                    $"{num}";
        }

        // проверка полей на заполненность
        private bool AreFieldsFilled() =>
            !String.IsNullOrEmpty(txbNumA.Text) &&
            !String.IsNullOrEmpty(txbNumB.Text) &&
            !String.IsNullOrEmpty(txbNumC.Text);

    }
}
