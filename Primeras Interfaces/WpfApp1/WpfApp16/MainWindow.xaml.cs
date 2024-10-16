using System.Collections;
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

namespace WpfApp16
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Persona> listaPersonas {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            listaPersonas = new ObservableCollection<Persona>();
        }

        private void salir_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Rea_Click(object sender, RoutedEventArgs e)
        {
            String profesion  = profesiontxt.Text;
            int herm =  int.Parse(numeroHermanostxt.Text);
            String anios = Edad.SelectedValue.ToString();
            string sexo = "";
            if (rBFemenino.IsChecked == true)
            {
                sexo = "Femenino";
            }
            else { sexo = "Masculino"; 
            }
            string deporte = deportes.SelectedItem.ToString();

            int compras = (int) coompras.Value;
            int tele = (int) tv.Value;
            int verCine = (int) cine.Value;
            Persona p = new Persona(profesion, herm, sexo, anios, deporte, compras, tele, verCine);
            listaPersonas.Add(p);
            listaQueSale.Items.Add(p.ToString);
        }
    }
}