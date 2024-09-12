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
            this.Close();
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
            if(cbxTalleXL.Checked) tbxTalleXL.Enabled = true; else tbxTalleXL.Enabled= false;
        }
    }
}
