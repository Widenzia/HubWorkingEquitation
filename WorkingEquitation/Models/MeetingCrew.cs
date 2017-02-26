using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class MeetingCrew
    {
        public int MeetingId { get; set; }
        public int MeetingCrewId { get; set; }
        public int CrewId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNo { get; set; }
        public string Email { get; set; }

        public MeetingCrew(int meetingId, int crewId, int meetingCrewId, string firstName, string lastName, int phoneNo, string email)
        {
            MeetingCrewId = meetingCrewId;
            MeetingId = meetingId;
            CrewId = crewId;
            FirstName = firstName;
            LastName = lastName;
            PhoneNo = phoneNo;
            Email = email;
        }
    }
}