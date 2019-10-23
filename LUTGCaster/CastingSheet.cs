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
    public partial class CastingSheet : Form
    {

        List<TextBox> nameBoxes;
        List<Show> shows;

        public CastingSheet(List<Show> shows)
        {
            InitializeComponent();
            this.shows = shows;
            initDyn();
        }

        private void initDyn()
        {
            nameBoxes = new List<TextBox>();
            foreach (Show s in shows)
            {
                GroupBox gBox = new GroupBox();
                for (int i = 0; i < s.roles.Count; i++)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        TextBox tb = new TextBox();
                        tb = new TextBox();
                        gBox = (GroupBox)Controls.Find("gBoxS" + (shows.IndexOf(s) + 1), false)[0];
                        gBox.Controls.Add(tb);
                        gBox.Text = s.name;
                        tb.BackColor = SystemColors.Window;
                        tb.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        tb.Location = new Point(74 + (i * 122), 39 + (j * 20));
                        tb.Margin = new Padding(0);
                        string st = "lblS" + (shows.IndexOf(s) + 1) + "C" + (i + 1);
                        Label l = (Label)Controls.Find("lblS" + (shows.IndexOf(s) + 1) + "C" + (i + 1), true)[0];
                        l.Text = s.roles[i].name;
                        string n = "txtS1C" + (i + 1);
                        switch (j)
                        {
                            case 0:
                                n += "a";
                                break;
                            case 1:
                                n += "b";
                                break;
                            case 2:
                                n += "c";
                                break;
                            case 3:
                                n += "d";
                                break;
                            case 4:
                                n += "e";
                                break;
                            case 5:
                                n += "f";
                                break;
                        }
                        tb.Name = n;
                        tb.Size = new Size(122, 20);
                        tb.TabIndex = 7;
                        tb.TextChanged += new EventHandler(UpdateAllColours);
                        nameBoxes.Add(tb);
                        s.roles[i].addTextBox(tb);

                    }
                }
            }

        }

        private void UpdateColours(TextBox tb)
        {
            string name = tb.Text;
            if (!name.Equals(""))
            {

                int countOther = 0;
                int countFirst = 0;
                List<TextBox> toColour = new List<TextBox>();
                foreach (TextBox nb in nameBoxes)
                {
                    if (nb.Text.Equals(name))
                    {
                        if (nb.Name[nb.Name.Length - 1].Equals('a'))
                        {
                            countFirst++;
                        }
                        else
                        {
                            countOther++;
                        }
                        toColour.Add(nb);
                    }
                }
                foreach (TextBox t in toColour)
                {
                    t.ForeColor = Color.Black;
                    switch (countFirst)
                    {
                        case 0:
                            t.BackColor = Color.DarkSeaGreen;
                            break;
                        case 1:
                            if (countOther == 0)
                            {
                                t.BackColor = Color.YellowGreen;    //1 1st choice
                            }
                            else
                            {
                                t.BackColor = Color.Yellow;         //1 1st choice + other
                            }
                            break;
                        case 2:
                            if (countOther == 0)
                            {
                                t.BackColor = Color.DarkTurquoise;      //2 1st choice
                            }
                            else
                            {
                                t.BackColor = Color.Goldenrod;           //2 1st choice + other
                            }
                            break;
                        case 3:
                            if (countOther == 0)
                            {
                                t.BackColor = Color.SteelBlue;      //3 1st choice
                            }
                            else
                            {
                                t.BackColor = Color.DarkOrange;     //3 1st choice + other
                            }
                            break;
                        case 4:
                            if (countOther == 0)
                            {
                                t.BackColor = Color.DarkSlateBlue;       //4 1st choice
                                t.ForeColor = Color.White;

                            }
                            else
                            {
                                t.BackColor = Color.Red;            //4 1st choice + other
                            }
                            break;
                        default:
                            //t.BackColor = Color.Gray;
                            break;
                    }
                }
            }
            if (name.Equals(""))
            {
                tb.BackColor = Color.White;
            }
        }

        private void UpdateAllColours(object sender, EventArgs e)
        {
            foreach (TextBox t in nameBoxes)
            {
                Console.WriteLine(t.Name);
                UpdateColours(t);
            }
        }

        //private void DetectLocks(TextBox tb)
        //{
        //    List<TextBox> appearBelow = new List<TextBox>();
        //    List<TextBox> appearAbove = new List<TextBox>();
        //    List<string> cA = new List<string>();
        //    List<string> cB = new List<string>();
        //    int pos = (int)char.GetNumericValue(tb.Name[tb.Name.Length - 1]);
        //    int show = (int)char.GetNumericValue(tb.Name[4]);
        //    int character = (int)char.GetNumericValue(tb.Name[6]);
        //    foreach (Show s in shows)
        //    {
        //        Console.WriteLine(tb.Name[4]);
        //        Console.WriteLine(Convert.ToChar(shows.IndexOf(s) + 1));
        //        if (tb.Name[4].Equals(Convert.ToChar(shows.IndexOf(s) + 1)))
        //        {
        //            foreach (Show.Role r in s.roles)
        //            {
        //                cA.Add(r.name);
        //            }
        //        }
        //        else
        //        {
        //            foreach (Show.Role r in s.roles)
        //            {
        //                cB.Add(r.name);
        //            }
        //        }
                
        //    }

        //}

        private void btnChkBlk_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in nameBoxes)
            {
                DetectLocks(tb);
            }
        }
    }
}
