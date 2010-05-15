
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using sUCO.core;
using System.Collections.Generic;
using sUCO.forms.usercontrols;
using sUCO.forms;

namespace sUCO.control
{
    interface Serializador
    {
        void SalvarArquivo(Projeto projeto, IList<CasoUso> ucList);
        IList<CasoUso> AbrirArquivo(ref Projeto projeto);
    }
}
