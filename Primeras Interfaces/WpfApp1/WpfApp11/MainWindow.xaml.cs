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

namespace WpfApp11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {

                    if(j == 0)
                    {
                        Label l = new Label();
                        l.Content = "Label "+ i+", "+j;
                        l.HorizontalAlignment = HorizontalAlignment.Center;
                        l.VerticalAlignment = VerticalAlignment.Center;

                        Grid.SetRow(l,i);
                        Grid.SetColumn(l,j);
                        contenedor.Children.Add(l);
                    }
                    if(j== 1)
                    {
                        Button l = new Button();
                        l.Content = "Boton " + i + ", " + j;
                        l.HorizontalAlignment = HorizontalAlignment.Center;
                        l.VerticalAlignment = VerticalAlignment.Center;

                        Grid.SetRow(l, i);
                        Grid.SetColumn(l, j);
                        contenedor.Children.Add(l);
                    }
                    if(j== 2)
                    {
                        TextBox l = new TextBox();
                        l.Text = "Text Box " + i + ", " + j;
                        l.HorizontalAlignment = HorizontalAlignment.Center;
                        l.VerticalAlignment = VerticalAlignment.Center;

                        Grid.SetRow(l, i);
                        Grid.SetColumn(l, j);
                        contenedor.Children.Add(l);
                    }
                }
            }
        }
    }
}