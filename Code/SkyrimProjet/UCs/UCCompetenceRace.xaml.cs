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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SkyrimProjet.UCs
{
    /// <summary>
    /// Interaction logic for UCCompetenceRace.xaml
    /// </summary>
    public partial class UCCompetenceRace : UserControl
    {
        public static readonly DependencyProperty NomCompetenceProperty = DependencyProperty.Register("NomCompetence", typeof(string), typeof(UCCompetenceRace), new PropertyMetadata(""));
        public static readonly DependencyProperty ValeurCompetenceProperty = DependencyProperty.Register("ValeurCompetence", typeof(int), typeof(UCCompetenceRace), new PropertyMetadata(0));

        public UCCompetenceRace()
        {
            InitializeComponent();
        }


        public string NomCompetence
        {
           get
            {
                return (string)GetValue(NomCompetenceProperty);
            }
            set
            {
                SetValue(NomCompetenceProperty, value);
            }
        }


        public int ValeurCompetence
        {
            get
            {
                return (int)GetValue(ValeurCompetenceProperty);
            }
            set
            {
                SetValue(ValeurCompetenceProperty, value);
            }
        }


    }
}
