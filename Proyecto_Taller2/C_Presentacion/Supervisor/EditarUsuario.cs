using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    public partial class EditarUsuario : Form
    {
        public EditarUsuario()
        {
            InitializeComponent();
        }

        private bool todosLosCamposValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, tbxNombre, 3)
                && validador.validarCampo(errorProvider, tbxApellido, 6)
                && validador.validarCampo(errorProvider, tbxDni, 7)
                && validador.validarCampo(errorProvider, tbxTelefono, 11)
                && validador.validarCampo(errorProvider, tbxUser, 4)
                && validador.validarCampo(errorProvider, tbxClave, 5);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidos()) MessageBox.Show("Exito");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar alta de usuario",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }
    }
}
