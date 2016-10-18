using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Estante
    {
        protected sbyte _CantMax;
        protected List<Producto> _list;

        public enum ETipoProducto
        {
            Galletita,
            Gaseosa,
            Jugo,
            Harina,
            Todos
        }



        public Estante(sbyte CantMax)
            : this()
        {
            this._CantMax = CantMax;
        }

        private Estante()
        {
            this._list = new List<Producto>(this._CantMax);
        }

        public float ValorEstanteTotal
        {
            get { return GetValorEstante(); }
        }

        public float GetValorEstante()
        {
            return GetValorEstante(ETipoProducto.Todos);
        }

        public float GetValorEstante(ETipoProducto Tipo)
        {
            float ContadorTotal = 0;
            float CG = 0, CJ = 0, CGs = 0, CH = 0;

            foreach (Producto elemento in this._list)
            {
                if (elemento is Galletita)
                {
                    CG += ((Galletita)elemento).Precio;
                }
                else if (elemento is Jugo)
                {
                    CJ += ((Jugo)elemento).Precio;
                }
                else if (elemento is Harina)
                {
                    CH += ((Harina)elemento).Precio;
                }
                else if (elemento is Gaseosa)
                {
                    CGs += ((Gaseosa)elemento).Precio;
                }
            }

            switch (Tipo)
            {
                case ETipoProducto.Galletita:
                    return CG;
                case ETipoProducto.Gaseosa:
                    return CGs;
                case ETipoProducto.Harina:
                    return CH;
                case ETipoProducto.Jugo:
                    return CJ;
                default:
                    return ContadorTotal = CG + CGs + CH + CJ;
            }
        }

        public List<Producto> GetProducto()
        {
            return this._list;
        }

        public static string MostrarEstante(Estante E)
        {
            string Mensaje = "Capacidad Maxima: " + E._CantMax + "\n";

            foreach (Producto elemento in E._list)
            {
                if (elemento is Galletita)
                {
                    Mensaje = Mensaje + elemento.ToString();
                }
                else if (elemento is Gaseosa)
                {
                    Mensaje = Mensaje + elemento.ToString();
                }
                else if (elemento is Harina)
                {
                    Mensaje = Mensaje + elemento.ToString();
                }
                else if (elemento is Jugo)
                {
                    Mensaje = Mensaje + elemento.ToString();
                }
            }

            return Mensaje.ToString();
        }

        public static bool operator ==(Estante E, Producto P)
        {
            bool Esta = false;


            if (!Object.ReferenceEquals(E, null) && !Object.ReferenceEquals(P, null))
            {
                foreach (Producto Elemento in E._list)
                {
                    if (Elemento == P)
                    {
                        Esta = true;
                        return Esta;
                    }
                }
            }
            return Esta;
        }

        public static bool operator !=(Estante E, Producto P)
        {
            return !(E == P);
        }

        public static bool operator +(Estante E, Producto P)
        {
            bool HayLugar = false;

            if (!Object.ReferenceEquals(E, null) && !Object.ReferenceEquals(P, null))
            {

                if (E._list.Count < E._CantMax)
                {
                    if (!(E==P))
                    {
                        HayLugar = true;
                        E._list.Add(P);
                        return HayLugar;
                    }
                }
            }
            return HayLugar;
        }

        public static Estante operator -(Estante E, Producto P)
        {
            if (E == P)
            {
                E._list.Remove(P);
            }

            return E;
        }

        public static Estante operator -(Estante E, ETipoProducto Tipo)
        {
            if (Tipo == ETipoProducto.Galletita)
            {
                for (int i = 0; i < E._list.Count; i++)
                {
                    if (E._list[i] is Galletita)
                    {
                        E._list.Remove(E._list[i]);
                    }
                }
            }

            if (Tipo == ETipoProducto.Gaseosa)
            {
                for (int i = 0; i < E._list.Count; i++)
                {
                    if (E._list[i] is Gaseosa)
                    {
                        E._list.Remove(E._list[i]);
                    }
                }
            }

            if (Tipo == ETipoProducto.Harina)
            {
                for (int i = 0; i < E._list.Count; i++)
                {
                    if (E._list[i] is Harina)
                    {
                        E._list.Remove(E._list[i]);
                    }
                }
            }

            if (Tipo == ETipoProducto.Jugo)
            {
                for (int i = 0; i < E._list.Count; i++)
                {
                    if (E._list[i] is Jugo)
                    {
                        E._list.Remove(E._list[i]);
                    }
                }
            }

            return E;
        }

    }
}