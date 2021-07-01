using SistemaBiblioteca.Datos;
using SistemaBiblioteca.Negocio;
using System;
using System.Collections.Generic;
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
            DgvActivosDevolucion.DataSource = null;
            DgvPrestamosActivos.DataSource = null;
            DgvEjemplares.DataSource = null;
            DgvProfesoresPrestamo.DataSource = null;
            DgvProfesoresDevolucion.DataSource = null;

            RdbVerPrestamos.Checked = true;
        }

        private void Buscar()
        {
            try
            {
                if(RdbVerPrestamos.Checked == true) 
                    DgvListadoPrestamos.DataSource = NPrestamo.BuscarPrestamos(TxtBuscar.Text);
                else 
                    DgvListadoPrestamos.DataSource = NPrestamo.BuscarDevoluciones(TxtBuscar.Text);

                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoPrestamos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ListarPrestamos()
        {
            try
            {
                DgvListadoPrestamos.DataSource = NPrestamo.ListarPrestamos();
                LblTotal.Text = "Total registros: " + Convert.ToString(DgvListadoPrestamos.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void ListarDevoluciones()
        {
            try
            {
                DgvListadoPrestamos.DataSource = NPrestamo.ListarDevoluciones();
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
            if (e.KeyCode == Keys.Enter)
            {
                this.Buscar();
                e.SuppressKeyPress = true;
            }
        }

        private void ListarProfesores()
        {
            DgvProfesoresPrestamo.DataSource = NUsuario.ListarProfesores();
        }

        private void ListarProfesoresDev()
        {
            DgvProfesoresDevolucion.DataSource = NUsuario.ListarProfesores();
        }

        private void ListarPrestamosActivosDeProfesor(int id)
        {
            DgvPrestamosActivos.DataSource = NPrestamo.BuscarPrestamosActivosProfesor(id);
        }

        private void ListarPrestamosActivosDeProfesorDev(int id)
        {
            DgvActivosDevolucion.DataSource = NPrestamo.BuscarPrestamosActivosProfesor(id);
        }

        private void ListarEjemplares()
        {
            DgvEjemplares.DataSource = NEjemplar.ListarEjemplaresDisponibles();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (DgvListadoPrestamos.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ningun registro para eliminar");
            else
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Realmente deseas eliminar el(los) registro(s)?", "Sistema de préstamo y devoluciones", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        string Rpta = "";

                        foreach (DataGridViewRow row in DgvListadoPrestamos.SelectedRows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = NLibro.Eliminar(Codigo);

                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se eliminó el registro: " + Convert.ToString(row.Cells[1].Value));
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }

                        RdbVerPrestamos.Checked = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
            }

        }

        private void TabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabPrincipal.SelectedIndex == 0)
                RdbVerPrestamos.Checked = true;
        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            this.ListarPrestamos();
            TabPrincipal.Controls.Remove(tabPage2);
            TabPrincipal.Controls.Remove(tabPage3);

        }

        private void RdbVerPrestamos_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarPrestamos();
        }

        private void RdbVerDevoluciones_CheckedChanged(object sender, EventArgs e)
        {
            this.ListarDevoluciones();
        }

        private void btnAgregarPrestamo_Click(object sender, EventArgs e)
        {
            if (TabPrincipal.TabPages.Count < 2)
            {
                TabPrincipal.Controls.Add(tabPage2);
            }

            this.ListarEjemplares();
            this.ListarProfesores();
            TabPrincipal.SelectedIndex = 1;
        }

        private void btnRegistrarDevolucion_Click_1(object sender, EventArgs e)
        {
            if (TabPrincipal.TabPages.Count < 2)
            {
                TabPrincipal.Controls.Add(tabPage3);
            }

            this.ListarProfesoresDev();
            TabPrincipal.SelectedTab = tabPage3;
        }

        private void DgvProfesoresPrestamo_SelectionChanged(object sender, EventArgs e)
        {
            this.ListarPrestamosActivosDeProfesor(Convert.ToInt32(DgvProfesoresPrestamo.CurrentRow.Cells[0].Value));
        }

        private void DgvProfesoresDevolucion_SelectionChanged(object sender, EventArgs e)
        {
            this.ListarPrestamosActivosDeProfesorDev(Convert.ToInt32(DgvProfesoresDevolucion.CurrentRow.Cells[0].Value));
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            TabPrincipal.SelectedIndex = 0;
            Limpiar();
            TabPrincipal.Controls.Remove(tabPage2);
        }

        private void BtnCancelar2_Click_1(object sender, EventArgs e)
        {
            TabPrincipal.SelectedIndex = 0;
            Limpiar();
            TabPrincipal.Controls.Remove(tabPage3);

        }

        private void BtnBuscarProfesorDevolucion_Click(object sender, EventArgs e)
        {
            this.BuscarProfesor(false, TxtBuscarPorNombreDev.Text);
        }

        private void BtnBuscarProfesorPrest_Click(object sender, EventArgs e)
        {
            this.BuscarProfesor(true, TxtBuscarPorNombrePrest.Text);
        }

        private void BuscarProfesor(bool esPrestamo, string valor)
        {
            try
            {
                if (esPrestamo)
                {
                    DgvProfesoresPrestamo.DataSource = NUsuario.BuscarProfesor(valor);
                }
                else
                {
                    DgvProfesoresDevolucion.DataSource = NUsuario.BuscarProfesor(valor);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnRegistraDevolucion_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                foreach (DataGridViewRow row in DgvActivosDevolucion.SelectedRows)
                {
                    Rpta = NPrestamo.Devolver(Convert.ToInt32(row.Cells["Id"].Value), DateTime.UtcNow.Date);

                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Registro agregado con éxito.");
                        Limpiar();
                        TabPrincipal.Controls.Remove(tabPage3);

                    }
                    else
                    {
                        this.MensajeError("Hubo un error. Favor Intente de nuevo");
                        MessageBox.Show(Rpta);
                    }
                }   
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnInsertarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                Rpta = NPrestamo.Insertar(Convert.ToInt32(DgvProfesoresPrestamo.CurrentRow.Cells["Id"].Value), Convert.ToInt32(DgvEjemplares.CurrentRow.Cells["Id"].Value),
                        DateTime.UtcNow.Date, DtpFechaDevolucion.Value.Date);

                if (Rpta.Equals("OK"))
                {
                    this.MensajeOk("Registro agregado con éxito.");
                    Limpiar();
                    TabPrincipal.Controls.Remove(tabPage2);

                }
                else
                {
                    this.MensajeError("Hubo un error. Favor Intente de nuevo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void BtnBuscarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                switch (CboCriterio.SelectedIndex)
                {
                    case 0:
                        DgvEjemplares.DataSource = NEjemplar.BuscarPorLibro(TxtBuscarPorLibro.Text.Trim());
                        break;
                    case 1:
                        DgvEjemplares.DataSource = NEjemplar.BuscarPorCodigoLibro(TxtBuscarPorLibro.Text.Trim());
                        break;
                    case 2:
                        DgvEjemplares.DataSource = NEjemplar.BuscarPorCodigoEjemplar(TxtBuscarPorLibro.Text.Trim());
                        break;
                    case 3:
                        DgvEjemplares.DataSource = NEjemplar.BuscarPorEditorial(TxtBuscarPorLibro.Text.Trim());
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

    }
}
