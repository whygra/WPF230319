using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using WPF230319.Models;
using WPF230319.Models.Figures;

namespace WPF230319.Views
{
    /// <summary>
    /// Логика взаимодействия для CylinderWindow.xaml
    /// </summary>
    public partial class CylinderWindow : Window
    {

        Body _body = new(new Cylinder(1, 1), Materials.Steel);

        public CylinderWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // по загрузке окна передаем полям ввода значения фигуры
            var figure = (Cylinder)(_body.Figure);
            txbxHeight.Text = $"{figure.Height:n2}";
            txbxRadius.Text = $"{figure.Radius:n2}";

            // привязка материалов к комбобоксу
            cmbxMaterial.ItemsSource = Materials.All;
            cmbxMaterial.DisplayMemberPath = "Name";
            // исходный материал - материал текущего тела
            cmbxMaterial.SelectedItem = _body.Material;
        }

        #region 

        // парсинг всех параметров
        private Cylinder ParseFigure()
        {
            double height = double.Parse(txbxHeight.Text);
            double radius = double.Parse(txbxRadius.Text);
            return new Cylinder(height, radius);
        }

        // вычисления и вывод
        private void DoCalculations()
        {
            // защищенный блок - парсинг значений из полей
            try
            {
                _body.Figure = ParseFigure();
                ShowResults();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка",
                    MessageBoxButton.OK, MessageBoxImage.Error, MessageBoxResult.OK);
            }
        }

        // вычисление и вывод результатов
        private void ShowResults()
        {
            txblArea.Text = $"{_body.CalcSurfaceArea():n2}";
            txblVolume.Text = $"{_body.CalcVolume():n2}";
            txblMass.Text = $"{_body.CalcMass():n2}";
        }

        // Сброс результатов
        private void ResetResults()
        {
            txblArea.Text = txblMass.Text = txblVolume.Text = "--//--";
        }

        #endregion

        // при потере текстбоксом фокуса
        // очистка поля от мусора
        private void txbxNumeric_LostFocus(object sender, RoutedEventArgs e)
        {
            var txbx = (TextBox)sender;
            double.TryParse(txbx.Text, out double value);
            // при неудачном парсинге будет 0
            txbx.Text = $"{value}";
        }

        // команда вычислить
        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            DoCalculations();
        }

        // закрыть окно
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // смена материала
        private void cmbxMaterial_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            _body.Material = e.AddedItems[0] as Material ?? Materials.Steel;

            // смена картинки
            imgMaterial.BeginInit();
            imgMaterial.Source = new BitmapImage(
                new Uri($"pack://application:,,,/Images/Bodies/{_body.Material.EnName()}Cylinder.png"));
            imgMaterial.EndInit();

            txblMass.Text = "--//--";
        }


        // сброс полей вывода при изменении входных параметров
        private void txbxNumeric_TextChanged(object sender, TextChangedEventArgs e)
        {
            ResetResults();
        }

        // вычисление по нажатию Enter
        private void txbxNumeric_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.Key)
            {
                case Key.Enter:
                    // убирает фокус с поля ввода
                    // срабатывает "валидация" txbxNumeric_LostFocus
                    btnCalculate.Focus();
                    DoCalculations();
                    break;
            }
        }
    }
}
