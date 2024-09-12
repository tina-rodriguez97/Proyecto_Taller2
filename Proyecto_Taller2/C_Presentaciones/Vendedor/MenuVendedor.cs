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
    }
}
