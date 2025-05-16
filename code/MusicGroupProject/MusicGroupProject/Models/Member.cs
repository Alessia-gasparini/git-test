using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace MusicGroupProject.Models
{
    public class Member
    {
        public string Name { get; set; }
        public string Role { get; set; }

        public Member(string name, string role)
        {
            Name = name;
            Role = role;

        }
        public override string ToString() => $"{Name} ({Role})";
    }
}
