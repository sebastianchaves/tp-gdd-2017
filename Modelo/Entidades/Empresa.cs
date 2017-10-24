using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.Entidades
{
    class Empresa
    {

        // Atributos
        public String nombre;
        public int cuit;
        public String direccion;
        public String rubro;
        public Boolean habilitada;

        // Constructores
        public Empresa()
        {
        }

        public Empresa(String nombre, int cuit, String rubro)
        {
            this.nombre = nombre;
            this.cuit = cuit;
            this.rubro = rubro;
        }

    }

}
