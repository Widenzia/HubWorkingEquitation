using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WorkingEquitation.Models
{
    public class Class
    {
        public int ShowId { get; set; }
        [Key]
        public string ClassNo { get; set; }
        public string Level { get; set; }
        public int ClassCrewId { get; set; }

        public Class(int showId, string classNo, string level, int classCrewId)
        {
            ShowId = showId;
            ClassNo = classNo;
            Level = level;
            ClassCrewId = classCrewId;
        }
    }
}