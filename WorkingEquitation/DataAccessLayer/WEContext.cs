using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.DataAccessLayer
{
    public class WEContext : DbContext
    {
        public WEContext() : base("WEContext")
        {
        }

        public DbSet<Models.Class> db_Classes { get; set; }
        public DbSet<Models.Crew> db_Crews { get; set; }
        public DbSet<Models.Entry> db_Entrys { get; set; }
        public DbSet<Models.EntryScore> db_EntryScores { get; set; }
        public DbSet<Models.Horse> db_Horses { get; set; }
        public DbSet<Models.Meeting> db_Meetings { get; set; }
        public DbSet<Models.MeetingCrew> db_MeetingCrews { get; set; }
        public DbSet<Models.Rider> db_Riders { get; set; }
    }
}