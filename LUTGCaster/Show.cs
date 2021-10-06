using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUTGCaster
{
    public class Show
    {
        public string name;
        public List<Role> roles;

        public Show(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }
            this.name = name;
            roles = new List<Role>();
        }

        public void AddRole(string rName)
        {
            if (rName is null)
            {
                throw new ArgumentNullException(nameof(rName));
            }
            roles.Add(new Role(rName));
        }
    }
}
