using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;


namespace SkyrimProjet.UCs
{

    public partial class UCCompetence : UserControl
    {
        public UCCompetence()
        {
            try
            {
                InitializeComponent();
                ListeDeComp.DataContext = (Application.Current as App).allCompetences;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
