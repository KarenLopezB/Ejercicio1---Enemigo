using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Videojuego
{
    class Enemigo
    {
        public int PosicionX { get; set; }
        public int PosicionY { get; set; }

        private int _puntosganados;
        public int PuntosGanados {
            get {
                return _puntosganados;
            }
            set {
                if (value >= 100)
                {
                    _puntosganados = value;
                }
                else
                {
                    throw new Exception("El numero de puntos es invalido");
                }
            }
        }

        public void Mover ()
        {

        }
        public void Disparar ()
        {

        }
        public void Explotar ()
        {

        }
    }
}
