﻿using System;
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
using WPF230319.Views;

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


        private void btnShowConoidWindow_Click(object sender, RoutedEventArgs e)
        {
            new ConoidWindow().ShowDialog();
        }

        private void btnShowSphereWindow_Click(object sender, RoutedEventArgs e)
        {
            new SphereWindow().ShowDialog();
        }

        private void btnShowCylinderWindow_Click(object sender, RoutedEventArgs e)
        {
            new CylinderWindow().ShowDialog();
        }

        private void btnShowParallelepipedWindow_Click(object sender, RoutedEventArgs e)
        {
            new ParallelepipedWindow().ShowDialog();
        }

        private void btnAbout_Click(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }
    }
}
