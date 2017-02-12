using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class EntryScore
    {
        public int ShowId { get; set; }
        public string ClassNo { get; set; }
        public int EntryId { get; set; }
        public int CrewId { get; set; }
        public int EntryScoreId { get; set; }
        public string Position { get; set; }
        public double TotalPoints { get; set; }
        public double PointsPercent { get; set; }

        public EntryScore(int showId, string classNo, int entryId, int crewId, int entryScoreId, string position, double totalPoints, double pointsPercent)
        {
            ShowId = showId;
            ClassNo = classNo;
            EntryId = entryId;
            CrewId = crewId;
            EntryScoreId = entryScoreId;
            Position = position;
            TotalPoints = totalPoints;
            PointsPercent = pointsPercent;
        }
    }
}