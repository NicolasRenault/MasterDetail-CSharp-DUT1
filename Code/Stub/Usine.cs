using Modele;
using Modele.classes;
using System.Collections.Generic;
using System.Collections.ObjectModel;



namespace Stub
{
    public static class Usine
    {
        public static EnsembleRace CreerRaces()
        {
            Statistique stats = new Statistique(100, 100, 100);

            EnsembleRace ensemble = new EnsembleRace();
            Race altmer = new Race("Altmer", "Dans la langue commune, le peuple à la peau dorée de l’Archipel de l'Automne s'appelle « Haut-Elfe », mais dans leur propre langue, ils s’appellent eux-mêmes les « Altmers », ou les « Gens Cultivés ». Les Hauts-Elfes se considèrent souvent comme le peuple le plus civilisé de Tamriel. En effet, la société Altmer est le berceau de la civilisation et de la magie telle qu'on les connaît à Tamriel ; le langage commun de l’Empire, le Tamriellien, tire d'ailleurs une partie de ses origines de la langue et de l’écriture Altmer et la plupart des arts, artisanats, lois et sciences de l'Empire sont issues des connaissances Altmers. La haute estime que les Altmers ont d’eux-mêmes et leur attitude narcissique engendre un dédain pour les autres races, ce qui est souvent assez mal perçu.", "Magie", 25, "Archerie", 20, "Arme", 20, stats, "../Images/races/altmer.jpeg");
            Race argonien = new Race("Argonien", "Les Argoniens, aussi appelés Saxhleel, sont des créatures autochtones ayant l'apparence d'homme reptile. Ils vivent dans la province du Marais Noir, territoire extrêmement dangereux pour les autres races. Ils ont été créés par les Hists, premières créatures mortelles avec les Ehlnofeys, dans le but d'entrer en communication avec ces derniers. Ils servaient également de garde du corps des Hists. Avec les Khajiits, ils sont la seule race autochtone face aux humains et au elfes. Refoulés par ces derniers, ils ne forment qu'une minorité sur le continent. Peu d'entre eux sortent de leur Marais. ", "Vol", 25, "Armure", 20, "Magie", 20, stats, "../Images/races/argonien.jpeg");
            Race bosmer = new Race("Bosmer", "Les Elfes des bois (ou Bosmer) sont le clan elfique de Val-Boisé qui préfèrent une existence simple, en harmonie avec la terre et les animaux. Ce sont les meilleurs archers de Tamriel et ils sont connus pour leur capacité à commander les animaux. Ils mênent une vie plus modeste que leurs cousins Dunmers ou Altmers.La cause de cette vie simple est partiellement liée au pacte vert, pacte qui leur interdit de faire du tort à une plante. Les Bosmer sont issus de la liaison entre Nirni et Y'ffer (où Y'ffre). Suite à la 'trahison' d'Azura découvert par Y'ffer, Nirni accepta d'engendrer une nouvelle race avec celui-ci, et créa ainsi la race des Elfes des bois. Ceci explique le culte que voue les Bosmers à Y'ffre aujourd'hui.", "Archerie", 25, "Vol", 20, "Alchimie", 20, stats, "../Images/races/bosmer.jpeg");
            Race breton = new Race("Bréton", "Les Brétons, de l'Ehlnofex 'beratu', ou 'moitié', sont les descendants humains qui viennent de la province de Haute-Roche. Selon le guide de poche de l'Empire, troisième édition, ils descendent des Nédiques et des Aldmers, tandis que d'autres sources prétendent qu'ils étaient le mélange du sang des Atmorans et des Aldmers. Les Altmers pensèrent à créer une nouvelle race avec leur propre sang qu'ils considèrent comme 'ancien' ou 'supérieur', et ce en s'accouplant avec d'autres races. Les Brétons sont parfois appelés 'Manmers', ou 'Hommes - elfes', à cause de cela. ", "Magie", 25, "Eloquence", 20, "Alchimie", 20, stats, "../Images/races/bréton.jpeg");
            Race dunmer = new Race("Dunmer", "Les Elfes Noirs — aussi appelés Dunmers en Morrowind, leur province d'origine— sont des elfes spécialistes de la furtivité et de la magie de destruction. Forts, intelligents, vifs, distants et réservés, on dit pourtant des Dunmers qu'ils sont des êtres infortunés et que leur destinée ne leur sera jamais favorable. ", "Destruction", 25, "Furtivité", 20, "Alchimie", 20, stats, "../Images/races/dunmer.jpeg");
            Race imperial = new Race("Impérial", "Les Impériaux, aussi connu comme les Cyrodiliens ou les Cyrodiils, sont une race humaines de Cyrodiil, la province centrale de Tamriel. Les membres de la race impériale sont parmi les plus éduqués, les plus riches et les mieux réputés de Tamriel. Originaires de la province cosmopolite et civilisée de Cyrodiil, ils se sont révélés être des diplomates astucieux, des commerçants et des stratèges. ", "Guérison", 25, "Arme", 20, "Enchantement", 20, stats, "../Images/races/imperial.jpeg");
            Race khajiit = new Race("Khajiit", "Les Khajiits sont l'une des races jouables de la série The Elder Scrolls. Ils ont en général l'apparence de félins, même si leur forme peut changer. Ils vivent dans le désert d'Elsweyr. Ils sont connus pour leurs cultures de sucre de lune qu'ils transforment en skooma. Il existe quinze espèces de Khajiit différentes, tous possédant des caractéristiques particulières. Ce qui détermine l'apparence d'un Khajiit à la naissance, ce sont les phases des deux lunes Masser et Secunda. Par rapport aux phases de ces lunes, les Khajiits nouveaux-nés auront une forme différente, dont les transformations seront visibles quelques semaines après leur naissance.", "Furtivité", 25, "Vol", 20, "Alchimie", 20, stats, "../Images/races/khajiit.jpeg");
            Race nordique = new Race("Nordique", "Les Nordiques (race par défaut dans The Elder Scrolls V: Skyrim) sont les habitants de la terre du nord de Tamriel nommée Bordeciel. Ils sont également appelés les Enfants du ciel, car selon les légendes, c'est en Bordeciel, au sommet de La Gorge du Monde, que les Nordiques furent créés, quand la déesse Kyne insuffla la vie aux premiers Hommes. Ils sont principalement connus pour leur résistance accrue au froid glacial et pour compter parmis les guerriers les plus brave et redoutés de Tamriel.Les Nordiques étaient autrefois connus en tant qu'Atmorans, du continent du nord, Atmora. La culture de ces anciens Nordiques est voilée de mystère mais elle était essentiellement basée sur la force et le courage ainsi qu'à la magie lié aux éléments et à l'essence vitale du corps humain, les Nordiques des anciens temps faisaient des offrandes de bêtes aux dieux de leur Panthéon, ils vénéraient également les dragons. ", "Deux Mains", 25, "Forgeage", 20, "Eloquence", 20, stats, "../Images/races/nordique.jpeg");
            Race orsimer = new Race("Orsimer", "Les Orsimers, ou plus communément les Orques (parfois orthographié, 'Orcs'), sont considérés comme l'un des peuples les plus barbares de Nirn. Il sont originaires des régions montagneuses de Tamriel, se concentrant massivement sur un territoire appelé Orsinium.Après l'arrivée des Hommes en Tamriel, les Orques exilés fuyant les terres de Haute-Roche, Cyrodiil et Bordeciel suite à l'expansion des grands empires, durent chercher refuge, et fondèrent diverses colonies Orsimers à l'écart de la civilisation, un peu partout dans les montagnes recluses de Tamriel : les Montagnes de Wrothgar et de la Queue du Dragon en Haute-Roche, mais également dans les montagnes de Morrowind, Lenclume, et Bordeciel, où ils y vivent dans divers bastions. ", "Armure", 25, "Main", 20, "Enchantement", 20, stats, "../Images/races/orsimer.jpeg");
            Race rougegarde = new Race("Rougegarde", "Les Rougegardes sont de grands guerriers à la peau foncée qui viennent de Lenclume. Ils sont les guerriers les plus redoutables de Tamriel, les plus courageux à ce que l'on dit, notamment dans la Légion Impériale. Étant les guerriers les plus combattifs, ils sont craints de toutes les armées. Les Rougegardes sont originaires de Lenclume, une province au climat chaud (mais moins torride qu'Elsweyr) qui est frontalière à Bordeciel par le Nord-Est, à Haute-Roche par le Nord et par le Sud à Cyrodiil. ", "Main", 25, "Parade", 20, "Destruction", 20, stats, "../Images/races/rougegarde.jpeg");


            ensemble.AjouterRace(altmer);
            ensemble.AjouterRace(argonien);
            ensemble.AjouterRace(bosmer);
            ensemble.AjouterRace(breton);
            ensemble.AjouterRace(dunmer);
            ensemble.AjouterRace(imperial);
            ensemble.AjouterRace(khajiit);
            ensemble.AjouterRace(nordique);
            ensemble.AjouterRace(orsimer);
            ensemble.AjouterRace(rougegarde);

            return ensemble;
        }

