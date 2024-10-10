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

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random rd = new Random();

            for (int i = 0; i < 1000; i++)
            {
                Ellipse elip = new Ellipse();
               

                if (i%2 == 0)
                {
                    elip.Fill = Brushes.Coral;

                }
                else
                {
                    elip.Fill= Brushes.Chartreuse;
                }
                elip.Width = 10;
                elip.Height = 10;

               

                Canvas.SetTop(elip, rd.Next(1, (int)this.Height));
                Canvas.SetLeft(elip, rd.Next(1, (int)this.Width));
                Canvas.SetZIndex(elip, rd.Next(1,10));

                canva.Children.Add(elip);
            }
        }
    }
}