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
        public string Ubicacion, Editorial, Pais, Idioma, Estado;
        private int EjemplarId;

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string Rpta = "";
            //    if (TxtTitulo.Text == string.Empty || TxtId.Text == string.Empty)
            //    {
            //        this.MensajeError("Falta ingresar algunos datos, serán remarcados.");
            //        ErrorIcono.SetError(TxtTitulo, "Ingrese un nombre.");
            //    }
            //    else
            //    {
            //        Rpta = NEjemplar.Actualizar(EjemplarId, this.TxtUbicacion.Text.Trim(),
            //            txtPais.Text.Trim(), TxtIdioma.Text.Trim());
            //        if (Rpta.Equals("OK"))
            //        {
            //            this.MensajeOk("Se actualizó de forma correcta el registro");
            //            this.Limpiar();
            //            this.Listar();
            //        }
            //        else
            //        {
            //            this.MensajeError(Rpta);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
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
        }

        public FrmEjemplar(int idEjemplar)
        {
            InitializeComponent();
            EjemplarId = idEjemplar;
        }
    }
}
