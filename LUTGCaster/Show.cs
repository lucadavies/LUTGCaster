using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUTGCaster
{
    public class Show
    {
        public string name;
        public List<string> roles;

        public Show(string name)
        {
            this.name = name;
            roles = new List<string>();
        }

        public void addRole(string rName)
        {
            roles.Add(rName);
        }
    }
}
