using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using Newtonsoft.Json;

namespace LUTGCaster
{
    public partial class CastingSheet : Form
    {

        List<TextBox> nameBoxes;
        List<Show> shows;
        Regex alphaNumSlashRgx = new Regex("[^a-zA-Z0-9/.' -]");

        public CastingSheet(List<Show> shows)
        {
            InitializeComponent();
            this.shows = shows;
            InitDyn();
        }

        /// <summary>
        /// Initialises the Casting Sheet by populating the form with the required numebr of textboxes for roles and labelling things accordingly.
        /// Role textbox names are in the format: txtSxCyz where x is the show number, y is the character number and z is a letter (a-f) representign choices 1-6
        /// Cast button names are in the format: btncastSxCy where x is the show number and y is the character number
        /// </summary>
        private void InitDyn()
        {
            nameBoxes = new List<TextBox>();
            foreach (Show s in shows) //loop thorugh all shows
            {
                int index = shows.IndexOf(s);
                GroupBox gBox = new GroupBox
                {
                    Location = new Point(12, 12 + (198 * index)),
                    Name = "gBoxS" + (index + 1),
                    Padding = new Padding(3, 3, 3, 10),
                    Size = new Size(1544, 192),
                    TabIndex = index,
                    TabStop = false,
                    Text = "<Show " + index + ">"
                };
                Controls.Add(gBox);

                Label lblCharHead = new Label
                {
                    AutoSize = true,
                    Location = new Point(6, 37),
                    Name = "lblCharHead" + index,
                    Padding = new Padding(0, 5, 0, 5),
                    Size = new Size(53, 23),
                    TabIndex = 0,
                    Text = "Character"
                };
                gBox.Controls.Add(lblCharHead);

                for (int i = 0; i < 6; i++)
                {
                    Label lbl = new Label
                    {
                        AutoSize = true,
                        BorderStyle = BorderStyle.FixedSingle,
                        Location = new Point(6, 63 + (20 * i)),
                        MinimumSize = new Size(65, 2),
                        Name = "lblChoiceHeadS" + index,
                        Padding = new Padding(0, 2, 0, 3),
                        Size = new Size(65, 20),
                        TabIndex = 1
                    };
                    switch (i)
                    {
                        case 0:
                            lbl.Name += "a";
                            lbl.Text = "1st Choice";
                            break;
                        case 1:
                            lbl.Name += "b";
                            lbl.Text = "2nd Choice";
                            break;
                        case 2:
                            lbl.Name += "c";
                            lbl.Text = "3rd Choice";
                            break;
                        case 3:
                            lbl.Name += "d";
                            lbl.Text = "4th Choice";
                            break;
                        case 4:
                            lbl.Name += "e";
                            lbl.Text = "5th Choice";
                            break;
                        case 5:
                            lbl.Name += "f";
                            lbl.Text = "6th Choice";
                            break;
                    }
                    gBox.Controls.Add(lbl);
                }

                for (int i = 0; i < s.roles.Count; i++) //loop through all roles for Show
                {
                    Button btn = new Button
                    {
                        Location = new Point(71 + (i * 122), 16),
                        Name = "btnCastS" + (shows.IndexOf(s) + 1) + "C" + (i + 1),
                        Size = new Size(122, 20),
                        Text = "Cast",
                        UseVisualStyleBackColor = true
                    };
                    btn.Click += new EventHandler(CastCharacter);
                    gBox.Controls.Add(btn);

                    Label l = new Label
                    {
                        AutoSize = true,
                        Location = new Point(71 + (i * 122), 37),
                        Name = "lbl" + (shows.IndexOf(s) + 1) + "C" + (i + 1),
                        Padding = new Padding(0, 5, 0, 5),
                        Size = new Size(44, 23),
                        Text = s.roles[i].rName
                    };
                    gBox.Controls.Add(l);

                    for (int j = 0; j < 6; j++) //loop to create six TextBoxes 
                    {
                        TextBox tb = new TextBox
                        {
                            BackColor = SystemColors.Window,
                            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                            Location = new Point(74 + (i * 122), 63 + (j * 20)),
                            Margin = new Padding(0)
                        };
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
                        tb.DoubleClick += new EventHandler(Tb_DoubleClick);
                        tb.LostFocus += new EventHandler(UpdateShowData);
                        gBox.Controls.Add(tb);
                        gBox.Text = s.name;
                        nameBoxes.Add(tb);
                        tb.Text = s.roles[i].names[j];

                    }
                }
                Height += 198; //enlarge form to fit number of shows
            }
        }

