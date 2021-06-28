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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            var User = NUsuario.Login(TxtUsuario.Text, MtbContrasenia.Text);
            if (User == null)
            {
                MessageBox.Show("El email o la clave es incorrecta.", "Acceso al Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FrmPrincipal Frm = new FrmPrincipal();
                Frm.IdUsuario = User.IdUsuario;
                Frm.IdRol = User.IdRol ?? 2;
                Frm.Nombre = User.Nombre;
                Frm.Show();
                this.Hide();

            }
        }

    }
}
