﻿using System;
using System.Collections.Generic;
using sUCO.forms.usercontrols;

namespace sUCO.core
{
    public class Projeto
    {
        public String Nome { get; set;}
        public DateTime DataCriacao{ get; set;}
        public DateTime DataAtualizacao { get; set; }
        public String Responsavel { get; set; }
        private IList<UserControlPanelCasoUso> listaPanelCasoUso;

        public Projeto()
        {
            this.listaPanelCasoUso = new List<UserControlPanelCasoUso>();
        }

        public void AddPanelCasoUso(UserControlPanelCasoUso panel)
        {
            this.listaPanelCasoUso.Add(panel);
        }

        public void RemovePanelCasoUso(UserControlPanelCasoUso panel)
        {
            this.listaPanelCasoUso.Remove(panel);
        }

        public int QtdCasoUso()
        {
            return this.listaPanelCasoUso.Count;
        }

    }
}
