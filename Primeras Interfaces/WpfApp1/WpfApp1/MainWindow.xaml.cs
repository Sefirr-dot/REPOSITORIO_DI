﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btSumat_Click(object sender, RoutedEventArgs e)
        {
            int primerNumero = int.Parse(numero1.Text);
            int segundoNumero = int.Parse(numero2.Text);
            int sumatotal = primerNumero + segundoNumero;
            holaLabel.Content= sumatotal;
        }

        private void btResta_Click(object sender, RoutedEventArgs e)
        {
            int primerNumero = int.Parse(numero1.Text);
            int segundoNumero = int.Parse(numero2.Text);
            int sumatotal = primerNumero - segundoNumero;
            holaLabel.Content = sumatotal;
        }
    }
}