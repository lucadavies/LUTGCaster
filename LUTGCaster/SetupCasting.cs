using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LUTGCaster
{
    public partial class SetupCasting : Form
    {
        public SetupCasting()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Show> shows = new List<Show>();
            if (!txtS1Name.Text.Equals(""))
            {
                Show s = new Show(txtS1Name.Text);
                foreach (Control el in panS1.Controls)
                {
                    if (!((TextBox)el).Text.Equals(""))
                    {
                        s.addRole(((TextBox)el).Text);
                    }
                }
                shows.Add(s);
            }
            if (!txtS2Name.Text.Equals(""))
            {
                Show s = new Show(txtS2Name.Text);
                foreach (Control el in panS2.Controls)
                {
                    if (!((TextBox)el).Text.Equals(""))
                    {
                        s.addRole(((TextBox)el).Text);
                    }
                }
                shows.Add(s);
            }
            if (!txtS3Name.Text.Equals(""))
            {
                Show s = new Show(txtS3Name.Text);
                foreach (Control el in panS3.Controls)
                {
                    if (!((TextBox)el).Text.Equals(""))
                    {
                        s.addRole(((TextBox)el).Text);
                    }
                }
                shows.Add(s);
            }
            if (!txtS4Name.Text.Equals(""))
            {
                Show s = new Show(txtS4Name.Text);
                foreach (Control el in panS4.Controls)
                {
                    if (!((TextBox)el).Text.Equals(""))
                    {
                        s.addRole(((TextBox)el).Text);
                    }
                }
                shows.Add(s);
            }


            CastingSheet cs = new CastingSheet(shows);
            cs.Show();
        }
    }
}
