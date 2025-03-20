using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFCadastroProduto
{
    public partial class FormCadastroProduto : Form
    {
        public FormCadastroProduto()
        {
            InitializeComponent();
        }
     
        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(cbxCategoria.Text))
            {
                Erro("Campo Categoria não pode estar Vazia!");
                return;
            }
            ////Verifica 
                 if (string.IsNullOrEmpty(txtNomedoProduto.Text))
            {
                Erro("Campo Nome do produto não pode estar Vazia!");
                return;
            }

            ////Verifica 
            else if (string.IsNullOrEmpty(dtpDataVencimento.Text))
            {
                Erro("Campo Data de vencimento do produto não pode estar Vazia!");
                return;
            }
            
        }



        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
