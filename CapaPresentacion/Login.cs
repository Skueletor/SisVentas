using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = new CN_Usuario().Listar();

            // Validar si el usuario es administrador
            if (txtdocumento.Text == "admin" && txtclave.Text == "admin")
            {
                // Abrir el formulario de inicio y actualizar el mensaje en el label
                Inicio form = new Inicio();
                form.Show();
                this.Hide();

                // Configurar el mensaje en el label
                Label usuario = (Label)form.Controls["usuario"];
                usuario.Text = "Usuario: admin";

                // Suscribirse al evento FormClosing del formulario Inicio
                form.FormClosing += frm_closing;
            }
            else
            {
                // Buscar el usuario en la lista
                Usuario ousuario = usuarios.FirstOrDefault(u => u.Documento == txtdocumento.Text && u.Clave == txtclave.Text);

                if (ousuario != null)
                {
                    // Abrir el formulario de inicio y actualizar el mensaje en el label
                    Inicio form = new Inicio();
                    form.Show();
                    this.Hide();

                    // Configurar el mensaje en el label
                    Label usuario = (Label)form.Controls["usuario"];
                    usuario.Text = $"Usuario: {ousuario.Documento}";

                    // Suscribirse al evento FormClosing del formulario Inicio
                    form.FormClosing += frm_closing;
                }
                else
                {
                    // Mostrar mensaje si no se encuentra el usuario
                    MessageBox.Show("No se encontró el usuario.", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        
            
        }
        

        private void frm_closing(object sender,FormClosingEventArgs e)
        {
            txtdocumento.Text = "";
            txtclave.Text = "";
            this.Show();
        }
    }
}
