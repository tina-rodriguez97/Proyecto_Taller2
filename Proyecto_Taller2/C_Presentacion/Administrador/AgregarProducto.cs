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
    public partial class AgregarProducto : Form
    {
        public AgregarProducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cancelar esta operacion?", "Cancelar alta de usuario",
                              MessageBoxButtons.YesNo,
                              MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void cbxTalleM_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTalleM.Checked) tbxTalleM.Enabled = true; else tbxTalleM.Enabled = false;
        }

        private void cbxTalleL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTalleL.Checked) tbxTalleL.Enabled = true; else tbxTalleL.Enabled = false;
        }

        private void cbxTalleXL_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxTalleXL.Checked) tbxTalleXL.Enabled = true; else tbxTalleXL.Enabled = false;
        }

        private bool todosSonValidos()
        {
            Validador validador = new Validador();

            return validador.validarCampo(errorProvider, tbxNombre, 5)
                && validador.validarCampo(errorProvider, tbxDescripcion, 10)
                && validador.validarCampo(errorProvider,tbxStockMnimo,1)
                && validador.validarTalles(errorProvider, tbxTalleS, tbxTalleM, tbxTalleL, tbxTalleXL);

        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (todosSonValidos()) return;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new nuevaMarca().ShowDialog();
        }

        private void tbxTalleS_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxTalleM_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxTalleL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxTalleXL_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void tbxStockMnimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
    }
}
