using SistemaBiblioteca.Datos;
using SistemaBiblioteca.Negocio;
using System;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmEjemplarPrincipal : Form
    {
        private bool Estado = true;
        private int ejemplarId, libroId;
        public int IdRol;


        public FrmEjemplarPrincipal()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            txtBuscarLibro.Clear();
            txtPais.Clear();
            TxtEditorial.Clear();
            TxtIdioma.Clear();
            TxtUbicacion.Clear();
            CboEstado.SelectedIndex = 0;
            DgvListadoLibro.DataSource = null;
            BtnAgregarEjemplar.Visible = true;
            BtnActualizar.Visible = false;
            ErrorIcono.Clear();
        }

        private void Buscar()
        {
            try
            {
                DgvListadoEjemplares.DataSource = NEjemplar.BuscarEjemplaresSinIdLibro(TxtBuscar.Text);
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoEjemplares.Rows.Count);
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
                DgvListadoEjemplares.DataSource = NEjemplar.ListarTodosEjemplares();
                DgvListadoEjemplares.Columns[1].Visible = false;
                DgvListadoEjemplares.Columns[7].Visible = false;


                this.Limpiar();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoEjemplares.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarLibrosPorId(int id)
        {
            try
            {
                DgvListadoLibro.DataSource = NLibro.BuscarLibroPorId(id);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarLibros()
        {
            try
            {
                DgvListadoLibro.DataSource = NLibro.Listar();
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
                if (TxtUbicacion.Text == string.Empty || TxtEditorial.Text == string.Empty || CboEstado.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");

                    if (TxtUbicacion.Text == string.Empty)
                        ErrorIcono.SetError(TxtUbicacion, "Ingrese una ubicación.");
                    else if (TxtEditorial.Text == string.Empty)
                        ErrorIcono.SetError(TxtEditorial, "Ingrese una editorial.");
                    else
                        ErrorIcono.SetError(TxtEditorial, "Ingrese una estado.");
                }
                else
                {
                    Estado = (CboEstado.Text == "Disponible") ? true : false;

                    Rpta = NEjemplar.Actualizar(ejemplarId, libroId, this.TxtUbicacion.Text.Trim(), Estado,
                        TxtEditorial.Text.Trim(), txtPais.Text.Trim(), TxtIdioma.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro.");
                        this.BtnCancelar2_Click(sender, e);
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
            try
            {
                DialogResult Opcion;
                Opcion = MessageBox.Show("Realmente deseas eliminar el(los) ejemplar(es)?", "Sistema de libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcion == DialogResult.OK)
                {
                    int Codigo;
                    string Rpta = "";

                    Codigo = Convert.ToInt32(DgvListadoEjemplares.CurrentRow.Cells[0].Value);
                    Rpta = NEjemplar.Eliminar(Codigo);

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se eliminó el ejemplar: " + Convert.ToString(DgvListadoEjemplares.CurrentRow.Cells[0].Value));
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }

                    this.Listar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void TabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabPrincipal.SelectedIndex == 0)
                this.Listar();
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            TabPrincipal.SelectedIndex = 0;
            Limpiar();
            TabPrincipal.Controls.Remove(tabPage2);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (TabPrincipal.TabPages.Count < 2)
            {
                TabPrincipal.Controls.Add(tabPage2);
            }

            ListarLibros();
            TabPrincipal.SelectedIndex = 1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;            

            ejemplarId = Convert.ToInt32(DgvListadoEjemplares.CurrentRow.Cells["Id"].Value);
            libroId = Convert.ToInt32(DgvListadoEjemplares.CurrentRow.Cells["IdLibro"].Value);
            TxtEditorial.Text = Convert.ToString(DgvListadoEjemplares.CurrentRow.Cells["Editorial"].Value);
            txtPais.Text = Convert.ToString(DgvListadoEjemplares.CurrentRow.Cells["Pais"].Value);
            TxtUbicacion.Text = Convert.ToString(DgvListadoEjemplares.CurrentRow.Cells["Ubicacion"].Value);
            TxtIdioma.Text = Convert.ToString(DgvListadoEjemplares.CurrentRow.Cells["Idioma"].Value);
            CboEstado.Text = Convert.ToString(DgvListadoEjemplares.CurrentRow.Cells["EstadoLibro"].Value);

            this.ListarLibrosPorId(libroId);

            if (TabPrincipal.TabPages.Count < 2) TabPrincipal.Controls.Add(tabPage2);
            TabPrincipal.SelectedIndex = 1;

            BtnAgregarEjemplar.Visible = false;
            BtnActualizar.Visible = true;

            Cursor.Current = Cursors.Default;
        }

        private void FrmEjemplarPrincipal_Load(object sender, EventArgs e)
        {
            if(IdRol == 2)
            {
                btnAgregar.Enabled = false;
                btnAgregar.Visible = false;
                btnEditar.Enabled = false;
                btnEditar.Visible = false;
                BtnEliminar.Enabled = false;
                BtnEliminar.Visible = false;
            }
            else if (IdRol == 1)
            {
                btnAgregar.Enabled = true;
                btnAgregar.Visible = true;
                btnEditar.Enabled = true;
                btnEditar.Visible = true;
                BtnEliminar.Enabled = true;
                BtnEliminar.Visible = true;
            }
            
            this.Listar();
            TabPrincipal.Controls.Remove(tabPage2);
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                DgvListadoLibro.DataSource = NLibro.Buscar(txtBuscarLibro.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnAgregarEjemplar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtUbicacion.Text == string.Empty || TxtEditorial.Text == string.Empty || CboEstado.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");

                    if(TxtUbicacion.Text == string.Empty)
                        ErrorIcono.SetError(TxtUbicacion, "Ingrese una ubicación.");
                    else if (TxtEditorial.Text == string.Empty)
                        ErrorIcono.SetError(TxtEditorial, "Ingrese una editorial.");
                    else
                        ErrorIcono.SetError(TxtEditorial, "Ingrese una estado.");

                }
                else
                {
                    Estado = (CboEstado.Text == "Disponible") ? true : false;

                    Rpta = NEjemplar.Insertar(Convert.ToInt32(DgvListadoLibro.CurrentRow.Cells[0].Value), this.TxtUbicacion.Text.Trim(), Estado,
                        TxtEditorial.Text.Trim(), txtPais.Text.Trim(), TxtIdioma.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se inserto de forma correcta el registro.");
                        BtnCancelar2_Click(sender, e);
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
    }
}
