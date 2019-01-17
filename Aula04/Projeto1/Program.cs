using Projeto01.Entities;
using Projeto1.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CADASTRO DE SETOR:");

            Setor setor = new Setor();

            Console.WriteLine("Informe o nome do Setor....:");
            setor.Nome = Console.ReadLine();
            try
            {
                SetorRepository sr = new SetorRepository();

                sr.AbrirConexao();
                sr.Inserir(setor);
                sr.FecharConexao();

                Console.WriteLine("Setor cadastrado com sucesso");
            }

            catch (Exception e)
            {
                Console.WriteLine("Erro:" + e.Message);

            }

            Console.ReadKey();
        }
    }
}
