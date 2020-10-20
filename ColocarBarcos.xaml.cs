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
    /// <summary>
    /// Lógica de interacción para Window1.xaml
    /// </summary>
    public partial class ColocarBarcos : Window
    {

        const int TAM_TABLERO = 10;

        List<List<Casilla>> botones;
        BindingList<Barco> listaBarcos;

        private void crearTablero(int tam, List<List<Casilla>> casillas)
        {

            casillas = new List<List<Casilla>>(tam);
            for (int i = 0; i < tam; i++)
                casillas.Add(new List<Casilla>(tam));

            for(int i = 0; i < tam; i++)
                for (int j = 0; j < tam; j++)
                {
                    Casilla aux = new Casilla(i, j);
                    aux.Click += new RoutedEventHandler(pulsarCasilla);
                    casillas[i].Add(aux);
                }

            botones = casillas;
           
        }

        private void definirBarcos(List<Barco> barcos)
        {
            listaBarcos = new BindingList<Barco>(barcos);            

        }

        public ColocarBarcos(int n, List<List<Casilla>> casillas, List<Barco> barcos)
        {
            InitializeComponent();
            crearTablero(n, casillas);
            definirBarcos(barcos);

            lst.ItemsSource = botones;
            listBox1.ItemsSource = listaBarcos;


        }

        private bool posibleColocar(Barco b, Casilla c, int fila, int columna)
        {
            if(c.Background != Brushes.LightBlue)
            {
                return false;
            }

            //POSICION VERTICAL SOLO
            if (fila + b.espacio > TAM_TABLERO)
                return false;
            else
            {
                for (int i = fila; i < fila + b.espacio; i++)
                    if (botones[i][columna].Background != Brushes.LightBlue)
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
                    MessageBox.Show("Barco colocado");
                    listaBarcos.Remove((Barco)listBox1.SelectedItem);
                    if (listaBarcos.Count == 0)
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
