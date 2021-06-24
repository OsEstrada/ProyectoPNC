﻿using SistemaBiblioteca.Datos;
using SistemaBiblioteca.Negocio;
using System;
using System.Collections.Generic;
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
            TabPrincipal.Controls.Remove(tabPage2);
        }

        private void Limpiar()
        {
            TxtBuscar.Clear();
            TxtTitulo.Clear();
            LblidLibro.Text = "";
            TxtAutor.Clear();
            TxtISBN.Clear();
            TxtDescripcion.Clear();
            TxtMateria.Clear();
            LblidLibro.Visible = true;
            NmEdicionNo.Value = 1;
            NmPaginas.Value = 1;
            LblId.Visible = false;
            BtnInsertar.Visible = true;
            BtnActualizar.Visible = false;
            GrpEjemplares.Visible = false;
            BtnCancelar2.Visible = false;
            BtnCancelar.Visible = true;
            DgvEjemplares.DataSource = null;
            ErrorIcono.Clear();
            this.ListarEjemplares();
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

        private void ListarEjemplares()
        {
            if (!string.IsNullOrEmpty(LblidLibro.Text))
            {
                DgvEjemplares.DataSource = NEjemplar.Listar(Convert.ToInt32(LblidLibro.Text.Trim()));
            }
            LblTotalEjemplares.Text = "Total Ejemplares: " + Convert.ToString(DgvEjemplares.Rows.Count);
            
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtTitulo.Text == string.Empty || LblidLibro.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtTitulo, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NLibro.Actualizar(Convert.ToInt32(LblidLibro.Text), this.TxtTitulo.Text.Trim(), 
                        TxtAutor.Text.Trim(), TxtISBN.Text.Trim(), TxtMateria.Text.Trim(), CboEdicionAnio.Text, Convert.ToInt32(NmEdicionNo.Value),
                        Convert.ToInt32(NmPaginas.Value), TxtDescripcion.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro");
                        this.BtnCancelar_Click(sender, e);
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
            Cursor.Current = Cursors.Default;
            this.Limpiar();
            BtnActualizar.Visible = true;
            BtnInsertar.Visible = false;
            BtnCancelar.Visible = false;
            LblId.Visible = true;
            GrpEjemplares.Visible = true;
            BtnCancelar2.Visible = true;

            LblidLibro.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Id"].Value);
            TxtTitulo.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Titulo"].Value);
            TxtAutor.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Autor"].Value);
            TxtISBN.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["ISBN"].Value);
            TxtDescripcion.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Descripcion"].Value);
            TxtMateria.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["Materia"].Value);
            CboEdicionAnio.Text = Convert.ToString(DgvListadoLibros.CurrentRow.Cells["AnioEdicion"].Value);
            NmEdicionNo.Value = Convert.ToInt64(DgvListadoLibros.CurrentRow.Cells["NoEdicion"].Value);
            NmPaginas.Value = Convert.ToInt64(DgvListadoLibros.CurrentRow.Cells["NoPaginas"].Value);

            this.ListarEjemplares();
            if (TabPrincipal.TabPages.Count < 2) TabPrincipal.Controls.Add(tabPage2);
            TabPrincipal.SelectedIndex = 1;
            Cursor.Current = Cursors.WaitCursor;
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtTitulo.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtTitulo, "Ingrese un nombre.");
                }
                else
                {
                    Rpta = NLibro.Insertar(TxtTitulo.Text.Trim(), TxtAutor.Text.Trim(), TxtISBN.Text.Trim(), TxtMateria.Text.Trim(),
                        CboEdicionAnio.Text, Convert.ToInt32(NmEdicionNo.Value),
                        Convert.ToInt32(NmPaginas.Value), TxtDescripcion.Text.Trim());
                    if (char.IsDigit(Rpta[0]))
                    {
                        DialogResult Opcion;
                        Opcion = MessageBox.Show("Se insertó de forma correcta el registro. ¿Desea agregar ejemplares?", "Sistema de libros", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (Opcion == DialogResult.Yes)
                        {
                            LblidLibro.Text = Rpta;
                            LblId.Visible = true;
                            BtnInsertar.Visible = false;
                            BtnCancelar.Visible = false;
                            BtnCancelar2.Visible = true;
                            GrpEjemplares.Visible = true;
                        }
                        else
                            this.BtnCancelar_Click(sender, e);
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
                    Opcion = MessageBox.Show("Realmente deseas eliminar el(los) libro(s)?", "Sistema de libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        string Rpta = "";

                        foreach (DataGridViewRow row in DgvListadoLibros.SelectedRows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells[1].Value);
                                Rpta = NLibro.Eliminar(Codigo);

                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se eliminó el libro: " + Convert.ToString(row.Cells[2].Value));
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
            TabPrincipal.SelectedIndex = 0;
            Limpiar();
            TabPrincipal.Controls.Remove(tabPage2);
        }

        private void TabPrincipal_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(TabPrincipal.SelectedIndex == 0)
                this.Listar();
        }

        private void DgvEjemplares_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var Ubicacion = Convert.ToString(DgvEjemplares.CurrentRow.Cells["Ubicacion"].Value);
            var Pais = Convert.ToString(DgvEjemplares.CurrentRow.Cells["Pais"].Value);
            var Idioma = Convert.ToString(DgvEjemplares.CurrentRow.Cells["Idioma"].Value);
            var Editorial = Convert.ToString(DgvEjemplares.CurrentRow.Cells["Editorial"].Value);
            var Estado = Convert.ToBoolean(DgvEjemplares.CurrentRow.Cells["Estado"].Value);
            var IdEjemplar = Convert.ToInt32(DgvEjemplares.CurrentRow.Cells["Id"].Value);
            var IdLibro = Convert.ToInt32(LblidLibro.Text.Trim());

            FrmEjemplar frm = new FrmEjemplar(IdEjemplar, IdLibro, Ubicacion, Editorial, Pais, Estado, Idioma);
            frm.ShowDialog();
            ListarEjemplares();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(TabPrincipal.TabPages.Count < 2)
            {
                TabPrincipal.Controls.Add(tabPage2);
            }
            TabPrincipal.SelectedIndex = 1;
        }


        private void PicAgregarEjemplar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(LblidLibro.Text))
                MessageBox.Show("Debe registrar un libro primero");
            else
            {
                FrmEjemplar frm = new FrmEjemplar(Convert.ToInt32(LblidLibro.Text.Trim()));
                frm.ShowDialog();
                ListarEjemplares();
            }
        }

        private void BtnCancelar2_Click(object sender, EventArgs e)
        {
            this.BtnCancelar_Click(sender, e);
        }

        private void BtnEliminarEjemplares_Click(object sender, EventArgs e)
        {
            if (DgvEjemplares.SelectedRows.Count == 0)
                MessageBox.Show("No se ha seleccionado ningun ejemplar para eliminar");
            else
            {
                try
                {
                    DialogResult Opcion;
                    Opcion = MessageBox.Show("Realmente deseas eliminar el(los) ejemplar(es)?", "Sistema de libros", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (Opcion == DialogResult.OK)
                    {
                        int Codigo;
                        string Rpta = "";

                        foreach (DataGridViewRow row in DgvEjemplares.SelectedRows)
                        {
                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                                Codigo = Convert.ToInt32(row.Cells["Id"].Value);
                                Rpta = NEjemplar.Eliminar(Codigo);

                                if (Rpta.Equals("OK"))
                                {
                                    this.MensajeOk("Se eliminó el ejemplar: " + Convert.ToString(row.Cells["Id"].Value));
                                }
                                else
                                {
                                    this.MensajeError(Rpta);
                                }
                            }
                        }
                        this.ListarEjemplares();
                    }
                }
                    catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + ex.StackTrace);
                }
        }
        }
    }
}
