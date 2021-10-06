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
			this.name = name;
            roles = new List<Role>();
        }

        public void AddRole(string rName)
        {
            if (string.IsNullOrWhiteSpace(rName))
            {
                throw new ArgumentNullException(nameof(rName));
            }
            roles.Add(new Role(rName));
        }

        public class Role
        {
            public string rName;
            public List<string> names;

            public Role(string rName)
            {
                this.rName = rName;
                names = new List<string>(6)
                {
                    "",
                    "",
                    "",
                    "",
                    "",
                    ""
                };
            }
        }
    }
}
