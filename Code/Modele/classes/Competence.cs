using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    [DataContract]

    public class Competence:Element
    {
        [DataMember]

        public int Valeur { get; set; }

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        /// <param name="chemin"></param>
        /// <param name="description"></param>
        /// <param name="nom"></param>
        /// <param name="valeur"></param>
     
        public Competence(string nom,int valeur, string description,string chemin) :base(nom,description,chemin)
        {
            Valeur = valeur;
        }

        public override string ToString()
        {
            return Nom + " " + Valeur;
        }
    }
}
