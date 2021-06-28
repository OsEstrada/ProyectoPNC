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
    public partial class FrmReportePrestamos : Form
    {
        public FrmReportePrestamos()
        {
            InitializeComponent();
        }

        private void FrmReporteLibros_Load(object sender, EventArgs e)
        {
            this.ListarPrestamosTableAdapter.Fill(this.DsBiblioteca.ListarPrestamos);

            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.PageWidth;
            this.reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
            this.reportViewer1.RefreshReport();
        }
    }
}
