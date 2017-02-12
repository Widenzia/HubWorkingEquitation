using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class ShowCrew
    {
        public int ShowId { get; set; }
        public int CrewId { get; set; }
        public int ShowCrewId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }

        public ShowCrew(int showId, int crewId, int showCrewId, string firstName, string lastName, int phoneNo, string email)
        {
            ShowId = showId;
            CrewId = crewId;
            ShowCrewId = showCrewId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
        }
    }
}