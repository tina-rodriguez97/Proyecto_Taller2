﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto_Taller2.C_Presentacion.Administrador;

namespace Proyecto_Taller2.C_Presentacion.Supervisor
{
    public partial class FormularioPrincipalSupervisor : Form
    {
        public FormularioPrincipalSupervisor()
        {
            InitializeComponent();
        }

        private void btnEstadistias_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = new EstadisticasVentas();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnListarVentas_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = new BackupRestore();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Seguro que desea cerrar la sesion actual?", "Cerrar sesion",
                               MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question);

            if (result == DialogResult.Yes) this.Close();
        }

        private void btnAgregarusuario_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = new AgregarUsuario();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void btnListarUsuarios_Click(object sender, EventArgs e)
        {
            if (this.Contains(this.ActiveMdiChild)) ActiveMdiChild?.Close();

            Form form = new ListarUsuarios();
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }
    }
}
