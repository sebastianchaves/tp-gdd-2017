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

        // Finds
        public List<String> findRubrosDisponibles()
        {
            List<String> rubros = new List<String>();
            
            // TODO es para probar
            rubros.Add("Rubro 1");
            rubros.Add("Rubro 2");
            rubros.Add("Rubro 3");
            rubros.Add("Rubro 4");

            return rubros;
        }

        public IList<Empresa> findEmpresa(String nombreEmpresa, int cuitEmpresa, String rubroEmpresa)
        {
            IList<Empresa> resultados = new List<Empresa>();

            // TODO para probar
            resultados.Add(new Empresa(nombreEmpresa, cuitEmpresa, rubroEmpresa));
            resultados.Add(new Empresa(nombreEmpresa, cuitEmpresa, rubroEmpresa));
            resultados.Add(new Empresa(nombreEmpresa, cuitEmpresa, rubroEmpresa));
            resultados.Add(new Empresa(nombreEmpresa, cuitEmpresa, rubroEmpresa));

            return resultados;
        }

    }
}
