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

namespace MiniHito1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
   
    public partial class MainWindow : Window
    {
        public ObservableCollection<string> nombreProyectos { get; set; }
        public ObservableCollection<double> presupuestoProyectos { get; set; }
        public ObservableCollection<int> ids {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            nombreProyectos = new ObservableCollection<string>();
            presupuestoProyectos = new ObservableCollection<double>();
            ids = new ObservableCollection<int>();
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
            
            
            Random rd = new Random();
            int randomID = rd.Next(20000)+1;
            ids.Add(randomID);
            labelID.Content = randomID.ToString();
            if (labelError.Content.ToString().Length == 0)
            {
                tabClientes.IsEnabled = true;
                tabClientes.Focus();
            }
            
            
        }
    }
}