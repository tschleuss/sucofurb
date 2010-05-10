using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using MySql.Data.MySqlClient;
using sUCO.control;

namespace sUCO.dao
{
    class ProjetoDAO
    {
        public void insert(Projeto projeto)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO projeto ( nm_projeto , ");
            sql.Append(" dt_criacao , dt_atualizacao , nm_responsavel ) ");
            sql.Append(" VALUES ( '{0}' , '{1}' , '{2}' , '{3}' ) ");

            Object[] sqlParams = new Object[]{
                projeto.Nome,
                projeto.DataCriacao.ToUniversalTime().ToString(),
                projeto.DataAtualizacao.ToUniversalTime().ToString(),
                projeto.Responsavel
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            projeto.Codigo = DBUtil.Instance.lastInsertedID();
            DBUtil.Instance.closeConnection();
        }
    }
}
