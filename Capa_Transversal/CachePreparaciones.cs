using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Transversal
{
    public class CachePreparaciones
    {
        private int _Id_plato;
        private string _Nombre_Plato;
        private string _Descripcion;
        private int _Tiempo_Preparacion;
        private int _Valor;
        private string _Disponibilidad;
        private int _Id_tipo_preparacion;
        private string _Categoria;


        public int Id_plato
        {
            get
            {
                return _Id_plato;
            }
            set
            {
                _Id_plato = value;
            }
        }

        public string Nombre_Plato
        {
            get
            {
                return _Nombre_Plato;
            }
            set
            {
                _Nombre_Plato = value;
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

        public int Tiempo_Preparacion
        {
            get
            {
                return _Tiempo_Preparacion;
            }
            set
            {
                _Tiempo_Preparacion = value;
            }
        }

        public int Valor
        {
            get
            {
                return _Valor;
            }
            set
            {
                _Valor = value;
            }
        }

        public string Disponibilidad
        {
            get
            {
                return _Disponibilidad;
            }
            set
            {
                _Disponibilidad = value;
            }
        }
        public int Id_tipo_preparacion
        {
            get
            {
                return _Id_tipo_preparacion;
            }
            set
            {
                _Id_tipo_preparacion = value;
            }
        }

        public string Categoria
        {
            get
            {
                return _Categoria;
            }
            set
            {
                _Categoria = value;
            }
        }


    }
}
