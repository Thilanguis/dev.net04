using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Projeto01.Entities;

namespace Projeto1.Repositories
{
    public class FuncionarioRepository : Conexao
    {
        public void Inserir(Funcionario funcionario)
        {
            string query = "insert into Funcionario(Nome, Salario, DataAdmissao, IdSetor)"
                 + " values(@Nome, @Salario, @DataAdmissao, @IdSetor)";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            Command.Parameters.AddWithValue("@Salario", funcionario.Salario);
            Command.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
            Command.Parameters.AddWithValue("@IdSetor", funcionario.Setor.IdSetor);
            Command.ExecuteNonQuery();
        }

        public void Atualizar(Funcionario funcionario)
        {
            string query = "update Funcionario set Nome = @Nome " +
                "Salario = @Salario, DataAdmissao = @DataAdmissao, " +
                "IdSetor = @IdSetor where IdFuncionario = @IdFuncionario";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@Nome", funcionario.Nome);
            Command.Parameters.AddWithValue("@Salario", funcionario.Salario);
            Command.Parameters.AddWithValue("@DataAdmissao", funcionario.DataAdmissao);
            Command.Parameters.AddWithValue("@IdSetor", funcionario.Setor.IdSetor);
            Command.Parameters.AddWithValue("@IdFuncionario", funcionario.IdFuncionario);
            Command.ExecuteNonQuery();
        }

        public void Excluir(int idFuncionario)
        {
            string query = "delete from Funcionario where IdFuncionario = @IdFuncionario";

            Command = new SqlCommand(query, Connection);
            Command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
            Command.ExecuteNonQuery();
        }

        public List<Setor> Consultar()
        {
            string query = "select * from Setor";

            Command = new SqlCommand(query, Connection);
            DataReader = Command.ExecuteReader();

            List<Setor> lista = new List<Setor>();

            while (DataReader.Read())
            {
                Setor setor = new Setor();

                setor.IdSetor = Convert.ToInt32(DataReader["IdSetor"]);
                setor.Nome = Convert.ToString(DataReader["Nome"]);
                lista.Add(setor);

            }
            return lista;
         }
    }
}
