using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Meeting
    {
        [Key, Column(Order = 1)]
        public int MeetingId { get; set; }

        [Key, Column(Order = 2)]
        public DateTime Date { get; set; }

        public string MeetingName { get; set; }

        public Meeting(int meetingId, DateTime date, string meetingName)
        {
            MeetingId = meetingId;
            Date = date;
            MeetingName = meetingName;
        }
    }
}