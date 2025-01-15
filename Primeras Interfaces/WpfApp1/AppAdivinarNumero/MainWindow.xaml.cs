using System.Windows;

namespace AppAdivinarNumero
{
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        private int numeroObjetivo;

        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            numeroObjetivo = random.Next(1, 101); 
            viewModel = new MainViewModel();
            DataContext = viewModel;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.StartDificil();
            txtPista.Content = "Elige un número.";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            viewModel.StartFacil();
            txtPista.Content = "Elige un número.";
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (int.TryParse(txBoxNumero.Text, out int numeroIngresado))
            {
                if (numeroIngresado == numeroObjetivo)
                {
                    txtPista.Content = "¡Correcto! Has ganado.";
                    viewModel.ResetGame();
                }
                else if (numeroIngresado < numeroObjetivo)
                {
                    txtPista.Content = "El número es mayor.";
                }
                else
                {
                    txtPista.Content = "El número es menor.";
                }
            }
            else
            {
                txtPista.Content = "Introduce un número válido.";
            }
        }
    }
}
