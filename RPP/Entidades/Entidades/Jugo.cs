using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugo:Producto
    {
        private ESaborJugo _saborJugo;
        private static bool _deConsumo;

        public enum ESaborJugo
        {
            Asqueroso,
            Pasable,
            Rico
        }

        public override string Consumir()
        {
            return "Bebible";
        }        

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio + (this._precio * 0.40f); }
        }

        public override float Precio
        {
            get { return this._precio; }
        }

        static Jugo()
        {
            Jugo._deConsumo = true;
        }

        public Jugo(int CodBarra, float Precio, EMarcaProducto Marca, ESaborJugo Sabor):base(CodBarra,Marca,Precio)
        {
            this._saborJugo = Sabor;
        }

        private string MostrarJugo()
        {
            return "Codigo Barra: " + this._codBarra.ToString() + "\nMarca: " + this._marcas.ToString() + "\nPrecio: " + this._precio.ToString() + "\nSabor: " + this._saborJugo.ToString() + "\n\n";
        }

        public override string ToString()
        {
            return MostrarJugo();
        }
    }
}
