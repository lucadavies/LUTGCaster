﻿using System;
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
using System.Collections;

namespace LUTGCaster
{
    public partial class CastingSheet : Form
    {

        List<TextBox> nameBoxes;
        List<Show> shows;
        Regex alphaNumSlashRgx = new Regex("[^a-zA-Z0-9/.' -]");
        bool checkingNames = false;
        float zoomChange = 0.05f;
        int numChoices;
        Dictionary<string, List<string>> lockDict = new Dictionary<string, List<string>>(); //records locked in names - key is actor, value is show/role that must be freed to remove the block
        List<string> viewedLocks = new List<string>();
        Color o = Color.FromArgb(198, 224, 180);
        Color f1 = Color.FromArgb(81, 211, 81);
        Color f1o = Color.FromArgb(255, 255, 0);
        Color f2 = Color.FromArgb(55, 203, 255);
        Color f2o = Color.FromArgb(255, 192, 0);
        Color f3 = Color.FromArgb(85, 147, 203);
        Color f3o = Color.FromArgb(237, 125, 49);
        Color f4 = Color.FromArgb(48, 84, 150);
        Color f4o = Color.FromArgb(255, 0, 0);

        public CastingSheet(List<Show> shows, int numChoices)
        {
            InitializeComponent();
            this.shows = shows;
            this.numChoices = numChoices;
            Init();
        }

        /// <summary>
        /// Initialises the Casting Sheet by populating the form with the required numebr of textboxes for roles and labelling things accordingly.
        /// Role textbox names are in the format: txtSxCyz where x is the show number, y is the character number and z is a letter (a-f) representign choices 1-6
        /// Cast button names are in the format: btncastSxCy where x is the show number and y is the character number
        /// </summary>
        private void Init()
        {
            nameBoxes = new List<TextBox>();
            foreach (Show s in shows) //loop thorugh all shows
            {
                int index = shows.IndexOf(s);
                GroupBox gBox = new GroupBox
                {
                    Location = new Point(12, 12 + ((80 + (numChoices * 20)) * index)),
                    Name = "gBoxS" + (index + 1),
                    Padding = new Padding(3, 3, 3, 10),
                    Size = new Size(202 + ((s.roles.Count - 1) * 122), 72 + (numChoices * 20)),
                    TabIndex = index,
                    TabStop = false,
                    Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0),
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
                    Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                    TabIndex = 0,
                    Text = "Character"
                };
                gBox.Controls.Add(lblCharHead);

                for (int i = 0; i < numChoices; i++) //loop to create 6 choice labels
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
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
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
                        Location = new Point(74 + (i * 122), 19),
                        Name = "btnCastS" + (shows.IndexOf(s) + 1) + "C" + (i + 1),
                        Size = new Size(122, 20),
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        Text = "Cast",
                        UseVisualStyleBackColor = true
                    };
                    btn.Click += new EventHandler(CastCharacter);
                    gBox.Controls.Add(btn);

                    Label l = new Label
                    {
                        AutoSize = false,
                        Location = new Point(74 + (i * 122), 37),
                        Name = "lbl" + (shows.IndexOf(s) + 1) + "C" + (i + 1),
                        Padding = new Padding(0, 5, 0, 5),
                        Size = new Size(122, 23),
                        Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                        AutoEllipsis = true,
                        Text = s.roles[i].rName
                    };
                    gBox.Controls.Add(l);

