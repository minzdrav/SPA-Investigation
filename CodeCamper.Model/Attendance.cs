using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamper.Model
{
    public class Attendance
    {
        public int PersonId { get; set; }
        public Person Person { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        [Range(0, 5)]
        public int Rating { get; set; }

        public string Text { get; set; }
    }
}
