﻿using System;
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
    public partial class ListarUsuarios : Form
    {
        public ListarUsuarios()
        {
            InitializeComponent();
        }

        private void test_Click(object sender, EventArgs e)
        {
            new EditarUsuario().ShowDialog();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
