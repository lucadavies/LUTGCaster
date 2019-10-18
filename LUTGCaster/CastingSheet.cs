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

        public CastingSheet(List<Show> shows)
        {
            InitializeComponent();
            //init();
            initDyn();
        }

        private void initDyn()
        {
            nameBoxes = new List<TextBox>();
            for (int i = 0; i < 5; i++)
            {
                TextBox txtTest = new TextBox();
                txtTest = new TextBox();
                groupBox5.Controls.Add(txtTest);
                txtTest.BackColor = SystemColors.Window;
                txtTest.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                txtTest.Location = new Point(122 * i, 10);
                txtTest.Margin = new Padding(0);
                txtTest.Name = "txtTest" + i;
                txtTest.Size = new Size(122, 20);
                txtTest.TabIndex = 7;
                txtTest.TextChanged += new EventHandler(UpdateAllColours);
            }

            foreach (object el in groupBox5.Controls)
            {
                if (el is TextBox)
                {
                    nameBoxes.Add((TextBox)el);
                }
            }
        }

        private void init()
        {
            nameBoxes = new List<TextBox>
            {
                #region Show1
                txtS1C1a,
                txtS1C1b,
                txtS1C1c,
                txtS1C1d,
                txtS1C1e,
                txtS1C1f,

                txtS1C2a,
                txtS1C2b,
                txtS1C2c,
                txtS1C2d,
                txtS1C2e,
                txtS1C2f,

                txtS1C3a,
                txtS1C3b,
                txtS1C3c,
                txtS1C3d,
                txtS1C3e,
                txtS1C3f,

                txtS1C4a,
                txtS1C4b,
                txtS1C4c,
                txtS1C4d,
                txtS1C4e,
                txtS1C4f,

                txtS1C5a,
                txtS1C5b,
                txtS1C5c,
                txtS1C5d,
                txtS1C5e,
                txtS1C5f,

                txtS1C6a,
                txtS1C6b,
                txtS1C6c,
                txtS1C6d,
                txtS1C6e,
                txtS1C6f,

                txtS1C7a,
                txtS1C7b,
                txtS1C7c,
                txtS1C7d,
                txtS1C7e,
                txtS1C7f,

                txtS1C8a,
                txtS1C8b,
                txtS1C8c,
                txtS1C8d,
                txtS1C8e,
                txtS1C8f,

                txtS1C9a,
                txtS1C9b,
                txtS1C9c,
                txtS1C9d,
                txtS1C9e,
                txtS1C9f,

                txtS1C10a,
                txtS1C10b,
                txtS1C10c,
                txtS1C10d,
                txtS1C10e,
                txtS1C10f,

                txtS1C11a,
                txtS1C11b,
                txtS1C11c,
                txtS1C11d,
                txtS1C11e,
                txtS1C11f,

                txtS1C12a,
                txtS1C12b,
                txtS1C12c,
                txtS1C12d,
                txtS1C12e,
                txtS1C12f,
                #endregion

                #region Show2
                txtS2C1a,
                txtS2C1b,
                txtS2C1c,
                txtS2C1d,
                txtS2C1e,
                txtS2C1f,

                txtS2C2a,
                txtS2C2b,
                txtS2C2c,
                txtS2C2d,
                txtS2C2e,
                txtS2C2f,

                txtS2C3a,
                txtS2C3b,
                txtS2C3c,
                txtS2C3d,
                txtS2C3e,
                txtS2C3f,

                txtS2C4a,
                txtS2C4b,
                txtS2C4c,
                txtS2C4d,
                txtS2C4e,
                txtS2C4f,

                txtS2C5a,
                txtS2C5b,
                txtS2C5c,
                txtS2C5d,
                txtS2C5e,
                txtS2C5f,

                txtS2C6a,
                txtS2C6b,
                txtS2C6c,
                txtS2C6d,
                txtS2C6e,
                txtS2C6f,

                txtS2C7a,
                txtS2C7b,
                txtS2C7c,
                txtS2C7d,
                txtS2C7e,
                txtS2C7f,

                txtS2C8a,
                txtS2C8b,
                txtS2C8c,
                txtS2C8d,
                txtS2C8e,
                txtS2C8f,

                txtS2C9a,
                txtS2C9b,
                txtS2C9c,
                txtS2C9d,
                txtS2C9e,
                txtS2C9f,

                txtS2C10a,
                txtS2C10b,
                txtS2C10c,
                txtS2C10d,
                txtS2C10e,
                txtS2C10f,

                txtS2C11a,
                txtS2C11b,
                txtS2C11c,
                txtS2C11d,
                txtS2C11e,
                txtS2C11f,

                txtS2C12a,
                txtS2C12b,
                txtS2C12c,
                txtS2C12d,
                txtS2C12e,
                txtS2C12f,
                #endregion
            };
            
        }

        private void addNameBox(TextBox t)
        {
            nameBoxes.Add(t);
        }

        private void TriggerColourUpdate(object sender, EventArgs e)
        {
            string name = ((TextBox)sender).Text;
            UpdateColours((TextBox)sender);
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
                UpdateColours(t);
            }
        }
    }
}
