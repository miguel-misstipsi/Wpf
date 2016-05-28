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

namespace Converter
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Usuario> Usuarios { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Usuarios = new List<Usuario>
            {
                new Usuario{
                    Nombre = "Fernando",
                    Edad = 29
                },
                new Usuario{
                    Nombre = "Miguel",
                    Edad = 40
                },
                new Usuario{
                    Nombre = "Jaimito",
                    Edad = 14
                },
                new Usuario{
                    Nombre = "Raymond",
                    Edad = 37
                }
            };

            listaUsuarios.ItemsSource = Usuarios;
        }
    }

    public class Usuario {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
