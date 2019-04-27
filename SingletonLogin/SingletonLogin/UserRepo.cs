using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using MySql.Data;


namespace SingletonLogin
{
    class UserRepo : IDAOUsuario
    {

        string constring = "server=localhost;uid=teste;" + "pwd=;database=Login";

        public List<Usuario> GetAll()
        {
            throw new NotImplementedException();
        }

        public Usuario Getusuario(string login, int senha)
        {
            throw new NotImplementedException();
        }

        public void Insert(string nome, int cpf, string login, int senha)
        {
            string sql = "insert into Usuarios Values ('"+nome+"',"+cpf+",'"+login+"',"+senha+");";
            
            SqlConnection conn = new SqlConnection(constring);
            SqlCommand cmd = new SqlCommand(sql,conn);
            conn.Open();

            try
            {
                int i = cmd.ExecuteNonQuery();
                if (i > 0)
                {
                    Console.WriteLine("Cadastro Bem Sucedido");
                }
                
            }
            catch(Exception er)
            {
                Console.WriteLine(er.ToString());
            }
            finally
            {
                conn.Close();
            }

        }

        public void Update()
        {
            throw new NotImplementedException();
        }
        
    }
}
