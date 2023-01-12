using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPAvion
{
    public class AvionCarga : Avion
    {
        public double Peso { get; set; }
        public string TipoMercancia { get; set; }
        public AvionCarga(string Piloto, string Copiloto, string Azafata,double Peso, string TipoMercancia) : base(Piloto, Copiloto, Azafata)
        {
            this.Peso = Peso;
            this.TipoMercancia = TipoMercancia;
        }

        public override string MostrarPropiedades()
        {
            return base.MostrarPropiedades() + "\nPeso: " + Peso + "\nTipo Mercancia: " + TipoMercancia;
        }

        public override string Aterriza()
        {
            return "Aterriza Avión de Carga";
        }

        public override string Despega()
        {
            return "Despega Avión de Carga";
        }
    }
}
