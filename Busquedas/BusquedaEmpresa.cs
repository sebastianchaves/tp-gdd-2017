﻿using PagoAgilFrba.Modelo.DAOs;
using PagoAgilFrba.Modelo.Entidades;
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

namespace PagoAgilFrba.Busquedas
{
    public partial class BusquedaEmpresa : Form
    {

        // Atributos
        private IList<Empresa> empresasEncontradas;
        private EmpresaDAO empresaDao;
        private Util util;
        private DataGridView resultadosGrid;

        // Constructores
        public BusquedaEmpresa(DataGridView resultadosGrid)
        {
            InitializeComponent();

            this.util = new Util();
            this.empresaDao = new EmpresaDAO();
            this.cargarRubrosDisponibles();
            this.resultadosGrid = resultadosGrid;
        }

        // Metodos
        private void cargarRubrosDisponibles()
        {
            List<String> rubros = this.empresaDao.findRubrosDisponibles();

            var dataSource = new List<String>();

            foreach (String rubro in rubros)
            {
                dataSource.Add(rubro);
            }

            rubroCombo.DataSource = dataSource;
        }

        private String cargarNombre()
        {
            return this.nombreInput.Text;
        }

        private int cargarCuit()
        {
            try
            {
                return Int32.Parse(cuitInput.Text);
            }
            catch (Exception ex)
            {
                util.catchearErrorFormato(ex, cuitTooltip, cuitInput);
                return 0;
            }
        }

        private String cargarRubro()
        {
            return this.rubroCombo.SelectedItem.ToString();
        }

        private void cargarDataGridEmpresas(IList<Empresa> empresas)
        {
            DataTable resultadosEmpresas = new DataTable();

            resultadosEmpresas.Columns.Add("Nombre");
            resultadosEmpresas.Columns.Add("Cuit");
            resultadosEmpresas.Columns.Add("Rubro");

            foreach (Empresa empresa in empresas)
            {
                resultadosEmpresas.Rows.Add(empresa.nombre, empresa.cuit, empresa.rubro);
            }
            resultadosGrid.DataSource = resultadosEmpresas;
        }

        // Eventos
        // Boton Buscar
        private void botonBuscar_Click(object sender, EventArgs e)
        {
            this.empresasEncontradas = this.empresaDao.findEmpresa(this.cargarNombre(),
                                                                this.cargarCuit(),
                                                                this.cargarRubro());
            if (empresasEncontradas.Count() == 0)
            {
                MessageBox.Show("No existe ninguna empresa que concuerde con esos parámetros.");
            }
            else if (empresasEncontradas.Count() > 0)
            {
                this.cargarDataGridEmpresas(empresasEncontradas);
                this.Close();
            }

        }

    }
}
