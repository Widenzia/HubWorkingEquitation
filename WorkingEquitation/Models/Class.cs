using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorkingEquitation.Models
{
    public class Class
    {
        public int ClassId { get; set; }
        public int MeetingId { get; set; }
        public string ClassNo { get; set; }
        public string Level { get; set; }
        public int ClassCrewId { get; set; }

        public Class( int meetingId, string classNo, string level, int classCrewId)
        {
            MeetingId = meetingId;
            ClassNo = classNo;
            Level = level;
            ClassCrewId = classCrewId; //Judges
        }
    }
}