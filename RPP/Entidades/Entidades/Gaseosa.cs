using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Gaseosa:Producto
    {
        protected float _litros;
        protected static bool Deconsumo;

        public override float CalcularCostoDeProduccion
        {
            get { return this._precio + (this._precio * 0.42f); }
        }

        public override float Precio
        {
            get { return this._precio; }
        }
        static Gaseosa()
        {
            Gaseosa.Deconsumo = true;
        }

        public override string Consumir()
        {
            return "Bebible";
        }

        public Gaseosa(int CodBarra, EMarcaProducto Marca, float Precio, float Litros):base(CodBarra, Marca, Precio)
        {
            this._litros = Litros;
        }

        public Gaseosa(Producto P, float Litros):this((int)P,P.Marcas,(float)P,Litros)
        { 
            
        }

        private string MostrarGaseosa()
        {
            return "Codigo Barra: " + this._codBarra.ToString() + "\nMarca: " + this._marcas.ToString() + "\nPrecio: " + this._precio.ToString() + "\nLitros: " + this._litros.ToString() + "\n\n";
        }

        public override string ToString()
        {
            return MostrarGaseosa();
        }
        

    }
}
