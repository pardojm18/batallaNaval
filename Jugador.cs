using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNavalGrafico
{

    public class Jugador
    {

        private String _nombre;
        private Tablero _tablero;

        private Tablero _oculto;

        private Jugador _rival;
        private List<Barco> _barcos;
        private int _vida;


        public Jugador(String nombre)
        {
            this._nombre = nombre;
            this._rival = null;
            this._tablero = new Tablero(this);
            this._oculto = new Tablero(this);
            this._barcos = new List<Barco>();
            this._vida = 0;

            this.generarBarcos();

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

        public Tablero oculto
        {
            get => _oculto;
            set => _oculto = value;
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

        private void generarBarcos()
        {

            for(int i = 0; i < Principal.NUM_PORTAVIONES; i++)
            {
                this._barcos.Add(new Barco(Barco.Tipo.PORTAVIONES));
                _vida += this._barcos[i].espacio;
            }

            for (int i = 0; i < Principal.NUM_SUBMARINOS; i++)
            {
                this._barcos.Add(new Barco(Barco.Tipo.SUBMARINO));
                _vida += this._barcos[i].espacio;
            }

            for (int i = 0; i < Principal.NUM_ACORAZADOS; i++)
            {
                this._barcos.Add(new Barco(Barco.Tipo.ACORAZADO));
                _vida += this._barcos[i].espacio;
            }

            for (int i = 0; i < Principal.NUM_DESTRUCTORES; i++)
            {
                this._barcos.Add(new Barco(Barco.Tipo.DESTRUCTOR));
                _vida += this._barcos[i].espacio;
            }

            for (int i = 0; i < Principal.NUM_FRAGATA; i++)
            {
                this._barcos.Add(new Barco(Barco.Tipo.FRAGATA));
                _vida += this._barcos[i].espacio;
            }

            
        }


    }
}
