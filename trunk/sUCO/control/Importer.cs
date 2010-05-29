using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace sUCO.control
{
    class Importer
    {
        public static void ImportarXML()
        {
            XmlReader reader = new XmlTextReader("/sUCO_UC.xml");
            Dictionary<String, UseCase> hash = new Dictionary<String, UseCase>();

            while (reader.Read())
            {
                if (reader.IsStartElement())
                {
                    parseElementTag(reader, hash);
                    parseDiagramsTag(reader, hash);
                    parseConnectorTag(reader, hash);
                }
            }

            Console.ReadLine();
        }

        private static void parseElementTag(XmlReader reader, Dictionary<String, UseCase> hash)
        {
            if (reader.Name.Equals("element"))
            {
                String type = reader.GetAttribute("xmi:type");

                if (type != null && type.Equals("uml:UseCase"))
                {
                    String id = reader.GetAttribute("xmi:idref");
                    String name = reader.GetAttribute("name");
                    UseCase uc = new UseCase(id, name);
                    hash.Add(id, uc);
                }
            }
        }

        private static void parseDiagramsTag(XmlReader reader, Dictionary<String, UseCase> hash)
        {
            if (reader.Name.Equals("diagrams"))
            {
                XmlReader sub = reader.ReadSubtree();

                while (sub.Read())
                {
                    if (sub.Name.Equals("element"))
                    {
                        String geometry = reader.GetAttribute("geometry");
                        String id = reader.GetAttribute("subject");
                        String seq = reader.GetAttribute("seqno");

                        if (geometry != null)
                        {
                            UseCase uc = null;
                            hash.TryGetValue(id, out uc);

                            if (uc != null)
                            {
                                uc.SeqNumber = int.Parse(seq);
                                String[] positions = geometry.Split(';');

                                foreach (String pos in positions)
                                {
                                    if (!pos.Equals(""))
                                    {
                                        int equalsIndex = pos.IndexOf("=");
                                        String attr = pos.Substring(0, equalsIndex);
                                        int value = int.Parse(pos.Substring(equalsIndex + 1));

                                        if (attr.Equals("Left"))
                                        {
                                            uc.Left = value;
                                        }
                                        else if (attr.Equals("Top"))
                                        {
                                            uc.Top = value;
                                        }
                                        else if (attr.Equals("Right"))
                                        {
                                            uc.Width = value - uc.Left;
                                        }
                                        else if (attr.Equals("Bottom"))
                                        {
                                            uc.Height = value - uc.Top;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private static void parseConnectorTag(XmlReader reader, Dictionary<String, UseCase> hash)
        {
            if (reader.Name.Equals("connector"))
            {
                XmlReader sub = reader.ReadSubtree();
                UserCaseLink ucl = null;

                while (sub.Read())
                {
                    if (sub.IsStartElement())
                    {
                        if (sub.Name.Equals("source"))
                        {
                            ucl = new UserCaseLink();
                            String id = sub.GetAttribute("xmi:idref");
                            ucl.Source = id;
                        }

                        if (ucl != null && sub.Name.Equals("target"))
                        {
                            String id = sub.GetAttribute("xmi:idref");
                            ucl.Target = id;
                        }

                        if (ucl != null && sub.Name.Equals("model"))
                        {
                            String type = sub.GetAttribute("type");
                            ucl.Type = type;
                        }

                        if (ucl != null && ucl.Source != null && ucl.Target != null)
                        {
                            UseCase uc = null;
                            hash.TryGetValue(ucl.Source, out uc);

                            if (uc == null)
                            {
                                hash.TryGetValue(ucl.Target, out uc);
                            }

                            uc.Links.Add(ucl);
                            ucl = null;
                        }
                    }
                }
            }
        }

        //static void Main()
        //{
        //    ImportarXML();
        //}
    }
}
