using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNavalGrafico
{
    public class Tablero
    {

        private int n;
        private List<List<Casilla>> _casillas;
        private Jugador jugador;

        public Tablero(int n, Jugador jugador)
        {
            this.n = n;
            this.jugador = jugador;
            this._casillas = null;
           
        }

        public List<List<Casilla>> casillas
        {
            get => _casillas;
            set => _casillas = value;
        }

        

    }
}
