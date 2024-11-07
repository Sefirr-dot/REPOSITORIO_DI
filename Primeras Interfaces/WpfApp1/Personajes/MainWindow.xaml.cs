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
            Objeto o1 = new Objeto("Hacha","hola", 50, 20,20,20);
            listaObjetos.Add(o1);
            listaAux = new ObservableCollection<Objeto>();
            personajeList = new ObservableCollection<Personaje>();



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
            txtDestreza.Text = personajeList[listaPersonajes.SelectedIndex].Destreza.ToString();
            txtResistencia.Text = personajeList[listaPersonajes.SelectedIndex].Resistencia.ToString();

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
            tabItemInventario.IsEnabled = true;




        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            Personaje p1 = new Personaje(txtNombre1.Text,txBoxClase1.SelectedItem.ToString(), txBoxGenero1.SelectedItem.ToString(),(int) Math.Round(sliderFuerza1.Value * 10), (int)Math.Round(sliderInteligencia.Value * 10), (int)Math.Round(sliderDestreza.Value * 10), (int)Math.Round(sliderResistencia.Value * 10));
            personajeList.Add(p1);
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using(MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO personaje (Nombre,Clase,Genero,Fuerza,Inteligencia,Destreza,Resistencia,Foto) VALUES (@Nombre,@Clase,@Genero,@Fuerza,@Inteligencia,@Destreza,@Resistencia,@Foto)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", p1.Nombre);
                    cmd.Parameters.AddWithValue("@Clase", p1.Clase);
                    cmd.Parameters.AddWithValue("@Genero", p1.Genero);                 
                    cmd.Parameters.AddWithValue("@Fuerza", p1.Fuerza);
                    cmd.Parameters.AddWithValue("@Inteligencia", p1.Inteligencia);
                    cmd.Parameters.AddWithValue("@Destreza", p1.Destreza);
                    cmd.Parameters.AddWithValue("@Resistencia", p1.Resistencia);
                    cmd.Parameters.AddWithValue("@Foto", "C:/Users/Alumno/Desktop/Interfaces/REPOSITORIO_DI/Primeras Interfaces/WpfApp1/Personajes/Paladin.jpeg");
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
                string query = "SELECT Nombre,Clase, Genero, Fuerza, Inteligencia, Destreza, Resistencia FROM personaje";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string nombre = reader.GetString("Nombre");
                            string clase = reader.GetString("Clase");
                            string genero = reader.GetString("Genero");
                            int fuerza = reader.GetInt32("Fuerza");
                            int inteligencia = reader.GetInt32("Inteligencia");
                            int destreza = reader.GetInt32("Destreza");
                            int resistencia = reader.GetInt32("Resistencia");
                            personajeList.Add(new Personaje(nombre, clase, genero, fuerza, inteligencia,destreza,resistencia));
                        }
                    }
                } 
            }
        }

        public void cargarObjetosPersonaje()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT nombre, tipo, fuerza, inteligencia, destreza, resistencia FROM objeto o INNER JOIN inventario i ON o.id=i.objeto_id WHERE o.id=@ID";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {

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
            txbFuerza.Text = "Fuerza: "+Math.Round(sliderFuerza1.Value*10);
        }

        private void sliderInteligencia_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txbInteligencia.Text = "Inteligencia: " + Math.Round(sliderInteligencia.Value * 10);
        }

        private void sliderDestreza_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txbDestreza.Text = "Destreza: " + Math.Round(sliderDestreza.Value * 10);
        }



        private void sliderResistencia_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            txbResistencia.Text = "Resistencia: " + Math.Round(sliderResistencia.Value * 10);
        }
    }
}