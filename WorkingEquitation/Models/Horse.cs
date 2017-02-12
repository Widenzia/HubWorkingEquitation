using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Horse
    {
        public int ShowId { get; set; }
        public int HorseId { get; set; }
        public string HorseName { get; set; }

        public Horse(int showId, int horseId, string horseName)
        {
            ShowId = showId;
            HorseId = horseId;
            HorseName = horseName;
        }
    }
}