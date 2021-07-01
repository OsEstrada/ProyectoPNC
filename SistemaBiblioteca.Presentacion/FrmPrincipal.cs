using System;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmPrincipal : Form
    {
        public int IdUsuario;
        public int IdRol;
        public string Nombre;
        private int childFormNumber = 0;

        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void librosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLibro frm = new FrmLibro();
            frm.MdiParent = this;
            frm.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPrestamo frm = new FrmPrestamo();
            frm.MdiParent = this;
            frm.Show();
        }

        private void ejemplaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEjemplarPrincipal frm = new FrmEjemplarPrincipal();
            frm.IdRol = IdRol;
            frm.MdiParent = this;
            frm.Show();
        }

        private void reportesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reportes.FrmElegirReporte frm = new Reportes.FrmElegirReporte();
            frm.ShowDialog();

            if (frm.esReporteLibro)
            {
                Cursor.Current = Cursors​.WaitCursor;
                Reportes.FrmReporteLibros rpt = new Reportes.FrmReporteLibros();
                rpt.MdiParent = this;
                rpt.Show();
                Cursor.Current = Cursors​.Default;
            }
            else
            {
                Cursor.Current = Cursors​.WaitCursor;
                Reportes.FrmReportePrestamos rpt = new Reportes.FrmReportePrestamos();
                rpt.MdiParent = this;
                rpt.Show();
                Cursor.Current = Cursors​.Default;
            }

            frm.Close();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                MdiClient client = control as MdiClient;
                if (!(client == null))
                {
                    client.BackgroundImage = Properties.Resources.BibliotecaFondo;
                    break;
                }
            }

            if (IdRol == 2)
            {
                MnuLibros.Enabled = false;
                MnuLibros.Visible = false;
                MnuEjemplares.Enabled = true;
                MnuEjemplares.Visible = true;
                MnuPrestamos.Enabled = false;
                MnuPrestamos.Visible = false;
                MnuReportes.Enabled = false;
                MnuReportes.Visible = false;

            }else if(IdRol == 1)
            {
                MnuLibros.Enabled = true;
                MnuLibros.Visible = true;
                MnuEjemplares.Enabled = true;
                MnuEjemplares.Visible = true;
                MnuPrestamos.Enabled = true;
                MnuPrestamos.Visible = true;
                MnuReportes.Enabled = true;
                MnuReportes.Visible = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
