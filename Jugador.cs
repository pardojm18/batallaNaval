using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNavalGrafico
{

    public class Jugador
    {

        const int TAM_TABLERO = 10;
        const int NUM_BARCOS = 9;

        private String _nombre;
        private Tablero _tablero;
        private Jugador _rival;
        private List<Barco> _barcos;
        private int _vida;

        public Jugador(String nombre)
        {
            this._nombre = nombre;
            this._rival = null;
            this._tablero = new Tablero(TAM_TABLERO, this);
            this._barcos = new List<Barco>(NUM_BARCOS);
            this._vida = 0;

            for (int i = 0; i < NUM_BARCOS; i++)
            {
                if (i == 0)
                {
                    this._barcos.Add(new Barco(Barco.Tipo.PORTAAVIONES));
                    _vida += this._barcos[i].espacio;
                }
                else if (i > 0 && i < 3)
                {
                    this._barcos.Add(new Barco(Barco.Tipo.SUBMARINO));
                    _vida += this._barcos[i].espacio;
                }
                else if (i == 3)
                {
                    this._barcos.Add(new Barco(Barco.Tipo.ACORAZADO));
                    _vida += this._barcos[i].espacio;
                }
                else if (i > 3 && i <= 6)
                {
                    this._barcos.Add(new Barco(Barco.Tipo.DESTRUCTOR));
                    _vida += this._barcos[i].espacio;
                }
                else
                {
                    this._barcos.Add(new Barco(Barco.Tipo.FRAGATA));
                    _vida += this._barcos[i].espacio;
                }
            }

        }

        public String nombre
        {
            get => _nombre;
            set => _nombre = value;
        }

        public Tablero tablero
        {
            get => _tablero;
            set => _tablero = value;
        }

        public Jugador rival
        {
            get => _rival;
            set => _rival = value;
        }

        public int vida
        {
            get => _vida;
            set => _vida = value;
        }

        public List<Barco> barcos
        {
            get => _barcos;
            set => _barcos = value;
        }

        

        /*public void dispara()
        {

            int fila;
            int columna;
            bool aux = true;

            Console.WriteLine("Turno de " + this.nombre);

            do
            {

                if (!aux)
                    Console.WriteLine("Posición no válida");

                Console.WriteLine("Fila:");
                fila = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Columna");
                columna = Convert.ToInt32(Console.ReadLine());

                aux = fila > 0 && fila < TAM_TABLERO && columna > 0 && columna < TAM_TABLERO;

            } while (!aux);



            if (rival.tablero.casillas[fila][columna].contenido == "VAC")
            {
                rival.tablero.casillas[fila][columna].contenido = "AGU";
            }
            else if (rival.tablero.casillas[fila][columna].contenido == "AGU")
            {
                Console.WriteLine("No se puede volver a disparar a esa casilla");
            }
            else
            {
                rival.tablero.casillas[fila][columna].contenido = "HER";
                --rival.vida;
            }

        }*/

    }
}
