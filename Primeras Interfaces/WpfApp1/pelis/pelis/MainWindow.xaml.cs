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

namespace pelis
{
    
    public partial class MainWindow : Window
    {
        List<Personaje> personajes = new List<Personaje>();
        private OmdbService _omdbService;

        public MainWindow()
        {
            InitializeComponent();
            _omdbService = new OmdbService();
        }

        private async void SearchButton_Click(object sender, RoutedEventArgs e)
        {
            string titulo = SearchBox.Text.Trim();

            if (!string.IsNullOrEmpty(titulo))
            {
                personajes.Add(await _omdbService.ObtenerPeliculasAsync(titulo));
                PeliculasDataGrid.ItemsSource = personajes;
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un título para buscar.");
            }
        }
    }
}