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
            InitDyn();
        }

        /// <summary>
        /// Initialises the Casting Sheet by populating the form with the required numebr of textboxes for roles and labelling things accordingly.
        /// </summary>
        private void InitDyn()
        {
            nameBoxes = new List<TextBox>();
            foreach (Show s in shows) //loop thorugh all shows
            {
                GroupBox gBox = new GroupBox();
                gBox = (GroupBox)Controls.Find("gBoxS" + (shows.IndexOf(s) + 1), false)[0]; //get Show's gBox for reference to add controls

                for (int i = 0; i < s.roles.Count; i++) //loop through all roles for Show
                {
                    for (int j = 0; j < 6; j++) //loop to create six TextBoxes 
                    {
                        TextBox tb = new TextBox();
                        tb = new TextBox();
                        gBox.Controls.Add(tb);
                        gBox.Text = s.name;
                        tb.BackColor = SystemColors.Window;
                        tb.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
                        tb.Location = new Point(74 + (i * 122), 63 + (j * 20));
                        tb.Margin = new Padding(0);
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
                    Label l = new Label();
                    gBox.Controls.Add(l);
                    l.AutoSize = true;
                    l.Location = new Point(71 + (i * 122), 40);
                    l.Name = "lbl" + (shows.IndexOf(s) + 1) + "C" + (i + 1);
                    l.Padding = new Padding(0, 5, 0, 5);
                    l.Size = new Size(44, 23);
                    l.Text = s.roles[i].name;

                    Button btn = new Button();
                    gBox.Controls.Add(btn);
                    btn.Location = new Point(71 + (i * 122), 19);
                    btn.Name = "btnCastS" + (shows.IndexOf(s) + 1) + "C" + (i + 1);
                    btn.Size = new Size(122, 20);
                    btn.Text = "Cast";
                    btn.UseVisualStyleBackColor = true;
                    btn.Click += new EventHandler(CastCharacter);

                    //Label l = (Label)Controls.Find("lblS" + (shows.IndexOf(s) + 1) + "C" + (i + 1), true)[0];
                }
            }

        }

        /// <summary>
        /// Event handler: Called by all "Cast" buttons. To show a cast role, disables all textboxes for the role, bolds the top choice
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CastCharacter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            Console.WriteLine(btn.Name);
            int charNum = int.Parse(btn.Name.Substring(10, btn.Name.Length == 11 ? 1 : 2)) - 1; //ternary to check if it's a single or two digit character number
            int showNum = (int)char.GetNumericValue(((Control)sender).Parent.Name, 5) - 1;       //get show number from parent (groupBox) name
            foreach (TextBox t in shows[showNum].roles[charNum].boxes)
            {
                if (t.Enabled)      //disable if enabled
                {
                    t.Enabled = false;
                    if (t.Name[t.Name.Length - 1].Equals('a')) //bold if first choice
                    {
                        t.Font = new Font(t.Font, FontStyle.Bold);
                    }
                }
                else      //enable if disabled

                {
                    t.Enabled = true;
                    if (t.Name[t.Name.Length - 1].Equals('a')) //unbold if first choice
                    {
                        t.Font = new Font(t.Font, FontStyle.Regular);
                    }
                }
            }
        }

        /// <summary>
        /// Checks for duplicate names in ALL other textboxes present on sheet, colours passed textbox accordingly
        /// </summary>
        /// <param name="tb">Textbox name to check against</param>
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
                foreach (TextBox t in toColour) //colour all textboxes found with same name the same colour
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
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateAllColours(object sender, EventArgs e)
        {
            foreach (TextBox t in nameBoxes)
            {
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
                        foreach (Show s in shows)
                        {
                            foreach (Show.Role r in s.roles)
                            {
                                foreach (TextBox t in r.boxes)
                                {
                                    f.Write(t.Text + ",");
                                    Console.WriteLine(t.Text + ",");
                                }
                            }
                        }
                    }
                }
            }            
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Theatre Group Casting Sheet (*.tgcs)|*.tgcs*";
                ofd.FilterIndex = 2;
                ofd.RestoreDirectory = true;

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    filePath = ofd.FileName;

                    //Read the contents of the file into a stream
                    var fileStream = ofd.OpenFile();

                    using (StreamReader reader = new StreamReader(fileStream))
                    {
                        fileContent = reader.ReadToEnd();
                    }
                }
            }
            string[] loadedNames   = fileContent.Split(',');
            try
            {
                for (int i = 0; i < nameBoxes.Count; i++)
                {
                    nameBoxes[i].Text = loadedNames[i];
                }
            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Error: loaded file does not match show setup. Please check show setup and tyr again.");
            }
        }
    }
}
