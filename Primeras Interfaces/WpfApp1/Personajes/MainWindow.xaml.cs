using System.Collections;
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

namespace Personajes
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        public ObservableCollection<Personaje> personajeList { get; set; }
        public List<string> clases { get; set; }
        public List<string> genero { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            personajeList = new ObservableCollection<Personaje>();
            Personaje p1 = new Personaje("Miguel", "Masculino", "Paldin", 100, 50);
            personajeList.Add(p1);
            clases = new List<string>();
            genero = new List<string>();
            genero.Add("Masculino");
            genero.Add("Femenino");
            clases.Add("Mago");
            clases.Add("Paladin");
            clases.Add("Trasgo");
            clases.Add("Elfo");
            this.DataContext = this;
        }

        private void listaPersonajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNombre.Text= personajeList[listaPersonajes.SelectedIndex].Nombre;
            txtGenero.Text = personajeList[listaPersonajes.SelectedIndex].Genero;
            txtClase.Text = personajeList[listaPersonajes.SelectedIndex].Clase;
            txtFuerza.Text = personajeList[listaPersonajes.SelectedIndex].Fuerza.ToString();
            txtInteligencia.Text = personajeList[listaPersonajes.SelectedIndex].Inteligencia.ToString();


        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            Personaje p1 = new Personaje(txtNombre1.Text,txBoxGenero1.SelectedItem.ToString(),txBoxClase1.SelectedItem.ToString(),int.Parse(txtFuerza1.Text),int.Parse(txtInteligencia1.Text));
            personajeList.Add(p1);
        }
    }
}