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
               
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (dgPeople.SelectedItem is Persona selectedPersona)
                {
                    _context.personas.Remove(selectedPersona);
                    _context.SaveChanges();
                    loadPeople();
                }
            } catch { }
        }
        private void Modificar_Persona(int id, string nuevonombre, int nuevaEdad)
        {
            using (var context = new AppDbContext())
            {
                var persona = context.personas.FirstOrDefault(p => p.Id == id);

                if(persona != null)
                {
                    persona.Nombre = nuevonombre;
                    persona.Edad = nuevaEdad;

                    
                    _context.SaveChanges();
                    loadPeople();

                } else
                {
                    MessageBox.Show($"Error al cargar los datos");
                }
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (dgPeople.SelectedItem is Persona selectedPersona)
            {
                Modificar_Persona(selectedPersona.Id, txtName.Text, int.Parse(txtEdad.Text));
            }
        }

        private void dgPeople_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            string nombreMasco = txtNameMascota.Text.Trim();
            string tipo = txtTypeMascota.Text.Trim();

            Persona p = (Persona)dgPeople.SelectedItem;
            if(p != null)
            {
                Mascota m = new Mascota();
                m.Nombre = nombreMasco;
                m.Tipo = tipo;
                m.PersonaId = p.Id;

                _context.mascotas.Add(m);
                _context.SaveChanges();
            }
        }
    }
}