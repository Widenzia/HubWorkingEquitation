using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.DataAccessLayer
{
    public class AppContext : DbContext
    {
        public AppContext() : base("DefaultConnection")
        {
        }

        public DbSet<Models.Class> db_Classes { get; set; }
        public DbSet<Models.Entry> db_Entrys { get; set; }
        public DbSet<Models.Horse> db_Horses { get; set; }
        public DbSet<Models.Rider> db_Riders { get; set; }
        public DbSet<Models.Show> db_Shows { get; set; }
        public DbSet<Models.ShowCrew> db_ShowCrews { get; set; }
        public DbSet<Models.EntryScore> db_EntryScores { get; set; }
        public DbSet<Models.Crew> db_Crews { get; set; }
    }
}