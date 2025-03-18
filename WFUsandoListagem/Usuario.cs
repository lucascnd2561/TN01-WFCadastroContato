using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFUsandoListagem
{
    public class Usuario
    {
        public Usuario(string? login, int senha, int codigo, DateTime datacadastro)
        {
            Login = login;
            Senha = senha;
            Codigo = codigo;
            Datacadastro = datacadastro;
        }

        public Usuario() { }

        public static List<Usuario> ListaUsuarios =
            new List<Usuario>();

        public string? Login { get; set; }
        public int Senha { get; set; }
        public int Codigo { get; set; }
        public DateTime Datacadastro { get; set; }

    } 
    


}

             




 
