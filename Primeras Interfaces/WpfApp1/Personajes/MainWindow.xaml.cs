using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.ObjectModel;
using System.Configuration;
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
            Personaje p1 = new Personaje("Miguel", "Masculino", "Paladin", 100, 50,listaObjetos);

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
            cargarPersonajes();


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

            dGridObjetos.ItemsSource = listaAux;

            if (personajeList[listaPersonajes.SelectedIndex].Clase == "Mago")
            {
                imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[0], UriKind.Relative));

            } else if(personajeList[listaPersonajes.SelectedIndex].Clase == "Paladin")
            {
                imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[1], UriKind.Relative));

            } else if (personajeList[listaPersonajes.SelectedIndex].Clase == "Trasgo")
            {
                imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[2], UriKind.Relative));

            } else if (personajeList[listaPersonajes.SelectedIndex].Clase == "Picaro")
            {
                imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[3], UriKind.Relative));

            }





        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            Personaje p1 = new Personaje(txtNombre1.Text,txBoxGenero1.SelectedItem.ToString(),txBoxClase1.SelectedItem.ToString(),int.Parse(txtFuerza1.Text),int.Parse(txtInteligencia1.Text),null);
            personajeList.Add(p1);
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO personajes (Nombre,Genero,Clase,Fuerza,Inteligencia) VALUES (@Nombre,@Genero,@Clase,@Fuerza,@Inteligencia)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", p1.Nombre);
                    cmd.Parameters.AddWithValue("@Genero", p1.Genero);
                    cmd.Parameters.AddWithValue("@Clase", p1.Clase);
                    cmd.Parameters.AddWithValue("@Fuerza", p1.Fuerza);
                    cmd.Parameters.AddWithValue("@Inteligencia", p1.Inteligencia);
                    cmd.ExecuteNonQuery();
                } 
            }
        }
        public void cargarPersonajes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Nombre, Genero, Clase, Fuerza, Inteligencia FROM personajes";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString("Nombre");
                            string genero = reader.GetString("Genero");
                            string clase = reader.GetString("Clase");
                            string fuerza = reader.GetString("Fuerza");
                            string inteligencia = reader.GetString("Inteligencia");
                            personajeList.Add(new Personaje(nombre, genero, clase, int.Parse(fuerza), int.Parse(inteligencia),null));
                        }
                    }
                } 
            }
        }

        public void cargarObjetos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT idObjetos, nombreObjeto, fuerzaObjeto, inteligenciaObjeto FROM objetos";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString("nombreObjeto");
                            string fuerza = reader.GetString("fuerzaObjeto");
                            string inteligencia = reader.GetString("nombreObjeto");
                            
                        }
                    }
                }
            }
        }

        private void txBoxClase1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
           imagenCreacion.Source = new BitmapImage(new Uri(imagenes[txBoxClase1.SelectedIndex], UriKind.Relative));
            
        }

        private void sliderFuerza1_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txbFuerza.Text = "Fuerza: "+sliderFuerza1.Value;
        }
    }
}