using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Transversal
{
    public class CacheStock
    {
        private int _Id_Producto;
        private string _Nombre;
        private string _Descripcion;
        private string _Fecha_Vencimiento;
        private int _Stock;
        private int _Stock_Critico;
        private int _Id_Familia;
        private string _Familia;

        public int Id_Producto
        {
            get
            {
                return _Id_Producto;
            }
            set
            {
                _Id_Producto = value;
            }
        }
        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }
        public string Descripcion
        {
            get
            {
                return _Descripcion;
            }
            set
            {
                _Descripcion = value;
            }
        }
        public string Fecha_Vencimiento
        {
            get
            {
                return _Fecha_Vencimiento;
            }
            set
            {
                _Fecha_Vencimiento = value;
            }
        }
        public int Stock
        {
            get
            {
                return _Stock;
            }
            set
            {
                _Stock = value;
            }
        }
        public int Stock_Critico
        {
            get
            {
                return _Stock_Critico;
            }
            set
            {
                _Stock_Critico = value;
            }
        }

        public int Id_Familia
        {
            get
            {
                return _Id_Familia;
            }
            set
            {
                _Id_Familia = value;
            }
        }
        public string Familia
        {
            get
            {
                return _Familia;
            }
            set
            {
                _Familia = value;
            }
        }
    }
}
