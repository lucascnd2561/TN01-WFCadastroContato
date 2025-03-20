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

            if (string.IsNullOrEmpty(mtbCodigo.Text))
                Erro("Campo vazio");
            if (cbxCategoria.SelectedIndex == -1)
                Erro("Campo vazio");
            if (string.IsNullOrEmpty(txtNomedoProduto.Text))
                Erro("Campo vazio");
            if (nudPreco.Value <= 0)
                Erro("Campo vazio");
            if (dtpDataVencimento.Value == DateTime.Today)
                Erro("Campo vazio");
            if (string.IsNullOrEmpty(txtObservacao.Text))
                Erro("Campo vazio");




        }



        private void FormCadastroProduto_Load(object sender, EventArgs e)
        {

        }
    }
}
