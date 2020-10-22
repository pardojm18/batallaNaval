using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    
    public partial class ColocarBarcos : Window
    {


        List<List<Casilla>> botones;
        BindingList<Barco> _listaBarcos;

        public ColocarBarcos(String nombre, List<List<Casilla>> casillas, List<Barco> barcos)
        {
            InitializeComponent();
            crearTablero(casillas);

            this._listaBarcos = new BindingList<Barco>(barcos);
            listBox1.ItemsSource = _listaBarcos;


            tituloVentana.Content = "Coloca las casillas "+nombre;
            lst.ItemsSource = botones;


        }

        private void crearTablero(List<List<Casilla>> casillas)
        {

            botones = casillas;

            for (int i = 0; i < Principal.TAM_TABLERO; i++)
                for (int j = 0; j < Principal.TAM_TABLERO; j++)
                {
                    botones[i][j].Click += new RoutedEventHandler(pulsarCasilla);
                }

        }

        private bool posibleColocar(Barco b, Casilla c, int fila, int columna)
        {
            if(c.Background != Brushes.Gray)
            {
                return false;
            }

            //POSICION VERTICAL SOLO
            if (fila + b.espacio > Principal.TAM_TABLERO)
                return false;
            else
            {
                for (int i = fila; i < fila + b.espacio; i++)
                    if (botones[i][columna].Background != Brushes.Gray)
                        return false;

                for (int i = fila; i < fila + b.espacio; i++)
                    botones[i][columna].Background = Brushes.Black;

                return true;

            }

            //POSICION HORIZONTAL PENDIENTE DE EDITAR
            /*
            if (columna + b.espacio >= n)
                    return false;
                else
                {
                    for (int i = columna; i < columna + b.espacio; i++)
                        if (_casillas[fila][i].contenido != "VAC")
                            return false;
                }

                for (int i = columna; i < columna + b.espacio; i++)
                    _casillas[fila][i].contenido = "BAR";
            */

        }

        private void pulsarCasilla(object sender, RoutedEventArgs e)
        {

            if(listBox1.SelectedItem != null)
            {

                if(posibleColocar((Barco)listBox1.SelectedItem, (Casilla)sender, ((Casilla)sender).fila,((Casilla)sender).columna))
                {
                    _listaBarcos.Remove((Barco)listBox1.SelectedItem);
                    if (_listaBarcos.Count == 0)
                        this.Close();
                }
                else
                {
                    MessageBox.Show("No se puede colocar en esa casilla");
                }       
            }
            else
            {
                MessageBox.Show("Selecciona un barco de la lista derecha");
            }


        }
    }

    

}
