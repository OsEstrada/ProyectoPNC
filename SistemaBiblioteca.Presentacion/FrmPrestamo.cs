using SistemaBiblioteca.Negocio;
using System;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmPrestamo : Form
    {
        public FrmPrestamo()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtBuscarPorLibro.Clear();
            ErrorIcono.Clear();
        }

        private void Buscar()
        {
            try
            {
                DgvListadoPrestamos.DataSource = NLibro.Buscar(TxtBuscar.Text);
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoPrestamos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Bibliotca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Listar()
        {
            try
            {
                DgvListadoPrestamos.DataSource = NLibro.Listar();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoPrestamos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void TxtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.Buscar();
                e.SuppressKeyPress = true;
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListadoPrestamos.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ningun libro para eliminar");
            else
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Realmente deseas eliminar el(los) libro(s)?", "Sistema de ventas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        string Rpta = "";

                        foreach (DataGridViewRow row in DgvListadoPrestamos.SelectedRows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[0].Value);
                                Rpta = NLibro.Eliminar(Codigo);

                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se eliminó el libro: " + Convert.ToString(row.Cells[1].Value));
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }
                        this.Listar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }
           
        }

        private void FrmPrestamo_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void DgvListadoPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
