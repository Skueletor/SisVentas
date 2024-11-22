using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CapaNegocio;
using CapaEntidad;
using CapaEntidad.Helpers;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            // Verificar si el usuario ingresado es el administrador predeterminado
            Usuario usuarioIngresado = new Usuario
            {
                Documento = txtdocumento.Text,
                Clave = txtclave.Text
            };

            if (UsuarioHelper.EsAdminPredeterminado(usuarioIngresado))
            {
                Usuario adminUsuario = UsuarioHelper.GetAdminPredeterminado();

                Inicio form = new Inicio(adminUsuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
                return;
            }

            // Buscar usuario en la base de datos
            Usuario ousuario = new CN_Usuario().Listar()
                .Where(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text)
                .FirstOrDefault();

            if (ousuario != null)
            {
                Inicio form = new Inicio(ousuario);
                form.Show();
                this.Hide();

                form.FormClosing += frm_closing;
            }
            else
            {
                MessageBox.Show("No se encontró el usuario", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }


        private void frm_closing(object sender, FormClosingEventArgs e) {

            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
