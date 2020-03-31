using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace SkyrimProjet

{

    public class Statistique

    {

        public int NbPtsDeVie { get; set; }

        public int NbPtsDeVigueur { get; set; }

        public int NbPtsDeMagie { get; set; }

        public Statistique(int hp, int vigueur, int magie)

        {

            NbPtsDeMagie = hp;

            NbPtsDeVigueur = vigueur;

            NbPtsDeMagie = magie;

        }

    }

}
