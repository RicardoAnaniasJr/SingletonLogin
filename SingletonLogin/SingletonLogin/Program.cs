using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogin
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome = "Teste";
            string login = "Dess@teste";
            int cpf = 987;
            int senha = 654321;
            UserRepo user = new UserRepo();

            user.Insert(nome,cpf,login,senha);

        }
    }
}
