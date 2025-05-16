using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Linq;
using MusicGroupProject.Models;
using MusicGroupProject.Repositories;
using MusicGroupProject.Utilities;

namespace MusicGroupProject.Services
{
    public class GroupService
    {
        private readonly IRepository<MusicGroup> _repo;
        public GroupService(IRepository<MusicGroup> repo) => _repo = repo;

        public void CreateGroup()
        {
            int id = _repo.GetAll().Count() + 1;
            string name = Utilities.Utilities.PromptString("Nome gruppo:");
            var group =new MusicGroup(id, name);

            foreach(var m in Utilities.Utilities.PromptCsv("Membri (separati da virgola):"))

            {
                string role = Utilities.Utilities.PromptString($"Ruolo di {m}:");
                group.Members.Add(new Member(m,role));
            }

            foreach(var i in Utilities.Utilities.PromptCsv("Strumenti (separati da virgola):"))
            {
                string type = Utilities.Utilities.PromptString($"Tipo di {i}:");
                group.Instruments.Add(new Instrument(i,type));
            }

            _repo.Add(group);
            Console.WriteLine(("Gruppo creato con successo."));
        }

        public void ListGroups()
        {
            foreach(var g in _repo.GetAll()) 
                Console.WriteLine(g);
        }

        public void UpdateGroup()
        { 
            int id = Utilities.Utilities.PromptInt("Inserisci ID per aggiornare:");
            var g = _repo.GetByld(id);
            if(g == null) { Console.WriteLine("Gruppo non trovato"); return; }
            string name = Utilities.Utilities.PromptString($"Nuovo nome ({g.Name})", allowEmpty:true);
            if (!string.IsNullOrEmpty(name)) g.Name = name;
            _repo.Update(g);
            Console.WriteLine("Gruppo aggiornato con successo.");
        }

        public void DeleteGroup()
        {
            int id = Utilities.Utilities.PromptInt("Entra con ID per visualizzare: ");
            _repo.Delete(id);
            Console.WriteLine("Gruppo eliminato con successo");
        }

        public void ViewDetails()
        {
            int id = Utilities.Utilities.PromptInt("Entra con ID per visualizzare: ");
            var g = _repo.GetByld(id);
            Console.WriteLine(g != null ? $"Gruppo trovato: {g}" : "Errore: Gruppo non trovato.");
        }

        public MusicGroup? GetByld(int id) => _repo.GetByld(id);
    }
}
