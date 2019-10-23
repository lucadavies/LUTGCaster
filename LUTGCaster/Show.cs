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

        public void addRole(string rName)
        {
            roles.Add(new Role(rName));
        }

        public class Role
        {
            public string name;
            public List<TextBox> boxes;

            public Role(string name)
            {
                this.name = name;
                boxes = new List<TextBox>();
            }

            public void addTextBox(TextBox tb)
            {
                boxes.Add(tb);
            }
        }
    }
}
