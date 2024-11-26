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

namespace EntityFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private AppDbContext _context;
        public MainWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            loadPeople();
        }
        public void loadPeople()
        {
            try
            {
                var people = _context.personas.ToList();
                dgPeople.ItemsSource = people;
            }
            catch(Exception ex) 
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtName.Text;
            int edad = int.Parse(txtEdad.Text);
            try
            {
                var person = new Persona { Nombre = nombre, Edad = edad };
                _context.personas.Add(person);
                _context.SaveChanges();
                MessageBox.Show("Persona agregada exitosamente");
                txtEdad.Clear();
                txtName.Clear();
                loadPeople();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }
    }
}