using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Galletita:Producto
    {
        protected float _peso;
        protected static bool DeConsumo;

        public Galletita(int CodBarra, float Precio, EMarcaProducto Marca, float Peso):base(CodBarra, Marca, Precio)
        {
            this._peso = Peso;
        }

        static Galletita()
        {
            DeConsumo = true;
        }

        private static string MostrarGalletita(Galletita G)
        {
            return "Codigo Barra: " + G._codBarra.ToString() + "\nMarca: " + G._marcas.ToString() + "\nPrecio: " + G._precio.ToString() + "\nPeso: " + G._peso.ToString() + "\n\n";
        }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio+(this._precio * 0.33f); }
        }

        public override float Precio
        {
            get { return this._precio; }
        }

        public override string Consumir()
        {
            return "Comestible";
        }

        public override string ToString()
        {
            return MostrarGalletita(this);
        }
    }
}
