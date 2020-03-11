using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaHoteleiro
{
    public partial class Login : MetroFramework.Forms.MetroForm
    {

        string uName = "Gustavo";
        string uSenha = "1234";

        public Login()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            //Compara se o email e a senha correspondem ao valor salvo nas variáveis no início da classe.
            if (txtFuncionario.Text.Equals(uName) && txtSenha.Text.Equals(uSenha))
            {
                //Cria um objeto da classe que apresenta o form principal.
                Hotel formPrinc = new Hotel();
                //Esconde a tela atual, ou seja, ela continua ativa na pilha de execução.
                this.Hide();
                //Abre a janela principal.
                formPrinc.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciais de acesso inválidas!!!");
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
