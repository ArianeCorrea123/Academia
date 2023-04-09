using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnAcesso_Click(object sender, EventArgs e)
        {
            String User = "Admin";
            String Password = "Admin";

            if (txtUsuario.Text == User & txtSenha.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                ACADEMIA FormMain = new ACADEMIA();
                FormMain.Show();
                this.Hide();

            }else
            {
                MessageBox.Show("Usuário/Senha Incorretos!");
            }
        }
    }
}
