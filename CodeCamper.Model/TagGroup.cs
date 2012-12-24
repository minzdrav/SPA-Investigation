using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamper.Model
{
    public class TagGroup
    {
        public string Tag { get; set; }
        public ICollection<int> Ids { get; set; } 
    }
}
