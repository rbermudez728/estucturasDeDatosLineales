using System;
using System.Linq;
using System.Windows.Forms;

namespace EstructurasDeDatosLineales
{
    public partial class FmLogin : Form
    {

        FrmConsulta frmMenu;

        public FmLogin()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            crearMenuForm();
        }

        private void crearMenuForm()
        {
            if (frmMenu == null)
            {

                frmMenu = new FrmConsulta();
                frmMenu.FormClosed += MenuFormClosed;
            }
        }

        private void MenuFormClosed(object sender, FormClosedEventArgs e)
        {
            frmMenu.FormClosed -= MenuFormClosed;
            frmMenu = null;
            this.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (!(tbPassword.Text.Any()) || tbPassword.Text != "123")
            {
                MessageBox.Show("Contraseña invalida, intente nuevamente...");
                tbPassword.Clear();
            }
            else
            {

                if (frmMenu == null)
                {

                    frmMenu = new FrmConsulta();
                    frmMenu.FormClosed += MenuFormClosed;
                }
                frmMenu.Show();
                this.Hide();
            }
        }

        private void lblTituloLogin_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!(tbPassword.Text.Any()) || tbPassword.Text != "123")
            {
                MessageBox.Show("Contraseña invalida, intente nuevamente...");
                tbPassword.Clear();
            }
            else
            {

                if (frmMenu == null)
                {

                    frmMenu = new FrmConsulta();
                    frmMenu.FormClosed += MenuFormClosed;
                }
                frmMenu.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
