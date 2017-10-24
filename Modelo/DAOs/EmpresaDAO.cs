using PagoAgilFrba.Modelo.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PagoAgilFrba.Modelo.DAOs
{

    class EmpresaDAO
    {
        // Adds
        public void agregarEmpresa(Empresa empresa)
        {

        }

        // Exists
        public Boolean existeCuit(int cuit)
        {
            return false;
        }

        // Pedidos
        public List<String> rubrosDisponibles()
        {
            List<String> rubros = new List<String>();
            rubros.Add("Rubro 1");
            rubros.Add("Rubro 2");
            rubros.Add("Rubro 3");
            rubros.Add("Rubro 4");

            return rubros;
        }

    }
}
