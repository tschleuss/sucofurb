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

        public void delete(Raia raia)
        {
            if (raia.Codigo != 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM raia WHERE cd_raia = {0} ");

                Object[] sqlParams = new Object[]{
                    raia.Codigo
                };

                DBUtil.Instance.openConnection();
                DBUtil.Instance.executeDelete(String.Format(sql.ToString(), sqlParams));
                DBUtil.Instance.closeConnection();
            }
        }

        public IList<Raia> findByCasoUso(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            IList<Raia> raiaList = null;
            Raia raia = null;

            try
            {
                sql.Append(" SELECT cd_raia , cd_casoUso , ");
                sql.Append(" cd_cenario , nm_raia , nr_tamanho FROM ");
                sql.Append(" raia WHERE cd_casoUso = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                raiaList = new List<Raia>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        raia = new Raia();
                        raia.Codigo = int.Parse(reader.GetString("cd_raia"));
                        raia.Nome = reader.GetString("nm_raia");
                        raia.Width = int.Parse(reader.GetString("nr_tamanho"));
                        raiaList.Add(raia);
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

            return raiaList;
        }

        public IList<Raia> findByCenario(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            IList<Raia> raiaList = null;
            Raia raia = null;

            try
            {
                sql.Append(" SELECT cd_raia , cd_casoUso , ");
                sql.Append(" cd_cenario , nm_raia , nr_tamanho FROM ");
                sql.Append(" raia WHERE cd_cenario = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                raiaList = new List<Raia>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        raia = new Raia();
                        raia.Codigo = int.Parse(reader.GetString("cd_raia"));
                        raia.Nome = reader.GetString("nm_raia");
                        raia.Width = int.Parse(reader.GetString("nr_tamanho"));
                        raiaList.Add(raia);
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

            return raiaList;
        }
    }
}
