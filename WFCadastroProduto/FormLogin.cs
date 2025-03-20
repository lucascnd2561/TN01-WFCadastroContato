namespace WFCadastroProduto
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 001;
            us.Login = "admin";
            us.Senha = "123456";
            us.DataCadastro = Convert.ToDateTime("18/03/25 18:30");

            Usuario.ListaUsuarios.Add(us);


        }

        public void Erro(string mensagem)
        {
            MessageBox.Show(mensagem, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }

        private void btnAcessar_Click(object sender, EventArgs e)
        {
            {
                if (string.IsNullOrEmpty(txtLogin.Text))
                {
                    Erro("O Campo Login n�o pode estar vazio!");
                    return;
                }
                if (string.IsNullOrEmpty(txtSenha.Text))
                {
                    Erro("O Campo Senha n�o pode estar vazio!");
                    return;
                }

                foreach (Usuario u in Usuario.ListaUsuarios)
                {
                    if (u.Login == txtLogin.Text)
                    {
                        if (u.Senha == txtSenha.Text)
                        {
                            FormMenu form = new FormMenu();
                            form.ShowDialog();

                            this.txtLogin.Clear();
                            this.txtSenha.Clear();

                            return;
                        }
                    }

                }

                Erro("Usuario e Senha n�o se encontra na Base!");
                return;
            }
        }
    }
}
              