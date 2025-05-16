using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using MusicGroupProject.Models;
using MusicGroupProject.Utilities;

namespace MusicGroupProject.Services
{
    internal class SetlistService
    {
        private readonly GroupService _groupService;
        public SetlistService(GroupService groupService) => _groupService = groupService;

        public void AddSetlist()
        {
            int id = Utilities.Utilities.PromptInt("ID gruppo per la scaletta: ");
            var group = _groupService.GetByld(id);
            if (group == null) { Console.WriteLine("Gruppo non trovato."); return; }

            var songs = Utilities.Utilities.PromptCsv("Inserisci i brani (separati da (,)): ");
            group.Setlist.Songs.AddRange(songs);
            Console.WriteLine("Lista aggiornata con successo.");
        }
    }
}
