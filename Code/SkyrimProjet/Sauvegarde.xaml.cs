using Stub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace SkyrimProjet
{
    /// <summary>
    /// Interaction logic for Sauvegarde.xaml
    /// </summary>
    public partial class Sauvegarde : Window
    {
        public Sauvegarde()
        {
            InitializeComponent();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {
            Serialiser.SauverRaces((Application.Current as App).allRaces);
            this.Close();
        }

        private void Cancel_Click(object sender, RoutedEventArgs e)
        {
            Serialiser.SauverRaces(Usine.CreerRaces());
            this.Close();
        }
    }
}
