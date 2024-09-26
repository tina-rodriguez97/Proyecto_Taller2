using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller2.C_Presentaciones.Vendedor;
using Proyecto_Taller2.C_Presentaciones.Login;

namespace Proyecto_Taller2.C_Presentaciones
{
    public partial class MenuVendedor : Form
    {
        private int childFormNumber = 0;

        public MenuVendedor()
        {
            InitializeComponent();
        }

        private void btnListaProductos_Click(object sender, EventArgs e)
        {
            ListaProductos productosForm = new ListaProductos();
            CargarFormularioEnPanel(new ListaProductos(), panelMuestra);
        }

        private void CargarFormularioEnPanel(Form formulario, Panel panelDestino)
        {
            // Limpiar cualquier control anterior en el panel destino
            panelDestino.Controls.Clear();

            // Configurar el formulario como hijo de este contenedor (MDI)
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel destino y mostrarlo
            panelDestino.Controls.Add(formulario);
            formulario.Show();
        }

        private void btnRealizarVenta_Click(object sender, EventArgs e)
        {
            RealizarVenta productosForm = new RealizarVenta();
            CargarFormularioEnPanel(new RealizarVenta(), panelMuestra);
        }

        private void btnVentasRealizadas_Click(object sender, EventArgs e)
        {
            ListaVentasRealizadas productosForm = new ListaVentasRealizadas();
            CargarFormularioEnPanel(new ListaVentasRealizadas(), panelMuestra);
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            AltaCliente productosForm = new AltaCliente();
            CargarFormularioEnPanel(new AltaCliente(), panelMuestra);
        }

        private void panelMuestra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCerrarSseion_Click(object sender, EventArgs e)
        {
            // Crear una instancia del formulario Login
            Login loginForm = new Login();

            // Mostrar el formulario de Login
            loginForm.Show();

            // Cerrar el formulario actual (el que contiene el botón)
            this.Close();
        }
    }
}
