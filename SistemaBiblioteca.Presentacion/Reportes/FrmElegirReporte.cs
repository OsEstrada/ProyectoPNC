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
        public FrmElegirReporte()
        {
            InitializeComponent();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (CboReporte.SelectedIndex == 0)
            {
                FrmReporteLibros reportes = new FrmReporteLibros();
                reportes.ShowDialog();
            }
            else if (CboReporte.SelectedIndex == 1)
            {
                FrmReporteLibros reportes = new FrmReporteLibros();
                reportes.ShowDialog();
            }
        }
    }
}
