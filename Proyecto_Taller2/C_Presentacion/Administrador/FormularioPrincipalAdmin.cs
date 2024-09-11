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

        private bool _isFormOpen = false;
        public Principal_Admin()
        {
            InitializeComponent();
        }

        private void btnNuevoUsuario_Click(object sender, EventArgs e)
        {


            if (Application.OpenForms.Count == 2) return;

            Form form = new formAltaUsuarioAdmin();
            form.MdiParent = this;
            form.Show();


        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {

            if (Application.OpenForms.Count == 2) return;

            Form form = new AgregarProducto();
            form.MdiParent = this;
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2) return;
            Form form = new formListarUsuarios();
            form.MdiParent = this;
            form.Show();
        }

        private void Principal_Admin_Load(object sender, EventArgs e)
        {

        }

        private void btnListarProductos_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 2) return;
            Form form = new ListarProductos();
            form.MdiParent = this;
            form.Show();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
