﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto01.Entities
{
    class Funcionario
    {
        public int IdFuncionario { get; set; }
        public string Nome { get; set; }
        public decimal Salario { get; set; }
        public DateTime DataAdmissao { get; set; }

        //Relacionamento de Associação (ter-1)
        public Setor Setor { get; set; }

        public Funcionario()
        {

        }

        public Funcionario(int idFuncionario, string nome, decimal salario, DateTime dataAdmissao)
        {
            IdFuncionario = idFuncionario;
            Nome = nome;
            Salario = salario;
            DataAdmissao = dataAdmissao;
        }
    }

}
