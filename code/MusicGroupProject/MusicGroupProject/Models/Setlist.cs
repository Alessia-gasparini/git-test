using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace MusicGroupProject.Models
{
    //scaletta di canzoni per un concerto
    public class Setlist
    {
        public List<string> Songs { get; set; } = new List<string>();

        public override string ToString()

        { return Songs.Count == 0
                ? "(Niente canzoni)"
                : string.Join("->", Songs);
        }
    }
}
