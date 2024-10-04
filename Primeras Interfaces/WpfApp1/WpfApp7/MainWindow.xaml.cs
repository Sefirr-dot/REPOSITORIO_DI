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

namespace WpfApp7
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int numero { get; set; }
        public int intentos { get; set; }
        public Boolean salir { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            
            tbNumeroSugerido.Visibility = Visibility.Collapsed;
            btAdivinar.Visibility = Visibility.Collapsed;
            txtNumero.Visibility = Visibility.Collapsed;
            intentos = 1;
            salir = false;
        }

        private void btAdivinar_Click(object sender, RoutedEventArgs e)
        {
            tbNumeroSugerido.Visibility = Visibility.Visible;
            btAdivinar.Visibility = Visibility.Visible;
            txtNumero.Visibility = Visibility.Visible;
            int numeroSugerido = int.Parse(tbNumeroSugerido.Text.ToString());
            
            if(intentos == 4)
            {
                salir = true;
            }
            if (intentos < 4 && !salir)
            {
                if (numeroSugerido < numero)
                {
                    labelAcierto.Content = "El numero es mayor";
                    intentos++;
                }
                else if (numeroSugerido > numero)
                {
                    labelAcierto.Content = "El numero es menor";
                    intentos++;
                }
                else
                {
                    labelAcierto.Content = $"Acertaste el numero era {numero}";
                    intentos = 10;
                    salir = false;
                }
                if (intentos == 2)
                {
                    tick_1.Visibility = Visibility.Collapsed;
                    cruz1.Visibility = Visibility.Visible;
                }
                else if (intentos == 3)
                {
                    tick_2.Visibility = Visibility.Collapsed;
                    cruz2.Visibility = Visibility.Visible;
                }
                else if (intentos == 4)
                {
                    tick_3.Visibility = Visibility.Collapsed;
                    cruz3.Visibility = Visibility.Visible;
                }

            }
            else if (salir)
            {
                labelAcierto.Content = $"Has perdido el numero era {numero}";

            }
 
            }

        private void Button_Click(object sender, RoutedEventArgs e) //dificl
        {
            Random rd = new Random();
            numero = rd.Next(100) + 1;
            tbNumeroSugerido.Visibility = Visibility.Visible;
            btAdivinar.Visibility = Visibility.Visible;
            txtNumero.Visibility = Visibility.Visible;
            btDificil.Visibility = Visibility.Collapsed;
            btFacil.Visibility = Visibility.Collapsed;
            tick_1.Visibility = Visibility.Visible;
            tick_2.Visibility = Visibility.Visible;
            tick_3.Visibility = Visibility.Visible;
            cruz1.Visibility = Visibility.Collapsed;
            cruz2.Visibility = Visibility.Collapsed;
            cruz3.Visibility = Visibility.Collapsed;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e) //facil
        {
            Random rd = new Random();
            numero = rd.Next(10) + 1;
            tbNumeroSugerido.Visibility = Visibility.Visible;
            btAdivinar.Visibility = Visibility.Visible;
            txtNumero.Visibility = Visibility.Visible;
            btDificil.Visibility = Visibility.Collapsed;
            btFacil.Visibility = Visibility.Collapsed;
            tick_1.Visibility = Visibility.Visible;
            tick_2.Visibility = Visibility.Visible;
            tick_3.Visibility = Visibility.Visible;
            cruz1.Visibility = Visibility.Collapsed;
            cruz2.Visibility = Visibility.Collapsed;
            cruz3.Visibility = Visibility.Collapsed;
        }
    }
}