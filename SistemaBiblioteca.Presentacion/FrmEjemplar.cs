using SistemaBiblioteca.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaBiblioteca.Presentacion
{
    public partial class FrmEjemplar : Form
    {
        public string Ubicacion, Editorial, Pais, Idioma;
        public bool Estado = true;
        private int EjemplarId, LibroId;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void MensajeError(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Bibliotca", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeOk(string Mensaje)
        {
            MessageBox.Show(Mensaje, "Sistema de Biblioteca", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (TxtUbicacion.Text == string.Empty || CboEstado.Text == string.Empty)
                {
                    this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
                    ErrorIcono.SetError(TxtUbicacion, "Ingrese una ubicación.");
                }
                else
                {
                    Estado = (CboEstado.Text == "Disponible") ? true : false;

                    Rpta = NEjemplar.Actualizar(EjemplarId, LibroId, this.TxtUbicacion.Text.Trim(), Estado,
                        TxtEditorial.Text.Trim(), txtPais.Text.Trim(), TxtIdioma.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeOk("Se actualizó de forma correcta el registro.");
                        Dispose();
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

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Ubicacion = TxtUbicacion.Text.Trim();
            Editorial = TxtEditorial.Text.Trim();
            Pais = txtPais.Text.Trim();
            Idioma = TxtIdioma.Text.Trim();
        }

        public FrmEjemplar()
        {
            InitializeComponent();
            CboEstado.SelectedIndex = 0;
        }

        public FrmEjemplar(int idEjemplar, int idLibro)
        {
            InitializeComponent();
            CboEstado.SelectedIndex = 0;
            EjemplarId = idEjemplar;
            LibroId = idLibro;
        }
    }
}
