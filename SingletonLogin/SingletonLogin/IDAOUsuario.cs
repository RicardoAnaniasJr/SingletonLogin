using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonLogin
{
    interface IDAOUsuario
    {
        List<Usuario> GetAll();
        Usuario Getusuario(string login, int senha);
        void Update();




    }
}
