using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SisLanchonete3
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            FormSplashScreen formSplash = new FormSplashScreen();
            formSplash.Show();
            Thread.Sleep(3000);
            formSplash.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String login = txtLogin.Text;
            String senha = txtSenha.Text;
            if (login == "teste" && senha == "teste")
            {
                FormPrincipal principal = new FormPrincipal();
                principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha incorretos! Tenten novamente.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtLogin.Focus();
            }
        }
    }
}
