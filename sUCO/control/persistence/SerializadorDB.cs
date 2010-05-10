using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using sUCO.dao;
using sUCO.core;

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
            throw new NotImplementedException();
        }

        #endregion
    }
}
