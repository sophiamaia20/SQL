using Dapper;
using ListaDB.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace ListaDB.DAL
{
    public class SalaDAO
    {
        SqlConnection _conexao;
        public SalaDAO()
        {
            _conexao = ConexaoBD.getConexao();
        }

        public List<Sala> getTodaAsSalas()
        {
            string query = "select * from Sala";

            var lista = (List<Sala>)_conexao.Query<Sala>(query);

            return lista;
        }
        public void insertSala(Sala psala)
        {
            string query = "insert sala (SALADESC) values(@SALADESC)";
            var qtdInserida = _conexao.Execute(query, psala);

        }
        public void updateSala(Sala psala)
        {
            string query = "update sala set SALADESC=@SALADESC where SALID=@SALID";

            int qtdAtualizada = _conexao.Execute(query, psala);

        }
        public void apgarSala(Sala psala)
        {
            string query = "Delete sala where SALAID=@SALAID";

            int qtdAtualizada = _conexao.Execute(query, psala);

        }
    }
}
