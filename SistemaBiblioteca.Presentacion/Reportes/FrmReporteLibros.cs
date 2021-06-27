﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion.Reportes
{
    public partial class FrmReporteLibros : Form
    {
        public FrmReporteLibros()
        {
            InitializeComponent();
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DsBiblioteca.ListarLibros' table. You can move, or remove it, as needed.
            this.ListarLibrosTableAdapter.Fill(this.DsBiblioteca.ListarLibros);

            this.reportViewer1.RefreshReport();
        }
    }
}
