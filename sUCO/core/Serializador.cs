
using System.IO;
using System.Runtime.Serialization.Formatters.Soap; 

namespace sUCO
{
    class Serializador
    {
        public static void salvarArquivo(CasoUso diagrama)
        {
            if (File.Exists(diagrama.FileName))
            {
                File.Delete(diagrama.FileName);
            }
            else
            {
                diagrama.FileName += ".xml";
            }

            SoapFormatter s = new SoapFormatter();
            FileStream f = File.Create(diagrama.FileName);
            s.Serialize(f, diagrama);
            f.Close();
        }

        public static CasoUso abrirArquivo(string filename)
        {
            if (File.Exists(filename))
            {
                SoapFormatter sXML = new SoapFormatter();
                FileStream f = new FileStream(filename, FileMode.Open, FileAccess.Read);

                CasoUso casoDeUso = (CasoUso)sXML.Deserialize(f);
                f.Close();

                casoDeUso.FileName = filename;
                return casoDeUso;
            }
            return null;
        }
    }
}
