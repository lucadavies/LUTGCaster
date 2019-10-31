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
        int setupShows = 0;
        List<Show> shows = new List<Show>();
        List<GroupBox> showBoxes = new List<GroupBox>();

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
            shows = new List<Show>();

            foreach (GroupBox g in showBoxes)
            {
                Panel p = new Panel();
                TextBox t = new TextBox();
                foreach (Control c in g.Controls)
                {
                    if (c is Panel)
                    {
                        p = (Panel)c;
                    }
                    else if (c is TextBox)
                    {
                        t = (TextBox)c;
                    }
                }

                Show s = new Show(t.Text);
                s.addRole("Dave");
            }

            //if (!txtS1Name.Text.Equals(""))
            //{
            //    Show s = new Show(txtS1Name.Text);
            //    foreach (Control el in panS1.Controls)
            //    {
            //        if (!((TextBox)el).Text.Equals(""))
            //        {
            //            s.addRole(((TextBox)el).Text);
            //        }
            //    }
            //    shows.Add(s);
            //}
            //if (!txtS2Name.Text.Equals(""))
            //{
            //    Show s = new Show(txtS2Name.Text);
            //    foreach (Control el in panS2.Controls)
            //    {
            //        if (!((TextBox)el).Text.Equals(""))
            //        {
            //            s.addRole(((TextBox)el).Text);
            //        }
            //    }
            //    shows.Add(s);
            //}
            //if (!txtS3Name.Text.Equals(""))
            //{
            //    Show s = new Show(txtS3Name.Text);
            //    foreach (Control el in panS3.Controls)
            //    {
            //        if (!((TextBox)el).Text.Equals(""))
            //        {
            //            s.addRole(((TextBox)el).Text);
            //        }
            //    }
            //    shows.Add(s);
            //}
            //if (!txtS4Name.Text.Equals(""))
            //{
            //    Show s = new Show(txtS4Name.Text);
            //    foreach (Control el in panS4.Controls)
            //    {
            //        if (!((TextBox)el).Text.Equals(""))
            //        {
            //            s.addRole(((TextBox)el).Text);
            //        }
            //    }
            //    shows.Add(s);
            //}


            CastingSheet cs = new CastingSheet(shows);
            cs.Show();
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

        private void AddShow()
        {
            GroupBox gBox = new GroupBox
            {
                Location = new Point(12, 12 + (76 * (setupShows))),
                Name = "gBoxS" + (setupShows + 1),
                Size = new Size(320, 70),
                TabIndex = 7,
                TabStop = false,
                Text = "Show " + (setupShows + 1)
            };

            Label lblName = new Label
            {
                AutoSize = true,
                Location = new Point(6, 16),
                Name = "lblName" + (setupShows + 1),
                Size = new Size(35, 13),
                TabIndex = 1,
                Text = "Name"
            };

            Label lblChar = new Label
            {
                AutoSize = true,
                Location = new Point(6, 42),
                Name = "lblChar" + (setupShows + 1),
                Size = new Size(58, 13),
                TabIndex = 2,
                Text = "Characters"
            };

            TextBox txtSName = new TextBox
            {
                Location = new Point(70, 13),
                Name = "txtS1Name",
                Size = new Size(244, 20),
                TabIndex = 0
            };

            Panel panChars = new Panel
            {
                Location = new Point(70, 39),
                Name = "panS1",
                Size = new Size(300, 21),
                TabIndex = 28
            };

            TextBox txtChar1 = new TextBox
            {
                Location = new Point(0, 0),
                Margin = new Padding(0, 3, 0, 3),
                Name = "txtS" + (setupShows + 1) + "C1",
                Size = new Size(122, 20),
                TabIndex = 3
            };

            TextBox txtChar2 = new TextBox
            {
                Location = new Point(122, 0),
                Margin = new Padding(0, 3, 0, 3),
                Name = "txtS" + (setupShows + 1) + "C1",
                Size = new Size(122, 20)
            };

            gBox.Controls.Add(panChars);
            gBox.Controls.Add(lblName);
            gBox.Controls.Add(lblChar);
            gBox.Controls.Add(txtSName);
            panChars.Controls.Add(txtChar1);
            panChars.Controls.Add(txtChar2);
            Controls.Add(gBox);

            showBoxes.Add(gBox);
            setupShows += 1;
        }

        private void AddCharacter(int show)
        {
             
        }

        private void btnAddShow_Click(object sender, EventArgs e)
        {
            AddShow();
        }
    }
}
