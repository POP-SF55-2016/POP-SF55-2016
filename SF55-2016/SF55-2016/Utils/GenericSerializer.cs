using SF55_2016.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SF55_2016.Utils
{
    class GenericSerializer
    {
        public static List<T> Deserialize<T>(string fileName) where T : class
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var sr = new StreamReader($@"../../Data/{ fileName }"))
                {
                    return (List<T>)serializer.Deserialize(sr);
                }
                
            }
            catch (Exception)
            {

                throw new Exception("Greska prilikom ucitavanja datoteke: {fileName} sa diska.");
            }
        }

        public static void Serialize<T>(string fileName, List<T> listToSerialize) where T : class
        {
            try
            {
                var serializer = new XmlSerializer(typeof(List<T>));
                using (var sr = new StreamReader($@"../../Data/{ fileName }"))
                {
                    serializer.Serialize(sr, listToSerialize);
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Greska prilikom upisa datoteke: {fileName} na diska.");
            }
        }

        internal static void Serialize<T>(string v, List<TipNamestaja> listaTipovaNamestaja)
        {
            throw new NotImplementedException();
        }
    }
}
