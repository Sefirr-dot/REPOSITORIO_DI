using System.Collections.ObjectModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<String> list {  get; set; }
        public ObservableCollection<String> list2 { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            list = new ObservableCollection<string>();
            list2 = new ObservableCollection<string>();
            list.Add("KG");
            list.Add("GR");
            list2.Add("M");
            list2.Add("CM");
            
            this.DataContext = this;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void txboxi_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btCalcular_Click(object sender, RoutedEventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);
            double imc = 0;
            if (combitoBox2.SelectedIndex == 0)
            {
                if (combitoBox.SelectedIndex == 0)
                {
                    imc = Math.Round(peso / (altura * altura), 3);
                }
                else if (combitoBox.SelectedIndex == 1)
                {
                    imc = Math.Round(peso / 1000 / (altura * altura), 3);
                }
            } else if(combitoBox2.SelectedIndex == 1)
            {
                altura = altura / 100;
                if (combitoBox.SelectedIndex == 0)
                {
                    imc = Math.Round(peso / (altura * altura), 3);
                }
                else if (combitoBox.SelectedIndex == 1)
                {
                    imc = Math.Round(peso / 1000 / (altura * altura), 3);
                }
            }
            
            

            labelIMC.Content = imc;
            if(imc <= 18.5)
            {
                labelIndice.Content = "Peso inferior al normal";
                labelIndice.Foreground = Brushes.Red;
            } else if(imc <= 24.9)
            {
                labelIndice.Content = "Peso normal";
                labelIndice.Foreground = Brushes.Green;
            } else if (imc <= 29.9)
            {
                labelIndice.Content = "Peso superior al normal";
                labelIndice.Foreground = Brushes.Orange;
            }
            else
            {
                labelIndice.Content = "Obesidad";
                labelIndice.Foreground = Brushes.Red;
            }
        }
    }
}