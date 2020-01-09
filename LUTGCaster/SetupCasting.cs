using Newtonsoft.Json;
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
                foreach (Control c in p.Controls)
                {
                    if (!((TextBox)c).Text.Equals(""))
                    {
                        s.addRole(((TextBox)c).Text);
                    }
                }
                shows.Add(s);
            }
            CastingSheet cs = new CastingSheet(shows);
            cs.Show();
        }

        private void AddShow()
        {
            if (setupShows < 10)
            {
                GroupBox gBox = new GroupBox
                {
                    Location = new Point(12, 12 + (76 * (setupShows))),
                    Name = "gBoxS" + (setupShows + 1),
                    Size = new Size(365, 70),
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
                    Size = new Size(245, 21),
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
                    Name = "txtS" + (setupShows + 1) + "C2",
                    Size = new Size(122, 20)
                };

                Button btnAddChar = new Button
                {
                    Location = new Point(320, 12),
                    Name = "btnS" + (setupShows + 1) + "AddChar",
                    Size = new Size(38, 48),
                    Text = "Add Role"
                };
                btnAddChar.Click += new EventHandler(BtnAddChar_Click);

                gBox.Controls.Add(panChars);
                gBox.Controls.Add(lblName);
                gBox.Controls.Add(lblChar);
                gBox.Controls.Add(txtSName);
                gBox.Controls.Add(btnAddChar);
                panChars.Controls.Add(txtChar1);
                panChars.Controls.Add(txtChar2);
                panShows.Controls.Add(gBox);

                showBoxes.Add(gBox);
                setupShows += 1;
            }
            else
            {
                MessageBox.Show("You have reached the maximum number of shows.", "LUTG Caster",  MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnAddChar_Click(object sender, EventArgs e)
        {
            int showIndex = (int)char.GetNumericValue(((Button)sender).Name[4]) - 1;
            AddChar(showIndex);
        }

        private void AddChar(int showIndex)
        {
            GroupBox gBox = showBoxes[showIndex];
            Panel pan = null;
            Button btn = null;
            foreach (Control c in gBox.Controls)
            {
                if (c is Panel)
                {
                    pan = (Panel)c; //unsafe but internal
                }
                else if (c is Button)
                {
                    btn = (Button)c;
                }
            }
            if (!(pan == null) && !(btn == null))
            {
                gBox.Width += 122;
                pan.Width += 122;

                TextBox txt = new TextBox
                {
                    Location = new Point((((pan.Width - 1) / 122) - 1) * 122, 0),
                    Margin = new Padding(0, 3, 0, 3),
                    Name = "txtS" + (setupShows + 1) + "C" + (pan.Width - 1) / 122,
                    Size = new Size(122, 20)
                };
                pan.Controls.Add(txt);
                btn.Location = new Point(btn.Location.X + 122, btn.Location.Y);
            }
        }

        private void BtnAddShow_Click(object sender, EventArgs e)
        {
            AddShow();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Theatre Group Casting Sheet (*.tgcs)|*.tgcs|All files (*.*)|*.*";
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
            try
            {
                shows = JsonConvert.DeserializeObject<List<Show>>(fileContent);
                CastingSheet cs = new CastingSheet(shows);
                cs.Show();
            }
            catch (JsonException ex)
            {
                MessageBox.Show("Error: loaded file is corrupt and cannot be deserialised." + Environment.NewLine + ex.Message);
            }
        }
    }
}
