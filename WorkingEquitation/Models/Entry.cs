using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Entry
    {
        [Key, Column(Order = 1)]
        public int MeetingId { get; set; }

        [Key, Column(Order = 2)]
        public string ClassId { get; set; }

        [Key, Column(Order = 3)]
        public int EntryId { get; set; }

        public int RiderId { get; set; }
        public int HorseId { get; set; }

        //Foreign Composite Keys
        //[ForeignKey("Entry")]
        //[Column(Order = 1)]
        //public int MeetingId { get; set; }
        //[ForeignKey("Entry")]
        //[Column(Order = 2)]
        //public string ClassId { get; set; }
        //[ForeignKey("Entry")]
        //[Column(Order = 3)]
        //public int EntryId { get; set; }

        public Entry(int meetingId, string classId, int entryId, int riderId, int horseId)
        {
            MeetingId = meetingId;
            ClassId = classId;
            EntryId = entryId;
            RiderId = riderId;
            HorseId = horseId;
        }
    }
}