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

namespace Plantillas
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
         public ObservableCollection<Libro> Libros { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            Libros = new ObservableCollection<Libro>
            {
                new Libro { Portada = "/img/cat.jpg", Nombre = "1984", Autor = "George Orwell" },
                new Libro { Portada = "/img/cat.jpg", Nombre = "Don Quijote", Autor = "Cervantes" }
            };

            this.DataContext = this;
        }
    
    }



 
}