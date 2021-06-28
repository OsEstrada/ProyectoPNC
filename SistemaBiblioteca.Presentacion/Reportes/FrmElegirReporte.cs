using System;
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
    public partial class FrmElegirReporte : Form
    {
        public bool esReporteLibro;
        public FrmElegirReporte()
        {
            InitializeComponent();
            CboReporte.SelectedIndex = 0;
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (CboReporte.SelectedIndex == 0)
            {
                esReporteLibro = true;
            }
            else if (CboReporte.SelectedIndex == 1)
            {
                esReporteLibro = false;
            }

            Hide();
        }
    }
}
