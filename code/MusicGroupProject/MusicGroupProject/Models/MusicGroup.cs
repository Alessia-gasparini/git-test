using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace MusicGroupProject.Models
{
    //members e struments contengono liste di oggetti specifici
    public class MusicGroup :IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; } // ToString() restituisce una stampa formattta dei dati
        public List<Member> Members { get; set; } 
        public List<Instrument>Instruments { get; set; }
        public Setlist Setlist { get; set; }

        public MusicGroup(int id, string name)
        {
            Id = id;
            Name = name;
            Members = new List<Member>();
            Instruments = new List<Instrument>();
            Setlist = new Setlist();
        }

        public override string ToString() 
        {
            return $"ID:{Id}\n" +
                $"Name:{Name}\n" +
                $"Members:{string.Join(",", Members)}\n" +
                $"Instruments:{string.Join(",", Instruments)}\n" +
                $"Setlist:{Setlist}\n";
        }
    }
}