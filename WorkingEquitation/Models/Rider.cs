using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WorkingEquitation.Models
{
    public class Rider
    {
        [Column(Order = 1), Key, ForeignKey("Horse")]
        public int MeetingId { get; set; }

        [Column(Order = 2), Key]
        public int RiderId { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ClubTeam { get; set; }

        [Column(Order = 3), ForeignKey("Horse")]
        public int HorseId { get; set; }

        public Rider(int meetingId, int riderId, string firstName, string lastName, string clubTeam, int horseId)
        {
            MeetingId = meetingId;
            RiderId = riderId;
            FirstName = firstName;
            LastName = lastName;
            ClubTeam = clubTeam;
            HorseId = horseId;
        }

        //Navigation  property
        public virtual Horse Horse { get; set; }

        //[Key, Column(Order = 1)]
        //public int MeetingId { get; set; }

        //[Key, Column(Order = 2)]
        //public int HorseId { get; set; }

        //public class NotificationMessageDevice
        //{
        //    [Column(Order = 0), Key, ForeignKey("Horse")]
        //    public int NotificationMessage_ID { get; set; }

        //    [Column(Order = 1), Key, ForeignKey("Device")]
        //    public int Device_ID { get; set; }
        //    [Column(Order = 2), Key, ForeignKey("Device")]
        //    public string Device_UDID { get; set; }
        //    [Column(Order = 3), Key, ForeignKey("Device")]
        //    public string Device_ApplicationKey { get; set; }

        //    public virtual Device Device { get; set; }
        //    public virtual NotificationMessage NotificationMessage { get; set; }
        //}

    }
}