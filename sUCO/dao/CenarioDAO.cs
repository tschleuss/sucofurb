using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using sUCO.control;

namespace sUCO.dao
{
    class CenarioDAO
    {
        public void insert(CenarioAlternativo cenario, Acao acao)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO cenario ( nm_cenario , ");
            sql.Append(" cd_acao , fl_alternativo ) VALUES ");
            sql.Append(" ( '{0}' , {1} , {2} ) ");

            Object[] sqlParams = new Object[]{
                cenario.Nome,
                acao.Codigo,
                1
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            cenario.Codigo = DBUtil.Instance.lastInsertedID();
            DBUtil.Instance.closeConnection();

            RaiaDAO raiaDAO = new RaiaDAO();
            foreach (Raia raia in cenario.ListaRaias)
            {
                raiaDAO.insert(raia, cenario);
            }
        }
    }
}
