using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

//interfaccia che garantisce la presenza di un ID
namespace MusicGroupProject.Models
{
    public interface IEntity
    {
        int Id { get; set; }
    }
}
