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

namespace TabControl1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<Persona> listaPersonas { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            listaPersonas = new ObservableCollection<Persona>();
            Persona p1 = new Persona("Jose", "Gonzalez", 27);
            Persona p2 = new Persona("Pedro", "Perez", 67);
            Persona p3 = new Persona("Antonia", "Maestre", 11);
            listaPersonas.Add(p1);
            listaPersonas.Add(p2);
            listaPersonas.Add(p3);
            this.DataContext = this;
        }

        private void btAgregarPersona_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btEliminar_Click(object sender, RoutedEventArgs e)
        {
            listaPersonas.RemoveAt(datGrid1.SelectedIndex);
        }

        private void datGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Persona seleccionada = (Persona)datGrid1.SelectedItem;
            if(seleccionada != null)
            {
                txBoxName.Text = listaPersonas[datGrid1.SelectedIndex].Nombre;
                txBoxApellido.Text = listaPersonas[datGrid1.SelectedIndex].Apellidos;
                txBoxEDAD.Text = listaPersonas[datGrid1.SelectedIndex].Edad.ToString();
            }
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btAgregar_Click(object sender, RoutedEventArgs e)
        {
            Persona persona = new Persona(txBoxName.Text, txBoxApellido.Text, int.Parse(txBoxEDAD.Text));
            listaPersonas.Add(persona);
        }
    }
}