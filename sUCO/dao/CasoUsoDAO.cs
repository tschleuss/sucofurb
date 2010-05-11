using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using sUCO.control;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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

        public void delete(CasoUso casoUso)
        {
            if (casoUso.Codigo != 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM casouso WHERE cd_casoUso = {0} ");

                Object[] sqlParams = new Object[]{
                    casoUso.Codigo
                };

                DBUtil.Instance.openConnection();
                DBUtil.Instance.executeDelete(String.Format(sql.ToString(), sqlParams));
                DBUtil.Instance.closeConnection();
            }
        }

        public IList<CasoUso> findByProjeto(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            IList<CasoUso> casoUsoList = null;
            CasoUso casoUso = null;

            try
            {
                sql.Append(" SELECT cd_casoUso , nm_casoUso , ");
                sql.Append(" cd_projeto , ds_objetivo , ds_preCondicao , ");
                sql.Append(" ds_posCondicao FROM casouso WHERE cd_projeto = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                casoUsoList = new List<CasoUso>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        casoUso = new CasoUso();
                        casoUso.Codigo = int.Parse(reader.GetString("cd_casoUso"));
                        casoUso.Nome = reader.GetString("nm_casoUso");
                        casoUso.Objetivo = reader.GetString("ds_objetivo");
                        casoUso.PreCondicao = reader.GetString("ds_preCondicao");
                        casoUso.PosCondicao = reader.GetString("ds_posCondicao");
                        casoUsoList.Add(casoUso);
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

            return casoUsoList;
        }
    }
}
