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
    public partial class formAltaUsuarioAdmin : Form
    {
        public formAltaUsuarioAdmin()
        {
            InitializeComponent();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.todosLosCamposValidados()) return;
        }

        private bool todosLosCamposValidados()
        {

            Validador validador = new Validador();
            return validador.validarCampo(errorProvider, tbxNombre) 
                && validador.validarCampo(errorProvider, tbxApellido)
                && validador.validarCampo(errorProvider, tbxDni, 8)
                && validador.validarCampo(errorProvider, tbxTelefono, 11)
                && validador.validarCampo(errorProvider, tbxUser)
                && validador.validarCampo(errorProvider, tbxClave, 5);

        }

        private void tbxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = char.IsDigit(e.KeyChar); 
        }

        private void tbxDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
