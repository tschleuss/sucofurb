using System;
using System.Collections.Generic;
using sUCO.forms.usercontrols;

namespace sUCO.core
{
    public class Projeto
    {
        public int      Codigo { get; set; }
        public String   Nome { get; set;}
        public DateTime DataCriacao{ get; set;}
        public DateTime DataAtualizacao { get; set; }
        public String   Responsavel { get; set; }
        public String   NomeArquivo { get; set; }
        public String   DatePattern { get; set; }
        public IList<UserControlPanelCasoUso> ListaPanelCasoUso;

        public Projeto()
        {
            this.ListaPanelCasoUso = new List<UserControlPanelCasoUso>();
            this.DataCriacao = System.DateTime.Now;
            this.DataAtualizacao = System.DateTime.Now;
            this.DatePattern = @"dd\/MM\/yyyy HH:mm:ss";
        }

        public void AddPanelCasoUso(UserControlPanelCasoUso panel)
        {
            this.ListaPanelCasoUso.Add(panel);
        }

        public void RemovePanelCasoUso(UserControlPanelCasoUso panel)
        {
            this.ListaPanelCasoUso.Remove(panel);
        }

        public void LimparPanelCasoUso()
        {
            this.ListaPanelCasoUso.Clear();
        }

        public int QtdCasoUso()
        {
            return this.ListaPanelCasoUso.Count;
        }

        public void RessetarInfo()
        {
            this.DataCriacao = System.DateTime.Now;
            this.DataAtualizacao = System.DateTime.Now;
            this.ListaPanelCasoUso.Clear();
            this.Nome = String.Empty;
            this.Responsavel = String.Empty;
            this.NomeArquivo = String.Empty;
            this.Codigo = 0;
        }

    }
}
