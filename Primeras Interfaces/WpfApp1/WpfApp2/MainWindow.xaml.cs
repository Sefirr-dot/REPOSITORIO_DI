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

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            List<Persona> lista = new List<Persona>();
            Persona p1 = new Persona("Migueliko", "XEMIKA");
            Persona p2 = new Persona("DAVICILLO", "Manoliko");
            Persona p3 = new Persona("Alexillo", "Markillos");
            lista.Add(p1);
            lista.Add(p2);  
            lista.Add(p3);
            foreach ( Persona p in lista)
            {
                ComboBoxItem item = new ComboBoxItem();
                item.Content = p;
                combitoBoxi.Items.Add(item);  
                
            }

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ComboBoxItem personaItem = (ComboBoxItem)combitoBoxi.SelectedItem;
            Persona persona = (Persona)personaItem.Content;
            NombreLabel.Content = persona.Nombre;
            ApellidoLabel.Content=persona.Apellidos;

        }
        class Persona
        {
            public Persona(string nombre, string apellidos)
            {
                Nombre = nombre;
                Apellidos = apellidos;
            }

            public String Nombre { get; set; }
            public String Apellidos { get; set; }

            public override String ToString()
            {
                return $"Nombre: {Nombre} Apellido: {Apellidos}";
            }
        }

    }

}