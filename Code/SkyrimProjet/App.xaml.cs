using Modele;
using Modele.classes;
using Stub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace SkyrimProjet
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    /// 
   
    public partial class App : Application
    {
        public EnsembleRace allRaces = Usine.CreerRaces();


        public EnsembleCompetences allCompetences = Usine.CreeCompetences();

       
        
    }
}
