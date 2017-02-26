using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Crew
    {
        public int CrewId { get; set; }
        public string Position { get; set; }

        public Crew(int crewId, string position)
        {
            CrewId = crewId;
            Position = position;
        }
    }
}

