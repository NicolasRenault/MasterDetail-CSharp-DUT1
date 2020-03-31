using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modele.classes
{
    public class EnsembleCompetences
    {
        public ObservableCollection<Competence> LesCompetences { get; set; }

        public EnsembleCompetences()
        {
            LesCompetences = new ObservableCollection<Competence>();
        }

        public void AjouterCompetence(Competence competence)
        {
            LesCompetences.Add(competence);
        }
    }
}
