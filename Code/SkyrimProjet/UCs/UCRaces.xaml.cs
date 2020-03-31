using Modele;
using Stub;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace SkyrimProjet.UCs
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UCRaces : UserControl
    {

        public UCRaces()
        {
            try
            {
                InitializeComponent();
                (Application.Current as App).allRaces= Serialiser.LireRaces();

                ListeDeRaces.DataContext = (Application.Current as App).allRaces;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void DeleteButton_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
          int retourne = (Application.Current as App).allRaces.SupprimerRace((Race)ListeDeRaces.SelectedItem);
          if (retourne == 1)
          {
                ListeDeRaces.SelectedItem = (Application.Current as App).allRaces.LesRaces.First();
                Serialiser.SauverRaces((Application.Current as App).allRaces);

            }
        }

   
    }
}
