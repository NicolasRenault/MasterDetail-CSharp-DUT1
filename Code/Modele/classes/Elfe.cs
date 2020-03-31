using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]

    class Elfe :Race
    {
        [DataMember]

        string NomElfique { get; set; }

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        /// <param name="chemin"></param>
        /// <param name="nom"></param>
        /// <param name="comp1"></param>
        /// <param name="comp2"></param>
        /// <param name="comp3"></param>
        /// <param name="descriptif"></param>
        /// <param name="intcomp1"></param>
        /// <param name="intcomp2"></param>
        /// <param name="intcomp3"></param>
        /// <param name="nomElfique"></param>
        /// <param name="stats"></param>
        
        public Elfe(string nom, string nomElfique , string descriptif, string comp1, int intcomp1, string comp2, int intcomp2, string comp3, int intcomp3, Statistique stats, string chemin) :base(nom, descriptif, comp1, intcomp1, comp2, intcomp2, comp3, intcomp3, stats, chemin)
        {
            NomElfique = nomElfique;
        }
    }
}
