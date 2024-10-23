using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Ventanas
{
    /// <summary>
    /// Lógica de interacción para AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        private ObservableCollection<Persona> personaList;
        public AddPersonWindow(ObservableCollection<Persona> personas)
        {
            InitializeComponent();
            personaList = personas;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var persona = new Persona(txBoxName.Text,txBoxApellido.Text, int.Parse(txBoxEDAD.Text));
            personaList.Add(persona);
            this.Close();
        }
    }
}
