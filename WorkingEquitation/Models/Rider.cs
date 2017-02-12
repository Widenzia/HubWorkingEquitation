using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Rider
    {
        public int ShowId { get; set; }
        public int RiderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClubTeam { get; set; }
        public int HorseId { get; set; }

        public Rider(int showId, int riderId, string firstName, string lastName, string clubTeam, int horseId)
        {
            ShowId = showId;
            RiderId = riderId;
            FirstName = firstName;
            LastName = lastName;
            ClubTeam = clubTeam;
            HorseId = horseId;
        }
    }
}