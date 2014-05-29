﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

using SistemaMundoAnimal.Source.Dados;
using SistemaMundoAnimal.Source.Entidades;

namespace SistemaMundoAnimal.Source.Pesquisa.Entidade {
    public static class PesquisaFuncionario {

        private static string SelectFuncionarioPorIdSqlQuery = @"SELECT *"
            + " FROM View_Funcionarios WHERE [Código da Pessoa] = {0}";

        public static Funcionario PorId(int id) {
            var funcionario = new Funcionario();
            var consulta = string.Format(SelectFuncionarioPorIdSqlQuery, id);

            BancoDeDados.NovaConsultaSql(consulta, (SqlDataReader reader) => {
                funcionario.SetId(Convert.ToInt32(reader["Código da Pessoa"]));
                funcionario.SetNome(reader["Nome"].ToString());
                funcionario.SetSobrenome(reader["Sobrenome"].ToString());
                funcionario.SetGenero((char) reader["Genero"]);
                funcionario.SetTipoPessoa('F');
                funcionario.SetRG(reader["RG"].ToString());
                funcionario.SetCPF(reader["CPF"].ToString());
                funcionario.SetSalario(Convert.ToDouble(reader["Salario"]));
                funcionario.SetAssitenciaMedica(Convert.ToDouble(reader["Assitencia Medica"]));
                funcionario.SetAuxilioCreche(Convert.ToDouble(reader["Auxilio Creche"]));
                funcionario.SetValeAlimentacao(Convert.ToDouble(reader["Vale Alimentção"]));
                funcionario.SetValeTransporte(Convert.ToDouble(reader["Vale Transporte"]));
                funcionario.SetDiaPagamento(Convert.ToInt32(reader["Dia de Pagamento"]));
                funcionario.SetCargo((TipoCargo) Convert.ToInt32(reader["Codigo do Cargo"]));
            });

            return funcionario;
        }

    }
}