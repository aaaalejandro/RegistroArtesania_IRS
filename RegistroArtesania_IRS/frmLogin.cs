using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RegistroArtesania_IRS
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioL.Text == "" || txtContraseñaL.Text == "")
            {
                MessageBox.Show("Por favor, ingresa usuario y/o contraseña.");
                return;
            }
            if (txtUsuarioL.Text == "admin" && txtContraseñaL.Text == "admin")
            {
                // Si las credenciales son correctas, abre el formulario deseado
                FrmRegistrarArtesania formulario = new FrmRegistrarArtesania();
                formulario.Show();


                // Cierra el formulario de inicio de sesión
                this.Hide();
            }
            else
            {
                // Si las credenciales son incorrectas, muestra un mensaje de error
                MessageBox.Show("Usuario o contraseña incorrectos");
                txtUsuarioL.Clear();
                txtContraseñaL.Clear();
                txtUsuarioL.Focus();

            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void txtContraseñaL_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseñaL_Click(object sender, EventArgs e)
        {
            txtContraseñaL.PasswordChar = '*';
        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            txtContraseñaL.PasswordChar = '\0';
            if (!checkBox1.Checked)
            {
                txtContraseñaL.PasswordChar = '*';
            }
        }

        private void txtContraseñaL_Enter_1(object sender, EventArgs e)
        {
            txtContraseñaL.PasswordChar = '*';
        }

        private void txtContraseñaL_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void txtContraseñaL_Click_1(object sender, EventArgs e)
        {
            txtContraseñaL.PasswordChar = '*';
        }
    }
}
