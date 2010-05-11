using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.core;
using MySql.Data.MySqlClient;
using sUCO.control;
using System.Windows.Forms;

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

        public void delete(Projeto projeto)
        {
            if (projeto.Codigo != 0)
            {
                StringBuilder sql = new StringBuilder();
                sql.Append(" DELETE FROM projeto WHERE cd_projeto = {0} ");

                Object[] sqlParams = new Object[]{
                    projeto.Codigo
                };

                DBUtil.Instance.openConnection();
                DBUtil.Instance.executeDelete(String.Format(sql.ToString(), sqlParams));
                DBUtil.Instance.closeConnection();
            }
        }

        public Projeto find(int codigo)
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            Projeto projeto = null;

            try
            {
                sql.Append(" SELECT cd_projeto , nm_projeto , ");
                sql.Append(" dt_criacao , dt_atualizacao , nm_responsavel FROM ");
                sql.Append(" projeto WHERE cd_projeto = {0} ");

                Object[] sqlParams = new Object[]{
                    codigo
                };

                command = new MySqlCommand(String.Format(sql.ToString(), sqlParams), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    projeto = new Projeto();
                    while (reader.Read())
                    {
                        projeto.Codigo = int.Parse(reader.GetString("cd_projeto"));
                        projeto.Nome = reader.GetString("nm_projeto");
                        projeto.DataCriacao = DateTime.Parse(reader.GetString("dt_criacao"));
                        projeto.DataAtualizacao = DateTime.Parse(reader.GetString("dt_atualizacao"));
                        projeto.Responsavel = reader.GetString("nm_responsavel");
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

            return projeto;
        }

        public IList<Projeto> findAll()
        {
            DBUtil.Instance.openConnection();
            MySqlCommand command = null;
            MySqlDataReader reader = null;
            StringBuilder sql = new StringBuilder();
            IList<Projeto> projetoList = null;
            Projeto projeto = null;

            try
            {
                sql.Append(" SELECT cd_projeto , nm_projeto , ");
                sql.Append(" dt_criacao , dt_atualizacao , ");
                sql.Append(" nm_responsavel FROM projeto ");

                command = new MySqlCommand(sql.ToString(), DBUtil.Instance.Connection);
                reader = command.ExecuteReader();

                projetoList = new List<Projeto>();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        projeto = new Projeto();
                        projeto.Codigo = int.Parse(reader.GetString("cd_projeto"));
                        projeto.Nome = reader.GetString("nm_projeto");
                        projeto.DataCriacao = DateTime.Parse(reader.GetString("dt_criacao"));
                        projeto.DataAtualizacao = DateTime.Parse(reader.GetString("dt_atualizacao"));
                        projeto.Responsavel = reader.GetString("nm_responsavel");
                        projetoList.Add(projeto);
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

            return projetoList;
        }
    }
}
