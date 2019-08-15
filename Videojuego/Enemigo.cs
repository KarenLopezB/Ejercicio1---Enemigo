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

        private string _puntosganados;
        public string PuntosGanados {
            get {
                return _puntosganados;
            }
            set {
                if (value.Length >= 100)
                {
                    _puntosganados = value;
                }
                else
                {
                    throw new Exception();
                }
            }
        }

        public string Movimiento { get; set; }
        public string Disparar {get; set; }
        public string Explotar { get; set; }
    }
}
