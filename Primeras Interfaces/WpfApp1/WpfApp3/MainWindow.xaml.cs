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

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ObservableCollection<String> Strings { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            Strings = new ObservableCollection<String>();
            Strings.Add("KG");
            Strings.Add("LB");
            this.DataContext = this;
            //comboBox1.Items.Add("KG");
            //comboBox1.Items.Add("LB");

            //comboBox2.Items.Add("KG");
            //comboBox2.Items.Add("LB");


        }
        private void txBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            String cantidad1 = txBox.Text;
            double cantidad = double.Parse(cantidad1);


            if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
            {

                double final = cantidad * 2.205;
                labelFinal.Content = final.ToString();
            }
            else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
            {
                labelFinal.Content = cantidad / 2.205;
            }
            else
            {
                labelFinal.Content = cantidad;
            }

        }

        private void comboBox2_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
                String cantidad1 = txBox.Text;
                double cantidad = double.Parse(cantidad1);


                if (comboBox1.SelectedIndex == 0 && comboBox2.SelectedIndex == 1)
                {

                    double final = cantidad * 2.205;
                    labelFinal.Content = final.ToString();
                }
                else if (comboBox1.SelectedIndex == 1 && comboBox2.SelectedIndex == 0)
                {
                    labelFinal.Content = cantidad / 2.205;
                }
                else
                {
                    labelFinal.Content = cantidad;
                }
            }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Strings.Add("KG");
        }
    }
    }
