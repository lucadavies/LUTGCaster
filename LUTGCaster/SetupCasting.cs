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

        private void numUDShows_ValueChanged(object sender, EventArgs e)
        {
            switch (numUDShows.Value)
            {
                case 1:
                    EnableShowBox(gBoxS1, true);
                    EnableShowBox(gBoxS2, false);
                    EnableShowBox(gBoxS3, false);
                    EnableShowBox(gBoxS4, false);
                    break;
                case 2:
                    EnableShowBox(gBoxS1, true);
                    EnableShowBox(gBoxS2, true);
                    EnableShowBox(gBoxS3, false);
                    EnableShowBox(gBoxS4, false);
                    break;
                case 3:
                    EnableShowBox(gBoxS1, true);
                    EnableShowBox(gBoxS2, true);
                    EnableShowBox(gBoxS3, true);
                    EnableShowBox(gBoxS4, false);
                    break;
                case 4:
                    EnableShowBox(gBoxS1, true);
                    EnableShowBox(gBoxS2, true);
                    EnableShowBox(gBoxS3, true);
                    EnableShowBox(gBoxS4, true);
                    break;
            }
        }

        private void EnableShowBox(GroupBox gb, bool enabled)
        {
            if (!enabled)
            {
                foreach (Control c in gb.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).Text = "";
                    }
                    else if (c is Panel)
                    {
                        foreach (Control pc in c.Controls)
                        {
                            if (pc is TextBox)
                            {
                                ((TextBox)pc).Text = "";
                            }
                        }
                    }
                }
                
            }
            gb.Enabled = enabled;
        }        
    }
}
