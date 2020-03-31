using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]
    [KnownType(typeof(Elfe))]
    public class Race : Element, IVivant
    {
        [DataMember]
        public string Competence1 { get; set; }

        [DataMember]
        public int IntCompetence1 { get; set; }

        [DataMember]
        public string Competence2 { get; set; }

        [DataMember]
        public int IntCompetence2 { get; set; }

        [DataMember]
        public string Competence3 { get; set; }

        [DataMember]
        public int IntCompetence3 { get; set; }

        [DataMember]
        public Statistique Stats { get; set; }

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        /// <param name="stats"></param>
        /// <param name="intcomp3"></param>
        /// <param name="intcomp2"></param>
        /// <param name="intcomp1"></param>
        /// <param name="descriptif"></param>
        /// <param name="comp3"></param>
        /// <param name="comp2"></param>
        /// <param name="comp1">/param>
       
        public Race(string nom, string descriptif, string comp1, int intcomp1, string comp2, int intcomp2, string comp3, int intcomp3, Statistique stats, string chemin) : base(nom, descriptif, chemin)
        {
            Stats = stats;
            Competence1 = comp1;
            Competence2 = comp2;
            Competence3 = comp3;
            IntCompetence1 = intcomp1;
            IntCompetence2 = intcomp2;
            IntCompetence3 = intcomp3;
        }

      
       


    }
}
