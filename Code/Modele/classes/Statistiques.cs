using System;

using System.Collections.Generic;

using System.Linq;
using System.Runtime.Serialization;
using System.Text;

using System.Threading.Tasks;

namespace Modele

{
    [DataContract]
    public class Statistique

    {
        [DataMember]
        public int NbPtsDeVie { get; set; }

        [DataMember]
        public int NbPtsDeVigueur { get; set; }

        [DataMember]
        public int NbPtsDeMagie { get; set; }

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        /// <param name="hp"></param>
        /// <param name="magie"></param>
        /// <param name="vigueur"></param>
        public Statistique(int hp, int vigueur, int magie)

        {

            NbPtsDeVie = hp;

            NbPtsDeVigueur = vigueur;

            NbPtsDeMagie = magie;

        }

    }

}
