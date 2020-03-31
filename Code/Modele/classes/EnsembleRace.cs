using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;  
using System.Runtime.Serialization;


namespace Modele
{
    [DataContract]
    public class EnsembleRace
    {
        [DataMember]
        public ObservableCollection<Race> LesRaces { get; set; }

        /// <summary>
        /// Contructeur de la classe
        /// </summary>
        public EnsembleRace()
        {
            LesRaces = new ObservableCollection<Race>();
        }

        public void AjouterRace(Race race)
        {
            LesRaces.Add(race);
        }

        public int SupprimerRace(Race race)
        {
            LesRaces.Remove(race);
            if (LesRaces.Count == 0)
            {
                LesRaces.Add(new Race("FINAL BOSS", "Mr. Bouhours"+"\n"+" Est un professeur", "C#", 1000, "Testeur d'application", 700, "Humour ☻", 10000, new Statistique(1, 2, 3), "../Images/EasterEgg.jpg"));
                return 1;
            }
            return 0;
        }
    }
}
