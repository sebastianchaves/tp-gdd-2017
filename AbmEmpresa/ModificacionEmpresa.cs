using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Modelo.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PagoAgilFrba.AbmEmpresa
{
    public partial class ModificacionEmpresa : Form
    {

        // Atributos
        private Util utils;

        // Constructores
        public ModificacionEmpresa()
        {
            InitializeComponent();

            this.utils = new Util();
        }

        // Eventos
        private void botonBuscar_Click(object sender, EventArgs e)
        {    
            utils.iniciarGrids(resultadosGrid);

            using (BusquedaEmpresa busquedaForm = new BusquedaEmpresa(resultadosGrid))
            {
                busquedaForm.ShowDialog(this);
            }
        }

    }
}
