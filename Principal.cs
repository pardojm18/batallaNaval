using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNavalGrafico
{
    public class Principal
    {

        public ColocarBarcos pantalla;

        Jugador jugadorA;
        Jugador jugadorB;

        public Principal(String a, String b)
        {
            this.jugadorA = new Jugador(a);
            this.jugadorB = new Jugador(b);

            this.jugadorA.rival = this.jugadorB;
            this.jugadorB.rival = this.jugadorA;

        }

        public void colocar()
        {

            //Creacción del tablero y definicion de casillas
            pantalla = new ColocarBarcos(10, jugadorA.tablero.casillas, jugadorA.barcos);
            pantalla.ShowDialog();

            pantalla = new ColocarBarcos(10, jugadorB.tablero.casillas, jugadorB.barcos);
            pantalla.ShowDialog();

            /*
            while (pantalla.IsActive);
            pantalla.Close();

            pantalla = new ColocarBarcos(10, jugadorB.tablero.casillas, jugadorB.barcos);
            pantalla.Show();
            */


            //pantalla.Close();



        }

        public void disparar(Jugador x)
        {

        }

    }
}
