using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LUTGCaster
{
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
