using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Harina:Producto
    {
        protected ETipoHarina _TipoH;
        protected static bool DeConsumo;

        public enum ETipoHarina
        {
            Leudante,
            CuatroCeros,
            TresCeros,
            Integral
        }

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio + (this._precio * 0.60f); }
        }

        public override float Precio
        {
            get { return this._precio; }
        }

        static Harina()
        {
            Harina.DeConsumo = false;
        }

        public Harina(int CodBarra, float Precio, EMarcaProducto Marca, ETipoHarina TH):base(CodBarra,Marca,Precio)
        {
            this._TipoH = TH;
        }

        private string MostrarHarina()
        {
            return "Codigo Barra: " + this._codBarra.ToString() + "\nMarca: " + this._marcas.ToString() + "\nPrecio: " + this._precio.ToString() + "\nTipo Harina: " + this._TipoH.ToString() + "\n\n";
        }

        public override string ToString()
        {
            return MostrarHarina();
        }
    }
}
