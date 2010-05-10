using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using sUCO.control;

namespace sUCO.dao
{
    class RaiaDAO
    {
        public void insert(Raia raia, CasoUso casoUso)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO raia ( cd_casoUso , ");
            sql.Append(" nm_raia , nr_tamanho ) VALUES ");
            sql.Append(" ( {0} , '{1}' , {2} ) ");

            Object[] sqlParams = new Object[]{
                casoUso.Codigo,
                raia.Nome,
                raia.Width
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            raia.Codigo = DBUtil.Instance.lastInsertedID();
            DBUtil.Instance.closeConnection();

            AcaoDAO acaoDAO = new AcaoDAO();
            foreach (Acao acao in raia.ListaAcoes)
            {
                acaoDAO.insert(acao, raia);
            }
        }

        public void insert(Raia raia, CenarioAlternativo cenario)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO raia ( cd_cenario , ");
            sql.Append(" nm_raia , nr_tamanho ) VALUES ");
            sql.Append(" ( {0} , '{1}' , {2} ) ");

            Object[] sqlParams = new Object[]{
                cenario.Codigo,
                raia.Nome,
                raia.Width
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            raia.Codigo = DBUtil.Instance.lastInsertedID();
            DBUtil.Instance.closeConnection();

            AcaoDAO acaoDAO = new AcaoDAO();
            foreach (Acao acao in raia.ListaAcoes)
            {
                acaoDAO.insert(acao, raia);
            }
        }
    }
}
