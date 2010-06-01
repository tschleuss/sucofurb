using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using MySql.Data.MySqlClient;
using sUCO.control;
using System.Windows.Forms;

namespace sUCO.dao.componentes
{
    class ComponenteDiagramaDAO
    {
        public void insert(String content, CasoUso casoUso)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append(" INSERT INTO componentediagrama ( cd_casoUso , ds_content ) ");
            sql.Append(" VALUES ( '{0}' , '{1}' ) ");

            Object[] sqlParams = new Object[]{
                casoUso.Codigo,
                content
            };

            DBUtil.Instance.openConnection();
            DBUtil.Instance.executeInsert(String.Format(sql.ToString(), sqlParams));
            DBUtil.Instance.closeConnection();
        }

        public void delete(CasoUso casoUso)
        {
            if (casoUso.Codigo != 0 )
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM componentediagrama WHERE cd_casoUso = {0} ");

                Object[] sqlParams = new Object[]{
                    casoUso.Codigo
                };

                DBUtil.Instance.openConnection();
                DBUtil.Instance.executeDelete(String.Format(sql.ToString(), sqlParams));
                DBUtil.Instance.closeConnection();
            }
        }

        public String findByCasoUso(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            String content = "";

            try
            {
                sql.Append(" SELECT ds_content FROM componentediagrama WHERE cd_casoUso = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                if( reader.Read() )
                {
                    content = reader.GetString("ds_content");
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

            return content;
        }
    }
}
