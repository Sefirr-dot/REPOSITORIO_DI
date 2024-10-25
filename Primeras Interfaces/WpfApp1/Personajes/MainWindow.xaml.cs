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
        public ObservableCollection<Objeto> listaObjetos {  get; set; }
        public ObservableCollection<Personaje> personajeList { get; set; }
        public ObservableCollection<Objeto> listaAux {  get; set; }
        public List<string> clases { get; set; }
        public List<string> genero { get; set; }
        public ObservableCollection<string> imagenes { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            listaObjetos = new ObservableCollection<Objeto>();
            Objeto o1 = new Objeto("Hacha", 50, 20);
            listaObjetos.Add(o1);
            listaAux = new ObservableCollection<Objeto>();
            personajeList = new ObservableCollection<Personaje>();
            Personaje p1 = new Personaje("Miguel", "Masculino", "Paldin", 100, 50,listaObjetos);

            personajeList.Add(p1);
            clases = new List<string>();
            genero = new List<string>();

            genero.Add("Masculino");
            genero.Add("Femenino");
            clases.Add("Mago");
            clases.Add("Paladin");
            clases.Add("Trasgo");
            clases.Add("Picaro");
            imagenes = new ObservableCollection<string>();

            imagenes.Add("/Mago.jpeg");
            imagenes.Add("/Paladin.jpeg");
            imagenes.Add("/Trasgo.jpeg");
            imagenes.Add("/Picaro.jpeg");


            this.DataContext = this;
        }

        private void listaPersonajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNombre.Text= personajeList[listaPersonajes.SelectedIndex].Nombre;
            txtGenero.Text = personajeList[listaPersonajes.SelectedIndex].Genero;
            txtClase.Text = personajeList[listaPersonajes.SelectedIndex].Clase;
            txtFuerza.Text = personajeList[listaPersonajes.SelectedIndex].Fuerza.ToString();
            txtInteligencia.Text = personajeList[listaPersonajes.SelectedIndex].Inteligencia.ToString();
            listaAux = personajeList[listaPersonajes.SelectedIndex].ObjetoList;
            imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[txBoxClase1.SelectedIndex], UriKind.Relative));

            dGridObjetos.ItemsSource = listaAux;

            


        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            Personaje p1 = new Personaje(txtNombre1.Text,txBoxGenero1.SelectedItem.ToString(),txBoxClase1.SelectedItem.ToString(),int.Parse(txtFuerza1.Text),int.Parse(txtInteligencia1.Text),listaObjetos);
            personajeList.Add(p1);
        }

        private void txBoxClase1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
           imagenCreacion.Source = new BitmapImage(new Uri(imagenes[txBoxClase1.SelectedIndex], UriKind.Relative));
            
        }

    }
}