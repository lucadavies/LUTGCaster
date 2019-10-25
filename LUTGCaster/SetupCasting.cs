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

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateCastingSheet();
        }

        /// <summary>
        /// Extracts show information from this form and contructs a list of Show objects to intantiate a new CastinSheet with.
        /// </summary>
        private void GenerateCastingSheet()
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

        private void NumUDShows_ValueChanged(object sender, EventArgs e)
        {
            EnableDisableShowBoxes();
        }

        /// <summary>
        /// Enables / disables show box based on value of selector for numebr of shows
        /// </summary>
        private void EnableDisableShowBoxes()
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

        /// <summary>
        /// Enables / disables shows boxes and blanks their child controls
        /// </summary>
        /// <param name="gb">Show box (groupBox) to enable/disable</param>
        /// <param name="enabled"></param>
        private void EnableShowBox(GroupBox gb, bool enabled)
        {
            if (!enabled)
            {
                foreach (Control c in gb.Controls)
                {
                    if (c is TextBox)   //blank title box
                    {
                        ((TextBox)c).Text = "";
                    }
                    else if (c is Panel)
                    {
                        foreach (Control pc in c.Controls)  //blank all role boxes
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
