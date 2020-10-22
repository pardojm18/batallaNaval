using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace batallaNavalGrafico
{
    public class Principal
    {
        //Macros
        public const int TAM_TABLERO = 10;
        public const int NUM_PORTAVIONES = 1;
        public const int NUM_SUBMARINOS = 0;    //2
        public const int NUM_ACORAZADOS = 0;    //1
        public const int NUM_DESTRUCTORES = 0;  //3
        public const int NUM_FRAGATA = 0;   //2

        public ColocarBarcos pantalla;

        public tableroJuego tablaA;
        public tableroJuego tablaB;

        private int turno = 0;

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
            pantalla = new ColocarBarcos(jugadorA.nombre, jugadorA.tablero.casillas, jugadorA.barcos);
            pantalla.ShowDialog();

            pantalla = new ColocarBarcos(jugadorB.nombre, jugadorB.tablero.casillas, jugadorB.barcos);
            pantalla.ShowDialog();


        }

        public bool jugar()
        {
            bool ganador = false;
            int vidaAnterior;


            if(turno == 1)
            {
                vidaAnterior = jugadorA.rival.vida;
                tablaA.ShowDialog();

                tablaB.vida.Value = jugadorA.rival.vida;
                if (jugadorA.rival.vida == 0)
                {
                    ganador = true;
                    MessageBox.Show("HA GANADO " + jugadorA.nombre);
                    tablaA.Close();
                    tablaB.Close();
                }
                else if (vidaAnterior == jugadorA.rival.vida)
                {
                    turno = 2;
                }
            }else if(turno == 2)
            {

                vidaAnterior = jugadorB.rival.vida;
                tablaB.ShowDialog();

                tablaA.vida.Value = jugadorB.rival.vida;

                if (jugadorB.rival.vida == 0)
                {
                    ganador = true;
                    MessageBox.Show("HAS GANADO " + jugadorB.nombre.ToUpper());
                    tablaB.Close();
                    tablaA.Close();
                }
                else if (vidaAnterior == jugadorB.rival.vida)
                {
                    turno = 1;
                }
            }
            else
            {
                tablaA = new tableroJuego(jugadorA, 10);
                tablaB = new tableroJuego(jugadorB, 10);
                turno = 1;
            }

            return ganador;

        }

    }
}
