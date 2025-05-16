using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using MusicGroupProject.Models;

namespace MusicGroupProject.Repositories
{
    public class InMemoryRepository <T> :IRepository<T> where T : IEntity

    {
        private readonly List<T>_items = new List<T>();
        public void Add(T item) => _items.Add(item);
        public IEnumerable<T> GetAll() => _items;
        public T? GetByld(int id) => _items.FirstOrDefault(x => x.Id == id);
        public void Update(T item)

        { 
          var idx =_items.FindIndex(x => x.Id==item.Id);
          if (idx >= 0) _items[idx] =item;
        }

        public void Delete(int id) => _items.RemoveAll(x => x.Id == id);
    }
}
