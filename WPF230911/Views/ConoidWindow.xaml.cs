﻿using System;
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
    /// Логика взаимодействия для ConoidWindow.xaml
    /// </summary>
    public partial class ConoidWindow : Window
    {

        Body _body = new(new Conoid(1, 1, 1), MaterialFactory.Steel);

        public ConoidWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // по загрузке окна передаем полям ввода значения фигуры
            var figure = (Conoid)(_body.Figure);
            txbxHeight.Text = $"{figure.Height:n2}";
            txbxRadiusBot.Text = $"{figure.R1:n2}";
            txbxRadiusTop.Text = $"{figure.R2:n2}";

            // привязка материалов к комбобоксу
            cmbxMaterial.ItemsSource = MaterialFactory.Materials;
            cmbxMaterial.DisplayMemberPath = "Name";
            // исходный материал - материал текущего тела
            cmbxMaterial.SelectedItem = _body.Material; 
        }

        #region 

        // парсинг всех параметров
        private Conoid ParseFigure(){
            double height = double.Parse(txbxHeight.Text);
            double radiusBot = double.Parse(txbxRadiusBot.Text);
            double radiusTop = double.Parse(txbxRadiusTop.Text);
            return new Conoid(height, radiusBot, radiusTop);
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
            _body.Material = e.AddedItems[0] as Material;

            // TODO: смена картинки

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
