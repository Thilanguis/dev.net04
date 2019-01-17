using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01.Entities
{
    public class Setor
    {
        //É a mesma coisa declar os atributos e encapsular, só td implícito
        public int IdSetor { get; set; }
        //prop : atalho para declarar e encapsuar de uma vez só
        public string Nome { get; set; }

        //Relacionamento de Associação (TER-MUITOS)
        public List<Funcionario> Funcionario { get; set; }

        public Setor()
        {

        }

        public Setor(int idSetor, string nome)
        {
            IdSetor = idSetor;
            Nome = nome;
        }
    }
}
