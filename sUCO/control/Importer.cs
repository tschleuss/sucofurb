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
            //XmlReader reader = new XmlTextReader("/EATeste.xml");
            Dictionary<String, UseCase> hash = new Dictionary<String, UseCase>();

            while (reader.Read())
            {
                if (reader.IsStartElement())
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
            }

            Console.ReadLine();
        }

        //static void Main()
        //{
        //   importarXML();
        //}
    }
}
