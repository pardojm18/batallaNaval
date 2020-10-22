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
using System.Windows.Shapes;

namespace batallaNavalGrafico
{
    
    public partial class tableroJuego : Window
    {

        Jugador _x;

        List<List<Casilla>> casillas;
        List<List<Casilla>> casillasRival;


        private void crearTablero(List<List<Casilla>> casillasO)
        {

            casillas = casillasO;

            for (int i = 0; i < Principal.TAM_TABLERO; i++)
                for (int j = 0; j < Principal.TAM_TABLERO; j++)
                {
                    casillas[i][j].Click += new RoutedEventHandler(pulsarCasilla);
                }

        }

        public tableroJuego(Jugador x, int n)
        {

            InitializeComponent();
            crearTablero(x.rival.oculto.casillas);
            casillasRival = x.rival.tablero.casillas;

            _x = x;
            tituloVentana.Content = "Turno de " + x.nombre;
            lst.ItemsSource = casillas;

            int vidaMaxima = x.vida;

            vida.Minimum = 0;
            vida.Maximum = vidaMaxima;
            vida.Value = vidaMaxima;

            vidaRival.Minimum = 0;
            vidaRival.Maximum = vidaMaxima;
            vidaRival.Value = vidaMaxima;
        }


        private void pulsarCasilla(object sender, RoutedEventArgs e)
        {

            if (((Casilla)sender).Background != Brushes.Gray)
            {
                MessageBox.Show("Ya has disparado aquí.");
            }else if (casillasRival[((Casilla)sender).fila][((Casilla)sender).columna].Background == Brushes.Black)
            {
                ((Casilla)sender).Background = Brushes.Red;
                --_x.rival.vida;
                vidaRival.Value = _x.rival.vida;
                if(_x.rival.vida != 0)
                    MessageBox.Show("Diana. Repite turno.");
                
                this.Hide();
            }
            else if (casillasRival[((Casilla)sender).fila][((Casilla)sender).columna].Background == Brushes.Gray)
            {
                ((Casilla)sender).Background = Brushes.LightBlue;
                MessageBox.Show("Agua");
                this.Hide();
            }



        }

    }
}
