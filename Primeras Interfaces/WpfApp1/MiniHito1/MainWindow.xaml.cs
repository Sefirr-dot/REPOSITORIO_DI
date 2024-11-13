using MySql.Data.MySqlClient;
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

namespace MiniHito1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public ObservableCollection<Proyecto> listaProyectos { get; set; }
        public ObservableCollection<Empleado> listaEmpleados {  get; set; }
        public ObservableCollection<string> nombreProyectos { get; set; }
        public ObservableCollection<double> presupuestoProyectos { get; set; }
        public ObservableCollection<int> ids {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            nombreProyectos = new ObservableCollection<string>();
            presupuestoProyectos = new ObservableCollection<double>();
            ids = new ObservableCollection<int>();
            listaEmpleados = new ObservableCollection<Empleado>();
            listaProyectos = new ObservableCollection<Proyecto>();
            cargarEmpleados();
            cargarProyectos();
            ComboBoxEmpleados.ItemsSource = listaEmpleados;
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {


            if(txtBoxNombreProyecto.Text.ToString().Length == 0)
            {
                labelError.Content = "El nombre del proyecto no puede esta vacio";
            }
            else
            {
                labelError.Content = "";
                nombreProyectos.Add(txtBoxNombreProyecto.Text.ToString());
            }
            if (double.Parse(txBoxPresupuesto.Text.ToString()) <= 0)
            {
                labelError.Content = "El presupuesto no puede ser 0 o menor que 0";
            } else
            {
                labelError.Content = "";
                presupuestoProyectos.Add(double.Parse(txBoxPresupuesto.Text.ToString()));
            }

            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO proyecto (nombre,presupuesto_inicial) VALUES (@Nombre,@Presupuesto_inicial)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txtBoxNombreProyecto.Text.ToString());
                    cmd.Parameters.AddWithValue("Presupuesto_inicial", double.Parse(txBoxPresupuesto.Text.ToString()));

                    cmd.ExecuteNonQuery();
                }
            }
            cargarProyectos();

            foreach (var proyec in listaProyectos)
            {
                if (proyec.Nombre.Equals(txtBoxNombreProyecto.Text.ToString()))
                {
                    labelID.Content = proyec.Id.ToString();
                }
            }


            if (labelError.Content.ToString().Length == 0)
            {
                tabClientes.IsEnabled = true;
                tabClientes.Focus();
            }
            
            
        }

        public void cargarEmpleados()
        {
            listaEmpleados.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id,Nombre,Rol, Coste_por_hora FROM empleado";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string nombre = reader.GetString("Nombre");
                            string rol = reader.GetString("Rol");
                            double coste_por_hora = reader.GetDouble("Coste_por_hora");
                
                            listaEmpleados.Add(new Empleado(id, nombre, rol, coste_por_hora));
                        }
                    }
                }
            }
            dGridEmpleados.ItemsSource = listaEmpleados;
        }

        public void cargarProyectos()
        {
            listaProyectos.Clear();
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "SELECT Id,Nombre,Presupuesto_inicial FROM proyecto";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int id = reader.GetInt32("Id");
                            string nombre = reader.GetString("Nombre");
                            double presupuesto = reader.GetDouble("Presupuesto_inicial");

                            listaProyectos.Add(new Proyecto(id, nombre, presupuesto));
                        }
                    }
                }
            }
            dGridProyectos.ItemsSource = listaProyectos;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        { 
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO empleado (nombre,rol,coste_por_hora) VALUES (@Nombre,@Rol,@Coste_por_hora)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Nombre", txBoxNombreEmpleado.Text.ToString());
                    cmd.Parameters.AddWithValue("@Rol", txBoxRolEmpleado.Text.ToString());
                    cmd.Parameters.AddWithValue("@Coste_por_hora", txBoxCosteEmpleado.Text.ToString());
                    
                    cmd.ExecuteNonQuery();
                }
            }
            cargarEmpleados();
        }

        

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM empleado WHERE id = @empleado_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@empleado_id", listaEmpleados[dGridEmpleados.SelectedIndex].Id);


                    cmd.ExecuteNonQuery();
                }
            }
            cargarEmpleados();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "DELETE FROM proyecto WHERE id = @proyecto_id;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@proyecto_id", listaProyectos[dGridProyectos.SelectedIndex].Id);


                    cmd.ExecuteNonQuery();
                }
            }
            cargarProyectos();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["MySqlConnection"].ConnectionString;
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                conn.Open();
                string query = "INSERT INTO proyecto_empleado (proyecto_id,empleado_id) VALUES (@Proyecto_id,@Empleado_id)";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Proyecto_id", listaProyectos[dGridProyectos.SelectedIndex].Id);
                    cmd.Parameters.AddWithValue("@Empleado_id", listaEmpleados[ComboBoxEmpleados.SelectedIndex].Id);

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}