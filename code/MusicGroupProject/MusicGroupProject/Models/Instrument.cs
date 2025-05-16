using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System; 

namespace MusicGroupProject.Models
    //strumento musicale con nome e categora
{
    public class Instrument

    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Instrument(string name, string type)
        {
            Name = name;
            Type = type;
        }
        public override string ToString()=>$"{Name} [{Type}]";
    }
}