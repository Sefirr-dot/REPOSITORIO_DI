using MySql.Data.MySqlClient;
using System.Collections;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Configuration;
using System.Data;
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
        public ObservableCollection<Objeto> listaObjetos { get; set; }
        public ObservableCollection<Personaje> personajeList { get; set; }
        public ObservableCollection<Objeto> listaAux { get; set; }
        public List<string> clases { get; set; }
        public List<string> genero { get; set; }
        public ObservableCollection<string> imagenes { get; set; }
        public ObservableCollection<string> imagesPersonajes { get; set; }
        private ICollectionView vistafiltrada;
        public MainWindow()
        {
            InitializeComponent();
            listaObjetos = new ObservableCollection<Objeto>();

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
            
            aniadirObjetosATablaDeTodosLosObjetos();


            this.DataContext = this;
            vistafiltrada = CollectionViewSource.GetDefaultView(listaAux);
            vistafiltrada = CollectionViewSource.GetDefaultView(personajeList);
            listaPersonajes.ItemsSource = vistafiltrada;
        }

        private async Task<ObservableCollection<Personaje>> ObtenerPersonasAsync()
        {
            ObservableCollection<Personaje> listPersonas = new ObservableCollection<Personaje>();
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;

            using (var conn = new MySqlConnection(connectionString))
            {
                await conn.OpenAsync();
                string query = "SELECT Id,Nombre,Clase, Genero, Fuerza, Inteligencia, Destreza, Resistencia, Foto FROM personaje";
                
                using (var cmd = new MySqlCommand(query, conn))
                {
                    using (var reader = await cmd.ExecuteReaderAsync())
                    {
                        while (await reader.ReadAsync())
                        {
                            int id = reader.GetInt32("Id");
                            string nombre = reader.GetString("Nombre");
                            string clase = reader.GetString("Clase");
                            string genero = reader.GetString("Genero");
                            int fuerza = reader.GetInt32("Fuerza");
                            int inteligencia = reader.GetInt32("Inteligencia");
                            int destreza = reader.GetInt32("Destreza");
                            int resistencia = reader.GetInt32("Resistencia");
                            string foto = reader.GetString("Foto");
                            personajeList.Add(new Personaje(id, nombre, clase, genero, fuerza, inteligencia, destreza, resistencia, foto));
                        }
                    }
                    conn.Close();
                }
            }
            return listPersonas;
        }
        private void Filtrar(string texto)
        {
            vistafiltrada.Filter = personaje =>
            {
                if (personaje is Personaje p1)
                {
                    return string.IsNullOrEmpty(texto.ToLower()) || p1.Nombre.Contains(texto.ToLower(), StringComparison.OrdinalIgnoreCase);
                }
                return false;
            };
            vistafiltrada.Refresh();
            vistafiltrada = CollectionViewSource.GetDefaultView(personajeList);
            listaPersonajes.ItemsSource = vistafiltrada;
        }
        private void listaPersonajes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Check if an item is selected
            if (listaPersonajes.SelectedItem is Personaje selectedPersonaje)
            {
                // Use the selected object directly
                txtNombre.Text = selectedPersonaje.Nombre;
                txtGenero.Text = selectedPersonaje.Genero;
                txtClase.Text = selectedPersonaje.Clase;
                txtFuerza.Text = selectedPersonaje.Fuerza.ToString();
                txtInteligencia.Text = selectedPersonaje.Inteligencia.ToString();
                txtDestreza.Text = selectedPersonaje.Destreza.ToString();
                txtResistencia.Text = selectedPersonaje.Resistencia.ToString();

                dGridObjetos.ItemsSource = listaAux;

                // Set the image based on the selected character's class
                switch (selectedPersonaje.Clase)
                {
                    case "Mago":
                        imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[0], UriKind.Relative));
                        break;
                    case "Paladin":
                        imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[1], UriKind.Relative));
                        break;
                    case "Trasgo":
                        imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[2], UriKind.Relative));
                        break;
                    case "Picaro":
                        imagenPersonajes.Source = new BitmapImage(new Uri(imagenes[3], UriKind.Relative));
                        break;
                }

                tabItemInventario.IsEnabled = true;
                cargarObjetosPersonaje(selectedPersonaje.Id);
            }
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO personaje (Nombre,Clase,Genero,Fuerza,Inteligencia,Destreza,Resistencia,Foto) VALUES (@Nombre,@Clase,@Genero,@Fuerza,@Inteligencia,@Destreza,@Resistencia,@Foto)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre1.Text);
                    cmd.Parameters.AddWithValue("@Clase", txBoxClase1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Genero", txBoxGenero1.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Fuerza", (int)Math.Round(sliderFuerza1.Value * 10));
                    cmd.Parameters.AddWithValue("@Inteligencia", (int)Math.Round(sliderInteligencia.Value * 10));
                    cmd.Parameters.AddWithValue("@Destreza", (int)Math.Round(sliderDestreza.Value * 10));
                    cmd.Parameters.AddWithValue("@Resistencia", (int)Math.Round(sliderResistencia.Value * 10));
                    cmd.Parameters.AddWithValue("@Foto", "C:/Users/Alumno/Desktop/Interfaces/REPOSITORIO_DI/Primeras Interfaces/WpfApp1/Personajes/" + txBoxClase1.SelectedItem.ToString() + ".jpeg");
                    cmd.ExecuteNonQuery();
                }
            }
            cargarPersonajes();
        }
        public void cargarPersonajes()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id,Nombre,Clase, Genero, Fuerza, Inteligencia, Destreza, Resistencia, Foto FROM personaje";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string nombre = reader.GetString("Nombre");
                            string clase = reader.GetString("Clase");
                            string genero = reader.GetString("Genero");
                            int fuerza = reader.GetInt32("Fuerza");
                            int inteligencia = reader.GetInt32("Inteligencia");
                            int destreza = reader.GetInt32("Destreza");
                            int resistencia = reader.GetInt32("Resistencia");
                            string foto = reader.GetString("Foto");
                            personajeList.Add(new Personaje(id, nombre, clase, genero, fuerza, inteligencia, destreza, resistencia, foto));
                        }
                    }
                }
            }
        }
        public void aniadirObjetosATablaDeTodosLosObjetos()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT * FROM objeto";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("id");
                            String nombre = reader.GetString("nombre");
                            String tipo = reader.GetString("tipo");
                            int fuerza = reader.GetInt32("fuerza");
                            int inteligencia = reader.GetInt32("inteligencia");
                            int destreza = reader.GetInt32("destreza");
                            int resistencia = reader.GetInt32("resistencia");

                            Objeto objeto = new Objeto(id, nombre, tipo, fuerza, inteligencia, destreza, resistencia);
                            listaObjetos.Add(objeto);

                        }
                    }
                }
            }

        }
        public void cargarObjetosPersonaje(int id)
        {
            // Limpiar la lista antes de cargar nuevos datos
            listaAux.Clear();

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();

                // Obtener el ID del personaje seleccionado
                int personajeId = id;

                // Consulta para obtener los objetos del personaje seleccionado
                string query = "SELECT o.id AS objeto_id, o.nombre AS objeto_nombre, o.tipo AS objeto_tipo, o.fuerza AS objeto_fuerza," +
                               " o.inteligencia AS objeto_inteligencia, o.destreza AS objeto_destreza, o.resistencia AS objeto_resistencia," +
                               " i.equipado AS objeto_equipado FROM Inventario i JOIN Objeto o ON i.objeto_id = o.id WHERE i.personaje_id = @PersonajeId";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    // Parámetro seguro para evitar inyección SQL
                    cmd.Parameters.AddWithValue("@PersonajeId", personajeId);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Crear una instancia de Objeto con los datos del lector
                            int objetoId = reader.GetInt32("objeto_id");
                            string nombre = reader.GetString("objeto_nombre");
                            string tipo = reader.GetString("objeto_tipo");
                            int fuerza = reader.GetInt32("objeto_fuerza");
                            int inteligencia = reader.GetInt32("objeto_inteligencia");
                            int destreza = reader.GetInt32("objeto_destreza");
                            int resistencia = reader.GetInt32("objeto_resistencia");


                            // Agregar el objeto a la lista auxiliar
                            Objeto objeto = new Objeto(objetoId, nombre, tipo, fuerza, inteligencia, destreza, resistencia);
                            listaAux.Add(objeto);
                        }
                    }
                }
            }

            // Establecer el ItemsSource de dGridObjetos para que refleje listaAux
            dGridObjetos.ItemsSource = listaAux;
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
            txbFuerza.Text = "Fuerza: " + Math.Round(sliderFuerza1.Value * 10);
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO inventario (personaje_id,objeto_id,equipado) VALUES (@personaje_id,@objeto_id,@equipado)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (listaPersonajes.SelectedItem is Personaje selectedPersonaje)
                    {
                        cmd.Parameters.AddWithValue("@personaje_id", selectedPersonaje.Id);
                        cmd.Parameters.AddWithValue("@objeto_id", listaObjetos[listaObjetosInventario.SelectedIndex].Id);
                        cmd.Parameters.AddWithValue("@equipado", 1);
                        cmd.ExecuteNonQuery();
                        cargarObjetosPersonaje(selectedPersonaje.Id);
                    }
                        
                }
            }
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private int cogerIdInventario()
        {
            int id = 0;
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT max(id) as id FROM inventario WHERE personaje_id = @personaje_id AND objeto_id = @objeto_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@personaje_id", personajeList[listaPersonajes.SelectedIndex].Id);
                    cmd.Parameters.AddWithValue("@objeto_id", listaAux[dGridObjetos.SelectedIndex].Id);
                    cmd.ExecuteNonQuery();
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            id = reader.GetInt32("id");

                        }
                    }
                }
            }
            return id;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM inventario WHERE personaje_id = @personaje_id AND objeto_id = @objeto_id AND id=@id_inventario;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    if (listaPersonajes.SelectedItem is Personaje selectedPersonaje)
                    {
                        cmd.Parameters.AddWithValue("@personaje_id", selectedPersonaje.Id);
                        cmd.Parameters.AddWithValue("@objeto_id", listaAux[dGridObjetos.SelectedIndex].Id);
                        cmd.Parameters.AddWithValue("@id_inventario", cogerIdInventario());


                        cmd.ExecuteNonQuery();
                        cargarObjetosPersonaje(selectedPersonaje.Id);
                    }

                        
                }
            }
            
        }

        private void Filtro_TextChanged(object sender, TextChangedEventArgs e)
        {
            Filtrar(Filtro.Text);
        }

        
    }
}