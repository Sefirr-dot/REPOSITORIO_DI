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

namespace WpfApp5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<String> lista {  get; set; }
        public MainWindow()
        {
            InitializeComponent();

            lista = new ObservableCollection<String>();
            lista.Add("$");
            lista.Add("€");
            this.DataContext = this;


        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cbox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double cantidad = double.Parse(tbCantidad.Text.ToString());
            if (cbox1.SelectedIndex == 0 && cbox2.SelectedIndex==1)
            {
                cantidad = cantidad * 0.91;
            }
            else if(cbox1.SelectedIndex == 1 && cbox2.SelectedIndex == 0)
            {
                cantidad = cantidad * 1.1;
            } 
            labelConversion.Content = Math.Round(cantidad,2);

            
        }

        private void cbox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            double cantidad = double.Parse(tbCantidad.Text.ToString());
            if (cbox1.SelectedIndex == 0 && cbox2.SelectedIndex == 1)
            {
                cantidad = cantidad * 0.91;
            }
            else if (cbox1.SelectedIndex == 1 && cbox2.SelectedIndex == 0)
            {
                cantidad = cantidad * 1.1;
            }
            labelConversion.Content = Math.Round(cantidad, 2);
        }
    }
}