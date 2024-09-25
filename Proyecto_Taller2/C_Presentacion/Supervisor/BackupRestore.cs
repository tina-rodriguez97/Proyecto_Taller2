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
    public partial class BackupRestore : Form
    {
        public BackupRestore()
        {
            InitializeComponent();
        }

        private void btnBuscarGuardar_Click(object sender, EventArgs e)
        {
            //openFileDialog1.Filter = "*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK) tbxGuardarEn.Text = openFileDialog1.FileName;



        }

        private void btnBuscarRestaurar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) tbxBuscarCopia.Text = openFileDialog1.FileName;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
