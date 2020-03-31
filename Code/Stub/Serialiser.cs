using Modele;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Stub
{
    public static class Serialiser
    {
        public static void SetDirectory()
        {
            Directory.SetCurrentDirectory(Path.Combine(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory()).FullName).FullName).FullName, "Stub", "XML"));
        }

        /// <summary>
        /// Sauvegarde des Races
        /// </summary>
        
        public static void SauverRaces(EnsembleRace races)
        {
            XmlWriterSettings settings = new XmlWriterSettings() { Indent = true };

            var serializer = new DataContractSerializer(typeof(EnsembleRace), new DataContractSerializerSettings() { PreserveObjectReferences = true });

            using (XmlWriter writer = XmlWriter.Create("Races.xml", settings))
            {
                serializer.WriteObject(writer, races);
            }
        }

        /// <summary>
        /// Chargement Des races
        /// </summary>
       
        public static EnsembleRace LireRaces()
        {
            EnsembleRace catalogue;
            var serializer = new DataContractSerializer(typeof(EnsembleRace));

            using (Stream reader = File.OpenRead("Races.xml"))
            {
                catalogue = serializer.ReadObject(reader) as EnsembleRace;
            }
            return catalogue;
        }
    }
}
