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
    public partial class Form1 : Form
    {

        List<TextBox> nameBoxes;

        public Form1()
        {
            InitializeComponent();
            init();
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
            };
        }

        private void TxtS1Name_TextChanged(object sender, EventArgs e)
        {
            gBoxS1.Text = txtS1Name.Text;
        }

        private void TxtS2Name_TextChanged(object sender, EventArgs e)
        {
            gBoxS2.Text = txtS2Name.Text;
        }

        private void TxtS3Name_TextChanged(object sender, EventArgs e)
        {
            gBoxS3.Text = txtS3Name.Text;
        }

        private void TxtS4Name_TextChanged(object sender, EventArgs e)
        {
            gBoxS4.Text = txtS4Name.Text;
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

        private void TxtS1C1_TextChanged(object sender, EventArgs e)
        {
            lblS1C1.Text = txtS1C1.Text;
        }

        private void TxtS1C2_TextChanged(object sender, EventArgs e)
        {
            lblS1C2.Text = txtS1C2.Text;
        }

        private void TxtS1C3_TextChanged(object sender, EventArgs e)
        {
            lblS1C3.Text = txtS1C3.Text;
        }

        private void TxtS1C4_TextChanged(object sender, EventArgs e)
        {
            lblS1C4.Text = txtS1C4.Text;
        }

        private void TxtS1C5_TextChanged(object sender, EventArgs e)
        {
            lblS1C5.Text = txtS1C5.Text;
        }

        private void TxtS1C6_TextChanged(object sender, EventArgs e)
        {
            lblS1C6.Text = txtS1C6.Text;
        }

        private void TxtS1C7_TextChanged(object sender, EventArgs e)
        {
            lblS1C7.Text = txtS1C7.Text;
        }

        private void TxtS1C8_TextChanged(object sender, EventArgs e)
        {
            lblS1C8.Text = txtS1C8.Text;
        }

        private void TxtS1C9_TextChanged(object sender, EventArgs e)
        {
            lblS1C9.Text = txtS1C9.Text;
        }

        private void TxtS1C10_TextChanged(object sender, EventArgs e)
        {
            lblS1C10.Text = txtS1C10.Text;
        }

        private void TxtS1C11_TextChanged(object sender, EventArgs e)
        {
            lblS1C11.Text = txtS1C11.Text;
        }

        private void TxtS1C12_TextChanged(object sender, EventArgs e)
        {
            lblS1C12.Text = txtS1C12.Text;
        }

        private void TxtS2C1_TextChanged(object sender, EventArgs e)
        {
            lblS2C1.Text = txtS2C1.Text;
        }

        private void TxtS2C2_TextChanged(object sender, EventArgs e)
        {
            lblS2C2.Text = txtS2C2.Text;
        }

        private void TxtS2C3_TextChanged(object sender, EventArgs e)
        {
            lblS2C3.Text = txtS2C3.Text;
        }

        private void TxtS2C4_TextChanged(object sender, EventArgs e)
        {
            lblS2C4.Text = txtS2C4.Text;
        }

        private void TxtS2C5_TextChanged(object sender, EventArgs e)
        {
            lblS2C5.Text = txtS2C5.Text;
        }

        private void TxtS2C6_TextChanged(object sender, EventArgs e)
        {
            lblS2C6.Text = txtS2C6.Text;
        }

        private void TxtS2C7_TextChanged(object sender, EventArgs e)
        {
            lblS2C7.Text = txtS2C7.Text;
        }

        private void TxtS2C8_TextChanged(object sender, EventArgs e)
        {
            lblS2C8.Text = txtS2C8.Text;
        }

        private void TxtS2C9_TextChanged(object sender, EventArgs e)
        {
            lblS2C9.Text = txtS2C9.Text;
        }

        private void TxtS2C10_TextChanged(object sender, EventArgs e)
        {
            lblS2C10.Text = txtS2C10.Text;
        }

        private void TxtS2C11_TextChanged(object sender, EventArgs e)
        {
            lblS2C11.Text = txtS2C11.Text;
        }

        private void TxtS2C12_TextChanged(object sender, EventArgs e)
        {
            lblS2C12.Text = txtS2C12.Text;
        }
    }
}
