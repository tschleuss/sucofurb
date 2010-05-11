using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.dao;
using sUCO.core;
using sUCO.forms;

namespace sUCO.control
{
    class SerializadorDB : Serializador
    {
        #region Serializador Members

        public void salvarArquivo(Projeto projeto, IList<CasoUso> ucList)
        {
            ProjetoDAO projDAO = new ProjetoDAO();
            CasoUsoDAO casoDAO = new CasoUsoDAO();

            projDAO.insert(projeto);

            foreach (CasoUso casoUso in ucList)
            {
                casoDAO.insert(casoUso, projeto);
            }
        }

        public IList<CasoUso> abrirArquivo(Projeto projeto)
        {
            ProjetoDAO projDAO = new ProjetoDAO();
            CasoUsoDAO casoDAO = new CasoUsoDAO();
            RaiaDAO raiaDAO = new RaiaDAO();
            AcaoDAO acaoDAO = new AcaoDAO();
            CenarioDAO cenarioDAO = new CenarioDAO();

            IList<CasoUso> casoUsoList = null;

            DBUtil.Instance.testConnection();


            if (DBUtil.Instance.Configured)
            {
                IList<Projeto> projetoList = projDAO.findAll();
                FrmProjetosSelect frm = new FrmProjetosSelect();

                foreach (Projeto proj in projetoList)
                {
                    frm.add(proj.Nome, proj.Codigo);
                }

                frm.ShowDialog();

                if (frm.SelectedProject != -1)
                {
                    Projeto proj = projDAO.find(frm.SelectedProject);
                    casoUsoList = casoDAO.findByProjeto(proj.Codigo);

                    foreach (CasoUso caso in casoUsoList)
                    {
                        IList<Raia> casoUsoRaias = raiaDAO.findByCasoUso(caso.Codigo);

                        foreach (Raia raia in casoUsoRaias)
                        {
                            IList<Acao> raiaAcoes = acaoDAO.findByRaia(raia.Codigo);

                            foreach (Acao acao in raiaAcoes)
                            {
                                IList<CenarioAlternativo> acaoCenario = cenarioDAO.findByAcao(acao.Codigo);

                                foreach (CenarioAlternativo cenario in acaoCenario)
                                {
                                    IList<Raia> cenarioRaias = raiaDAO.findByCenario(cenario.Codigo);

                                    foreach (Raia cenarioRaia in cenarioRaias)
                                    {
                                        IList<Acao> cenarioRaiaAcoes = acaoDAO.findByRaia(cenarioRaia.Codigo);
                                        cenarioRaia.ListaAcoes = cenarioRaiaAcoes;
                                    }
                                    cenario.ListaRaias = cenarioRaias;
                                }

                                acao.Cenarios = acaoCenario;
                            }

                            raia.ListaAcoes = raiaAcoes;
                        }

                        caso.FluxoCasoUso = new FluxoCasoUso();
                        caso.FluxoCasoUso.ListaRaias = casoUsoRaias;
                    }
                }
            }

            return casoUsoList;
        }

        #endregion
    }
}
