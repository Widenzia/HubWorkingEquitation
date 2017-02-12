using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Show
    {
        public int ShowId { get; set; }
        public DateTime Date { get; set; }
        public string ShowName { get; set; }

        public Show(int showId, DateTime date, string showName)
        {
            ShowId = showId;
            Date = date;
            ShowName = showName;
        }
    }
}