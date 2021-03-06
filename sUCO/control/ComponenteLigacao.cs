﻿using System;
using sUCO.diagram;
using sUCO.core;

namespace sUCO
{
    public class ComponenteLigacao
    {
        private String source;
        private String target;
        private String type;
        private TipoRelacionamento relacionamento;

        public ComponenteLigacao()
        {
        }

        public String Source
        {
            get { return this.source; }
            set { this.source = value; }
        }

        public String Target
        {
            get { return this.target; }
            set { this.target = value; }
        }

        public String Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        public TipoRelacionamento Relacionamento
        {
            get { return this.relacionamento; }
            set { this.relacionamento = value; }
        }
    }
}
