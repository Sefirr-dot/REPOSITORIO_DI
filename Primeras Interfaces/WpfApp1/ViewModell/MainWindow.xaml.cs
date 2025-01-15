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

namespace ViewModell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel();
            this.DataContext = viewModel;

        }

        private void btAniadir_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBoxNombre.Text))
            {
                MessageBox.Show("El nombre no puede estar vacío.");
                return;
            }

            viewModel.agregarPersona(txtBoxNombre.Text, int.Parse(txtBoxEdad.Text));
        }

        private void dGridPersonas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (dGridPersonas.SelectedItem is Persona selectedPersonaje)
            {
                viewModel.PersonaSeleccionada = selectedPersonaje;
                
            }
             
            
        }

        private void btEnabled_Click(object sender, RoutedEventArgs e)
        {
            viewModel.ProgressValue++;
        }
        public async void StartDownloadClick(object sender, EventArgs e)
        {
            progressBarDownload.Value = 0;
            ProgressText.Content = "Descarga iniciada";

            for(int i = 0; i < 100; i++)
            {
                await Task.Delay(50);
                progressBarDownload.Value = i;
                ProgressText.Content = $"{i}% completo";
            }
            ProgressText.Content = "Descarga completada";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            StartDownloadClick(sender, e);
        }
    }
}