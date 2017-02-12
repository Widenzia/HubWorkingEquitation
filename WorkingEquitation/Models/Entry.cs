using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Entry
    {
        public int ShowId { get; set; }
        public string ClassNo { get; set; }
        public int EntryId { get; set; }
        public int RiderId { get; set; }
        public int HorseId { get; set; }

        public Entry(int showId, string classNo, int entryId, int riderId, int horseId)
        {
            ShowId = showId;
            ClassNo = classNo;
            EntryId = entryId;
            RiderId = riderId;
            HorseId = horseId;
        }
    }
}