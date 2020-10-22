using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace batallaNavalGrafico
{
    public class Casilla : Button
    {

        private int _fila;
        private int _columna;
        private Tablero _tablero;


        public Casilla(int fila, int columna, Tablero tablero)
        {
            this._fila = fila;
            this._columna = columna;
            this._tablero = tablero;

            this.Height = 40;
            this.Width = 40;
            this.Margin = new Thickness(2);
            this.Background = Brushes.Gray;    //Se emplea para saber el tipo de dato guardado
        }

        
        public int fila
        {
            get => _fila;
            set => _fila = value;
        }

        public int columna
        {
            get => _columna;
            set => _columna = value;
        }

        public Tablero tablero
        {
            get => _tablero;
            set => _tablero = value;
        }

    }
}
