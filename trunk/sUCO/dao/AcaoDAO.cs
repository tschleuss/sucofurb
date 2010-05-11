using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.control;
using sUCO.core;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

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
            if (acao.Cenarios != null)
            {
                foreach (CenarioAlternativo cenario in acao.Cenarios)
                {
                    cenarioDAO.insert(cenario, acao);
                }
            }
        }

        public void delete(Acao acao)
        {
            if (acao.Codigo != 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM acao WHERE cd_acao = {0} ");

                Object[] sqlParams = new Object[]{
                    acao.Codigo
                };

                DBUtil.Instance.openConnection();
                DBUtil.Instance.executeDelete(String.Format(sql.ToString(), sqlParams));
                DBUtil.Instance.closeConnection();
            }
        }

        public IList<Acao> findByRaia(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            IList<Acao> acaoList = null;
            Acao acao = null;

            try
            {
                sql.Append(" SELECT cd_acao , ds_acao , cd_raia ");
                sql.Append(" FROM acao WHERE cd_raia = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                acaoList = new List<Acao>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        acao = new Acao();
                        acao.Codigo = int.Parse(reader.GetString("cd_acao"));
                        acao.Texto = reader.GetString("ds_acao");
                        acaoList.Add(acao);
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

            return acaoList;
        }
    }
}
