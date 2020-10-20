using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace batallaNavalGrafico
{
    public class Barco
    {

        public enum Tipo
        {
            PORTAAVIONES,
            SUBMARINO,
            ACORAZADO,
            DESTRUCTOR,
            FRAGATA
        }

        private int _espacio;
        private Tipo _tipo;

        public Barco(Barco.Tipo tipo)
        {

            this._tipo = tipo;

            switch (tipo)
            {
                case Tipo.PORTAAVIONES:
                    _espacio = 4;
                    break;
                case Tipo.SUBMARINO:
                    _espacio = 3;
                    break;
                case Tipo.ACORAZADO:
                    _espacio = 3;
                    break;
                case Tipo.DESTRUCTOR:
                    _espacio = 2;
                    break;
                case Tipo.FRAGATA:
                    _espacio = 1;
                    break;
            }

        }

        public Tipo tipo
        {
            get => _tipo;
            set => _tipo = value;
        }

        public int espacio
        {
            get => _espacio;
            set => _espacio = value;
        }


        public override string ToString()
        {
            String cadena = "";

            switch (this._tipo)
            {
                case Tipo.PORTAAVIONES:
                    cadena = "Portaaviones";
                    break;
                case Tipo.SUBMARINO:
                    cadena = "Submarino";
                    break;
                case Tipo.ACORAZADO:
                    cadena = "Acorazado";
                    break;
                case Tipo.DESTRUCTOR:
                    cadena = "Destructor";
                    break;
                case Tipo.FRAGATA:
                    cadena = "Fragata";
                    break;
            }
            return cadena + "(" + _espacio + ")";
        }

        public string datos
        {
            get
            {
                String cadena = "";

                switch (this._tipo)
                {
                    case Tipo.PORTAAVIONES:
                        cadena = "Portaaviones";
                        break;
                    case Tipo.SUBMARINO:
                        cadena = "Submarino";
                        break;
                    case Tipo.ACORAZADO:
                        cadena = "Acorazado";
                        break;
                    case Tipo.DESTRUCTOR:
                        cadena = "Destructor";
                        break;
                    case Tipo.FRAGATA:
                        cadena = "Fragata";
                        break;
                }
                return cadena + "(" + _espacio + ")";
            }
            set
            {

            }
            
        }

    }
}
