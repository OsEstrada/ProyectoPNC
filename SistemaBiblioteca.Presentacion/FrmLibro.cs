using SistemaBiblioteca.Negocio;
using System;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmLibro : Form
    {
        public FrmLibro()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }


        private void FrmLibro_Load(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtNombre.Clear();
            TxtId.Clear();
            TxtAutor.Clear();
            TxtISBN.Clear();
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
        }

        private void Buscar()
        {
            try
            {
                DgvListadoLibros.DataSource = NLibro.Buscar(TxtBuscar.Text);
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoLibros.Rows.Count);
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
                DgvListadoLibros.DataSource = NLibro.Listar();
                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoLibros.Rows.Count);
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
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty || TxtId.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NLibro.Actualizar(Convert.ToInt32(TxtId.Text), this.TxtNombre.Text.Trim(), TxtAutor.Text.Trim(), TxtISBN.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void DgvListadoLibros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                BtnActualizar.Visible = true;
                BtnInsertar.Visible = false;
                TxtId.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["ID"].Value);
                TxtNombre.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Nombre"].Value);
                TxtAutor.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Autor"].Value);
                TxtISBN.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["ISBN"].Value);
                TabPrincipal.SelectedIndex = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione desde la celda nombre.");
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtNombre, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NLibro.Insertar(TxtNombre.Text.Trim(), TxtAutor.Text.Trim(), TxtISBN.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se insertó de forma correcta el registro.");
                        this.Limpiar();
                        this.Listar();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListadoLibros.SelectedRows.Count == 0)
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

                        foreach (DataGridViewRow row in DgvListadoLibros.SelectedRows)
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

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
            TabPrincipal.SelectedIndex = 0;
        }
    }
}
