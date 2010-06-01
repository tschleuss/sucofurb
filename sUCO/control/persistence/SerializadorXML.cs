using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using sUCO.core;
using System.Collections.Generic;
using sUCO.forms.usercontrols;
using sUCO.forms;
using System.Globalization;

namespace sUCO.control
{
    class SerializadorXML : Serializador
    {
        #region Serializador Members

        void Serializador.SalvarArquivo(Projeto projeto, IList<CasoUso> ucList)
        {
            if (File.Exists(projeto.NomeArquivo))
            {
                File.Delete(projeto.NomeArquivo);
            }

            SalvarXML(projeto, ucList);
        }

        IList<CasoUso> Serializador.AbrirArquivo(ref Projeto projeto)
        {
            if (File.Exists(projeto.NomeArquivo))
            {
                IList<CasoUso> ucList = new List<CasoUso>();
                XmlTextReader xmlIn = new XmlTextReader(projeto.NomeArquivo);
                xmlIn = LerXmlRaias(xmlIn, ucList, projeto, null, null);

                return ucList;
            }

            return null;
        }

        #endregion

        private static void SalvarXML(Projeto projeto, IList<CasoUso> ucList)
        {
            XmlTextWriter xmlOut = new XmlTextWriter(projeto.NomeArquivo, null);
            xmlOut.Formatting = Formatting.Indented;
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("casosDeUso");
            xmlOut.WriteAttributeString("nome", projeto.Nome);
            xmlOut.WriteAttributeString("criado", projeto.DataCriacao.ToString(projeto.DatePattern));
            xmlOut.WriteAttributeString("atualizado", projeto.DataAtualizacao.ToString(projeto.DatePattern));
            xmlOut.WriteAttributeString("responsavel", projeto.Responsavel);

            foreach (CasoUso diagrama in ucList)
            {
                //Gera o xml para as raias, acoes, cenarios.. de cada caso de uso
                xmlOut.WriteStartElement("casoDeUso");
                xmlOut.WriteAttributeString("nome", diagrama.Nome);
                xmlOut.WriteAttributeString("objetivo", diagrama.Objetivo);
                xmlOut.WriteAttributeString("preCondicao", diagrama.PreCondicao);
                xmlOut.WriteAttributeString("posCondicao", diagrama.PosCondicao);
                xmlOut = GeraXmlComponente(xmlOut, diagrama.ComponentText);
                xmlOut = GeraXmlRaias(xmlOut, diagrama.FluxoCasoUso.ListaRaias);
                xmlOut.WriteEndElement();

                xmlOut.WriteStartElement("casoDeUso-end");
                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();
            xmlOut.Flush();
            xmlOut.Close();
        }

        private static XmlTextWriter GeraXmlComponente(XmlTextWriter xmlOut, String components)
        {
            xmlOut.WriteStartElement("componentes");
            xmlOut.WriteCData(components);
            xmlOut.WriteEndElement();
            return xmlOut;
        }

        private static XmlTextWriter GeraXmlRaias(XmlTextWriter xmlOut, IList<Raia> listaRaias)
        {
            xmlOut.WriteStartElement("raias");
            foreach (Raia raia in listaRaias)
            {
                xmlOut.WriteStartElement("raia");
                xmlOut.WriteAttributeString("nome", raia.Nome);
                xmlOut.WriteAttributeString("tamanho", Convert.ToString(raia.Width));

                if (raia.ListaAcoes != null && raia.ListaAcoes.Count > 0)
                {
                    xmlOut.WriteStartElement("acoes");
                    foreach (Acao acao in raia.ListaAcoes)
                    {
                        xmlOut.WriteStartElement("acao");
                        xmlOut.WriteAttributeString("valor", acao.Texto);

                        if (acao.Cenarios != null && acao.Cenarios.Count > 0)
                        {
                            xmlOut.WriteStartElement("cenarios");
                            foreach (CenarioAlternativo cenario in acao.Cenarios)
                            {
                                xmlOut.WriteStartElement("cenario");
                                xmlOut.WriteAttributeString("nome", cenario.Nome);

                                //Recursivamente gera o xml para as raias e acoes dos cenarios alternativos.
                                GeraXmlRaias(xmlOut, cenario.ListaRaias);
                                xmlOut.WriteEndElement();

                                xmlOut.WriteStartElement("cenario-end");
                                xmlOut.WriteEndElement();
                            }
                            xmlOut.WriteEndElement();
                        }
                        xmlOut.WriteEndElement();
                    }
                    xmlOut.WriteEndElement();
                }
                xmlOut.WriteEndElement();
            }
            xmlOut.WriteEndElement();
            return xmlOut;
        }

        private static XmlTextReader LerXmlRaias(XmlTextReader xmlIn, IList<CasoUso> usList, Projeto projeto, CasoUso casoDeUso, IList<Raia> raias)
        {
            IList<Acao> acoes = null;
            CenarioAlternativo cenario = null;
            Raia raia = null;
            Acao acao = null;

            while (xmlIn.Read())
            {
                xmlIn.MoveToElement();

                if (xmlIn.IsStartElement())
                {
                    if (xmlIn.Name.Equals("casosDeUso"))
                    {
                        projeto.Nome = xmlIn.GetAttribute("nome");
                        projeto.Responsavel = xmlIn.GetAttribute("responsavel");
                        projeto.DataCriacao = DateTime.ParseExact(xmlIn.GetAttribute("criado"), projeto.DatePattern, null);
                        projeto.DataAtualizacao = DateTime.ParseExact(xmlIn.GetAttribute("atualizado"), projeto.DatePattern, null);
                    }

                    if (xmlIn.Name.Equals("casoDeUso"))
                    {
                        casoDeUso = new CasoUso(new FluxoCasoUso());
                        raias = casoDeUso.FluxoCasoUso.ListaRaias;
                        casoDeUso.Nome = xmlIn.GetAttribute("nome");
                        casoDeUso.Objetivo = xmlIn.GetAttribute("objetivo");
                        casoDeUso.PreCondicao = xmlIn.GetAttribute("preCondicao");
                        casoDeUso.PosCondicao = xmlIn.GetAttribute("posCondicao");
                    }

                    if (xmlIn.Name.Equals("componentes"))
                    {
                        String componente = xmlIn.ReadElementContentAsString();
                        casoDeUso.ComponentText = componente;
                    }

                    if (xmlIn.Name.Equals("raia"))
                    {
                        acoes = new List<Acao>();
                        String nomeAtor = xmlIn.GetAttribute("nome");
                        int tamanho = int.Parse(xmlIn.GetAttribute("tamanho"));
                        raia = new Raia(nomeAtor, tamanho, acoes);
                        raias.Add(raia);
                    }

                    if (xmlIn.Name.Equals("acao"))
                    {
                        String valorAcao = xmlIn.GetAttribute("valor");
                        acao = new Acao(valorAcao, new List<CenarioAlternativo>());
                        raias[raias.Count - 1].ListaAcoes.Add(acao);
                    }

                    if (xmlIn.Name.Equals("cenario"))
                    {
                        String nomeCenario = xmlIn.GetAttribute("nome");
                        cenario = new CenarioAlternativo(nomeCenario);

                        acoes = raias[raias.Count - 1].ListaAcoes;
                        acoes[acoes.Count - 1].Cenarios.Add(cenario);

                        //Recursivamente recupera as raias e acoes dos cenarios alternativos.
                        xmlIn = LerXmlRaias(xmlIn, usList, projeto, casoDeUso, cenario.ListaRaias);
                    }

                    if (xmlIn.Name.Equals("cenario-end"))
                    {
                        //Se for final dos cenarios, pula ele e termina a recursao
                        xmlIn.Skip();
                        return xmlIn;
                    }

                    if (xmlIn.Name.Equals("casoDeUso-end"))
                    {
                        //Se for final do casoDeUso, adiciona na lista
                        usList.Add(casoDeUso);
                    }
                }
            }
            return xmlIn;
        }
    }
}
