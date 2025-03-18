namespace WFUsandoListagem
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = 1;
            us.Login = "user";
            us.Senha = "123456";
            us.Datacadastro
        }
    }
}
