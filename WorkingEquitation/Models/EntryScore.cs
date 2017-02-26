using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class EntryScore
    {
        [Key]
        [Column(Order = 1)]
        public int MeetingId { get; set; }

        [Key]
        [Column(Order = 2)]
        public string ClassId { get; set; }

        [Key]
        [Column(Order = 3)]
        public int EntryId { get; set; }
        [Key]
        [Column(Order = 4)]
        public int EntryScoreId { get; set; }

        public int CrewId { get; set; }
        public string Position { get; set; }
        public double TotalPoints { get; set; }
        public double PointsPercent { get; set; }

        public EntryScore(int meetingId, string classId, int entryId, int entryScoreId, int crewId, string position, double totalPoints, double pointsPercent)
        {
            MeetingId = meetingId;
            ClassId = classId;
            EntryId = entryId;
            EntryScoreId = entryScoreId;
            CrewId = crewId;
            Position = position;
            TotalPoints = totalPoints;
            PointsPercent = pointsPercent;
        }
    }
}