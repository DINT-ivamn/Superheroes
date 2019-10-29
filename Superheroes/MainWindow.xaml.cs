using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroes
{
    public partial class MainWindow : Window
    {
        Superheroe Super { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            Superheroe superheroe = new Superheroe()
            {
                Nombre = "Tomioka",
                Enemigo = "Muzan",
                Foto = @"https://i.imgur.com/UnAQciW.jpg",
                Vengador = false
            };
            DatosEstaticosDockPanel.DataContext = superheroe;
            Super = superheroe;
        }

        private void EditarButton_Click(object sender, RoutedEventArgs e)
        {
            EditarStackPanel.DataContext = Super;
        }
    }
}
