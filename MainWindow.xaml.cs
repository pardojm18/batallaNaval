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

namespace batallaNavalGrafico
{
    
    public partial class MainWindow : Window
    {

        Principal menu;       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void empezarJuego(object sender, RoutedEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbNombreA.Text))
                MessageBox.Show("Introduce el nombre del Jugador A");
            else if (string.IsNullOrWhiteSpace(tbNombreB.Text))
                MessageBox.Show("Introduce el nombre del Jugador B");
            else
            {
                menu = new Principal(tbNombreA.Text, tbNombreB.Text);
                this.Hide();
                menu.colocar();
                while (!menu.jugar());
                this.Close();
            }
        }
    }
}
