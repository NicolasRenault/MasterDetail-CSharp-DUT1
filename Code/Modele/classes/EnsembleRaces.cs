using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele
{
    public class EnsembleRace
    {
        public ObservableCollection<Race> StockRaces { get; private set; }

        public EnsembleRace()
        {
            StockRaces = new ObservableCollection<Race>();
        }

        public void AjouterRace(Race race)
        {
            StockRaces.Add(race);
        }
    }  
}
