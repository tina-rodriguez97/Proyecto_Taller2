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
    public partial class EditarProducto : Form
    {
        public EditarProducto()
        {
            InitializeComponent();
        }

        private bool todosSonValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, tbxNombre, 5)
                && validador.validarCampo(errorProvider, tbxDescripcion, 10);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (todosSonValidos()) MessageBox.Show("Exito!"); 
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cacncelar la edicion del producto?", "Cancelar accion",
                                 MessageBoxButtons.YesNo,
                                 MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }
    }
}
