using SkyrimProjet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stub
{
    public class Class1
    {
        private Statistique stats = new Statistique(200, 100, 150);
        private ISet<Competence> lesCompetencesAltmer = new HashSet<Competence>();
        private ISet<Competence> lesCompetencesArgonien = new HashSet<Competence>();
        public ObservableCollection<ListRaces> Tout { get; } = new ObservableCollection<ListRaces>();

        public ObservableCollection<ListRaces> CreatDictionary()
        {
            lesCompetencesAltmer.Add(new Competence("Forgeage", 15, "Le Forgeage est l'art de créer et d'améliorer armes et armures à partir de matières brutes. C'est l'utilisation d'outils de forge, de meules et d'établis qui permettent d'augmenter vos compétences de forgeage."));
            lesCompetencesAltmer.Add(new Competence("Armure Lourde", 15, "Les personnages entraînés à porter des armures lourdes utilisent plus efficacement les armures de fer, d'acier, orques, Daedra et en os de Dragon."));
            lesCompetencesAltmer.Add(new Competence("Parade", 15, "La parade est la capacité à parer les coups d'un ennemi à l'aide d'un bouclier ou d'une arme. La parade diminue les dégâts et le déséquilibre des attaques physiques."));
            lesCompetencesAltmer.Add(new Competence("Deux Mains", 15, "Capacité à se battre à l'aide d'armes à deux mains comme les grandes épées, les haches de combat et les marteaux de guerre. Les personnages entraînés dans cette discipline peuvent infliger des coups mortels."));
            lesCompetencesAltmer.Add(new Competence("Une Main", 15, "Capacité à se battre à l'aide d'armes à une main comme les dagues, les épées, les masses d'armes et les haches de guerre.Les personnages entraînés dans cette discipline peuvent infliger des coups mortels."));
            lesCompetencesAltmer.Add(new Competence("Archerie", 15, "La compétence d' Archerie est améliorée par l'utilisation d'arc."));
            lesCompetencesAltmer.Add(new Competence("Armure Légère", 15, "Les personnages entraînés à porter des armures légères utilisent plus efficacement les armures de peau, de cuir, elfiques et de verres."));
            lesCompetencesAltmer.Add(new Competence("Furtivité", 15, "La furtivité est accrue"));
            lesCompetencesAltmer.Add(new Competence("Crochetage", 15, "Elle est améliorée en crochetant des serrures ou coffres. Le niveau de crochetage augmente plus rapidement si vous déverrouillez des coffres haut niveau. Plus cette compétence évolue et plus le crochetage est facile à réaliser. "));
            lesCompetencesAltmer.Add(new Competence("Vol à la tire", 15, "Capacité à faire les poches d'une cible sans méfiance. Un voleur expérimenté a moins de chances d'être pris et est plus à même de dérober des objets de valeur."));
            lesCompetencesAltmer.Add(new Competence("Éloquence", 15, "En plus des atouts sur les prix, l’éloquence peut être utilisé sur des personnages dans la boite de dialogue pour persuader, corrompre ou soudoyer."));
            lesCompetencesAltmer.Add(new Competence("Alchimie", 15, "La compétence Alchimie permet de créer des potions et des poisons"));
            lesCompetencesAltmer.Add(new Competence("Illusion", 25, "Cette magie est axée sur la manipulation des PNJ."));
            lesCompetencesAltmer.Add(new Competence("Conjuration", 20, "Les pratiques de conjuration concernent la résurrection des morts et l'invocation de créatures d'Oblivion."));
            lesCompetencesAltmer.Add(new Competence("Destruction", 20, "Ce sont des sorts dits de destruction axés principalement sur des dégâts directs et immédiats par le biais des sorts de feu, de glace et de foudre."));
            lesCompetencesAltmer.Add(new Competence("Guérison", 20, "Ce sont comme des sorts dits de restauration axés sur ​​la guérison et la protection."));
            lesCompetencesAltmer.Add(new Competence("Altération", 20, " L'École de l'Altération implique la manipulation du monde physique et de ses propriétés naturelles. Cette compétence permet de lancer des sorts comme Respiration sous l'eau Protection magique, et Paralysie."));
            lesCompetencesAltmer.Add(new Competence("Enchantement", 20, "L'enchantement est l'art d'utiliser des gemmes sprirituelles pleines pour appliquer des effets magiques immuable et permanent sur l'objet désiré."));
            var altmer = new ListRaces
            {
                R = new Race("Altmer", "Dans la langue commune, le peuple à la peau dorée de l’Archipel de l'Automne s'appelle « Haut-Elfe », mais dans leur propre langue, ils s’appellent eux-mêmes les « Altmers », ou les « Gens Cultivés ».", "Tamriel", stats),
                LesCompetences = lesCompetencesAltmer
            };

            lesCompetencesArgonien.Add(new Competence("Forgeage", 15, "Le Forgeage est l'art de créer et d'améliorer armes et armures à partir de matières brutes. C'est l'utilisation d'outils de forge, de meules et d'établis qui permettent d'augmenter vos compétences de forgeage."));
            lesCompetencesArgonien.Add(new Competence("Armure Lourde", 15, "Les personnages entraînés à porter des armures lourdes utilisent plus efficacement les armures de fer, d'acier, orques, Daedra et en os de Dragon."));
            lesCompetencesArgonien.Add(new Competence("Parade", 15, "La parade est la capacité à parer les coups d'un ennemi à l'aide d'un bouclier ou d'une arme. La parade diminue les dégâts et le déséquilibre des attaques physiques."));
            lesCompetencesArgonien.Add(new Competence("Deux Mains", 15, "Capacité à se battre à l'aide d'armes à deux mains comme les grandes épées, les haches de combat et les marteaux de guerre. Les personnages entraînés dans cette discipline peuvent infliger des coups mortels."));
            lesCompetencesArgonien.Add(new Competence("Une Main", 15, "Capacité à se battre à l'aide d'armes à une main comme les dagues, les épées, les masses d'armes et les haches de guerre.Les personnages entraînés dans cette discipline peuvent infliger des coups mortels."));
            lesCompetencesArgonien.Add(new Competence("Archerie", 15, "La compétence d' Archerie est améliorée par l'utilisation d'arc."));
            lesCompetencesArgonien.Add(new Competence("Armure Légère", 20, "Les personnages entraînés à porter des armures légères utilisent plus efficacement les armures de peau, de cuir, elfiques et de verres."));
            lesCompetencesArgonien.Add(new Competence("Furtivité", 20, "La furtivité est accrue"));
            lesCompetencesArgonien.Add(new Competence("Crochetage", 25, "Elle est améliorée en crochetant des serrures ou coffres. Le niveau de crochetage augmente plus rapidement si vous déverrouillez des coffres haut niveau. Plus cette compétence évolue et plus le crochetage est facile à réaliser. "));
            lesCompetencesArgonien.Add(new Competence("Vol à la tire", 20, "Capacité à faire les poches d'une cible sans méfiance. Un voleur expérimenté a moins de chances d'être pris et est plus à même de dérober des objets de valeur."));
            lesCompetencesArgonien.Add(new Competence("Éloquence", 15, "En plus des atouts sur les prix, l’éloquence peut être utilisé sur des personnages dans la boite de dialogue pour persuader, corrompre ou soudoyer."));
            lesCompetencesArgonien.Add(new Competence("Alchimie", 15, "La compétence Alchimie permet de créer des potions et des poisons"));
            lesCompetencesArgonien.Add(new Competence("Illusion", 15, "Cette magie est axée sur la manipulation des PNJ."));
            lesCompetencesArgonien.Add(new Competence("Conjuration", 15, "Les pratiques de conjuration concernent la résurrection des morts et l'invocation de créatures d'Oblivion."));
            lesCompetencesArgonien.Add(new Competence("Destruction", 20, "Ce sont des sorts dits de destruction axés principalement sur des dégâts directs et immédiats par le biais des sorts de feu, de glace et de foudre."));
            lesCompetencesArgonien.Add(new Competence("Guérison", 20, "Ce sont comme des sorts dits de restauration axés sur ​​la guérison et la protection."));
            lesCompetencesArgonien.Add(new Competence("Altération", 15, " L'École de l'Altération implique la manipulation du monde physique et de ses propriétés naturelles. Cette compétence permet de lancer des sorts comme Respiration sous l'eau Protection magique, et Paralysie."));
            lesCompetencesArgonien.Add(new Competence("Enchantement", 15, "L'enchantement est l'art d'utiliser des gemmes sprirituelles pleines pour appliquer des effets magiques immuable et permanent sur l'objet désiré."));
            var argonien = new ListRaces
            {
                R = new Race("Argonien", "Les Argoniens, aussi appelés Saxhleel, sont des créatures autochtones ayant l'apparence d'homme reptile. Ils vivent dans la province du Marais Noir, territoire extrêmement dangereux pour les autres races.", "Tamriel", stats),
                LesCompetences = lesCompetencesArgonien
            };

            Tout.Add(altmer);
            Tout.Add(argonien);
            return Tout;
        }
    }
}