                    for (int j = 0; j < numChoices; j++) //loop to create six TextBoxes 
                    {
                        TextBox tb = new TextBox
                        {
                            BackColor = SystemColors.Window,
                            Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0),
                            Location = new Point(74 + (i * 122), 63 + (j * 20)),
                            Margin = new Padding(0)
                        };
                        string n = "txtS" + (shows.IndexOf(s) + 1) + "C" + (i + 1);
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
                        tb.TextChanged += new EventHandler(Tb_TextChanged);
                        tb.DoubleClick += new EventHandler(Tb_DoubleClick);
                        tb.LostFocus += new EventHandler(UpdateShowData);
                        gBox.Controls.Add(tb);
                        gBox.Text = s.name;
                        panAll.Controls.Add(gBox);
                        nameBoxes.Add(tb);
                        tb.Text = s.roles[i].names[j];

                    }
                }
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
            List<TextBox> charTBs = new List<TextBox>();
            foreach (TextBox t in nameBoxes)
            {
                if (t.Name.Substring(3, t.Name.Length - 4).Equals(btn.Name.Substring(7)))
                {
                    charTBs.Add(t);
                    if (charTBs.Count == 6)
                    {
                        break;
                    }
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
        private void UpdateColours()
        {
            lockDict = new Dictionary<string, List<string>>();
            int countOther;
            int countFirst;
            char pos; //role position
            int show; //show number
            int character; //character number
            foreach (TextBox tb in nameBoxes)
            {
                countOther = 0;
                countFirst = 0;
                string name = tb.Text;
                if (!name.Equals(""))
                {
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
                                t.BackColor = o;       //other
                                break;
                            case 1:
                                if (countOther == 0)
                                {
                                    t.BackColor = f1;    //1 1st choice
                                }
                                else
                                {
                                    t.BackColor = f1o;         //1 1st choice + other
                                }
                                break;
                            case 2:
                                if (countOther == 0)
                                {
                                    t.BackColor = f2;      //2 1st choice
                                }
                                else
                                {
                                    t.BackColor = f2o;           //2 1st choice + other
                                }
                                break;
                            case 3:
                                if (countOther == 0)
                                {
                                    t.BackColor = f3;      //3 1st choice
                                    t.ForeColor = Color.White;
                                }
                                else
                                {
                                    t.BackColor = f3o;     //3 1st choice + other
                                }
                                break;
                            case 4:
                            default:
                                if (countOther == 0)
                                {
                                    t.BackColor = f4;       //4 1st choice
                                    t.ForeColor = Color.White;

                                }
                                else
                                {
                                    t.BackColor = f4o;            //4 1st choice + other
                                }
                                break;
                        }
                    }
                }
                if (name.Equals(""))
                {
                    tb.BackColor = SystemColors.Control;
                }
                pos = tb.Name[tb.Name.Length - 1];
                show = (int)char.GetNumericValue(tb.Name[4]);
                character = (int)char.GetNumericValue(tb.Name[6]);
                if (countFirst > 0 && countOther > 0 && !pos.Equals('a'))
                {
                    string t = shows[show - 1].name + " > " + shows[show - 1].roles[character - 1].rName + " > Choice ";
                    switch (pos)
                    {
                        case 'b':
                            t += "2";
                            break;
                        case 'c':
                            t += "3";
                            break;
                        case 'd':
                            t += "4";
                            break;
                        case 'e':
                            t += "5";
                            break;
                        case 'f':
                            t += "6";
                            break;
                        default:
                            break;
                    }
                    if (lockDict.ContainsKey(tb.Text))
                    {
                        if (!lockDict[tb.Text].Contains(t))
                        {
                            lockDict[tb.Text].Add(t);
                        }
                    }
                    else
                    {
                        lockDict.Add(tb.Text, new List<string>() { t });
                    }
                }
            }
            viewedLocks.Clear();
            UpdateLockSuggestion();
        }

        /// <summary>
        /// Reads the lock dictionary to find the least locked of all locked names and displays it
        /// </summary>
        private void UpdateLockSuggestion()
        {
            int minLock = 999;
            string minLockName = "";
            foreach (string name in lockDict.Keys)
            {
                List<string> tmp = lockDict[name];
                int score = 1;
                foreach (string l in tmp)
                {
                    switch (l[l.Length - 1])
                    {
                        case 'b':
                            score += 1;
                            break;
                        case 'c':
                            score += 2;
                            break;
                        case 'd':
                            score += 3;
                            break;
                        case 'e':
                            score += 4;
                            break;
                        case 'f':
                            score += 5;
                            break;
                        default:
                            break;
                    }
                }
                if (score < minLock && !viewedLocks.Contains(name))
                {
                    minLock = score;
                    minLockName = name;
                }
            }
            if (!minLockName.Equals(""))
            {
                lblLockName.Text = minLockName;
                txtNextLock.Text = "";
                viewedLocks.Add(minLockName);
                foreach (string s in lockDict[minLockName])
                {
                    txtNextLock.Text = txtNextLock.Text + s + Environment.NewLine;
                }
            }
            else
            {
                txtNextLock.Text = "";
                lblLockName.Text = "None";
            }
            
        }

        /// <summary>
        /// Event handler: called when any textbox raises TextChanged event. Calls UpdateColours for all textboxes.
        /// </summary>
        /// <param rName="sender"></param>
        /// <param rName="e"></param>
        private void Tb_TextChanged(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            string cleanText = alphaNumSlashRgx.Replace(tb.Text, "");
            if (!tb.Text.Equals(cleanText))
            {
                tb.Text = cleanText;
                tb.SelectionStart = tb.Text.Length;
                tb.SelectionLength = 0;
            }
            if (checkingNames)
            {
                UpdateColours();
            }
        }

        /// <summary>
        /// Event handler: called when a textbox loses focus. Ensures the data inside it is copied into the internal shows variable
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdateShowData(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            int showNum = (int)char.GetNumericValue(((Control)sender).Parent.Name, 5) - 1;       //get show number from parent (groupBox) name
            string temp = tb.Name.Substring(6, tb.Name.Length == 8 ? 1 : 2);                     //ternary to check if it's a single or two digit character number
            int charNum = int.Parse(temp) - 1; 
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

        private void BtnSave_Click(object sender, EventArgs e)
        {
            SaveSheet();            
        }

        private void SaveSheet()
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
                        f.Write("|" + numChoices);
                    }
                }
            }
        }

        private void Tb_DoubleClick(object sender, EventArgs e)
        {
            TextBox t = (TextBox)sender;
            string name = t.Text;
            if (!name.Equals(""))
            {
                FlashName(name);
            } 
        }

        /// <summary>
        /// Flashes textboxes containing the provided name
        /// </summary>
        /// <param name="name">Name to find and flash</param>
        private void FlashName(string name)
        {
            foreach (TextBox nb in nameBoxes)
            {
                if (nb.Text.Equals(name))
                {
                    Flash(nb, 250, Color.FromArgb(0xFFFFFF ^ nb.BackColor.ToArgb()), 5);
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

        private void CastingSheet_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("Want to save your sheet?", "Casting Sheet", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (res == DialogResult.Yes)
            {
                SaveSheet();
            }
            else if (res == DialogResult.No)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void BtnChkNames_Click(object sender, EventArgs e)
        {
            if (checkingNames)
            {
                checkingNames = false;
                lblChkNames.Text = "Not checking names";
                lblChkNames.ForeColor = Color.Red;
            }
            else
            {
                checkingNames = true;
                lblChkNames.Text = "Checking names";
                lblChkNames.ForeColor = Color.Green;
                UpdateColours();
            }
        }

        private void BtnZoomOut_Click(object sender, EventArgs e)
        {
            Font = new Font(Font.Name, Font.Size * (1 - zoomChange), Font.Style);
            foreach (TextBox tb in nameBoxes)
            {
                tb.Font = new Font(tb.Font.Name, tb.Font.Size * (1 - zoomChange), tb.Font.Style);
            }
        }

        private void BtnZoomUp_Click(object sender, EventArgs e)
        {
            Font = new Font(Font.Name, Font.Size * (1 + zoomChange), Font.Style);
            foreach (TextBox tb in nameBoxes)
            {
                tb.Font = new Font(tb.Font.Name, tb.Font.Size * (1 + zoomChange), tb.Font.Style);
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0112) // WM_SYSCOMMAND
            {
                // Check your window state here
                if (m.WParam == new IntPtr(0xF030)) // Maximize event - SC_MAXIMIZE from Winuser.h
                {
                    btnZoomUp.Enabled = false;
                    btnZoomOut.Enabled = false;
                }
                else if (m.WParam == new IntPtr(0xF120)) // Restore event - SC_RESTORE from Winuser.h
                {
                    btnZoomUp.Enabled = true;
                    btnZoomOut.Enabled = true;
                }
                else if (m.WParam == new IntPtr(0xF012)) // Drag move event - SC_DRAGMOVE from Winuser.h
                {
                    if (btnZoomUp.Enabled || btnZoomOut.Enabled)
                    {
                        btnZoomUp.Enabled = false;
                        btnZoomOut.Enabled = false;
                    }
                    else
                    {
                        btnZoomUp.Enabled = true;
                        btnZoomOut.Enabled = true;
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void LLblAbout_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            About ab = new About();
            ab.Show();
        }

        private void BtnFlash_Click(object sender, EventArgs e)
        {
            FlashName(lblLockName.Text);
        }

        private void BtnNextLock_Click(object sender, EventArgs e)
        {
            if (viewedLocks.Count == lockDict.Count) //if all locked names have been viewed, clear list and start over
            {
                viewedLocks.Clear();
            }
            UpdateLockSuggestion();
        }
    }
}
