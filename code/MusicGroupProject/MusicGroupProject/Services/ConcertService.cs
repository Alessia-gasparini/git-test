using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using MusicGroupProject.Models;
using MusicGroupProject.Repositories;
using MusicGroupProject.Utilities;
using System.Linq;
using System.Globalization;


namespace MusicGroupProject.Services
{
    public class ConcertService
    {
        private readonly IRepository<ConcertDay> _repo;
        private readonly GroupService _groupService;

        public ConcertService(IRepository<ConcertDay> repo, GroupService groupService)
        {
            _repo = repo;
            _groupService = groupService;
        }
        public void CreateConcertDay()
        {
            int id = _repo.GetAll().Count() + 1;
            string dateStr = Utilities.Utilities.PromptString("Immetti la data(yyyy-MM-dd): ");
            if (!DateTime.TryParseExact(dateStr, "yyyy-MM-dd", CultureInfo.InvariantCulture,
                DateTimeStyles.None, out DateTime date))

            {
                Console.WriteLine("Formato non valido. Usa yyyy-MM-dd");
                return;
            }

            if(_repo.GetAll().Any(d=> d.Date.Date == date.Date))
            {
                Console.WriteLine("Esiste gia una giornata per questa data.");
                    return;
            }

            var day = new ConcertDay(id, date);
            _repo.Add(day);
            Console.WriteLine("Giorno per il concerto creato.");
        }
        public void AssignGroupToDay()
        {
            int dayId = Utilities.Utilities.PromptInt("ID Giorno:");
            var day = _repo.GetByld(dayId);
            if(day == null) {Console.WriteLine("Giorno non trovato."); return;}
        
            int groupId = Utilities.Utilities.PromptInt("ID Gruppo assegnato:");
            var group = _groupService.GetByld(groupId);
            if (group == null) {Console.WriteLine("Gruppo non trovato."); return;}

            day.Groups.Add(group);
            _repo.Update(day);
            Console.WriteLine($"Gruppo{group.Name}assegnato al giorno{day.Date:yyyy-MM-dd}.");
        }
        public void ListConcertDays()
        {
            foreach (var d in _repo.GetAll())
            Console.WriteLine(d);
        }
    }
}
