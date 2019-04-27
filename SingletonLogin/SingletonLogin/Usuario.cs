using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogin
{
    class Usuario
    {
        private string _nome;
        private int _cpf;
        private string _login;
        private int _senha;

        public static Usuario _instance;
        
        public Usuario Criar()
        {
            if(_instance == null)
            {
                _instance = new Usuario();
            }
            return _instance;
        }



        private Usuario() { }

        public string nome
        {
            get { return _nome; }
            set { _nome = value; }
        }

        public int cpf
        {
            get { return _cpf; }
            set { _cpf = value; }
        }

        public string login
        {
            get { return _login; }
            set { _login = value; }
        }

        public int senha
        {
            get { return _senha; }
            set { _senha = value; }
        }

        








    }
}