        public static EnsembleCompetences CreeCompetences()
        {
            EnsembleCompetences ensemble = new EnsembleCompetences();
            Competence forgeage = new Competence("Forgeage", 0, "Le Forgeage est l'art de créer et d'améliorer armes et armures à partir de matières brutes. C'est l'utilisation d'outils de forge, de meules et d'établis qui permettent d'augmenter vos compétences de forgeage. ", "../Images/icones/Smithing_icon.png");
            Competence armure_lourde = new Competence("Armure Loude", 0, "Les personnages entraînés à porter des armures lourdes utilisent plus efficacement les armures de fer, d'acier, orques, Daedra et en os de Dragon. ", "../Images/icones/Heavy_Armor_icon.png");
            Competence parade = new Competence("Parade", 0, "La parade est la capacité à parer les coups d'un ennemi à l'aide d'un bouclier ou d'une arme. La parade diminue les dégâts et le déséquilibre des attaques physiques. ", "../Images/icones/Block_icon.png");
            Competence deux_mains = new Competence("Deux Mains", 0, "Deux mains ou Arme à deux mains est une compétence dans The Elder Scrolls V: Skyrim, c'est l'une des 6 régies par la constellation du Guerrier. Elle est liée à l'utilisation des armes tenues avec deux mains. ", "../Images/icones/Two-handed_icon.png");
            Competence une_main = new Competence("Une Main", 0, "Capacité à se battre à l'aide d'armes à une main comme les dagues, les épées, les masses d'armes et les haches de guerre. Les personnages entraînés dans cette discipline peuvent infliger des coups mortels. ", "../Images/icones/One-handed_icon.png");
            Competence archerie = new Competence("Archerie", 0, "L'Archerie est une compétence dans Skyrim et est l'une des 6 compétences du Guerrier.Toutefois, l' Archerie est fortement impliquée dans la voie du Voleur, en particulier avec la compétence Furtivité La compétence d' Archerie est améliorée par l'utilisation d'arc. ", "../Images/icones/Archer_icon.png");
            Competence armure_legere = new Competence("Armure Légère", 0, "Les personnages entraînés à porter des armures légères utilisent plus efficacement les armures de peau, de cuir, elfiques et de verres. ", "../Images/icones/Light_Armor_icon.png");
            Competence furtivite = new Competence("Furtivité", 0, "La Furtivité est une compétence dans The Elder Scrolls V : Skyrim et est une des six compétences de l'arbre du voleur.", "../Images/icones/Sneak_icon.png");
            Competence crochetage = new Competence("Crochetage", 0, "Le Crochetage est une compétence dans The Elder Scrolls V: Skyrim, l'une des 6 compétences  Elle est améliorée en crochetant des serrures ou coffres.Le niveau de crochetage augmente plus rapidement si vous déverrouillez des coffres haut niveau Plus cette compétence évolue et plus le crochetage est facile à réaliser. ", "../Images/icones/Lockpiting_icon.png");
            Competence vol = new Competence("Vol à la tire", 0, "Capacité à faire les poches d'une cible sans méfiance. Un voleur expérimenté a moins de chances d'être pris et est plus à même de dérober des objets de valeur.", "../Images/icones/Pickpocket_icon.png");
            Competence eloquence = new Competence("Eloquence", 0, "L'éloquence est l'une des six compétences du voleur. Elle peut être utilisée lors d'achats auprès des marchands de Bordeciel afin de réaliser les meilleures transactions possibles, mais aussi afin de persuader. d'autres personnages.", "../Images/icones/Speechcraft_icon.png");
            Competence alchimie = new Competence("Alchimie", 0, "L'alchimie est l'une des six compétences propre au personnage de la classe des Voleurs. La compétence Alchimie permet de créer des potions et des poisons.Les potions se boivent et permettent de se renforcer, de se soigner ou encore de se régénérer ; quant aux poisons, ils s'appliquent sur l'arme et permettent ainsi une sorte d'enchantement unique et utilisable une seule fois.", "../Images/icones/Alchemy_icon.png");
            Competence illusion = new Competence("Illusion", 0, "L'Illusion est une compétence dans The Elder Scrolls V: Skyrim. L'Illusion est l'une des 6 compétences du Mage.La magie d'illusion est une compétence améliorée par l'utilisation de certains types de sorts.Cette magie est axée sur la manipulation des PNJ. La magie d'illusion était déjà proposée dans les opus précédents. Elle comprenait des sorts ciblés tels que Charmer, Calmer, Frénésie, Silence, Démoraliser, Commander ou Rallier, et des sorts que l'on pouvait lancer sur soi - même comme Invisibilité, Caméléon, Lumière ou Vision de nuit. ", "../Images/icones/Illusion_icon.png");
            Competence conjuration = new Competence("Conjuration", 0, "Les pratiques de conjuration concernent la résurrection des morts et l'invocation de créatures d'Oblivion. Cette compétence facilite le lancement des sorts de conjuration, du sort de Capture d'âme et des sorts de captures. ", "../Images/icones/Conjuration_icon.png");
            Competence destruction = new Competence("Destruction", 0, "La Destruction est l'une des 6 compétences de la voie du Mage. La compétence de Destruction est une compétence qui s'améliore par l'utilisation de certains types de sorts. Ce sont des sorts dits de destruction axés principalement sur des dégâts directs et immédiats par le biais des sorts de feu, de glace et de foudre.", "../Images/icones/Destruction_icon.png");
            Competence guerison = new Competence("Guérison", 0, "La guérison est l'une des 6 compétences du Mage. La compétence de Guérison est une compétence améliorée par l'utilisation de certains types de sorts. Ce sont comme des sorts dits de restauration axés sur ​​la guérison et la protection.", "../Images/icones/Restoration_icon.png");
            Competence alteration = new Competence("Altération", 0, "L'École de l'Altération implique la manipulation du monde physique et de ses propriétés naturelles. Cette compétence permet de lancer des sorts comme Respiration sous l'eau Protection magique, et Paralysie.  L'Altération est l'une des 6 compétences du Mage. La compétence d'Altération est une compétence améliorée par l'utilisation de certains types de sorts.", "../Images/icones/Alteration_icon.png");
            Competence enchantement = new Competence("Enchantement", 0, "L'enchantement est une compétence dans The Elder Scrolls V: Skyrim et il s'agit de l'une des 6 compétences de la voie du mage. L'enchantement est l'art d'utiliser des gemmes sprirituelles pleines pour appliquer des effets magiques immuable et permanent sur l'objet désiré.L'enchantement est l'une des trois compétences de crafting disponible dans le jeu avec l'Alchimie et le Forgeage. ", "../Images/icones/Enchanting_icon.png");

            ensemble.AjouterCompetence(forgeage);
            ensemble.AjouterCompetence(armure_lourde);
            ensemble.AjouterCompetence(parade);
            ensemble.AjouterCompetence(deux_mains);
            ensemble.AjouterCompetence(une_main);
            ensemble.AjouterCompetence(archerie);
            ensemble.AjouterCompetence(armure_legere);
            ensemble.AjouterCompetence(furtivite);
            ensemble.AjouterCompetence(crochetage);
            ensemble.AjouterCompetence(vol);
            ensemble.AjouterCompetence(eloquence);
            ensemble.AjouterCompetence(alchimie);
            ensemble.AjouterCompetence(illusion);
            ensemble.AjouterCompetence(conjuration);
            ensemble.AjouterCompetence(destruction);
            ensemble.AjouterCompetence(guerison);
            ensemble.AjouterCompetence(alteration);
            ensemble.AjouterCompetence(enchantement);

            return ensemble;
        }

    }

}
