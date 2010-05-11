using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using sUCO.control;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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

        public void delete(CenarioAlternativo cenario)
        {
            if (cenario.Codigo != null)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM cenario WHERE cd_cenario = {0} ");

                Object[] sqlParams = new Object[]{
                    cenario.Codigo
                };

                DBUtil.Instance.openConnection();
                DBUtil.Instance.executeDelete(String.Format(sql.ToString(), sqlParams));
                DBUtil.Instance.closeConnection();
            }
        }

        public IList<CenarioAlternativo> findByAcao(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            IList<CenarioAlternativo> cenarioList = null;
            CenarioAlternativo cenario = null;

            try
            {
                sql.Append(" SELECT cd_cenario , cd_acao , ");
                sql.Append(" nm_cenario , fl_alternativo FROM ");
                sql.Append(" cenario WHERE cd_acao = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                cenarioList = new List<CenarioAlternativo>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        cenario = new CenarioAlternativo();
                        cenario.Codigo = int.Parse(reader.GetString("cd_cenario"));
                        cenario.Nome = reader.GetString("nm_cenario");
                        cenarioList.Add(cenario);
                    }
                }

                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Erro ao executar query: " + e.Message);
                throw new Exception(e.Message, e);
            }
            finally
            {
                DBUtil.Instance.closeConnection();
            }

            return cenarioList;
        }
    }
}
