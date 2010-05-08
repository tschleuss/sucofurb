
using System;
using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
using System.Xml;
using sUCO.core;
using System.Collections.Generic;

namespace sUCO.control
{
    class Serializador
    {
        public static void salvarArquivo(Projeto projeto, IList<CasoUso> ucList)
        {
            if (File.Exists(projeto.NomeArquivo))
            {
                File.Delete(projeto.NomeArquivo);
            }

            salvarXML(projeto,ucList);
        }

        private static void salvarXML(Projeto projeto, IList<CasoUso> ucList)
        {
            XmlTextWriter xmlOut = new XmlTextWriter(projeto.NomeArquivo, null);
            xmlOut.Formatting = Formatting.Indented;
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("casosDeUso");
            xmlOut.WriteAttributeString("projeto",      projeto.Nome);
            xmlOut.WriteAttributeString("criado",       projeto.DataCriacao.ToString());
            xmlOut.WriteAttributeString("atualizado",   projeto.DataAtualizacao.ToString());
            xmlOut.WriteAttributeString("autor",        projeto.Responsavel);

            foreach (CasoUso diagrama in ucList)
            {
                //Gera o xml para as raias, acoes, cenarios.. de cada caso de uso
                xmlOut.WriteStartElement("casoDeUso");
                xmlOut.WriteAttributeString("nome",         diagrama.Nome);
                xmlOut.WriteAttributeString("objetivo",     diagrama.Objetivo);
                xmlOut.WriteAttributeString("preCondicao",  diagrama.PreCondicao);
                xmlOut.WriteAttributeString("posCondicao",  diagrama.PosCondicao);
                xmlOut = geraXmlRaias(xmlOut, diagrama.Diagrama.ListaRaias);
                xmlOut.WriteEndElement();
            }

            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();
            xmlOut.Flush();
            xmlOut.Close();
        }

        private static XmlTextWriter geraXmlRaias(XmlTextWriter xmlOut, ArrayList listaRaias)
        {
            xmlOut.WriteStartElement("raias");
            foreach (Raia raia in listaRaias)
            {
                xmlOut.WriteStartElement("raia");
                xmlOut.WriteAttributeString("nome", raia.Nome);
                xmlOut.WriteAttributeString("tamanho", Convert.ToString(raia.Width));

                if (raia.ListaAcoes.Count > 0)
                {
                    xmlOut.WriteStartElement("acoes");
                    foreach (Acao acao in raia.ListaAcoes)
                    {
                        xmlOut.WriteStartElement("acao");
                        xmlOut.WriteAttributeString("valor", acao.Texto);

                        if (acao.ListaCenariosAlternativos.Count > 0)
                        {
                            xmlOut.WriteStartElement("cenarios");
                            foreach (CenarioAlternativo cenario in acao.ListaCenariosAlternativos)
                            {
                                xmlOut.WriteStartElement("cenario");
                                xmlOut.WriteAttributeString("nome",cenario.Nome);

                                //Recursivamente gera o xml para as raias e acoes dos cenarios alternativos.
                                geraXmlRaias(xmlOut, cenario.ListaRaias);
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

        public static CasoUso abrirArquivo(string filename)
        {
            if (File.Exists(filename))
            {
                Diagrama diagrama = new Diagrama();
                CasoUso casoDeUso = new CasoUso("", diagrama, filename);

                XmlTextReader xmlIn = new XmlTextReader(filename);
                xmlIn = lerXmlRaias(xmlIn, casoDeUso, casoDeUso.Diagrama.ListaRaias);

                return casoDeUso;
            }
            return null;
        }

        private static XmlTextReader lerXmlRaias(XmlTextReader xmlIn, CasoUso casoDeUso, ArrayList raias)
        {
            ArrayList acoes = null;
            CenarioAlternativo cenario = null;
            Raia raia = null;
            Acao acao = null;

            while (xmlIn.Read())
            {
                xmlIn.MoveToElement();

                if (xmlIn.IsStartElement())
                {
                    if (xmlIn.Name.Equals("projeto"))
                    {
                        String nomeProjeto = xmlIn.GetAttribute("nome");
                        casoDeUso.Nome = nomeProjeto;
                    }

                    if (xmlIn.Name.Equals("raia"))
                    {
                        acoes = new ArrayList();
                        String nomeAtor = xmlIn.GetAttribute("nome");
                        int tamanho = int.Parse(xmlIn.GetAttribute("tamanho"));
                        raia = new Raia(nomeAtor, tamanho, acoes);
                        raias.Add(raia);
                    }

                    if (xmlIn.Name.Equals("acao"))
                    {
                        String valorAcao = xmlIn.GetAttribute("valor");
                        acao = new Acao(valorAcao, new ArrayList());
                        ((Raia)raias[raias.Count - 1]).ListaAcoes.Add(acao);
                    }

                    if (xmlIn.Name.Equals("cenario"))
                    {
                        String nomeCenario = xmlIn.GetAttribute("nome");
                        cenario = new CenarioAlternativo(nomeCenario);

                        acoes = ((Raia)raias[raias.Count - 1]).ListaAcoes;
                        ((Acao)acoes[acoes.Count - 1]).ListaCenariosAlternativos.Add(cenario);

                        //Recursivamente recupera as raias e acoes dos cenarios alternativos.
                        xmlIn = lerXmlRaias(xmlIn, casoDeUso, cenario.ListaRaias);
                    }

                    if (xmlIn.Name.Equals("cenario-end"))
                    {
                        //Se for final dos cenarios, pula ele e termina a recursao
                        xmlIn.Skip();
                        return xmlIn;
                    }
                }
            }
            return xmlIn;
        }
    }
}
