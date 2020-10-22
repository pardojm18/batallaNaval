using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNavalGrafico
{
    public class Tablero
    {

        private List<List<Casilla>> _casillas;
        private Jugador _jugador;

        public Tablero(Jugador jugador)
        {
            this._jugador = jugador;

            this._casillas = new List<List<Casilla>>(Principal.TAM_TABLERO);
            for (int i = 0; i < Principal.TAM_TABLERO; i++)
                casillas.Add(new List<Casilla>((Principal.TAM_TABLERO)));

            for (int i = 0; i < Principal.TAM_TABLERO; i++)
                for (int j = 0; j < Principal.TAM_TABLERO; j++)
                    casillas[i].Add(new Casilla(i, j, this));

        }

        public List<List<Casilla>> casillas
        {
            get => _casillas;
            set => _casillas = value;
        }

        

    }
}
