using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        protected int _codBarra;
        protected EMarcaProducto _marcas;
        protected float _precio;

        public enum EMarcaProducto
        {
            Manaos,
            Pitusas,
            Naranjú,
            Diversión,
            Swift,
            Favorita
        }

        #region Propiedades

        public abstract float CalcularCostoDeProduccion
        {
            get;
        }

        public abstract float Precio
        {
            get;
        }


	    public int CodigoBarra
	    {
		    get { return this._codBarra; }
	    }

        public EMarcaProducto Marcas
        { 
            get { return this._marcas; } 
        }

#endregion

        #region Constructores

        public Producto(int CodBarra, EMarcaProducto Marca, float Precio)
        {
            this._codBarra = CodBarra;
            this._marcas = Marca;
            this._precio = Precio;
        }

        private static string MostrarProducto(Producto P)
        {
            return "Codigo Barra: " + P._codBarra.ToString() + "\nMarca: " + P._marcas.ToString() + "\nPrecio: " + P._precio.ToString() + "\n\n";
        }

        public static explicit operator int(Producto P)
        {
            return P.CodigoBarra;
        }

        public static implicit operator string(Producto P)
        {
            return MostrarProducto(P);
        }

        public virtual string Consumir()
        {
            return "Parte de la mezcla";
        }

        public static bool operator ==(Producto P1, Producto P2)
        {
            bool Esta = false;

            if (P1._marcas == P2._marcas && P1._codBarra == P2._codBarra)
            {
                Esta = true;
                return Esta;
            }
            return Esta;
        }

        public static bool operator !=(Producto P1, Producto P2)
        {
            return !(P1 == P2);
        }

        public static bool operator ==(Producto P1, EMarcaProducto Marca)
        {
            bool Esta = false;

            if (P1._marcas == Marca)
            {
                Esta = true;
                return Esta;
            }
            return Esta;
        }

        public static bool operator !=(Producto P1, EMarcaProducto Marca)
        {
            return !(P1._marcas == Marca);
        }



        #endregion 
    }
}
