using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using MusicGroupProject.Models;

namespace MusicGroupProject.Repositories
{
    //contratto CRUD per entità che implementano IEntity
    public interface IRepository<T> where T : IEntity

    {
        void Add(T item);
        IEnumerable<T> GetAll();
        T? GetByld(int id);
        void Update(T item);
        void Delete(int id);
    }
}
