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

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            int number = 10;
            

            for (int i = 0; i < 4; i++)
            {
                number = number - 3;
                for (int j = 0; j < 3; j++)
                {
                    Button b = new Button();
                    b.HorizontalAlignment = HorizontalAlignment.Center;
                    b.VerticalAlignment = VerticalAlignment.Center;
                    b.Width = 100;
                    b.Height = 100;
                    b.Content = "*";
                     
                    if (i == 3)
                    {
                        switch (j)
                        {
                            case 0:
                                b.Content = "=";
                                break;
                            case 1:
                                b.Content = "0";
                                break;
                            case 2:
                                b.Content = "C";
                                break;
                        }
                    }
                    else
                    {
                        b.Content = number+j;
                    }
                    calc.Children.Add(b);
                }
            }

            
        }
    }
}