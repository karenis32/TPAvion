using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAvion
{
    public class AvionComercial: Avion
    {
        public int Capacidad { get; set; }
        public string LineaAerea { get; set; }

        public AvionComercial(string Piloto, string Copiloto, string Azafata, int Capacidad, string LineaAerea) : base(Piloto, Copiloto, Azafata)
        {
            this.Capacidad = Capacidad;
            this.LineaAerea = LineaAerea;
        }

        public override string Aterriza()
        {
            return "Aterriza Avión Comercial";
        }

        public override string Despega()
        {
            return "Despega Avión Comercial";
        }

        public override string ToString()
        {
            return MostrarPropiedades() + "\nCapacidad: " + Capacidad + "\nLinea Aérea: " + LineaAerea;
        }
    }
}
