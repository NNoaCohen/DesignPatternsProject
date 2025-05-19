using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Proxy_design
{
    public class User
    {
        public string Name { get; }
        public bool HasPermission { get; } // האם יש למשתמש הרשאה לספרים נדירים

        public User(string name, bool hasPermission)
        {
            Name = name;
            HasPermission = hasPermission;
        }
    }
}
