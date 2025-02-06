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

namespace PracticaExamen
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Albums> albums { get; set; }
        public MainWindow()
        {
            albums = new List<Albums>
{
    new Albums("🎶Cigarettes After Sex", "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c9/Cigarettes_After_Sex_%28album%29.svg/1200px-Cigarettes_After_Sex_%28album%29.svg.png", "Hello"),
    new Albums("🎶Deftones", "https://upload.wikimedia.org/wikipedia/en/9/91/Deftones-selftitled_albumcover.jpg", "Hello"),
    new Albums("🎶Cry", "https://upload.wikimedia.org/wikipedia/en/4/4c/Cigarettes_After_Sex_-_Cry.png", "Hello"),
    new Albums("🎶Audioslave", "https://upload.wikimedia.org/wikipedia/en/a/ac/Audioslave_-_Audioslave.jpg", "Hello"),
    new Albums("🎶Out of Exile", "https://upload.wikimedia.org/wikipedia/en/thumb/e/e4/Audioslave_-_Out_of_Exile.jpg/220px-Audioslave_-_Out_of_Exile.jpg", "Hello"),
    new Albums("🎶Numb", "https://upload.wikimedia.org/wikipedia/en/thumb/b/b9/Linkin_Park_-_Numb_CD_cover.jpg/220px-Linkin_Park_-_Numb_CD_cover.jpg", "Hello")
};

            InitializeComponent();
            
            this.DataContext = this;
        }
    }
}