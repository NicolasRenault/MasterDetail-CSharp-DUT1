using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;


namespace Modele
{
    [DataContract]
    [KnownType(typeof(Race))]
    [KnownType(typeof(Competence))]
    public abstract class Element
    {
        [DataMember]
        public string Nom { get; set; }

        [DataMember]
        public string Descriptif { get; set; }

        [DataMember]
        public string CheminImage { get; set; }

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="chemin"></param>
        /// <param name="descritpif"></param>
        
        public Element(string nom, string descritpif, string chemin)
        {
            Nom = nom;
            Descriptif = descritpif;
            CheminImage = chemin;
        }
    }
}
