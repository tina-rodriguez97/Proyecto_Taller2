using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller2.C_Presentacion.Administrador
{
    public partial class Principal_Admin : Form
    {
        public Principal_Admin()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = new ListarVentas();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = new AgregarProducto();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
        }

        private void Principal_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();
            Form form = new ListarProductos();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cerrar la sesion actual?", "Cerrar sesion",
                                MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }
    }
}
