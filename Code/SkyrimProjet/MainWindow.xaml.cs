using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using Modele;
using SkyrimProjet.UCs;
using Stub;

namespace SkyrimProjet
{
    /// <summary>
    /// Fenêtre principale 
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Serialiser.SetDirectory();
            if(!File.Exists("Races.xml"))
            {
                Serialiser.SauverRaces((Application.Current as App).allRaces);
            }

        }

        private void ConsulterRaces_Click(object sender, RoutedEventArgs e)
        {
            AppelRace();
        }

        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            Contenu.Children.Clear();
            Accueil acceuil = new Accueil();
            Contenu.Children.Add(acceuil);  
        }

        private void AjouterRace_Click(object sender, RoutedEventArgs e)
        {
            CreationRace creationRace = new CreationRace();
            creationRace.ShowDialog();    
            if (creationRace.TestValidation)
            { 
                AppelRace();
            }
        }

        private void Competence_Click (object sender, RoutedEventArgs e)
        {
            Contenu.Children.Clear();
            UCCompetence comp = new UCCompetence();
            Contenu.Children.Add(comp);
        }


        private void AppelRace() 
        {
            Contenu.Children.Clear();
            UCRaces race = new UCRaces();
            Contenu.Children.Add(race);
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {

            Sauvegarde save = new Sauvegarde();
            save.ShowDialog();
        }

    }
}