        /// <summary>
        /// Event handler: Called by all "Cast" buttons. To show a cast role, disables all textboxes for the role, bolds the top choice
        /// </summary>
        /// <param rName="sender"></param>
        /// <param rName="e"></param>
        private void CastCharacter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Console.WriteLine(btn.Name);
            List<TextBox> charTBs = new List<TextBox>();
            foreach (TextBox t in nameBoxes)
            {
                if (t.Name.Substring(3, t.Name.Length - 1).Equals(btn.Name.Substring(7)))
                {
                    charTBs.Add(t);
                }
            }
            foreach (TextBox t in charTBs)
            {
                if (!t.ReadOnly)      //disable if enabled
                {
                    t.ReadOnly = true;
                    if (t.Name[t.Name.Length - 1].Equals('a')) //bold if first choice
                    {
                        t.Font = new Font(t.Font, FontStyle.Bold);
                    }
                    else
                    {
                        t.Visible = false;
                    }
                }
                else      //enable if disabled

                {
                    t.ReadOnly = false;
                    if (t.Name[t.Name.Length - 1].Equals('a')) //unbold if first choice
                    {
                        t.Font = new Font(t.Font, FontStyle.Regular);
                    }
                    else
                    {
                        t.Visible = true;
                    }
                }

            }
        }

        /// <summary>
        /// Checks for duplicate names in ALL other textboxes present on sheet, colours each textbox accordingly
        /// </summary>
        /// <param rName="tb">Textbox rName to check against</param>
        private void UpdateColours(TextBox tb)
        {
            string name = tb.Text;
            if (!name.Equals(""))
            {

                int countOther = 0;
                int countFirst = 0;
                List<TextBox> toColour = new List<TextBox>();
                foreach (TextBox nb in nameBoxes)   //count all first choice appearances and other appearacnes
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
                foreach (TextBox t in toColour) //colour all textboxes found with same rName the same colour
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
                    }
                }
            }
            if (name.Equals(""))
            {
                tb.BackColor = Color.White;
            }
        }

        /// <summary>
        /// Event handler: called when any textbox raises TextChanged event. Calls UpdateColours for all textboxes.
        /// </summary>
        /// <param rName="sender"></param>
        /// <param rName="e"></param>
        private void UpdateAllColours(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.Text = alphaNumSlashRgx.Replace(tb.Text, "");
            tb.SelectionStart = tb.Text.Length;
            tb.SelectionLength = 0;
            foreach (TextBox t in nameBoxes)
            {
                UpdateColours(t);
            }
        }

        private void UpdateShowData(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int showNum = (int)char.GetNumericValue(((Control)sender).Parent.Name, 5) - 1;       //get show number from parent (groupBox) name
            string temp = tb.Name.Substring(6, tb.Name.Length == 8 ? 1 : 2);
            int charNum = int.Parse(temp) - 1; //ternary to check if it's a single or two digit character number
            int choiceNum;
            switch (tb.Name[tb.Name.Length - 1])
            {
                case 'a':
                    choiceNum = 0;
                    break;
                case 'b':
                    choiceNum = 1;
                    break;
                case 'c':
                    choiceNum = 2;
                    break;
                case 'd':
                    choiceNum = 3;
                    break;
                case 'e':
                    choiceNum = 4;
                    break;
                case 'f':
                    choiceNum = 5;
                    break;
                default:
                    choiceNum = -1;
                    break;
            }
            shows[showNum].roles[charNum].names[choiceNum] = tb.Text;
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
        //                cA.Add(r.rName);
        //            }
        //        }
        //        else
        //        {
        //            foreach (Show.Role r in s.roles)
        //            {
        //                cB.Add(r.rName);
        //            }
        //        }

        //    }

        //}

        private void BtnChkBlk_Click(object sender, EventArgs e)
        {
            foreach (TextBox tb in nameBoxes)
            {
                //DetectLocks(tb);
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            string fileName;
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Theatre Group Casting Sheet (*.tgcs)|*.tgcs";
                sfd.FilterIndex = 2;
                sfd.RestoreDirectory = true;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    fileName = sfd.FileName;
                    using (StreamWriter f = new StreamWriter(fileName, false))
                    {
                        string json = JsonConvert.SerializeObject(shows, Formatting.Indented, new JsonSerializerSettings { ReferenceLoopHandling = ReferenceLoopHandling.Ignore });
                        f.Write(json);
                    }
                }
            }
        }

        private void Tb_DoubleClick(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            string name = t.Text;
            foreach (TextBox nb in nameBoxes)
            {
                if (nb.Text.Equals(name))
                {
                    Flash(nb, 250, Color.MediumPurple, 5);
                }
            }
        }

        private void Flash(TextBox textBox, int interval, Color color, int flashes)
        {
            new Thread(() => FlashInternal(textBox, interval, color, flashes)).Start();
        }

        private delegate void UpdateTextboxDelegate(TextBox textBox, Color originalColor);
        private void UpdateTextbox(TextBox textBox, Color color)
        {
            if (textBox.InvokeRequired)
            {
                this.Invoke(new UpdateTextboxDelegate(UpdateTextbox), new object[] { textBox, color });
            }
            textBox.BackColor = color;
        }

        private void FlashInternal(TextBox textBox, int interval, Color flashColor, int flashes)
        {
            Color original = textBox.BackColor;
            for (int i = 0; i < flashes; i++)
            {
                UpdateTextbox(textBox, flashColor);
                Thread.Sleep(interval / 2);
                UpdateTextbox(textBox, original);
                Thread.Sleep(interval / 2);
            }
        }
    }
}
