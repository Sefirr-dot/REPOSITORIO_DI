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

namespace WpfApp18
{
   
    public partial class MainWindow : Window
    {
        public ObservableCollection<String> strings1 { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            strings1 = new ObservableCollection<String>();
            strings1.Add("Jose");
            strings1.Add("Antonio");
            strings1.Add("Pepe");
            strings1.Add("Mateo");
            strings1.Add("Lusillo");

            this.DataContext = this;
            
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }
    }
}