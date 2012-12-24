using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamper.Model
{
    public class Lookups
    {
        public IList<Room> Rooms { get; set; }
        public IList<TimeSlot> TimeSlots { get; set; }
        public IList<Track> Tracks { get; set; }
    }
}
