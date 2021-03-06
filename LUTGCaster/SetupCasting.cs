﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace LUTGCaster
{
    public partial class SetupCasting : Form
    {
        int setupShows = 0;
        List<Show> shows = new List<Show>();
        List<GroupBox> showBoxes = new List<GroupBox>(); //holds groupboxes for each show and its textboxes, buttons, etc...
        List<int> charNumbers = new List<int>(); //records how many characters in each show

        public SetupCasting()
        {
            AppDomain.CurrentDomain.AssemblyResolve += (sender, args) =>
            {
                string resourceName = new AssemblyName(args.Name).Name + ".dll";
                string resource = Array.Find(this.GetType().Assembly.GetManifestResourceNames(), element => element.EndsWith(resourceName));

                using (var stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(resource))
                {
                    Byte[] assemblyData = new Byte[stream.Length];
                    stream.Read(assemblyData, 0, assemblyData.Length);
                    return Assembly.Load(assemblyData);
                }
            };

            InitializeComponent();
        }

        /// <summary>
        /// Extracts show information from this form and contructs a list of Show objects to intantiate a new CastinSheet with.
        /// </summary>
        private void GenerateCastingSheet()
        {
            shows = new List<Show>();

            for (int i = 0; i < showBoxes.Count; i++)
            {
                Panel p = (Panel)showBoxes[i].Controls["panS" + (i + 1)];
                TextBox t = (TextBox)showBoxes[i].Controls["txtS" + (i + 1) + "Name"];
                Show s = new Show(t.Text);

                TextBox nb;
                for (int j = 0; j < charNumbers[i]; j++)
                {
                    nb = (TextBox)p.Controls["txtS" + (i + 1) + "C" + (j + 1)];
                    if (!nb.Text.Equals(""))
                    {
                        s.addRole(nb.Text);
                    }
                }
                shows.Add(s);
            }
            CastingSheet cs = new CastingSheet(shows, (int)numUDChoices.Value);
            cs.Show();
        }

        /// <summary>
        /// Creates controls and background resources to add an additional show 
        /// </summary>
        private void AddShow()
        {
            if (btnRemShow.Enabled == false)
            {
                btnRemShow.Enabled = true;
            }
            GroupBox gBox = new GroupBox
            {
                Location = new Point(12, 12 + (76 * (setupShows))),
                Name = "gBoxS" + (setupShows + 1),
                Size = new Size(406, 70),
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
                Name = "txtS" + (setupShows + 1) + "Name",
                Size = new Size(244, 20),
                TabIndex = 0
            };

            Panel panChars = new Panel
            {
                Location = new Point(70, 39),
                Name = "panS" + (setupShows + 1),
                Size = new Size(245, 21),
                TabIndex = 28
            };

            Button btnAddChar = new Button
            {
                Location = new Point(320, 12),
                Name = "btnS" + (setupShows + 1) + "AddChar",
                Size = new Size(38, 48),
                Anchor = AnchorStyles.Right,
                Text = "Add Role"
            };
            btnAddChar.Click += new EventHandler(BtnAddChar_Click);

            Button btnRemChar = new Button
            {
                Location = new Point(361, 12),
                Name = "btnS" + (setupShows + 1) + "RemChar",
                Size = new Size(38, 48),
                Anchor = AnchorStyles.Right,
                Text = "Rm. Role",
                Enabled = false
            };
            btnRemChar.Click += new EventHandler(BtnRemChar_Click);

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
                Name = "txtS" + (setupShows + 1) + "C2",
                Size = new Size(122, 20)
            };

            gBox.Controls.Add(lblName);
            gBox.Controls.Add(lblChar);
            gBox.Controls.Add(txtSName);
            gBox.Controls.Add(panChars);
            gBox.Controls.Add(btnAddChar);
            gBox.Controls.Add(btnRemChar);
            panChars.Controls.Add(txtChar1);
            panChars.Controls.Add(txtChar2);
            panShows.Controls.Add(gBox);
            panShows.Controls.SetChildIndex(gBox, showBoxes.Count); //make on top of pre-existing controls (mainly to appear in front of full panel decorative label

            showBoxes.Add(gBox);
            charNumbers.Add(2);
            setupShows++;

            if (setupShows == 9)
            {
                btnAddShow.Enabled = false;
            }
        }

        /// <summary>
        /// Removes controls and background resources of the LAST show
        /// </summary>
        private void RemoveShow()
        {
            if (btnAddShow.Enabled == false)
            {
                btnAddShow.Enabled = true;
            }
            panShows.Controls.Remove(showBoxes[showBoxes.Count - 1]);
            showBoxes.RemoveAt(showBoxes.Count - 1);
            charNumbers.RemoveAt(charNumbers.Count - 1);
            setupShows--;
            if (setupShows == 0)
            {
                btnRemShow.Enabled = false;
            }
        }

        private void AddChar(int showIndex)
        {
            GroupBox gBox = showBoxes[showIndex];
            Panel pan = (Panel)gBox.Controls["panS" + (showIndex + 1)]; //gets panel containing char textboxes
            gBox.Width += 122;
            pan.Width += 122;
            charNumbers[showIndex]++;

            TextBox txt = new TextBox
            {
                Location = new Point((((pan.Width - 1) / 122) - 1) * 122, 0),
                Margin = new Padding(0, 3, 0, 3),
                Name = "txtS" + (showIndex + 1) + "C" + charNumbers[showIndex],
                Size = new Size(122, 20)
            };
            pan.Controls.Add(txt);
        }

        private void RemoveChar(int showIndex)
        {
            GroupBox gBox = showBoxes[showIndex];
            Panel pan = (Panel)gBox.Controls["panS" + (showIndex + 1)]; //gets panel containing char textboxes
            pan.Controls.Remove(pan.Controls["txtS" + (setupShows + 1) + "C" + charNumbers[showIndex]]);
            charNumbers[showIndex]--;
            gBox.Width -= 122;
            pan.Width -= 122;
        }

        private void BtnAddShow_Click(object sender, EventArgs e)
        {
            AddShow();
        }

        private void BtnRemShow_Click(object sender, EventArgs e)
        {
            RemoveShow();
        }

        private void BtnAddChar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int showIndex = (int)char.GetNumericValue(b.Name[4]) - 1;
            if (charNumbers[showIndex] == 2) //reenable remove char button
            {
                ((Button)b.Parent.Controls["btnS" + (showIndex + 1) + "RemChar"]).Enabled = true;
            }
            AddChar(showIndex);
            if (charNumbers[showIndex] == 50)
            {
                b.Enabled = false;
            }
        }

        private void BtnRemChar_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int showIndex = (int)char.GetNumericValue((b).Name[4]) - 1;
            if (charNumbers[showIndex] == 50) //reenable add char button
            {
                ((Button)b.Parent.Controls["btnS" + (showIndex + 1) + "AddChar"]).Enabled = true;
            }
            RemoveChar(showIndex);
            if (charNumbers[showIndex] == 2)
            {
                b.Enabled = false;
            }
        }

        private void BtnLoad_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Theatre Group Casting Sheet (*.tgcs)|*.tgcs|All files (*.*)|*.*";
                ofd.FilterIndex = 0;
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
            if (!fileContent.Equals(string.Empty))
            {
                try
                {
                    string[] s = { "", ""};
                    s = fileContent.Split('|');
                    string json = s[0];
                    string choicesTxt = s[1];
                    shows = JsonConvert.DeserializeObject<List<Show>>(json);
                    CastingSheet cs = new CastingSheet(shows, (s[1].Equals("") ? 6 : Convert.ToInt32(s[1])), filePath);
                    cs.Show();
                }
                catch (JsonException ex)
                {
                    MessageBox.Show("Error: loaded file is corrupt and cannot be deserialised." + Environment.NewLine + ex.Message);
                }
                catch (IndexOutOfRangeException ex)
                {
                    MessageBox.Show("Error: loaded file is corrupt and cannot be loaded." + Environment.NewLine + ex.Message);
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Error: loaded file is corrupt and cannot be loaded." + Environment.NewLine + ex.Message);
                }
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            GenerateCastingSheet();
        }
    }
}
