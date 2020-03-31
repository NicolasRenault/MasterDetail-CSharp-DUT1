using Modele;
using Stub;
using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Input;

namespace SkyrimProjet
{
    /// <summary>
    /// Interaction logic for CréationRace.xaml
    /// </summary>
    public partial class CreationRace : Window
    {
        public bool TestValidation { get; private set; }

        public CreationRace()
        {
            InitializeComponent();
        }

        private void Valider_Click(object sender, RoutedEventArgs e)
        {

            if (IntComp1.Text.ToString() == "")
            {
                IntComp1.Text = "0";
            }
            int CIntComp1 = int.Parse(IntComp1.Text.ToString());

            if (IntComp2.Text.ToString() == "")
            {
                IntComp2.Text = "0";
            }
            int CIntComp2 = int.Parse(IntComp2.Text.ToString());

            if (IntComp3.Text.ToString() == "")
            {
                IntComp3.Text = "0";
            }
            int CIntComp3 = int.Parse(IntComp3.Text.ToString());

            if (Stat1.Text.ToString() == "")
            {
                Stat1.Text = "0";
            }
            int CStat1 = int.Parse (Stat1.Text.ToString());

            if (Stat2.Text.ToString() == "")
            {
                Stat2.Text = "0";
            }
            int CStat2 = int.Parse(Stat2.Text.ToString());

            if (Stat3.Text.ToString() == "")
            {
                Stat3.Text = "0";
            }
            int CStat3 = int.Parse(Stat3.Text.ToString());

            if (Nom.Text.ToString() == "")
            {
                MessageBox.Show("Veuillez indiquer le nom de votre Race");
            }
            else if (Description.Text.ToString() == "")
            {
                MessageBox.Show("Veuillez donner une description à votre Race");
            }
            else if (Comp1.Text.ToString() == Comp2.Text.ToString() || Comp1.Text.ToString() == Comp3.Text.ToString() || Comp2.Text.ToString() == Comp3.Text.ToString())
            {
                MessageBox.Show("Une race ne peut pas avoir deux compétences principales identiques");
            }
            else if (MonImage.Source == null)
            {
                MessageBox.Show("Veuillez selectionner une image");
            }
            else
            {
                (Application.Current as App).allRaces.AjouterRace(new Race(Nom.Text.ToString(),
                                                                       Description.Text.ToString(),
                                                                       Comp1.Text.ToString(),
                                                                       CIntComp1,
                                                                       Comp2.Text.ToString(),
                                                                       CIntComp2,
                                                                       Comp3.Text.ToString(),
                                                                       CIntComp3,
                                                                       new Statistique(CStat1, CStat2, CStat3),
                                                                       MonImage.Source.ToString()));
                Serialiser.SauverRaces((Application.Current as App).allRaces);
                TestValidation = true;
                Close();
            }


        }

        private void Parcourir_Click(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog
            {
                DefaultExt = ".png",
                Filter = "Fichiers JPEG (*.jpeg)|*.jpeg|Fichiers PNG (*.png)|*.png|Fichiers JPG (*.jpg)|*.jpg"
            };
            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                string nomFichier = dlg.FileName;
                (Resources["ImageNotify"] as ImageNotify).SrcImage = nomFichier;

            }
        }
        private void OnlyNombreTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }
}
