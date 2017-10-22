using PagoAgilFrba.Busquedas;
using PagoAgilFrba.Model;
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

namespace PagoAgilFrba.AbmCliente
{
    public partial class ModificacionCliente : Form
    {

        // Atributos
        private Util utils;
        private Cliente clienteACargar;

        // Constructores
        public ModificacionCliente()
        {
            InitializeComponent();
            utils = new Util();
        }

        private void botonBuscar_Click(object sender, EventArgs e)
        {
            utils.iniciarGrids(resultadosGrid);

            using (BusquedaCliente busquedaForm = new BusquedaCliente(resultadosGrid))
            {
                busquedaForm.ShowDialog(this);


                
            }
        }

        private void resultadosGrid_SelectionChanged(object sender, EventArgs e)
        {
            var cliente = resultadosGrid.SelectedCells[0].RowIndex;
            this.clienteACargar = new Cliente();
            this.clienteACargar.dni = Int32.Parse(resultadosGrid.Rows[cliente].Cells[2].Value.ToString());
        }

    }
}
