namespace WorkingEquitation.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WorkingEquitation.DataAccessLayer.AppContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WorkingEquitation.DataAccessLayer.AppContext context)
        {
            //  - hur göra för tävling samt cup med olika beräkningar? 
            //  - beräkningar i olika wiews?
            // HorseId ligga med i Rider-klass eller hur kopplar man häst/ar till en ryttare? Ny class tex RiderHorse där show-ryttare-häst kopplas ihop?

            // Classer med teknik- och speedhinder showid, classid

            // View med utskrift av huvudfunktionärer - SOS
            // utskrift protokoll dressyr, teknik, speed
            // utskrift startlistor
            // utskrift resultatlistor
            // ex startlista http://www.uppsalaponnyklubb.se/contentassets/02c3e970055440628ac202970d26fdbe/klubbdressyr-5-feb-2017.html#top


            //  This method will be called after migrating to the latest version.
            context.db_Shows.AddOrUpdate(new Show(1, new DateTime(2016, 8, 21, 8, 0, 0), "Working Equitation med KM"));
            context.db_Shows.AddOrUpdate(new Show(2, new DateTime(2017, 5, 28, 8, 0, 0), "Working Equitation MälarCup"));

            context.db_Crews.AddOrUpdate(new Crew(1, "Överdomare"));
            context.db_Crews.AddOrUpdate(new Crew(2, "Dressyrdomare"));
            context.db_Crews.AddOrUpdate(new Crew(3, "Hoppdomare"));
            context.db_Crews.AddOrUpdate(new Crew(4, "WEDomare"));
            context.db_Crews.AddOrUpdate(new Crew(5, "Tävlingsledare"));
            context.db_Crews.AddOrUpdate(new Crew(6, "Kontaktperson"));
            context.db_Crews.AddOrUpdate(new Crew(7, "Resultatansvarig"));
            context.db_Crews.AddOrUpdate(new Crew(8, "Banpersonal"));
            context.db_Crews.AddOrUpdate(new Crew(9, "In/Ut Collectingring"));
            context.db_Crews.AddOrUpdate(new Crew(10, "In/Ut Framhoppning"));
            context.db_Crews.AddOrUpdate(new Crew(11, "In/Ut Bana"));
            context.db_Crews.AddOrUpdate(new Crew(12, "Speaker"));
            context.db_Crews.AddOrUpdate(new Crew(13, "Protokollhämtare"));
            context.db_Crews.AddOrUpdate(new Crew(14, "Prisutdelare"));

            context.db_ShowCrews.AddOrUpdate(new ShowCrew(1, 6, 1, "Ulrika", "Pernler", 0, "018500749@telia.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(1, 7, 2, "Frida", "Engvall", 0, "fridaengvall@gmail.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(1, 4, 3, "Charlotta", "Ingvarsdotter", 0, "charlotta4@hotmail.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(1, 4, 4, "Åsa", "Tinnerholm", 0, "asa@cavaliera.se"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(1, 1, 5, "Ilse", "Eriksson", 0, "ilse_eriksson@hotmail.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(1, 5, 6, "Gabriella", "Pernler", 0, "upk@telia.com"));

            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 6, 1, "Ulrika", "Pernler", 0, "018500749@telia.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 7, 2, "Lena", "Widegren", 0, "lenawide@gmail.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 4, 3, "Charlotta", "Ingvarsdotter", 0, "charlotta4@hotmail.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 4, 4, "Åsa", "Tinnerholm", 0, "asa@cavaliera.se"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 4, 5, "Adriana", "Graucob", 0, "adriana.graucob@telia.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 1, 6, "Ulrika", "Pernler", 0, "018500749@telia.com"));
            context.db_ShowCrews.AddOrUpdate(new ShowCrew(2, 5, 7, "Gabriella", "Pernler", 0, "upk@telia.com"));

            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "1", 2, 3, 1, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "1", 3, 3, 2, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "2", -1, 3, 3, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "2", 1, 3, 4, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "2", 2, 3, 5, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "2", 3, 3, 6, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "3", -1, 3, 7, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "3", 1, 3, 8, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "3", 2, 3, 9, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "3", 3, 3, 10, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "3", 4, 3, 11, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "3", 5, 3, 12, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", -5, 4, 13, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", -3, 4, 14, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", -2, 4, 15, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", -1, 4, 16, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 1, 4, 17, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 2, 4, 18, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 3, 4, 19, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 4, 4, 20, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 5, 4, 21, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 6, 4, 22, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 7, 4, 23, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 9, 4, 24, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 10, 4, 25, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 11, 4, 26, "C", 0.0, 0.0));
            context.db_EntryScores.AddOrUpdate(new EntryScore(1, "4", 12, 4, 27, "C", 0.0, 0.0));

            context.db_Classes.AddOrUpdate(new Class(1, "1", "Svår", 3));
            context.db_Classes.AddOrUpdate(new Class(1, "2", "Msv", 3));
            context.db_Classes.AddOrUpdate(new Class(1, "3", "LA", 3));
            context.db_Classes.AddOrUpdate(new Class(1, "4", "LB", 4));
            context.db_Classes.AddOrUpdate(new Class(2, "1", "Svår", 3));
            context.db_Classes.AddOrUpdate(new Class(2, "2", "Msv", 3));
            context.db_Classes.AddOrUpdate(new Class(2, "3", "LA", 3));
            context.db_Classes.AddOrUpdate(new Class(2, "4", "LC", 4));
            context.db_Classes.AddOrUpdate(new Class(2, "5", "LB", 5));

            context.db_Horses.AddOrUpdate(new Horse(1, 18, "Majors Lovely Arwen"));
            context.db_Horses.AddOrUpdate(new Horse(1, 20, "Mr Clarence"));
            context.db_Horses.AddOrUpdate(new Horse(1, 24, "Roy"));
            context.db_Horses.AddOrUpdate(new Horse(1, 5, "Brudvik Pryder"));
            context.db_Horses.AddOrUpdate(new Horse(1, 14, "Granit"));
            context.db_Horses.AddOrUpdate(new Horse(1, 6, "Choohoo"));
            context.db_Horses.AddOrUpdate(new Horse(1, 16, "Laodikeia"));
            context.db_Horses.AddOrUpdate(new Horse(1, 21, "Müstik"));
            context.db_Horses.AddOrUpdate(new Horse(1, 26, "Black Ice"));
            context.db_Horses.AddOrUpdate(new Horse(1, 7, "Clarice Q"));
            context.db_Horses.AddOrUpdate(new Horse(1, 4, "Banjo"));
            context.db_Horses.AddOrUpdate(new Horse(1, 11, "Fielman"));
            context.db_Horses.AddOrUpdate(new Horse(1, 23, "Orlando CB (SWB)"));
            context.db_Horses.AddOrUpdate(new Horse(1, 29, "Tuilerie"));
            context.db_Horses.AddOrUpdate(new Horse(1, 2, "Arvak"));
            context.db_Horses.AddOrUpdate(new Horse(1, 1, "Aishitera"));
            context.db_Horses.AddOrUpdate(new Horse(1, 15, "Lancelot Du Fol"));
            context.db_Horses.AddOrUpdate(new Horse(1, 25, "Šamane"));
            context.db_Horses.AddOrUpdate(new Horse(1, 28, "Tubber Lad"));
            context.db_Horses.AddOrUpdate(new Horse(1, 9, "Dahlina"));
            context.db_Horses.AddOrUpdate(new Horse(1, 12, "Fredriksdals Tiffany"));
            context.db_Horses.AddOrUpdate(new Horse(1, 3, "Azamar"));
            context.db_Horses.AddOrUpdate(new Horse(1, 10, "Damasco"));
            context.db_Horses.AddOrUpdate(new Horse(1, 17, "Lindegaards Baltza"));
            context.db_Horses.AddOrUpdate(new Horse(1, 27, "Sobeloosa"));
            context.db_Horses.AddOrUpdate(new Horse(1, 13, "Glorius"));
            context.db_Horses.AddOrUpdate(new Horse(1, 30, "Unico"));

            context.db_Riders.AddOrUpdate(new Rider(1, 1, "Åsa", "Cidh", "Lagga Fältrittklubb", 18));
            context.db_Riders.AddOrUpdate(new Rider(1, 2, "Maria", "Jurestam", "Enköpings Fältrittklubb", 20));
            context.db_Riders.AddOrUpdate(new Rider(1, 3, "Malin", "Bergvall", "Mälarö Sportryttareförening", 24));
            context.db_Riders.AddOrUpdate(new Rider(1, 4, "Frida", "Axén", "Jälla Hästsportförening", 5));
            context.db_Riders.AddOrUpdate(new Rider(1, 5, "Malin", "Andersson", "Ridklubben Norrtälje Ryttare", 14));
            context.db_Riders.AddOrUpdate(new Rider(1, 6, "Jennie", "Jurestam", "Enköpings Fältrittklubb", 6));
            context.db_Riders.AddOrUpdate(new Rider(1, 7, "Malin", "Gullberg", "Ridklubben Norrtälje Ryttare", 16));
            context.db_Riders.AddOrUpdate(new Rider(1, 8, "Lena", "Karlsson", "Rotbrunna Ryttarförening", 21));
            context.db_Riders.AddOrUpdate(new Rider(1, 9, "Susanna", "Graucob", "Roslagens Rid och Körklubb", 26));
            context.db_Riders.AddOrUpdate(new Rider(1, 10, "Ilse", "Eriksson", "Uppsala Ponnyklubb", 7));
            context.db_Riders.AddOrUpdate(new Rider(1, 11, "Kristina", "Alderheim", "Piteå Rid & Körsällskap", 4));
            context.db_Riders.AddOrUpdate(new Rider(1, 12, "Karin", "Andersson", "Ridklubben Norrtälje Ryttare", 11));
            context.db_Riders.AddOrUpdate(new Rider(1, 13, "Malin", "Bergvall", "Mälarö Sportryttareförening", 23));
            context.db_Riders.AddOrUpdate(new Rider(1, 14, "Anne", "Engqvist", "Ridklubben Norrtälje Ryttare", 29));
            context.db_Riders.AddOrUpdate(new Rider(1, 15, "Edda", "Flink", "Heby Ryttarförening", 2));
            context.db_Riders.AddOrUpdate(new Rider(1, 16, "Rebecca", "Hamnstedt", "Dannemora Ridklubb", 1));
            context.db_Riders.AddOrUpdate(new Rider(1, 17, "Mimmi", "Törnqvist", "Rotbrunna Ryttarförening", 15));
            context.db_Riders.AddOrUpdate(new Rider(1, 18, "Catarina", "Helgezon", "Dannemora Ridklubb", 25));
            context.db_Riders.AddOrUpdate(new Rider(1, 19, "Isabelle", "Wiklund", "Sällskapet Segersta Sportryttare", 28));
            context.db_Riders.AddOrUpdate(new Rider(1, 20, "Moa", "Eriksson", "Gävle Fältrittklubb", 9));
            context.db_Riders.AddOrUpdate(new Rider(1, 21, "Saga", "Kumlin", "Uppsala Ponnyklubb", 12));
            context.db_Riders.AddOrUpdate(new Rider(1, 22, "Gabriella", "Pernler", "Uppsala Ponnyklubb", 3));
            context.db_Riders.AddOrUpdate(new Rider(1, 23, "Kaisa", "Sörén", "Uppsala Ponnyklubb", 10));
            context.db_Riders.AddOrUpdate(new Rider(1, 24, "Jacob", "Johansson", "Uppsala Dressyrsällskap", 17));
            context.db_Riders.AddOrUpdate(new Rider(1, 25, "Lotta", "Frithiof", "Uppsala Ponnyklubb", 27));
            context.db_Riders.AddOrUpdate(new Rider(1, 26, "Ulrika", "Dufwa", "Uppsala Ponnyklubb", 13));
            context.db_Riders.AddOrUpdate(new Rider(1, 27, "Pia", "Nylander", "Uppsala Ponnyklubb", 30));

            context.db_Entrys.AddOrUpdate(new Entry(1, "1", 2, 1, 18));
            context.db_Entrys.AddOrUpdate(new Entry(1, "1", 3, 2, 20));
            context.db_Entrys.AddOrUpdate(new Entry(1, "2", -1, 3, 24));
            context.db_Entrys.AddOrUpdate(new Entry(1, "2", 1, 4, 5));
            context.db_Entrys.AddOrUpdate(new Entry(1, "2", 2, 5, 14));
            context.db_Entrys.AddOrUpdate(new Entry(1, "2", 3, 6, 6));
            context.db_Entrys.AddOrUpdate(new Entry(1, "3", -1, 7, 16));
            context.db_Entrys.AddOrUpdate(new Entry(1, "3", 1, 8, 21));
            context.db_Entrys.AddOrUpdate(new Entry(1, "3", 2, 9, 26));
            context.db_Entrys.AddOrUpdate(new Entry(1, "3", 3, 10, 7));
            context.db_Entrys.AddOrUpdate(new Entry(1, "3", 4, 11, 4));
            context.db_Entrys.AddOrUpdate(new Entry(1, "3", 5, 12, 11));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", -5, 13, 23));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", -3, 14, 29));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", -2, 15, 2));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", -1, 16, 1));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 1, 17, 15));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 2, 18, 25));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 3, 19, 28));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 4, 20, 9));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 5, 21, 12));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 6, 22, 3));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 7, 23, 10));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 9, 24, 17));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 10, 25, 27));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 11, 26, 13));
            context.db_Entrys.AddOrUpdate(new Entry(1, "4", 12, 27, 30));

        }
    }
}
