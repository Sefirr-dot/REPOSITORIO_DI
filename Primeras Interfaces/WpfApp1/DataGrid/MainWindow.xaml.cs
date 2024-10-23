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

namespace DataGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public ObservableCollection<Persona> personas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            personas = new ObservableCollection<Persona>();
            Persona p1 = new Persona("Jose", "Gonzalez", 27);
            Persona p2 = new Persona("Pedro", "Perez", 67);
            Persona p3 = new Persona("Antonia", "Maestre", 11);
            personas.Add(p1);
            personas.Add(p2);
            personas.Add(p3);
            this.DataContext = this;
        }

        private void btAgregarPersona_Click(object sender, RoutedEventArgs e)
        {
            Persona persona = new Persona(txtNombre.Text,txtApellido.Text,int.Parse(txtEdad.Text));
            personas.Add(persona);
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e)
        {
            personas.RemoveAt(datGrid1.SelectedIndex);
        }

        private void datGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            txtNombre.Text  = personas[datGrid1.SelectedIndex].Nombre;
            txtApellido.Text = personas[datGrid1.SelectedIndex].Apellidos;
            txtEdad.Text = personas[datGrid1.SelectedIndex].Edad.ToString();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Persona seleccionada = (Persona) datGrid1.SelectedItem;
            seleccionada.Nombre = txtNombre.Text;
            seleccionada.Apellidos = txtEdad.Text;
            seleccionada.Edad = int.Parse(txtEdad.Text);
        }
    }
}