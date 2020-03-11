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
    public partial class CadastroFuncionarios : MetroFramework.Forms.MetroForm
    {
       
        
        public CadastroFuncionarios()
        {
            InitializeComponent();
        }

        bool validarCPF()
        {
            if (fncCPF.Text.Length == 14)
            {
                int n1 = Convert.ToInt32(fncCPF.Text.Substring(0, 1));
                int n2 = Convert.ToInt32(fncCPF.Text.Substring(1, 1));
                int n3 = Convert.ToInt32(fncCPF.Text.Substring(2, 1));
                int n4 = Convert.ToInt32(fncCPF.Text.Substring(4, 1));
                int n5 = Convert.ToInt32(fncCPF.Text.Substring(5, 1));
                int n6 = Convert.ToInt32(fncCPF.Text.Substring(6, 1));
                int n7 = Convert.ToInt32(fncCPF.Text.Substring(8, 1));
                int n8 = Convert.ToInt32(fncCPF.Text.Substring(9, 1));
                int n9 = Convert.ToInt32(fncCPF.Text.Substring(10, 1));

                int n10 = Convert.ToInt32(fncCPF.Text.Substring(12, 1));
                int n11 = Convert.ToInt32(fncCPF.Text.Substring(13, 1));

                if (n1 == n2 && n2 == n3 && n3 == n4 && n4 == n5 && n5 == n6 && n6 == n7 && n7 == n8 && n8 == n9)
                {
                    return false;
                }

                int Soma1 = n1 * 10 + n2 * 9 + n3 * 8 + n4 * 7 + n5 * 6 + n6 * 5 + n7 * 4 + n8 * 3 + n9 * 2;

                int digitoVerificador1 = Soma1 % 11;

                if (digitoVerificador1 < 2)
                {
                    digitoVerificador1 = 0;
                }
                else
                {
                    digitoVerificador1 = 11 - digitoVerificador1;
                }


                int Soma2 = n1 * 11 + n2 * 10 + n3 * 9 + n4 * 8 + n5 * 7 + n6 * 6 + n7 * 5 + n8 * 4 + n9 * 3 + digitoVerificador1 * 2;

                int digitoVerificador2 = Soma2 % 11;


                if (digitoVerificador2 < 2)
                {
                    digitoVerificador2 = 0;
                }
                else
                {
                    digitoVerificador2 = 11 - digitoVerificador2;
                }

                if (digitoVerificador1 == n10 && digitoVerificador2 == n11)
                {
                    return true;
                }
                else
                {
                    return false;
                }


            }
            else
            {
                return false;
            }
        } //Validação CPF 
        bool validaRG(string RG)
        {
            try
            {

                RG = fncRG.Text.Replace(".", "").Replace("-", "").Replace(",", "").Replace(" ", "").Trim();
                int n1 = int.Parse(RG.Substring(0, 1));
                int n2 = int.Parse(RG.Substring(1, 1));
                int n3 = int.Parse(RG.Substring(2, 1));
                int n4 = int.Parse(RG.Substring(3, 1));
                int n5 = int.Parse(RG.Substring(4, 1));
                int n6 = int.Parse(RG.Substring(5, 1));
                int n7 = int.Parse(RG.Substring(6, 1));
                int n8 = int.Parse(RG.Substring(7, 1));

                string DV = RG.Substring(8, 1);

                int Soma = n1 * 2 + n2 * 3 + n3 * 4 + n4 * 5 + n5 * 6 + n6 * 7 + n7 * 8 + n8 * 9;

                string digitoVerigicadoRG = Convert.ToString(Soma % 11);

                if (digitoVerigicadoRG == "1")
                {
                    digitoVerigicadoRG = "x";
                }
                else if (digitoVerigicadoRG == "0")
                {
                    digitoVerigicadoRG = "0";
                }
                else
                {
                    digitoVerigicadoRG = (11 - int.Parse(digitoVerigicadoRG)).ToString();
                }

                if (digitoVerigicadoRG == DV)
                {
                    return true;
                }

                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        } //Validação RG
        public void validaEmail()
        {
            string email = textBox1.Text;

            bool validarEmail = email.Contains("@") && email.Contains(".com");

            if(validarEmail == true)
            {
                fncEmailVali.Text = "";
            }
            else
            {
                fncEmailVali.ForeColor = Color.Red;
                fncEmailVali.Text = "Email invalido";
            }
        }
        private void fncCPF_Leave(object sender, EventArgs e)
        {
            if (validarCPF())
            {

                fncCPFvali.Text = "";
            }
            else
            {
                fncCPFvali.ForeColor = Color.Red;
                fncCPFvali.Text = "CPF invalido";
            }
        }
        private void fncRG_Leave(object sender, EventArgs e)
        {

            if (validaRG(fncRG.Text))
            {
                fncRGvali.Text = "";
            }
            else
            {
                fncRGvali.ForeColor = Color.Red;
                fncRGvali.Text = "RG invalido";
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void CadastroFuncionarios_Load(object sender, EventArgs e)
        {

        }
    }
}
