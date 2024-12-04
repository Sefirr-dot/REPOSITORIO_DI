using Microsoft.EntityFrameworkCore;
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
        private Persona usuario;
        int errores;
        
        public MainWindow()
        {
            InitializeComponent();
            _context = new AppDbContext();
            _context.Database.EnsureCreated();
            usuario = new Persona();
            DataContext = usuario;
            errores = 0;
            loadPeople();
        }

        private void Validation_Error(object sender, ValidationErrorEventArgs e)
        {
            if(e.Action == ValidationErrorEventAction.Added)
            {
                errores++;
            }
            else
            {
                errores--;
            }
            if (errores == 0)
            {
            }
        }
        public void loadPeople()
        {
            using (var context = new AppDbContext())
            {
                var persona = context.Personas
                    .Include(b => b.EventosList)
                    .ToList();
                MessageBox.Show(persona[0].Nombre);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string nombre = txtName.Text;
            int edad = int.Parse(txtEdad.Text);
            try
            {
                var person = new Persona { Nombre = nombre, Edad = edad };
                _context.Personas.Add(person);
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
                    _context.Personas.Remove(selectedPersona);
                    _context.SaveChanges();
                    loadPeople();
                }
            } catch { }
        }
        private void Modificar_Persona(int id, string nuevonombre, int nuevaEdad)
        {
            using (var context = new AppDbContext())
            {
                var persona = context.Personas.FirstOrDefault(p => p.Id == id);

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
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Persona p = (Persona)dgPeople.SelectedItem;

                var eventos = p.EventosList;

                foreach ( var evento in eventos )
                {
                    MessageBox.Show(evento.Nombre);
                }
            
            
        }
    }
}