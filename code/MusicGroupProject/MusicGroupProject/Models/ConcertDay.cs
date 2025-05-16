using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;

namespace MusicGroupProject.Models
{
    //rappresenta una giornata di concerto con data e gruppi
    public class ConcertDay : IEntity
    { 
        public int Id { get; set; }
        public DateTime Date { get; set; } //date :data della giornata di concerto
        public List<MusicGroup> Groups {  get; set; } = new List<MusicGroup>(); // groups : i gruppi che suonano in quella data

        public ConcertDay(int id, DateTime date)
        {  
           Id = id; 
           Date = date; 
        }
        public override string ToString() // tostring() : stampa la data e inomi dei gruppi con numero di brani di brani previsti
        {
            string line = $"Day{Id}:{Date:yyyy-MM-dd}\n";
            foreach (var g in Groups)
                line += $"-{g.Name}(Setlist:{g.Setlist.Songs.Count}somgs)\n";
            return line;
        }
    }
}
