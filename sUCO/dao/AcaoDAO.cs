using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.control;
using sUCO.core;
using MySql.Data.MySqlClient;

namespace sUCO.dao
{
    class AcaoDAO
    {
        public void insert(Acao acao, Raia raia)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO acao ( ds_acao ");
            sql.Append(" , cd_raia ) VALUES ( '{0}' , {1} ) ");

            Object[] sqlParams = new Object[]{
                acao.Texto,
                raia.Codigo
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            acao.Codigo = DBUtil.Instance.lastInsertedID();
            DBUtil.Instance.closeConnection();

            CenarioDAO cenarioDAO = new CenarioDAO();
            foreach (CenarioAlternativo cenario in acao.Cenarios)
            {
                cenarioDAO.insert(cenario, acao);
            }
        }
    }
}
