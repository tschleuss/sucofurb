using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using sUCO.control;

namespace sUCO.dao
{
    class CasoUsoDAO
    {
        public void insert(CasoUso casoUso, Projeto projeto)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO casouso ( nm_casoUso , cd_projeto , ");
            sql.Append(" ds_objetivo , ds_preCondicao , ds_posCondicao ) VALUES ");
            sql.Append(" ( '{0}' , {1} , '{2}' , '{3}' , '{4}' ) ");

            Object[] sqlParams = new Object[]{
                casoUso.Nome,
                projeto.Codigo,
                casoUso.Objetivo,
                casoUso.PreCondicao,
                casoUso.PosCondicao
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            casoUso.Codigo = DBUtil.Instance.lastInsertedID();
            DBUtil.Instance.closeConnection();

            RaiaDAO raiaDAO = new RaiaDAO();
            foreach (Raia raia in casoUso.FluxoCasoUso.ListaRaias)
            {
                raiaDAO.insert(raia, casoUso);
            }
        }
    }
}
