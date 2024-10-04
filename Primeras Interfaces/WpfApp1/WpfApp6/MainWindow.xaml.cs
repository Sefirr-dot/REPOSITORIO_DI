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

namespace WpfApp6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public ObservableCollection<String> lista;
        public MainWindow()
        {

            InitializeComponent();
            lista = new ObservableCollection<string>();

            tbUnidades.Visibility = Visibility.Collapsed;
            txtUnidades.Text = "";
            txtUnidadesBaseT.Visibility = Visibility.Collapsed;
            tbUnidadesBaseT.Visibility = Visibility.Collapsed;
            this.DataContext = this;
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            tbUnidadesBaseT.Visibility = Visibility.Collapsed;
            txtUnidadesBaseT.Visibility = Visibility.Collapsed;
            if (rdCirculo.IsChecked == true)
            {
                
                txtUnidades.Text = "Radio del circulo";
                tbUnidades.Visibility = Visibility.Visible;
                
            } else if (rdCuadrado.IsChecked == true)
            {
                tbUnidadesBaseT.Visibility = Visibility.Collapsed;
                txtUnidades.Text = "Lado del cuadrado";
                tbUnidades.Visibility = Visibility.Visible;
            } else if (rdTriangulo.IsChecked == true)
            {
                txtUnidades.Text = "Altura del triangulo";
                tbUnidades.Visibility = Visibility.Visible;
                tbUnidadesBaseT.Visibility = Visibility.Visible;
                txtUnidadesBaseT.Visibility = Visibility.Visible;
                txtUnidadesBaseT.Text = "Base del triangulo: ";
                
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double unidades = double.Parse(tbUnidades.Text.ToString());
            if (rdCirculo.IsChecked == true)
            {
                unidades = unidades * double.Pi * unidades;

            } else if(rdCuadrado.IsChecked == true)
            {
                unidades = unidades * unidades;
            } else if(rdTriangulo.IsChecked == true)
            {
                double baseT = double.Parse(tbUnidadesBaseT.Text.ToString());
                unidades = (unidades * baseT) / 2;
            }
            labelSolucion.Content = unidades.ToString();
        }


    }
}