using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroCliente
{
    class Cadastro
    {
        //Construtores:
        public int id { get; set; }
        public string nome { get; set; }
        public string cidade { get; set; }
        public string endereco { get; set; }
        public string celular { get; set; }
        public string email { get; set; }
        public string nascimento { get; set; }

        //Objeto de conexão com o BD;
        SqlConnection conexaoBD = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\CadastroCliente\SistemaBD.mdf;Integrated Security=True");

        //Método que chama a lista (precisa de Return);
        public List<Cadastro> listaClientes()
        {
            //Objeto lista que traz as informações do BD;
            List<Cadastro> lista = new List<Cadastro>();
            string sql = "SELECT * FROM Clientes";
            conexaoBD.Open();

            //Método que pega a query(SELECT * FROM Clientes) e faz a CONEXÃO com o banco de dados;
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);

            //Método que gera um Array com as informações do banco;
            SqlDataReader leitor = comandoBD.ExecuteReader();
            while (leitor.Read())
            {
                //Objeto que traz as informações do Arrey para serem adicionadas na lista 'li';
                Cadastro cliente = new Cadastro();
                cliente.id = (int)leitor["id"];
                cliente.nome = leitor["nome"].ToString();
                cliente.cidade = leitor["cidade"].ToString();
                cliente.endereco = leitor["endereco"].ToString();
                cliente.celular = leitor["celular"].ToString();
                cliente.email = leitor["email"].ToString();
                cliente.nascimento = leitor["nascimento"].ToString();
                lista.Add(cliente);
            }
            leitor.Close();
            conexaoBD.Close();
            return lista;
        }

        //Método para INSERIR registro no banco de dados;
        public void Inserir(string nome, string cidade, string endereco, string celular, string email, string nascimento)
        {
            string sql = "INSERT INTO Clientes(nome, cidade, endereco, celular, email, nascimento) VALUES('"+nome+"', '"+cidade+"', '"+endereco+"', '"+celular+"', '"+email+"', '"+nascimento+"')";
            conexaoBD.Open();
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);
            comandoBD.ExecuteNonQuery();
            conexaoBD.Close();
        }

        //Método para ATUALIZAR registro do banco de dados;
        public void Atualizar(int id, string nome, string cidade, string endereco, string celular, string email, string nascimento)
        {
            string sql = "UPDATE Clientes SET nome='"+nome+"', cidade='"+cidade+"', endereco='"+endereco+"', celular='"+celular+"', email='"+email+"', nascimento='"+nascimento+"' WHERE id='"+id+"'";
            conexaoBD.Open();
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);
            comandoBD.ExecuteNonQuery();
            conexaoBD.Close();
        }

        //Método para EXCLUIR registro do banco de dados;
        public void Excluir(int id)
        {
            string sql = "DELETE FROM Clientes WHERE Id='"+id+"'";
            conexaoBD.Open();
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);
            comandoBD.ExecuteNonQuery();
            conexaoBD.Close();
        }

        //Método para CONSULTAR registro do banco de dados;
        public void Localizar(int id)
        {
            string sql = "SELECT * FROM Clientes WHERE id='"+id+"'";
            conexaoBD.Open();
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);
            SqlDataReader leitor = comandoBD.ExecuteReader();
            while (leitor.Read())
            {
                nome = leitor["nome"].ToString();
                cidade = leitor["cidade"].ToString();
                endereco = leitor["endereco"].ToString();
                celular = leitor["celular"].ToString();
                email = leitor["email"].ToString();
                nascimento = leitor["nascimento"].ToString();
            }
            leitor.Close();
            conexaoBD.Close();
        }

        //Método para VERIFICAR se o registro do cliente já existe;
        public bool VerificarCadastro(string nome, string email)
        {
            string sql = "SELECT * FROM Clientes WHERE nome=@nome AND email=@email";
            conexaoBD.Open();
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);
            comandoBD.Parameters.AddWithValue("@nome", nome);
            comandoBD.Parameters.AddWithValue("@email", email);
            var resultado = comandoBD.ExecuteScalar();
            conexaoBD.Close();
            if (resultado != null)
            {
                return (int)resultado > 0;
            }
            else
            {
                return false;
            }
        }

        //Método para VERIFICAR se o ID existe no banco de dados;
        public bool VerificarID(int id)
        {
            string sql = "SELECT * FROM Clientes WHERE id=@id";
            conexaoBD.Open();
            SqlCommand comandoBD = new SqlCommand(sql, conexaoBD);
            comandoBD.Parameters.AddWithValue("@id", id);
            var resultado = comandoBD.ExecuteScalar();
            conexaoBD.Close();
            if (resultado != null)
            {
                return (int)resultado > 0;
            }
            else
            {
                return false;
            }
        }
    }
}
