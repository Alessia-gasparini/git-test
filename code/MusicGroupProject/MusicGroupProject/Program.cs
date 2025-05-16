using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using MusicGroupProject.Repositories;
using MusicGroupProject.Services;
using MusicGroupProject.Utilities;
using MusicGroupProject.Models;

static void Main()
    {
        var repoGroups = new InMemoryRepository<MusicGroup>();
        var groupService = new GroupService(repoGroups);
        var setlistService = new SetlistService(groupService);

        var repoDays = new InMemoryRepository<ConcertDay>();
        var concertService = new ConcertService(repoDays, groupService);
        
        bool exit = false;
        while (!exit)
    {
        Console.WriteLine("1.Crea Gruppo");    
        Console.WriteLine("2.Elenca Gruppi");
        Console.WriteLine("3.Modifica Gruppo");
        Console.WriteLine("4.Elimina Gruppo");
        Console.WriteLine("5.Aggiungi Scaletta a Gruppo");
        Console.WriteLine("6.Visualizza Dettagli Gruppo");
        Console.WriteLine("7.Uscita");
        Console.WriteLine("8.Crea il giorno del concerto");
        Console.WriteLine("9.Assegna il gruppo al giorno");
        Console.WriteLine("10.Elenco dei giorni dei concerti");
        int choice = Utilities.PromptInt("Seleziona opzione: ");

        switch (choice)
        {
            case 1: groupService.CreateGroup(); break;
            case 2: groupService.ListGroups(); break;
            case 3: groupService.UpdateGroup(); break;
            case 4: groupService.DeleteGroup(); break;
            case 5: setlistService.AddSetlist(); break;
            case 6: groupService.ViewDetails(); break;
            case 7: exit = true; break;
            case 8: concertService.CreateConcertDay();break;
            case 9: concertService.AssignGroupToDay(); break;
            case 10: concertService.ListConcertDays(); break;
            default: Console.WriteLine("Opzione non valida."); break;
        }
    }
 }

Main();
