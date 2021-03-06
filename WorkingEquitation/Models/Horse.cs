﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Horse
    {
        [Key, Column(Order = 1)]
        public int MeetingId { get; set; }

        [Key, Column(Order = 2)]
        public int HorseId { get; set; }

        public string HorseName { get; set; }

        public Horse(int meetingId, int horseId, string horseName)
        {
            MeetingId = meetingId;
            HorseId = horseId;
            HorseName = horseName;
        }
    }
}